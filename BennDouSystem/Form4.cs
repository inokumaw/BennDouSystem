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
    public partial class Form4 : Form
    {
        SqlConnectionStringBuilder scsb;    //連接資料庫
        int stu_id; //dgvStudents選擇cell指向資料庫的id
        int sto_id; //cbMnu_store選擇內容指向資料庫的id
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //返回鍵
            this.Close();
        }

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(SqlConnectionStringBuilder scsb) 
        {
            InitializeComponent();
            this.scsb = scsb;            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvClass_Load();
            dgvStores_Load();           
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tpStudents")
            {
                cbStu_class.Items.Clear();

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                //tpStudents期別comboBox資料載入：列出所有期別(cls_id)
                cmd = new SqlCommand(@"select cls_id
                                   from class
                                   order by 1 desc", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    cbStu_class.Items.Add(reader[0]);

                reader.Close();

                con.Close();
            }

            if (tabControl.SelectedTab.Name == "tpMenu")
            {
                cbMnu_store.Items.Clear();

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                //tpMenu店家comboBox資料載入：列出所有店家名稱(sto_name)
                cmd = new SqlCommand(@"select sto_name
                                   from stores
                                   order by 1 ", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    cbMnu_store.Items.Add(reader[0]);

                reader.Close();

                con.Close();
            }
        }

        private void cbStu_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents_Load();
        }

        private void cbMnu_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMenu_Load();
            //列出所選擇店家的sto_id
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(String.Format(@"select sto_id
                                                 from stores
                                                 where sto_name = '{0}'", cbMnu_store.Text), con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                sto_id = Convert.ToInt32(reader[0]);

            reader.Close();

            con.Close();
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCls_class.Text = Convert.ToString(dgvClass.SelectedCells[0].Value);
            tbCls_name.Text = Convert.ToString(dgvClass.SelectedCells[1].Value);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbStu_name.Text = Convert.ToString(dgvStudents.SelectedCells[0].Value);            
            //列出所選擇學生的stu_id
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(String.Format(@"
                        select stu_id
                        from students
                        where cls_id = {0} and stu_name = '{1}'
                        ", cbStu_class.Text, tbStu_name.Text), con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                stu_id = Convert.ToInt32(reader[0]);

            reader.Close();

            con.Close();
        }

        private void dgvStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSto_name.Text = Convert.ToString(dgvStores.SelectedCells[0].Value);
            tbSto_tel.Text = Convert.ToString(dgvStores.SelectedCells[1].Value);
            tbSto_address.Text = Convert.ToString(dgvStores.SelectedCells[2].Value);
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMnu_name.Text = Convert.ToString(dgvMenu.SelectedCells[0].Value);
            tbMnu_price.Text = Convert.ToString(dgvMenu.SelectedCells[1].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)    //新增按鈕
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;          
     
            if (tabControl.SelectedTab.Name == "tpClass")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"insert into class(cls_id, cls_name)
                                                         values ({0}, '{1}')", tbCls_class.Text, tbCls_name.Text), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已新增{0}個資料。", row));

                    dgvClass_Load();

                    tbCls_class.Text = "";
                    tbCls_name.Text = "";
                }
                catch (Exception) 
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStudents")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"insert into students(cls_id, stu_name)
                                                         values ({0}, '{1}')", cbStu_class.Text, tbStu_name.Text), con);
                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已新增{0}個資料。", row));

                    dgvStudents_Load();
                                        
                    tbStu_name.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStores")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"insert into stores(sto_name, sto_tel, sto_address)
                                                         values ('{0}', '{1}', '{2}')
                                                        ", tbSto_name.Text, tbSto_tel.Text, tbSto_address.Text), con);
                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已新增{0}個資料。", row));

                    dgvStores_Load();

                    tbSto_name.Text = "";
                    tbSto_tel.Text = "";
                    tbSto_address.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpMenu")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"insert into products(sto_id, pro_name, pro_price)
                                                         values ({0}, '{1}', '{2}')
                                                        ", sto_id, tbMnu_name.Text, tbMnu_price.Text), con);
                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已新增{0}個資料。", row));

                    dgvMenu_Load();
                    
                    tbMnu_name.Text = "";
                    tbMnu_price.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }
            
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //修改按鈕
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;

            if (tabControl.SelectedTab.Name == "tpClass")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"
                        update class
                        set cls_name = '{0}'
                        where cls_id = {1}", tbCls_name.Text, tbCls_class.Text), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已修改{0}個資料。", row));

                    dgvClass_Load();

                    tbCls_class.Text = "";
                    tbCls_name.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStudents")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"
                        update students
                        set stu_name = '{0}'
                        where stu_id = {1}
                        ", tbStu_name.Text, stu_id), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已修改{0}個資料。", row));

                    dgvStudents_Load();
                                        
                    tbStu_name.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStores")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"
                        update stores
                        set sto_tel = '{0}', sto_address = '{1}'
                        where sto_name = '{2}'
                        ", tbSto_tel.Text, tbSto_address.Text, tbSto_name.Text), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已修改{0}個資料。", row));

                    dgvStores_Load();

                    tbSto_name.Text = "";
                    tbSto_tel.Text = "";
                    tbSto_address.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpMenu")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"
                        update products
                        set pro_price = {0}
                        where sto_id = {1} and pro_name = '{2}'
                        ", tbMnu_price.Text, sto_id, tbMnu_name.Text), con);

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已修改{0}個資料。", row));

                    dgvMenu_Load();
                                        
                    tbMnu_name.Text = "";
                    tbMnu_price.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //刪除按鈕
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;

            if (tabControl.SelectedTab.Name == "tpClass")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"delete from class
                                                         where cls_id = {0}", tbCls_class.Text), con);
                    

                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已刪除{0}個資料。", row));

                    dgvClass_Load();

                    tbCls_class.Text = "";
                    tbCls_name.Text = "";
                }
                catch (Exception) 
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStudents")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"delete from students
                                                         where cls_id = {0} and stu_name = '{1}'
                                                        ", cbStu_class.Text, tbStu_name.Text), con);


                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已刪除{0}個資料。", row));

                    dgvStudents_Load();
                                        
                    tbStu_name.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpStores")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"delete from stores
                                                         where sto_name = '{0}'", tbSto_name.Text), con);


                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已刪除{0}個資料。", row));

                    dgvStores_Load();

                    tbSto_name.Text = "";
                    tbSto_tel.Text = "";
                    tbSto_address.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            if (tabControl.SelectedTab.Name == "tpMenu")
            {
                try
                {
                    cmd = new SqlCommand(String.Format(@"delete from products
                                                         where sto_id = {0} and pro_name = '{1}'", sto_id, tbMnu_name.Text), con);


                    int row = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("已刪除{0}個資料。", row));

                    dgvMenu_Load();
                                        
                    tbMnu_name.Text = "";
                    tbMnu_price.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("你所輸入的資料不正確，請重新確認。");
                }
            }

            con.Close();
        }

        private void dgvClass_Load() 
        {
            tbCls_class.Text = "";
            tbCls_name.Text = "";

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            DataTable myDataTable;
            //表單dgvClass資料載入
            cmd = new SqlCommand(@"select cls_id as 期別, cls_name as 名稱
                                   from class
                                   order by 1 desc", con);
            reader = cmd.ExecuteReader();

            myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvClass.DataSource = myDataTable;

            reader.Close();

            con.Close();
        }

        private void dgvStudents_Load()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //表單dgvStudents資料載入：列出期別(cls_id)=cbStu_class的學生名稱(stu_name)
            cmd = new SqlCommand(String.Format(@"select stu_name
                                   from students
                                   where cls_id = {0}", cbStu_class.Text), con);
            reader = cmd.ExecuteReader();

            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvStudents.DataSource = myDataTable;

            reader.Close();

            con.Close();
        }

        private void dgvStores_Load() 
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            DataTable myDataTable;
            //表單dgvStores資料載入
            cmd = new SqlCommand(@"select sto_name as 名稱, sto_tel as 電話, sto_address as 地址 
                                   from stores", con);
            reader = cmd.ExecuteReader();

            myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvStores.DataSource = myDataTable;

            reader.Close();

            con.Close();
        }

        private void dgvMenu_Load()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            //表單dgvMenu資料載入：列出店家(sto_name)=cbMnu_store的菜單表
            cmd = new SqlCommand(String.Format(@"
                select pro_name as 名稱, pro_price as 單價
                from products
                where sto_id = (select sto_id
				                from stores
				                where sto_name = '{0}')
                ", cbMnu_store.Text), con);
            reader = cmd.ExecuteReader();

            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dgvMenu.DataSource = myDataTable;

            reader.Close();

            con.Close();
        }
    }
}
