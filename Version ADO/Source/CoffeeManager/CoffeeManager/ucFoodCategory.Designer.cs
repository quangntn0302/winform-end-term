namespace CoffeeManager
{
    partial class ucFoodCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnReportAccount = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbIDFoodCategory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlAccount.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnReportAccount);
            this.pnlAccount.Controls.Add(this.groupBox3);
            this.pnlAccount.Controls.Add(this.dtgvFoodCategory);
            this.pnlAccount.Controls.Add(this.groupBox1);
            this.pnlAccount.Location = new System.Drawing.Point(2, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(679, 377);
            this.pnlAccount.TabIndex = 12;
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
            this.btnReportAccount.Location = new System.Drawing.Point(606, 212);
            this.btnReportAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReportAccount.Name = "btnReportAccount";
            this.btnReportAccount.Size = new System.Drawing.Size(68, 57);
            this.btnReportAccount.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(333, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 112);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbName);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(6, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(335, 36);
            this.panel10.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.HintForeColor = System.Drawing.Color.Empty;
            this.txbName.HintText = "";
            this.txbName.isPassword = false;
            this.txbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbName.LineIdleColor = System.Drawing.Color.Red;
            this.txbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbName.LineThickness = 3;
            this.txbName.Location = new System.Drawing.Point(139, 1);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(195, 33);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Danh Mục :";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbIDFoodCategory);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(6, 28);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(335, 36);
            this.panel11.TabIndex = 0;
            // 
            // txbIDFoodCategory
            // 
            this.txbIDFoodCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDFoodCategory.Enabled = false;
            this.txbIDFoodCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDFoodCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDFoodCategory.HintForeColor = System.Drawing.Color.Empty;
            this.txbIDFoodCategory.HintText = "";
            this.txbIDFoodCategory.isPassword = false;
            this.txbIDFoodCategory.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbIDFoodCategory.LineIdleColor = System.Drawing.Color.Red;
            this.txbIDFoodCategory.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbIDFoodCategory.LineThickness = 3;
            this.txbIDFoodCategory.Location = new System.Drawing.Point(139, 1);
            this.txbIDFoodCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDFoodCategory.Name = "txbIDFoodCategory";
            this.txbIDFoodCategory.Size = new System.Drawing.Size(193, 33);
            this.txbIDFoodCategory.TabIndex = 2;
            this.txbIDFoodCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // dtgvFoodCategory
            // 
            this.dtgvFoodCategory.AllowUserToAddRows = false;
            this.dtgvFoodCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFoodCategory.BackgroundColor = System.Drawing.Color.White;
            this.dtgvFoodCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFoodCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodCategory.ColumnHeadersVisible = false;
            this.dtgvFoodCategory.GridColor = System.Drawing.Color.Blue;
            this.dtgvFoodCategory.Location = new System.Drawing.Point(3, 105);
            this.dtgvFoodCategory.MultiSelect = false;
            this.dtgvFoodCategory.Name = "dtgvFoodCategory";
            this.dtgvFoodCategory.ReadOnly = true;
            this.dtgvFoodCategory.RowHeadersVisible = false;
            this.dtgvFoodCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvFoodCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvFoodCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvFoodCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            this.dtgvFoodCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvFoodCategory.RowTemplate.Height = 35;
            this.dtgvFoodCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFoodCategory.Size = new System.Drawing.Size(328, 268);
            this.dtgvFoodCategory.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 87);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.color = System.Drawing.Color.SeaGreen;
            this.btnShow.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnShow.ImagePosition = 6;
            this.btnShow.ImageZoom = 42;
            this.btnShow.LabelPosition = 20;
            this.btnShow.LabelText = "Xem";
            this.btnShow.Location = new System.Drawing.Point(284, 24);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(61, 57);
            this.btnShow.TabIndex = 23;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.color = System.Drawing.Color.SeaGreen;
            this.btnDelete.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnDelete.ImagePosition = 6;
            this.btnDelete.ImageZoom = 42;
            this.btnDelete.LabelPosition = 20;
            this.btnDelete.LabelText = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(215, 24);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 57);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.color = System.Drawing.Color.SeaGreen;
            this.btnSave.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnSave.ImagePosition = 6;
            this.btnSave.ImageZoom = 42;
            this.btnSave.LabelPosition = 20;
            this.btnSave.LabelText = "Lưu";
            this.btnSave.Location = new System.Drawing.Point(144, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 57);
            this.btnSave.TabIndex = 21;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.color = System.Drawing.Color.SeaGreen;
            this.btnEdit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnEdit.ImagePosition = 6;
            this.btnEdit.ImageZoom = 42;
            this.btnEdit.LabelPosition = 20;
            this.btnEdit.LabelText = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(73, 24);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 57);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.color = System.Drawing.Color.SeaGreen;
            this.btnAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CoffeeManager.Properties.Resources.rsz_change;
            this.btnAdd.ImagePosition = 6;
            this.btnAdd.ImageZoom = 42;
            this.btnAdd.LabelPosition = 20;
            this.btnAdd.LabelText = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(2, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 57);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucFoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlAccount);
            this.Name = "ucFoodCategory";
            this.Size = new System.Drawing.Size(683, 389);
            this.Load += new System.EventHandler(this.ucFoodCategory_Load);
            this.pnlAccount.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccount;
        private Bunifu.Framework.UI.BunifuTileButton btnReportAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbIDFoodCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvFoodCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnShow;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnEdit;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
    }
}
