using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //建立命名空間
using System.Globalization;     //時間

namespace BennDouSystem
{
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;    //連接資料庫

        DateTime timeNow;   //現在時間
        int myClass;    //我的期別
        string myName;  //我的姓名
        string myStore; //我的店家        

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(SqlConnectionStringBuilder scsb, DateTime timeNow, int myClass, string myName, string myStore) 
        {
            InitializeComponent();
            this.scsb = scsb;
            this.timeNow = timeNow;
            this.myClass = myClass;
            this.myName = myName;
            this.myStore = myStore;
        }

        private void Form2_Load(object sender, EventArgs e)
        {         
            lblClass.Text = Convert.ToString(myClass);
            lblName.Text = myName;
            lblStore.Text = myStore;

            refresh_dgvMyOrder();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;            
            //產品cbNewItem資料載入：列出店家(sto_name)=myStore的所有產品
            cmd = new SqlCommand(String.Format(@"
                select pro_name
                from products
                where sto_id = (select sto_id
				                from stores
				                where sto_name = '{0}')
                ", myStore), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                cbItem.Items.Add(reader[0]);
            reader.Close();
            //確認訂單是否已完成訂購：rd_checked = [0,1]
            cmd = new SqlCommand(String.Format(@"
                    select ord_checked
                    from orders_main
                    where cls_id = {0} and ord_date = '{1}'
                    ", myClass, timeNow.ToShortDateString()), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int isChecked = Convert.ToInt32(reader[0]);
                if (isChecked == 0)
                {
                    lblOrderState.Visible = false;                            
                }
                if (isChecked == 1)
                {
                    lblOrderState.Visible = true;
                    lblOrderState.Text = "此訂單已完成訂購";
                    lblOrderState.ForeColor = Color.Red;
                    dgvMyOrder.Enabled = false;
                    cbItem.Enabled = false;
                    cbNum.Enabled = false;
                }
            }
            reader.Close();

            con.Close();
        }
        
        private void dgvMyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {                               
            cbItem.Text = Convert.ToString(dgvMyOrder.SelectedCells[0].Value);            
            cbNum.Text = Convert.ToString(dgvMyOrder.SelectedCells[1].Value);
            tbSum.Text = Convert.ToString(dgvMyOrder.SelectedCells[2].Value);
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            cbNum.Text = "1";
            int newNum = Convert.ToInt32(cbNum.Text);

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //列出產品名稱(pro_name)=cbItem.Text的單價(pro_price)
            cmd = new SqlCommand(String.Format(@"select pro_price
                                                 from products
                                                 where pro_name = '{0}'", cbItem.Text), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                tbSum.Text = Convert.ToString(Convert.ToInt32(reader[0]) * newNum);
            reader.Close();

            con.Close();           
        }

        private void cbNum_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int newNum = Convert.ToInt32(cbNum.Text);

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //列出產品名稱(pro_name)=cbItem.Text的單價(pro_price)
            cmd = new SqlCommand(String.Format(@"select pro_price
                                                 from products
                                                 where pro_name = '{0}'", cbItem.Text), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                tbSum.Text = Convert.ToString(Convert.ToInt32(reader[0]) * newNum);
            reader.Close();

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbItem.Text != "")
            {
                bool isAdd = true;
                int newNum = Convert.ToInt32(cbNum.Text);
                int newSum = Convert.ToInt32(tbSum.Text);
 
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                //列出姓名(stu_name)=myName,日期(ord_date)=timeNow的訂單中，所有產品名稱(pro_name)
                cmd = new SqlCommand(String.Format(@"
                    select pro_name
                    from orders_detail o inner join products p on o.pro_id = p.pro_id
                    where ord_id = (select ord_id
				                    from orders_main
				                    where ord_date = '{0}' and cls_id = {1}) and
	                      stu_id = (select stu_id
				                    from students
				                    where stu_name = '{2}' and cls_id = {1})
                    ", timeNow.ToShortDateString(), myClass, myName), con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {                    
                    if (cbItem.Text == Convert.ToString(reader[0]))
                        isAdd = false;                       
                }
                reader.Close();

                if (isAdd)
                {
                    //新增order_details資料
                    cmd = new SqlCommand(String.Format(@"
                    insert into orders_detail(ord_id, stu_id, pro_id, pro_num, pro_sum)
                    select ord_id, stu_id, pro_id, {0}, {1}
                    from orders_main, students, products
                    where ord_id = (select ord_id
		                     		from orders_main
                		    		where ord_date = '{2}' and cls_id = {3}) and
                	      stu_id = (select stu_id
	                	    		from students
	                		    	where stu_name = '{4}' and cls_id = {3}) and
	                      pro_id = (select pro_id
	                	    		from products
		                    		where pro_name = '{5}' and 
	                                      sto_id = (select sto_id
				                                    from stores
				                                    where sto_name = '{6}'))
                    ", newNum, newSum, timeNow.ToShortDateString(), myClass, myName, cbItem.Text, myStore), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已新增{0}個訂單資料。", row));
                }
                else
                {
                    MessageBox.Show(String.Format("已經有一筆\"{0}\"的訂單了。", cbItem.Text));
                }
                
                con.Close();

                cbItem.Text = "";
                cbNum.Text = "";
                tbSum.Text = "";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                refresh_dgvMyOrder();                
            }          
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;            
            //刪除order_details資料
            cmd = new SqlCommand(String.Format(@"
                delete orders_detail
                where ord_id = (select ord_id
				                from orders_main
				                where ord_date = '{0}' and cls_id = {1}) and
	                  stu_id = (select stu_id
			                	from students
			                	where stu_name = '{2}' and cls_id = {1}) and
	                  pro_id = (select pro_id
		                		from products
		                		where pro_name = '{3}' and 
	                                  sto_id = (select sto_id
				                                from stores
				                                where sto_name = '{4}')) and
	                  pro_num = {5}
                ", timeNow.ToShortDateString(), myClass, myName, cbItem.Text, myStore, cbNum.Text), con);

            int row = cmd.ExecuteNonQuery();
            MessageBox.Show(String.Format("已刪除{0}個訂單資料。", row));

            con.Close();
                        
            cbItem.Text = "";
            cbNum.Text = "";
            tbSum.Text = "";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            refresh_dgvMyOrder();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_dgvMyOrder()   //訂單dgvMyOrder重新載入
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //訂單dgvMyOrder資料載入：列出姓名(stu_name)=myName,日期(ord_date)=timeNow的訂單
            cmd = new SqlCommand(String.Format(@"
                select p.pro_name as 項目, od.pro_num as 數量, od.pro_sum as 金額
                from orders_detail od inner join products p on od.pro_id = p.pro_id
                where ord_id = (select ord_id
				                from orders_main
				                where ord_date = '{0}' and cls_id ={1}) and
	                  stu_id = (select stu_id
				                from students
				                where stu_name = '{2}' and cls_id ={1})
                    ", timeNow.ToShortDateString(),  myClass, myName), con);
            reader = cmd.ExecuteReader();

            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvMyOrder.DataSource = myDataTable;

            reader.Close();
            con.Close();
        }        
    }
}
