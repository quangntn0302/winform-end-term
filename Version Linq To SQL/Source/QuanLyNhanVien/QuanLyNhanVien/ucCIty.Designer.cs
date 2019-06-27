namespace QuanLyNhanVien
{
    partial class ucCIty
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCityCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvLoadCity = new System.Windows.Forms.DataGridView();
            this.txbCityName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadCity)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "Tên thành phố (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 117;
            this.label2.Text = "Mã thành phố (*)";
            // 
            // txbCityCode
            // 
            this.txbCityCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCityCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCityCode.ForeColor = System.Drawing.Color.Red;
            this.txbCityCode.HintForeColor = System.Drawing.Color.Empty;
            this.txbCityCode.HintText = "";
            this.txbCityCode.isPassword = false;
            this.txbCityCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbCityCode.LineIdleColor = System.Drawing.Color.Red;
            this.txbCityCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbCityCode.LineThickness = 3;
            this.txbCityCode.Location = new System.Drawing.Point(0, 333);
            this.txbCityCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbCityCode.Name = "txbCityCode";
            this.txbCityCode.Size = new System.Drawing.Size(314, 42);
            this.txbCityCode.TabIndex = 112;
            this.txbCityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvLoadCity
            // 
            this.dtgvLoadCity.AllowUserToAddRows = false;
            this.dtgvLoadCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoadCity.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLoadCity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoadCity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLoadCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoadCity.ColumnHeadersVisible = false;
            this.dtgvLoadCity.GridColor = System.Drawing.Color.Blue;
            this.dtgvLoadCity.Location = new System.Drawing.Point(0, 55);
            this.dtgvLoadCity.MultiSelect = false;
            this.dtgvLoadCity.Name = "dtgvLoadCity";
            this.dtgvLoadCity.ReadOnly = true;
            this.dtgvLoadCity.RowHeadersVisible = false;
            this.dtgvLoadCity.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvLoadCity.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvLoadCity.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvLoadCity.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            this.dtgvLoadCity.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvLoadCity.RowTemplate.Height = 35;
            this.dtgvLoadCity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLoadCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoadCity.Size = new System.Drawing.Size(992, 191);
            this.dtgvLoadCity.TabIndex = 107;
            this.dtgvLoadCity.Click += new System.EventHandler(this.dtgvLoadCity_Click);
            // 
            // txbCityName
            // 
            this.txbCityName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCityName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txbCityName.ForeColor = System.Drawing.Color.Red;
            this.txbCityName.HintForeColor = System.Drawing.Color.Empty;
            this.txbCityName.HintText = "";
            this.txbCityName.isPassword = false;
            this.txbCityName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbCityName.LineIdleColor = System.Drawing.Color.Red;
            this.txbCityName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbCityName.LineThickness = 3;
            this.txbCityName.Location = new System.Drawing.Point(0, 441);
            this.txbCityName.Margin = new System.Windows.Forms.Padding(4);
            this.txbCityName.Name = "txbCityName";
            this.txbCityName.Size = new System.Drawing.Size(312, 42);
            this.txbCityName.TabIndex = 115;
            this.txbCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSave.Iconimage = global::QuanLyNhanVien.Properties.Resources.antenna;
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
            this.btnSave.Location = new System.Drawing.Point(340, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(143, 48);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Tên thành phố";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::QuanLyNhanVien.Properties.Resources.strategy;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 64D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(487, 8);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(505, 48);
            this.bunifuFlatButton3.TabIndex = 121;
            this.bunifuFlatButton3.Text = "Tên thành phố";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Mã thành phố";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::QuanLyNhanVien.Properties.Resources.door;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 64D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(488, 48);
            this.bunifuFlatButton1.TabIndex = 116;
            this.bunifuFlatButton1.Text = "Mã thành phố";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnExit.Location = new System.Drawing.Point(849, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(143, 48);
            this.btnExit.TabIndex = 114;
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
            this.btnShow.Iconimage = global::QuanLyNhanVien.Properties.Resources.satellite_station;
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
            this.btnShow.Location = new System.Drawing.Point(677, 254);
            this.btnShow.Name = "btnShow";
            this.btnShow.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShow.selected = false;
            this.btnShow.Size = new System.Drawing.Size(143, 48);
            this.btnShow.TabIndex = 111;
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
            this.btnEdit.Iconimage = global::QuanLyNhanVien.Properties.Resources.wifi;
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
            this.btnEdit.Location = new System.Drawing.Point(508, 254);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.OnHovercolor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(143, 48);
            this.btnEdit.TabIndex = 110;
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
            this.btnDelete.Iconimage = global::QuanLyNhanVien.Properties.Resources.wireless;
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
            this.btnDelete.Location = new System.Drawing.Point(171, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(143, 48);
            this.btnDelete.TabIndex = 109;
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
            this.btnAdd.Iconimage = global::QuanLyNhanVien.Properties.Resources.satellite_dish;
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
            this.btnAdd.Location = new System.Drawing.Point(0, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Purple;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Purple;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(143, 48);
            this.btnAdd.TabIndex = 108;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucCIty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txbCityName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbCityCode);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvLoadCity);
            this.Name = "ucCIty";
            this.Size = new System.Drawing.Size(992, 487);
            this.Load += new System.EventHandler(this.ucCIty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbCityCode;
        private Bunifu.Framework.UI.BunifuFlatButton btnShow;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.DataGridView dtgvLoadCity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbCityName;
    }
}
