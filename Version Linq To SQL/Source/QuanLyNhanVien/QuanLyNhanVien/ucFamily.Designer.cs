namespace QuanLyNhanVien
{
    partial class ucFamily
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbEmployeeCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvLoadFamily = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRelationship = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.ckbFemale = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ckbMale = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadFamily)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 133;
            this.label4.Text = "Tên thân nhân(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 132;
            this.label2.Text = "Mã nhân viên(*)";
            // 
            // txbName
            // 
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txbName.ForeColor = System.Drawing.Color.Red;
            this.txbName.HintForeColor = System.Drawing.Color.Empty;
            this.txbName.HintText = "";
            this.txbName.isPassword = false;
            this.txbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbName.LineIdleColor = System.Drawing.Color.Red;
            this.txbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbName.LineThickness = 3;
            this.txbName.Location = new System.Drawing.Point(0, 440);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(312, 42);
            this.txbName.TabIndex = 130;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbEmployeeCode
            // 
            this.txbEmployeeCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmployeeCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeCode.ForeColor = System.Drawing.Color.Red;
            this.txbEmployeeCode.HintForeColor = System.Drawing.Color.Empty;
            this.txbEmployeeCode.HintText = "";
            this.txbEmployeeCode.isPassword = false;
            this.txbEmployeeCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbEmployeeCode.LineIdleColor = System.Drawing.Color.Red;
            this.txbEmployeeCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbEmployeeCode.LineThickness = 3;
            this.txbEmployeeCode.Location = new System.Drawing.Point(0, 332);
            this.txbEmployeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmployeeCode.Name = "txbEmployeeCode";
            this.txbEmployeeCode.Size = new System.Drawing.Size(314, 42);
            this.txbEmployeeCode.TabIndex = 128;
            this.txbEmployeeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvLoadFamily
            // 
            this.dtgvLoadFamily.AllowUserToAddRows = false;
            this.dtgvLoadFamily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoadFamily.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLoadFamily.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoadFamily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLoadFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoadFamily.ColumnHeadersVisible = false;
            this.dtgvLoadFamily.GridColor = System.Drawing.Color.Blue;
            this.dtgvLoadFamily.Location = new System.Drawing.Point(0, 54);
            this.dtgvLoadFamily.MultiSelect = false;
            this.dtgvLoadFamily.Name = "dtgvLoadFamily";
            this.dtgvLoadFamily.ReadOnly = true;
            this.dtgvLoadFamily.RowHeadersVisible = false;
            this.dtgvLoadFamily.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvLoadFamily.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvLoadFamily.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvLoadFamily.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            this.dtgvLoadFamily.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvLoadFamily.RowTemplate.Height = 35;
            this.dtgvLoadFamily.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLoadFamily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoadFamily.Size = new System.Drawing.Size(992, 191);
            this.dtgvLoadFamily.TabIndex = 123;
            this.dtgvLoadFamily.Click += new System.EventHandler(this.dtgvLoadFamily_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 137;
            this.label1.Text = "Quan hệ (*)";
            // 
            // txbRelationship
            // 
            this.txbRelationship.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRelationship.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRelationship.ForeColor = System.Drawing.Color.Red;
            this.txbRelationship.HintForeColor = System.Drawing.Color.Empty;
            this.txbRelationship.HintText = "";
            this.txbRelationship.isPassword = false;
            this.txbRelationship.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbRelationship.LineIdleColor = System.Drawing.Color.Red;
            this.txbRelationship.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbRelationship.LineThickness = 3;
            this.txbRelationship.Location = new System.Drawing.Point(340, 332);
            this.txbRelationship.Margin = new System.Windows.Forms.Padding(4);
            this.txbRelationship.Name = "txbRelationship";
            this.txbRelationship.Size = new System.Drawing.Size(314, 42);
            this.txbRelationship.TabIndex = 136;
            this.txbRelationship.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Nữ(*)";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(366, 416);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(53, 16);
            this.lblDisplayName.TabIndex = 140;
            this.lblDisplayName.Text = "Nam(*)";
            // 
            // ckbFemale
            // 
            this.ckbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbFemale.ChechedOffColor = System.Drawing.Color.Red;
            this.ckbFemale.Checked = false;
            this.ckbFemale.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbFemale.ForeColor = System.Drawing.Color.White;
            this.ckbFemale.Location = new System.Drawing.Point(340, 455);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(20, 20);
            this.ckbFemale.TabIndex = 139;
            this.ckbFemale.OnChange += new System.EventHandler(this.ckbFemale_OnChange);
            // 
            // ckbMale
            // 
            this.ckbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbMale.ChechedOffColor = System.Drawing.Color.Red;
            this.ckbMale.Checked = false;
            this.ckbMale.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbMale.ForeColor = System.Drawing.Color.White;
            this.ckbMale.Location = new System.Drawing.Point(340, 416);
            this.ckbMale.Name = "ckbMale";
            this.ckbMale.Size = new System.Drawing.Size(20, 20);
            this.ckbMale.TabIndex = 138;
            this.ckbMale.OnChange += new System.EventHandler(this.ckbMale_OnChange);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Giới tính";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::QuanLyNhanVien.Properties.Resources.gender;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 64D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(488, 7);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton5.TabIndex = 146;
            this.bunifuFlatButton5.Text = "Giới tính";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Tên";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::QuanLyNhanVien.Properties.Resources.businessman__1_;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 64D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(245, 7);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton6.TabIndex = 145;
            this.bunifuFlatButton6.Text = "Tên";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Mã NV";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::QuanLyNhanVien.Properties.Resources.verification;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 64D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 7);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(246, 48);
            this.bunifuFlatButton7.TabIndex = 144;
            this.bunifuFlatButton7.Text = "Mã NV";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Tên thành phố";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::QuanLyNhanVien.Properties.Resources.relationship;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 64D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(731, 7);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton4.TabIndex = 143;
            this.bunifuFlatButton4.Text = "Tên thành phố";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::QuanLyNhanVien.Properties.Resources.couple__2_;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 64D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(340, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(143, 48);
            this.btnSave.TabIndex = 135;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = global::QuanLyNhanVien.Properties.Resources.exit;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 64D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(849, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(143, 48);
            this.btnExit.TabIndex = 129;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.BorderRadius = 0;
            this.btnShow.ButtonText = "Xem";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DisabledColor = System.Drawing.Color.Gray;
            this.btnShow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShow.Iconimage = global::QuanLyNhanVien.Properties.Resources.grandparents;
            this.btnShow.Iconimage_right = null;
            this.btnShow.Iconimage_right_Selected = null;
            this.btnShow.Iconimage_Selected = null;
            this.btnShow.IconMarginLeft = 0;
            this.btnShow.IconMarginRight = 0;
            this.btnShow.IconRightVisible = true;
            this.btnShow.IconRightZoom = 0D;
            this.btnShow.IconVisible = true;
            this.btnShow.IconZoom = 64D;
            this.btnShow.IsTab = false;
            this.btnShow.Location = new System.Drawing.Point(677, 253);
            this.btnShow.Name = "btnShow";
            this.btnShow.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShow.selected = false;
            this.btnShow.Size = new System.Drawing.Size(143, 48);
            this.btnShow.TabIndex = 127;
            this.btnShow.Text = "Xem";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Textcolor = System.Drawing.Color.White;
            this.btnShow.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = global::QuanLyNhanVien.Properties.Resources.couple__3_;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 64D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(508, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.OnHovercolor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(143, 48);
            this.btnEdit.TabIndex = 126;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::QuanLyNhanVien.Properties.Resources.couple__1_;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 64D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(171, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(143, 48);
            this.btnDelete.TabIndex = 125;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Purple;
            this.btnAdd.BackColor = System.Drawing.Color.Purple;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::QuanLyNhanVien.Properties.Resources.couple;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 64D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(0, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Purple;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(143, 48);
            this.btnAdd.TabIndex = 124;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.ckbFemale);
            this.Controls.Add(this.ckbMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRelationship);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbEmployeeCode);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvLoadFamily);
            this.Name = "ucFamily";
            this.Size = new System.Drawing.Size(992, 488);
            this.Load += new System.EventHandler(this.ucFamily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadFamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbName;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbEmployeeCode;
        private Bunifu.Framework.UI.BunifuFlatButton btnShow;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.DataGridView dtgvLoadFamily;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbRelationship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayName;
        private Bunifu.Framework.UI.BunifuCheckbox ckbFemale;
        private Bunifu.Framework.UI.BunifuCheckbox ckbMale;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
    }
}
