namespace BennDouSystem
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.tbCls_name = new System.Windows.Forms.TextBox();
            this.tbCls_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.cbStu_class = new System.Windows.Forms.ComboBox();
            this.tbStu_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tpStores = new System.Windows.Forms.TabPage();
            this.tbSto_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSto_tel = new System.Windows.Forms.TextBox();
            this.tbSto_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.cbMnu_store = new System.Windows.Forms.ComboBox();
            this.tbMnu_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMnu_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.tpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tpStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.tpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpClass);
            this.tabControl.Controls.Add(this.tpStudents);
            this.tabControl.Controls.Add(this.tpStores);
            this.tabControl.Controls.Add(this.tpMenu);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(449, 377);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.tbCls_name);
            this.tpClass.Controls.Add(this.tbCls_class);
            this.tpClass.Controls.Add(this.label2);
            this.tpClass.Controls.Add(this.label1);
            this.tpClass.Controls.Add(this.dgvClass);
            this.tpClass.Location = new System.Drawing.Point(4, 29);
            this.tpClass.Name = "tpClass";
            this.tpClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpClass.Size = new System.Drawing.Size(441, 344);
            this.tpClass.TabIndex = 0;
            this.tpClass.Text = "班級";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // tbCls_name
            // 
            this.tbCls_name.Location = new System.Drawing.Point(68, 242);
            this.tbCls_name.Name = "tbCls_name";
            this.tbCls_name.Size = new System.Drawing.Size(290, 29);
            this.tbCls_name.TabIndex = 4;
            // 
            // tbCls_class
            // 
            this.tbCls_class.Location = new System.Drawing.Point(68, 197);
            this.tbCls_class.Name = "tbCls_class";
            this.tbCls_class.Size = new System.Drawing.Size(58, 29);
            this.tbCls_class.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "期別";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(6, 6);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(429, 172);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // tpStudents
            // 
            this.tpStudents.Controls.Add(this.cbStu_class);
            this.tpStudents.Controls.Add(this.tbStu_name);
            this.tpStudents.Controls.Add(this.label3);
            this.tpStudents.Controls.Add(this.label4);
            this.tpStudents.Controls.Add(this.dgvStudents);
            this.tpStudents.Location = new System.Drawing.Point(4, 29);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudents.Size = new System.Drawing.Size(441, 344);
            this.tpStudents.TabIndex = 1;
            this.tpStudents.Text = "學生";
            this.tpStudents.UseVisualStyleBackColor = true;
            // 
            // cbStu_class
            // 
            this.cbStu_class.FormattingEnabled = true;
            this.cbStu_class.Location = new System.Drawing.Point(68, 197);
            this.cbStu_class.Name = "cbStu_class";
            this.cbStu_class.Size = new System.Drawing.Size(56, 28);
            this.cbStu_class.TabIndex = 9;
            this.cbStu_class.SelectedIndexChanged += new System.EventHandler(this.cbStu_class_SelectedIndexChanged);
            // 
            // tbStu_name
            // 
            this.tbStu_name.Location = new System.Drawing.Point(68, 242);
            this.tbStu_name.Name = "tbStu_name";
            this.tbStu_name.Size = new System.Drawing.Size(145, 29);
            this.tbStu_name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "期別";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.ColumnHeadersVisible = false;
            this.dgvStudents.Location = new System.Drawing.Point(6, 6);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(429, 172);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // tpStores
            // 
            this.tpStores.Controls.Add(this.tbSto_address);
            this.tpStores.Controls.Add(this.label7);
            this.tpStores.Controls.Add(this.tbSto_tel);
            this.tpStores.Controls.Add(this.tbSto_name);
            this.tpStores.Controls.Add(this.label5);
            this.tpStores.Controls.Add(this.label6);
            this.tpStores.Controls.Add(this.dgvStores);
            this.tpStores.Location = new System.Drawing.Point(4, 29);
            this.tpStores.Name = "tpStores";
            this.tpStores.Size = new System.Drawing.Size(441, 344);
            this.tpStores.TabIndex = 2;
            this.tpStores.Text = "店家";
            this.tpStores.UseVisualStyleBackColor = true;
            // 
            // tbSto_address
            // 
            this.tbSto_address.Location = new System.Drawing.Point(68, 288);
            this.tbSto_address.Name = "tbSto_address";
            this.tbSto_address.Size = new System.Drawing.Size(290, 29);
            this.tbSto_address.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "地址";
            // 
            // tbSto_tel
            // 
            this.tbSto_tel.Location = new System.Drawing.Point(68, 242);
            this.tbSto_tel.Name = "tbSto_tel";
            this.tbSto_tel.Size = new System.Drawing.Size(145, 29);
            this.tbSto_tel.TabIndex = 8;
            // 
            // tbSto_name
            // 
            this.tbSto_name.Location = new System.Drawing.Point(68, 197);
            this.tbSto_name.Name = "tbSto_name";
            this.tbSto_name.Size = new System.Drawing.Size(145, 29);
            this.tbSto_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "電話";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "名稱";
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Location = new System.Drawing.Point(6, 6);
            this.dgvStores.MultiSelect = false;
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.RowHeadersVisible = false;
            this.dgvStores.RowTemplate.Height = 24;
            this.dgvStores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStores.Size = new System.Drawing.Size(429, 172);
            this.dgvStores.TabIndex = 1;
            this.dgvStores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStores_CellClick);
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.cbMnu_store);
            this.tpMenu.Controls.Add(this.tbMnu_price);
            this.tpMenu.Controls.Add(this.label8);
            this.tpMenu.Controls.Add(this.tbMnu_name);
            this.tpMenu.Controls.Add(this.label9);
            this.tpMenu.Controls.Add(this.label10);
            this.tpMenu.Controls.Add(this.dgvMenu);
            this.tpMenu.Location = new System.Drawing.Point(4, 29);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Size = new System.Drawing.Size(441, 344);
            this.tpMenu.TabIndex = 3;
            this.tpMenu.Text = "菜單";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // cbMnu_store
            // 
            this.cbMnu_store.FormattingEnabled = true;
            this.cbMnu_store.Location = new System.Drawing.Point(68, 197);
            this.cbMnu_store.Name = "cbMnu_store";
            this.cbMnu_store.Size = new System.Drawing.Size(145, 28);
            this.cbMnu_store.TabIndex = 17;
            this.cbMnu_store.SelectedIndexChanged += new System.EventHandler(this.cbMnu_store_SelectedIndexChanged);
            // 
            // tbMnu_price
            // 
            this.tbMnu_price.Location = new System.Drawing.Point(68, 288);
            this.tbMnu_price.Name = "tbMnu_price";
            this.tbMnu_price.Size = new System.Drawing.Size(145, 29);
            this.tbMnu_price.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "單價";
            // 
            // tbMnu_name
            // 
            this.tbMnu_name.Location = new System.Drawing.Point(68, 242);
            this.tbMnu_name.Name = "tbMnu_name";
            this.tbMnu_name.Size = new System.Drawing.Size(145, 29);
            this.tbMnu_name.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "名稱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "店家";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(6, 6);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(429, 172);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(251, 395);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(66, 33);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 437);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.Text = "資料維護";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl.ResumeLayout(false);
            this.tpClass.ResumeLayout(false);
            this.tpClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.tpStudents.ResumeLayout(false);
            this.tpStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tpStores.ResumeLayout(false);
            this.tpStores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.tpMenu.ResumeLayout(false);
            this.tpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.TabPage tpStores;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox tbCls_name;
        private System.Windows.Forms.TextBox tbCls_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStu_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox tbSto_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSto_tel;
        private System.Windows.Forms.TextBox tbSto_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.TextBox tbMnu_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMnu_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbStu_class;
        private System.Windows.Forms.ComboBox cbMnu_store;
    }
}