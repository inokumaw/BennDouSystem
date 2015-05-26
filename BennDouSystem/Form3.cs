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
    public partial class Form3 : Form
    {
        SqlConnectionStringBuilder scsb;    //連接資料庫

        DateTime timeNow;   //現在時間(測試用時間)
        int myClass;    //我的期別        
        string myStore; //我的店家
        
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(SqlConnectionStringBuilder scsb, DateTime timeNow, int myClass, string myStore) 
        {
            InitializeComponent();
            this.scsb = scsb;
            this.timeNow = timeNow;
            this.myClass = myClass;
            this.myStore = myStore;
        }

        private void Form3_Load(object sender, EventArgs e)
        {           
            cbClass.Text = Convert.ToString(myClass);
            if (myClass == 0)
                cbClass.Text = "";
            tbStore.Text = myStore;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;

            if (tbStore.Text == "")
            {
                btnCheckOK.Enabled = false;
                btnCheckNG.Enabled = false;
                //店家textBox資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow所決定的店家名稱(sto_name)
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
                    tbStore.Text = Convert.ToString(reader[0]);
                    myStore = Convert.ToString(reader[0]);
                }
                reader.Close();
            }
            else
            {
                //電話tbTel資料載入：列出店家名稱(sto_name)=myStore的電話(sto_tel)
                cmd = new SqlCommand(String.Format(@"select sto_tel
                                                     from stores
                                                      where sto_name = '{0}'", myStore), con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    tbTel.Text = Convert.ToString(reader[0]);
                reader.Close();
                //訂單dgvOrder資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單
                cmd = new SqlCommand(String.Format(@"
                    select pro_name as 項目, SUM(pro_num) as 數量, SUM(pro_sum)　as 金額
                    from orders_detail od inner join products p on od.pro_id = p.pro_id
                    where ord_id = (select ord_id
				                    from orders_main
				                    where ord_date = '{0}' and cls_id = {1})
                    group by pro_name
                    ", timeNow.ToShortDateString(), myClass), con);
                reader = cmd.ExecuteReader();

                DataTable myDataTable = new DataTable();
                myDataTable.Load(reader);
                dgvOrder.DataSource = myDataTable;

                reader.Close();
                //總金額tbSum資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單的總金額SUM(pro_sum)
                cmd = new SqlCommand(String.Format(@"
                    select SUM(pro_sum)
                    from orders_detail od inner join products p on od.pro_id = p.pro_id
                    where ord_id = (select ord_id
                    				from orders_main
				                    where ord_date = '{0}' and cls_id = {1})
                    ", timeNow.ToShortDateString(), myClass), con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    tbSum.Text = String.Format("${0}元", reader[0]);
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
                        lblOrderState.Visible = true;
                        lblOrderState.Text = "此訂單尚未完成訂購";
                        lblOrderState.ForeColor = Color.Red;
                        btnCheckOK.Enabled = true;
                        btnCheckNG.Enabled = true;
                    }
                    if (isChecked == 1)
                    {
                        lblOrderState.Visible = true;
                        lblOrderState.Text = "此訂單已完成訂購";
                        lblOrderState.ForeColor = Color.Gray;
                        btnCheckOK.Enabled = false;
                        btnCheckNG.Enabled = false;
                    }
                }
                reader.Close();
            }

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
            myClass = Convert.ToInt32(cbClass.SelectedItem.ToString());
            tbStore.Text = "";
            myStore = null;
            tbTel.Text = "";
            lblOrderState.Visible = false;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //店家textBox資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow所決定的店家名稱(sto_name)
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
                tbStore.Text = Convert.ToString(reader[0]);                
                myStore = Convert.ToString(reader[0]);
            }            
            reader.Close();
            //電話tbTel資料載入：列出店家名稱(sto_name)=myStore的電話(sto_tel)
            cmd = new SqlCommand(String.Format(@"select sto_tel
                                                 from stores
                                                 where sto_name = '{0}'", myStore), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                tbTel.Text = Convert.ToString(reader[0]);            
            reader.Close();
            //訂單dgvOrder資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單
            cmd = new SqlCommand(String.Format(@"
                select pro_name as 項目, SUM(pro_num) as 數量, SUM(pro_sum)　as 金額
                from orders_detail od inner join products p on od.pro_id = p.pro_id
                where ord_id = (select ord_id
				                from orders_main
				                where ord_date = '{0}' and cls_id = {1})
                group by pro_name
                ", timeNow.ToShortDateString(), myClass), con);
            reader = cmd.ExecuteReader();

            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvOrder.DataSource = myDataTable;

            reader.Close();
            //總金額tbSum資料載入：列出期別(cls_id)=myClass,日期(ord_date)=timeNow的訂單的總金額
            cmd = new SqlCommand(String.Format(@"
                select SUM(pro_sum)
                from orders_detail od inner join products p on od.pro_id = p.pro_id
                where ord_id = (select ord_id
                				from orders_main
				                where ord_date = '{0}' and cls_id = {1})
                ", timeNow.ToShortDateString(), myClass), con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                tbSum.Text = String.Format("${0}元", reader[0]);
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
                    lblOrderState.Visible = true;
                    lblOrderState.Text = "此訂單尚未完成訂購";
                    lblOrderState.ForeColor = Color.Red;
                    btnCheckOK.Enabled = true;
                    btnCheckNG.Enabled = true;
                }
                if (isChecked == 1)
                {
                    lblOrderState.Visible = true;
                    lblOrderState.Text = "此訂單已完成訂購";
                    lblOrderState.ForeColor = Color.Gray;
                    btnCheckOK.Enabled = false;
                    btnCheckNG.Enabled = false;
                }                
            }                        
            reader.Close();

            con.Close();
        }

        private void btnCheckOK_Click(object sender, EventArgs e)
        {
            string message = "你確定已經完成訂購這個訂單了嗎？\n決定後將無法更改。";
            var result = MessageBox.Show(message, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {                               
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                //完成訂購：ord_checked改為1
                cmd = new SqlCommand(String.Format(@"
                    update orders_main
                    set ord_checked = 1
                    where cls_id = {0} and 
	                      ord_date = '{1}' and 
	                      ord_checked = 0
                    ", myClass, timeNow.ToShortDateString()), con);

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("已確認{0}個訂單。", row));

                con.Close();

                this.Close();
            }                        
        }

        private void btnCheckNG_Click(object sender, EventArgs e)
        {
            string message = "你確定要取消這個訂單嗎？\n決定後將刪除這個訂單。";
            var result = MessageBox.Show(message, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                tbStore.Text = "";
                tbTel.Text = "";
                tbSum.Text = "";
                dgvOrder.DataSource = null;

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                //取消訂購：刪除訂單
                cmd = new SqlCommand(String.Format(@"
                    delete orders_main
                    where cls_id = {0} and 
                          ord_date = '{1}' and 
                          ord_checked = 0
                    ", myClass, timeNow.ToShortDateString()), con);

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("已刪除{0}個訂單。", row));

                con.Close();

                this.Close();
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
