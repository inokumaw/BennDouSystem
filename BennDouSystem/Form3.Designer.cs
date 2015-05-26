namespace BennDouSystem
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStore = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckOK = new System.Windows.Forms.Button();
            this.btnCheckNG = new System.Windows.Forms.Button();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOrderState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "期別";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(71, 23);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(56, 28);
            this.cbClass.TabIndex = 1;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "店家";
            // 
            // tbStore
            // 
            this.tbStore.Location = new System.Drawing.Point(71, 67);
            this.tbStore.Name = "tbStore";
            this.tbStore.ReadOnly = true;
            this.tbStore.Size = new System.Drawing.Size(145, 29);
            this.tbStore.TabIndex = 3;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(295, 67);
            this.tbTel.Name = "tbTel";
            this.tbTel.ReadOnly = true;
            this.tbTel.Size = new System.Drawing.Size(145, 29);
            this.tbTel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(28, 119);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(412, 210);
            this.dgvOrder.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "總金額";
            // 
            // btnCheckOK
            // 
            this.btnCheckOK.Location = new System.Drawing.Point(340, 391);
            this.btnCheckOK.Name = "btnCheckOK";
            this.btnCheckOK.Size = new System.Drawing.Size(100, 33);
            this.btnCheckOK.TabIndex = 9;
            this.btnCheckOK.Text = "完成訂購";
            this.btnCheckOK.UseVisualStyleBackColor = true;
            this.btnCheckOK.Click += new System.EventHandler(this.btnCheckOK_Click);
            // 
            // btnCheckNG
            // 
            this.btnCheckNG.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckNG.Location = new System.Drawing.Point(268, 402);
            this.btnCheckNG.Name = "btnCheckNG";
            this.btnCheckNG.Size = new System.Drawing.Size(66, 22);
            this.btnCheckNG.TabIndex = 10;
            this.btnCheckNG.Text = "取消訂購";
            this.btnCheckNG.UseVisualStyleBackColor = true;
            this.btnCheckNG.Click += new System.EventHandler(this.btnCheckNG_Click);
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(295, 347);
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.Size = new System.Drawing.Size(145, 29);
            this.tbSum.TabIndex = 11;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 33);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOrderState
            // 
            this.lblOrderState.AutoSize = true;
            this.lblOrderState.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderState.ForeColor = System.Drawing.Color.Red;
            this.lblOrderState.Location = new System.Drawing.Point(324, 26);
            this.lblOrderState.Name = "lblOrderState";
            this.lblOrderState.Size = new System.Drawing.Size(116, 16);
            this.lblOrderState.TabIndex = 13;
            this.lblOrderState.Text = "此訂單尚未完成訂購";
            this.lblOrderState.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 448);
            this.Controls.Add(this.lblOrderState);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.btnCheckNG);
            this.Controls.Add(this.btnCheckOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "櫃台確認";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStore;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckOK;
        private System.Windows.Forms.Button btnCheckNG;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrderState;
    }
}