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
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;    //連接資料庫

        DateTime timeNow;// = new DateTime(2015, 2, 1);    //現在時間(測試用時間)
        int myClass;    //我的期別
        string myName;  //我的姓名
        string myStore; //我的店家

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbTimeNow.Text = String.Format("{0}",timeNow.ToString());
            timer.Enabled = true;

            scsb = new SqlConnectionStringBuilder();     //建立資料庫連接字串
            scsb.DataSource = @"INOKUMAW-PC\SQLEXPRESS";    //資料庫路徑位置
            //scsb.DataSource = @".\SQLEXPRESS";
            scsb.InitialCatalog = "BennDouSystem";       //資料庫名稱
            scsb.IntegratedSecurity = true;              //整合性驗證

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //期別comboBox資料載入：列出所有期別(cls_id)
            cmd = new SqlCommand(@"select cls_id
                                   from class
                                   order by 1 desc", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())            
                cbClass.Items.Add(reader[0]);            

            reader.Close();

            con.Close();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass = Convert.ToInt32(cbClass.Text);
            myName = null;
            myStore = null;

            cbName.Text = "";
            cbName.Items.Clear();            
            cbStore.Text = "";
            cbStore.Items.Clear();
            cbStore.Enabled = false;
            btnMyOrder.Enabled = false;
            btnDecide.Visible = false;
            dgvOrder.DataSource = null;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //姓名comboBox資料載入：列出期別(cls_id)=myClass的學生姓名(stu_name)
            cmd = new SqlCommand(String.Format(@"select stu_name
                                                 from students
                                                 where cls_id = {0}", myClass), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                cbName.Items.Add(reader[0]);
            reader.Close();

            con.Close();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            myName = cbName.Text;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //店家comboBox資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow所決定的店家名稱(sto_name)
            cmd = new SqlCommand(String.Format(@"
                select sto_name
                from stores
                where sto_id = (select sto_id
				                from orders_main
				                where ord_date = '{0}' and cls_id = {1})
                ", timeNow.ToShortDateString(), myClass), con);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStore.Text = Convert.ToString(reader[0]);
                myStore = Convert.ToString(reader[0]);
            }
            reader.Close();
            
            if (cbStore.Text == "")
            {
                MessageBox.Show("今天還沒決定店家喔！");
                cbStore.Enabled = true;
                btnDecide.Enabled = true;
                btnDecide.Visible = true;
                //店家comboBox資料載入：列出所有店家名稱(sto_name)
                cmd = new SqlCommand(@"select sto_name from stores", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    cbStore.Items.Add(reader[0]);
                reader.Close();
            }
            else
            {
                btnMyOrder.Enabled = true;
                //訂單dgvOrder資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單
                cmd = new SqlCommand(String.Format(@"
                    select stu_name as 姓名, pro_name as 項目, pro_num as 數量, pro_sum as 金額
                    from orders_detail o inner join students s on o.stu_id = s.stu_id 
			        		             inner join products p on o.pro_id = p.pro_id
                    where ord_id = (select ord_id
			        	            from orders_main
				                    where ord_date = '{0}' and cls_id = {1})
                    ", timeNow.ToShortDateString(), myClass), con);
                reader = cmd.ExecuteReader();

                DataTable myDataTable = new DataTable();
                myDataTable.Load(reader);
                dgvOrder.DataSource = myDataTable;

                reader.Close();
            }

            con.Close();
        }

        private void cbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            myStore = cbStore.Text;
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {                       
            string message = "你確定要選擇這個店家嗎？\n"+myStore+"\n決定後將無法更改。";
            var result = MessageBox.Show(message, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                cbStore.Enabled = false;
                btnDecide.Visible = false;
                btnMyOrder.Enabled = true;

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                //新增訂單
                cmd = new SqlCommand(String.Format(@"
                    insert into orders_main(cls_id, sto_id, ord_date, ord_checked)
                    select {0}, sto_id, '{1}', 0
                    from stores
                    where sto_id = (select sto_id
	                    			from stores
	                    			where sto_name = '{2}')
                    ", myClass, timeNow.ToShortDateString(), myStore), con);
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("已新增{0}個訂單。", row));
                //訂單dgvOrder資料載入：列出欄位
                cmd = new SqlCommand(String.Format(@"
                    select stu_name as 姓名, pro_name as 項目, pro_num as 數量, pro_sum as 金額
                    from orders_detail o inner join students s on o.stu_id = s.stu_id 
			        		             inner join products p on o.pro_id = p.pro_id
                    where ord_id = (select ord_id
			        	            from orders_main
				                    where ord_date = '{0}' and cls_id = {1})
                    ", timeNow.ToShortDateString(), myClass), con);
                reader = cmd.ExecuteReader();

                DataTable myDataTable = new DataTable();
                myDataTable.Load(reader);
                dgvOrder.DataSource = myDataTable;

                reader.Close();

                con.Close();
            }
        }

        private void btnMyOrder_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(scsb, timeNow, myClass, myName, myStore);
            f2.ShowDialog();

            refresh_dgvOrder();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3(scsb, timeNow, myClass, myStore);            
            f3.ShowDialog();

            refresh_dgvOrder();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4(scsb);
            f4.ShowDialog();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //期別comboBox資料載入：列出所有期別(cls_id)
            cmd = new SqlCommand(@"select cls_id
                                   from class
                                   order by 1 desc", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                cbClass.Items.Add(reader[0]);

            reader.Close();

            con.Close();

            refresh_dgvOrder();
        }

        private void refresh_dgvOrder() 
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //訂單dgvOrder資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單
            cmd = new SqlCommand(String.Format(@"
                    select stu_name as 姓名, pro_name as 項目, pro_num as 數量, pro_sum as 金額
                    from orders_detail o inner join students s on o.stu_id = s.stu_id 
			        		             inner join products p on o.pro_id = p.pro_id
                    where ord_id = (select ord_id
			        	            from orders_main
				                    where ord_date = '{0}' and cls_id = {1})
                    ", timeNow.ToShortDateString(), myClass), con);
            reader = cmd.ExecuteReader();

            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvOrder.DataSource = myDataTable;

            reader.Close();
            con.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now;
            tbTimeNow.Text = timeNow.ToString();
        }
    }
}
