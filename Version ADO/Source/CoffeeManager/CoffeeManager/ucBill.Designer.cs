namespace CoffeeManager
{
    partial class ucBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBill));
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.lblShow = new System.Windows.Forms.Label();
            this.txbBillDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReportBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckBill = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Location = new System.Drawing.Point(0, 21);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(348, 26);
            this.dtpkFromDate.TabIndex = 1;
            this.dtpkFromDate.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Location = new System.Drawing.Point(0, 70);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(348, 24);
            this.dtpkToDate.TabIndex = 2;
            this.dtpkToDate.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.ColumnHeadersVisible = false;
            this.dtgvBill.GridColor = System.Drawing.Color.Blue;
            this.dtgvBill.Location = new System.Drawing.Point(0, 138);
            this.dtgvBill.MultiSelect = false;
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvBill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            this.dtgvBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBill.RowTemplate.Height = 35;
            this.dtgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(683, 152);
            this.dtgvBill.TabIndex = 3;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(3, 293);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(286, 23);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "Hiện Tổng Doanh Thu Theo Mốc";
            // 
            // txbBillDate
            // 
            this.txbBillDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBillDate.Enabled = false;
            this.txbBillDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBillDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBillDate.HintForeColor = System.Drawing.Color.Empty;
            this.txbBillDate.HintText = "";
            this.txbBillDate.isPassword = false;
            this.txbBillDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbBillDate.LineIdleColor = System.Drawing.Color.Gray;
            this.txbBillDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbBillDate.LineThickness = 4;
            this.txbBillDate.Location = new System.Drawing.Point(296, 310);
            this.txbBillDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbBillDate.Name = "txbBillDate";
            this.txbBillDate.Size = new System.Drawing.Size(218, 46);
            this.txbBillDate.TabIndex = 6;
            this.txbBillDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 32);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(44, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bàn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(135, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 32);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(27, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giảm Giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(266, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 32);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(27, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Location = new System.Drawing.Point(399, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 32);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(27, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Vào";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.Location = new System.Drawing.Point(532, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 32);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(27, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Ra";
            // 
            // btnReportBill
            // 
            this.btnReportBill.ActiveBorderThickness = 1;
            this.btnReportBill.ActiveCornerRadius = 20;
            this.btnReportBill.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReportBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnReportBill.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReportBill.BackColor = System.Drawing.Color.White;
            this.btnReportBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportBill.BackgroundImage")));
            this.btnReportBill.ButtonText = "Tạo Report";
            this.btnReportBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReportBill.IdleBorderThickness = 1;
            this.btnReportBill.IdleCornerRadius = 20;
            this.btnReportBill.IdleFillColor = System.Drawing.Color.White;
            this.btnReportBill.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReportBill.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReportBill.Location = new System.Drawing.Point(481, 17);
            this.btnReportBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnReportBill.Name = "btnReportBill";
            this.btnReportBill.Size = new System.Drawing.Size(115, 81);
            this.btnReportBill.TabIndex = 15;
            this.btnReportBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportBill.Click += new System.EventHandler(this.btnReportBill_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(7, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(7, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckBill
            // 
            this.btnCheckBill.ActiveBorderThickness = 1;
            this.btnCheckBill.ActiveCornerRadius = 20;
            this.btnCheckBill.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCheckBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnCheckBill.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCheckBill.BackColor = System.Drawing.Color.White;
            this.btnCheckBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckBill.BackgroundImage")));
            this.btnCheckBill.ButtonText = "Thống Kê Doanh Thu";
            this.btnCheckBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCheckBill.IdleBorderThickness = 1;
            this.btnCheckBill.IdleCornerRadius = 20;
            this.btnCheckBill.IdleFillColor = System.Drawing.Color.White;
            this.btnCheckBill.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCheckBill.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCheckBill.Location = new System.Drawing.Point(356, 17);
            this.btnCheckBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckBill.Name = "btnCheckBill";
            this.btnCheckBill.Size = new System.Drawing.Size(115, 81);
            this.btnCheckBill.TabIndex = 7;
            this.btnCheckBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckBill.Click += new System.EventHandler(this.btnCheckBill_Click);
            // 
            // ucBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReportBill);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckBill);
            this.Controls.Add(this.txbBillDate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Name = "ucBill";
            this.Size = new System.Drawing.Size(683, 389);
            this.Load += new System.EventHandler(this.ucBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label lblShow;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBillDate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCheckBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReportBill;
    }
}
