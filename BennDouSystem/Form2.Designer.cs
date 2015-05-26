namespace BennDouSystem
{
    partial class Form2
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
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.dgvMyOrder = new System.Windows.Forms.DataGridView();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNum = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblOrderState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(311, 28);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "期別";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(358, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(26, 28);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(41, 20);
            this.lblStore.TabIndex = 2;
            this.lblStore.Text = "店家";
            // 
            // dgvMyOrder
            // 
            this.dgvMyOrder.AllowUserToAddRows = false;
            this.dgvMyOrder.AllowUserToDeleteRows = false;
            this.dgvMyOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrder.Location = new System.Drawing.Point(30, 66);
            this.dgvMyOrder.MultiSelect = false;
            this.dgvMyOrder.Name = "dgvMyOrder";
            this.dgvMyOrder.ReadOnly = true;
            this.dgvMyOrder.RowHeadersVisible = false;
            this.dgvMyOrder.RowTemplate.Height = 24;
            this.dgvMyOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyOrder.Size = new System.Drawing.Size(420, 210);
            this.dgvMyOrder.TabIndex = 3;
            this.dgvMyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyOrder_CellClick);
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(30, 305);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(162, 28);
            this.cbItem.TabIndex = 5;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(278, 304);
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.Size = new System.Drawing.Size(100, 29);
            this.tbSum.TabIndex = 9;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(240, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(400, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 50);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "完成";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "項目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "金額";
            // 
            // cbNum
            // 
            this.cbNum.FormattingEnabled = true;
            this.cbNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNum.Location = new System.Drawing.Point(207, 305);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(56, 28);
            this.cbNum.TabIndex = 7;
            this.cbNum.SelectedIndexChanged += new System.EventHandler(this.cbNum_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(312, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblOrderState
            // 
            this.lblOrderState.AutoSize = true;
            this.lblOrderState.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderState.ForeColor = System.Drawing.Color.Red;
            this.lblOrderState.Location = new System.Drawing.Point(130, 358);
            this.lblOrderState.Name = "lblOrderState";
            this.lblOrderState.Size = new System.Drawing.Size(104, 16);
            this.lblOrderState.TabIndex = 19;
            this.lblOrderState.Text = "此訂單已完成訂購";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 404);
            this.Controls.Add(this.lblOrderState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.cbNum);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.dgvMyOrder);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblClass);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "我的訂單";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.DataGridView dgvMyOrder;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblOrderState;
    }
}