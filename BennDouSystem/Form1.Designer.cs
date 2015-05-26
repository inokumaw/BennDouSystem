namespace BennDouSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeNow = new System.Windows.Forms.TextBox();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDecide = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "期別";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(82, 23);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(56, 28);
            this.cbClass.TabIndex = 1;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(205, 23);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 28);
            this.cbName.TabIndex = 3;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "店家";
            // 
            // cbStore
            // 
            this.cbStore.Enabled = false;
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(82, 66);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(168, 28);
            this.cbStore.TabIndex = 5;
            this.cbStore.SelectedIndexChanged += new System.EventHandler(this.cbStore_SelectedIndexChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(31, 113);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(599, 321);
            this.dgvOrder.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "現在時間";
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.Location = new System.Drawing.Point(427, 23);
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.ReadOnly = true;
            this.tbTimeNow.Size = new System.Drawing.Size(203, 29);
            this.tbTimeNow.TabIndex = 9;
            this.tbTimeNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.Enabled = false;
            this.btnMyOrder.Location = new System.Drawing.Point(530, 63);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(100, 33);
            this.btnMyOrder.TabIndex = 10;
            this.btnMyOrder.Text = "我的訂單";
            this.btnMyOrder.UseVisualStyleBackColor = true;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(530, 451);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 33);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "櫃台確認";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDecide
            // 
            this.btnDecide.Location = new System.Drawing.Point(260, 63);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(66, 33);
            this.btnDecide.TabIndex = 12;
            this.btnDecide.Text = "決定";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Visible = false;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(31, 451);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(100, 33);
            this.btnData.TabIndex = 13;
            this.btnData.Text = "資料維護";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 509);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnDecide);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnMyOrder);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.cbStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "BennDouSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeNow;
        private System.Windows.Forms.Button btnMyOrder;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnData;
    }
}

