namespace CoffeeManager
{
    partial class ucTableFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnReportAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbNameTableFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbIDTableFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvLoadTableFood = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDeleteAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSaveAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.txbStatusTableFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlAccount.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadTableFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnReportAccount);
            this.pnlAccount.Controls.Add(this.groupBox3);
            this.pnlAccount.Controls.Add(this.dtgvLoadTableFood);
            this.pnlAccount.Controls.Add(this.groupBox1);
            this.pnlAccount.Location = new System.Drawing.Point(1, 8);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(679, 389);
            this.pnlAccount.TabIndex = 11;
            // 
            // btnReportAccount
            // 
            this.btnReportAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReportAccount.color = System.Drawing.Color.SeaGreen;
            this.btnReportAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnReportAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportAccount.ForeColor = System.Drawing.Color.White;
            this.btnReportAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnReportAccount.ImagePosition = 6;
            this.btnReportAccount.ImageZoom = 42;
            this.btnReportAccount.LabelPosition = 20;
            this.btnReportAccount.LabelText = "Report";
            this.btnReportAccount.Location = new System.Drawing.Point(612, 247);
            this.btnReportAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReportAccount.Name = "btnReportAccount";
            this.btnReportAccount.Size = new System.Drawing.Size(68, 57);
            this.btnReportAccount.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(333, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 147);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbStatusTableFood);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(6, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(335, 36);
            this.panel9.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái :";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbNameTableFood);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(6, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(335, 36);
            this.panel10.TabIndex = 2;
            // 
            // txbNameTableFood
            // 
            this.txbNameTableFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameTableFood.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbNameTableFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNameTableFood.HintForeColor = System.Drawing.Color.Empty;
            this.txbNameTableFood.HintText = "";
            this.txbNameTableFood.isPassword = false;
            this.txbNameTableFood.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbNameTableFood.LineIdleColor = System.Drawing.Color.Red;
            this.txbNameTableFood.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbNameTableFood.LineThickness = 3;
            this.txbNameTableFood.Location = new System.Drawing.Point(139, 1);
            this.txbNameTableFood.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameTableFood.Name = "txbNameTableFood";
            this.txbNameTableFood.Size = new System.Drawing.Size(195, 33);
            this.txbNameTableFood.TabIndex = 1;
            this.txbNameTableFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Bàn :";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbIDTableFood);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(6, 28);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(335, 36);
            this.panel11.TabIndex = 0;
            // 
            // txbIDTableFood
            // 
            this.txbIDTableFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDTableFood.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDTableFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDTableFood.HintForeColor = System.Drawing.Color.Empty;
            this.txbIDTableFood.HintText = "";
            this.txbIDTableFood.isPassword = false;
            this.txbIDTableFood.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbIDTableFood.LineIdleColor = System.Drawing.Color.Red;
            this.txbIDTableFood.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbIDTableFood.LineThickness = 3;
            this.txbIDTableFood.Location = new System.Drawing.Point(139, 1);
            this.txbIDTableFood.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDTableFood.Name = "txbIDTableFood";
            this.txbIDTableFood.Size = new System.Drawing.Size(193, 33);
            this.txbIDTableFood.TabIndex = 2;
            this.txbIDTableFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // dtgvLoadTableFood
            // 
            this.dtgvLoadTableFood.AllowUserToAddRows = false;
            this.dtgvLoadTableFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoadTableFood.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLoadTableFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoadTableFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLoadTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoadTableFood.ColumnHeadersVisible = false;
            this.dtgvLoadTableFood.GridColor = System.Drawing.Color.Blue;
            this.dtgvLoadTableFood.Location = new System.Drawing.Point(3, 105);
            this.dtgvLoadTableFood.MultiSelect = false;
            this.dtgvLoadTableFood.Name = "dtgvLoadTableFood";
            this.dtgvLoadTableFood.ReadOnly = true;
            this.dtgvLoadTableFood.RowHeadersVisible = false;
            this.dtgvLoadTableFood.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvLoadTableFood.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvLoadTableFood.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvLoadTableFood.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            this.dtgvLoadTableFood.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvLoadTableFood.RowTemplate.Height = 35;
            this.dtgvLoadTableFood.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLoadTableFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoadTableFood.Size = new System.Drawing.Size(328, 268);
            this.dtgvLoadTableFood.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAccount);
            this.groupBox1.Controls.Add(this.btnDeleteAccount);
            this.groupBox1.Controls.Add(this.btnSaveAccount);
            this.groupBox1.Controls.Add(this.btnEditAccount);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 87);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAccount.color = System.Drawing.Color.SeaGreen;
            this.btnShowAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnShowAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccount.ForeColor = System.Drawing.Color.White;
            this.btnShowAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnShowAccount.ImagePosition = 6;
            this.btnShowAccount.ImageZoom = 42;
            this.btnShowAccount.LabelPosition = 20;
            this.btnShowAccount.LabelText = "Xem";
            this.btnShowAccount.Location = new System.Drawing.Point(284, 24);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(61, 57);
            this.btnShowAccount.TabIndex = 23;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteAccount.color = System.Drawing.Color.SeaGreen;
            this.btnDeleteAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnDeleteAccount.ImagePosition = 6;
            this.btnDeleteAccount.ImageZoom = 42;
            this.btnDeleteAccount.LabelPosition = 20;
            this.btnDeleteAccount.LabelText = "Xóa";
            this.btnDeleteAccount.Location = new System.Drawing.Point(215, 24);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(61, 57);
            this.btnDeleteAccount.TabIndex = 22;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveAccount.color = System.Drawing.Color.SeaGreen;
            this.btnSaveAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.ForeColor = System.Drawing.Color.White;
            this.btnSaveAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnSaveAccount.ImagePosition = 6;
            this.btnSaveAccount.ImageZoom = 42;
            this.btnSaveAccount.LabelPosition = 20;
            this.btnSaveAccount.LabelText = "Lưu";
            this.btnSaveAccount.Location = new System.Drawing.Point(144, 24);
            this.btnSaveAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(61, 57);
            this.btnSaveAccount.TabIndex = 21;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditAccount.color = System.Drawing.Color.SeaGreen;
            this.btnEditAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnEditAccount.ImagePosition = 6;
            this.btnEditAccount.ImageZoom = 42;
            this.btnEditAccount.LabelPosition = 20;
            this.btnEditAccount.LabelText = "Sửa";
            this.btnEditAccount.Location = new System.Drawing.Point(73, 24);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(61, 57);
            this.btnEditAccount.TabIndex = 20;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAccount.color = System.Drawing.Color.SeaGreen;
            this.btnAddAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnAddAccount.ImagePosition = 6;
            this.btnAddAccount.ImageZoom = 42;
            this.btnAddAccount.LabelPosition = 20;
            this.btnAddAccount.LabelText = "Thêm";
            this.btnAddAccount.Location = new System.Drawing.Point(2, 23);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(61, 57);
            this.btnAddAccount.TabIndex = 19;
            // 
            // txbStatusTableFood
            // 
            this.txbStatusTableFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbStatusTableFood.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbStatusTableFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbStatusTableFood.HintForeColor = System.Drawing.Color.Empty;
            this.txbStatusTableFood.HintText = "";
            this.txbStatusTableFood.isPassword = false;
            this.txbStatusTableFood.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbStatusTableFood.LineIdleColor = System.Drawing.Color.Red;
            this.txbStatusTableFood.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbStatusTableFood.LineThickness = 3;
            this.txbStatusTableFood.Location = new System.Drawing.Point(139, 4);
            this.txbStatusTableFood.Margin = new System.Windows.Forms.Padding(4);
            this.txbStatusTableFood.Name = "txbStatusTableFood";
            this.txbStatusTableFood.Size = new System.Drawing.Size(195, 33);
            this.txbStatusTableFood.TabIndex = 2;
            this.txbStatusTableFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucTableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlAccount);
            this.Name = "ucTableFood";
            this.Size = new System.Drawing.Size(683, 389);
            this.Load += new System.EventHandler(this.ucTableFood_Load);
            this.pnlAccount.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadTableFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnReportAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbNameTableFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbIDTableFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvLoadTableFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnShowAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnDeleteAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnSaveAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnEditAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnAddAccount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbStatusTableFood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbStatusTableFood;
    }
}
