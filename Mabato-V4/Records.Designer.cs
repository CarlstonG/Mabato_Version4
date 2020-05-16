namespace Mabato_V4
{
    partial class Records
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLrnNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIndi = new ns1.BunifuDropdown();
            this.txtGender = new ns1.BunifuDropdown();
            this.txtDOB = new ns1.BunifuDatepicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new ns1.BunifuMaterialTextbox();
            this.txtZipcode = new ns1.BunifuMaterialTextbox();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSearch = new ns1.BunifuTextbox();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.BtnLoadRef = new MaterialSkin.Controls.MaterialFlatButton();
            this.studentsRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnExe = new MaterialSkin.Controls.MaterialFlatButton();
            this.RdYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.MrdNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.MrdYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.databaseMBDataSet2 = new Mabato_V4.DatabaseMBDataSet2();
            this.studentsRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsRecordTableAdapter = new Mabato_V4.DatabaseMBDataSet2TableAdapters.StudentsRecordTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lRNNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indigenousDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "LRN?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Returning?";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(334, 96);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(66, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "LRN NO:";
            // 
            // txtLrnNo
            // 
            this.txtLrnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLrnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLrnNo.Depth = 0;
            this.txtLrnNo.Hint = "";
            this.txtLrnNo.Location = new System.Drawing.Point(422, 96);
            this.txtLrnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLrnNo.Name = "txtLrnNo";
            this.txtLrnNo.PasswordChar = '\0';
            this.txtLrnNo.SelectedText = "";
            this.txtLrnNo.SelectionLength = 0;
            this.txtLrnNo.SelectionStart = 0;
            this.txtLrnNo.Size = new System.Drawing.Size(155, 23);
            this.txtLrnNo.TabIndex = 9;
            this.txtLrnNo.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(334, 125);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Firstname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFirstname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFirstname.Depth = 0;
            this.txtFirstname.Hint = "";
            this.txtFirstname.Location = new System.Drawing.Point(422, 125);
            this.txtFirstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.SelectionLength = 0;
            this.txtFirstname.SelectionStart = 0;
            this.txtFirstname.Size = new System.Drawing.Size(155, 23);
            this.txtFirstname.TabIndex = 11;
            this.txtFirstname.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(334, 154);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Lastname:";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLastname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLastname.Depth = 0;
            this.txtLastname.Hint = "";
            this.txtLastname.Location = new System.Drawing.Point(422, 154);
            this.txtLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.Size = new System.Drawing.Size(155, 23);
            this.txtLastname.TabIndex = 13;
            this.txtLastname.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(334, 183);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(30, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "MI:";
            // 
            // txtMI
            // 
            this.txtMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMI.Depth = 0;
            this.txtMI.Hint = "";
            this.txtMI.Location = new System.Drawing.Point(422, 183);
            this.txtMI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMI.Name = "txtMI";
            this.txtMI.PasswordChar = '\0';
            this.txtMI.SelectedText = "";
            this.txtMI.SelectionLength = 0;
            this.txtMI.SelectionStart = 0;
            this.txtMI.Size = new System.Drawing.Size(155, 23);
            this.txtMI.TabIndex = 15;
            this.txtMI.UseSystemPasswordChar = false;
            // 
            // txtIndi
            // 
            this.txtIndi.BackColor = System.Drawing.Color.Transparent;
            this.txtIndi.BorderRadius = 3;
            this.txtIndi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIndi.ForeColor = System.Drawing.Color.Black;
            this.txtIndi.Items = new string[] {
        "Igorot ",
        "Bontoc",
        "Ibaloi",
        "Ifugao",
        "Isneg",
        "Kalinga",
        "Kankanaey",
        "Tinguian",
        " Isnag ",
        "Moro",
        "Gaddang ",
        "badjao",
        "--NO--",
        "--Others--"};
            this.txtIndi.Location = new System.Drawing.Point(150, 160);
            this.txtIndi.Name = "txtIndi";
            this.txtIndi.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIndi.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtIndi.selectedIndex = -1;
            this.txtIndi.Size = new System.Drawing.Size(178, 28);
            this.txtIndi.TabIndex = 16;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderRadius = 3;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Items = new string[] {
        "Male",
        "Famale"};
            this.txtGender.Location = new System.Drawing.Point(214, 121);
            this.txtGender.Name = "txtGender";
            this.txtGender.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGender.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtGender.selectedIndex = -1;
            this.txtGender.Size = new System.Drawing.Size(114, 30);
            this.txtGender.TabIndex = 17;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDOB.BorderRadius = 0;
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDOB.FormatCustom = null;
            this.txtDOB.Location = new System.Drawing.Point(150, 195);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(178, 34);
            this.txtDOB.TabIndex = 18;
            this.txtDOB.Value = new System.DateTime(2020, 5, 3, 11, 33, 43, 458);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 160);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(90, 19);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Indigenous :";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(268, 96);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(60, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Gender:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(14, 195);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(42, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "DOB:";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Black;
            this.txtAddress.HintText = "Complete Address";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(594, 95);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 75);
            this.txtAddress.TabIndex = 22;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtZipcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtZipcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtZipcode.HintForeColor = System.Drawing.Color.Empty;
            this.txtZipcode.HintText = "Zipcode";
            this.txtZipcode.isPassword = false;
            this.txtZipcode.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtZipcode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtZipcode.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtZipcode.LineThickness = 3;
            this.txtZipcode.Location = new System.Drawing.Point(594, 178);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(165, 36);
            this.txtZipcode.TabIndex = 24;
            this.txtZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(315, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(373, 344);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(41, 36);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(422, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Depth = 0;
            this.btnNew.Location = new System.Drawing.Point(265, 344);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.Primary = false;
            this.btnNew.Size = new System.Drawing.Size(42, 36);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(12, 338);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 42);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.text = "SEARCH ";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(766, 90);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(276, 198);
            this.bunifuGradientPanel1.TabIndex = 34;
            // 
            // BtnLoadRef
            // 
            this.BtnLoadRef.AutoSize = true;
            this.BtnLoadRef.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoadRef.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLoadRef.Depth = 0;
            this.BtnLoadRef.Location = new System.Drawing.Point(938, 344);
            this.BtnLoadRef.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoadRef.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLoadRef.Name = "BtnLoadRef";
            this.BtnLoadRef.Primary = false;
            this.BtnLoadRef.Size = new System.Drawing.Size(111, 36);
            this.BtnLoadRef.TabIndex = 35;
            this.BtnLoadRef.Text = "Load/Refresh";
            this.BtnLoadRef.UseVisualStyleBackColor = false;
            this.BtnLoadRef.Click += new System.EventHandler(this.BtnLoadRef_Click);
            // 
            // studentsRecordDataGridView
            // 
            this.studentsRecordDataGridView.AutoGenerateColumns = false;
            this.studentsRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lRNDataGridViewTextBoxColumn,
            this.lRNNoDataGridViewTextBoxColumn,
            this.returningDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.mIDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.indigenousDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn});
            this.studentsRecordDataGridView.DataSource = this.studentsRecordBindingSource;
            this.studentsRecordDataGridView.Location = new System.Drawing.Point(12, 389);
            this.studentsRecordDataGridView.Name = "studentsRecordDataGridView";
            this.studentsRecordDataGridView.Size = new System.Drawing.Size(1045, 342);
            this.studentsRecordDataGridView.TabIndex = 36;
            // 
            // BtnExe
            // 
            this.BtnExe.AutoSize = true;
            this.BtnExe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExe.Depth = 0;
            this.BtnExe.Location = new System.Drawing.Point(494, 344);
            this.BtnExe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExe.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExe.Name = "BtnExe";
            this.BtnExe.Primary = false;
            this.BtnExe.Size = new System.Drawing.Size(70, 36);
            this.BtnExe.TabIndex = 37;
            this.BtnExe.Text = "Execute";
            this.BtnExe.UseVisualStyleBackColor = true;
            this.BtnExe.Click += new System.EventHandler(this.BtnExe_Click);
            // 
            // RdYes
            // 
            this.RdYes.AutoSize = true;
            this.RdYes.Depth = 0;
            this.RdYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdYes.Location = new System.Drawing.Point(107, 91);
            this.RdYes.Margin = new System.Windows.Forms.Padding(0);
            this.RdYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdYes.Name = "RdYes";
            this.RdYes.Ripple = true;
            this.RdYes.Size = new System.Drawing.Size(52, 30);
            this.RdYes.TabIndex = 38;
            this.RdYes.TabStop = true;
            this.RdYes.Text = "Yes";
            this.RdYes.UseVisualStyleBackColor = true;
            this.RdYes.CheckedChanged += new System.EventHandler(this.RdYes_CheckedChanged);
            // 
            // RdNo
            // 
            this.RdNo.AutoSize = true;
            this.RdNo.Depth = 0;
            this.RdNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdNo.Location = new System.Drawing.Point(164, 91);
            this.RdNo.Margin = new System.Windows.Forms.Padding(0);
            this.RdNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdNo.Name = "RdNo";
            this.RdNo.Ripple = true;
            this.RdNo.Size = new System.Drawing.Size(47, 30);
            this.RdNo.TabIndex = 39;
            this.RdNo.TabStop = true;
            this.RdNo.Text = "No";
            this.RdNo.UseVisualStyleBackColor = true;
            // 
            // MrdNo
            // 
            this.MrdNo.AutoSize = true;
            this.MrdNo.Depth = 0;
            this.MrdNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.MrdNo.Location = new System.Drawing.Point(164, 121);
            this.MrdNo.Margin = new System.Windows.Forms.Padding(0);
            this.MrdNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MrdNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.MrdNo.Name = "MrdNo";
            this.MrdNo.Ripple = true;
            this.MrdNo.Size = new System.Drawing.Size(47, 30);
            this.MrdNo.TabIndex = 41;
            this.MrdNo.TabStop = true;
            this.MrdNo.Text = "No";
            this.MrdNo.UseVisualStyleBackColor = true;
            // 
            // MrdYes
            // 
            this.MrdYes.AutoSize = true;
            this.MrdYes.Depth = 0;
            this.MrdYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.MrdYes.Location = new System.Drawing.Point(107, 121);
            this.MrdYes.Margin = new System.Windows.Forms.Padding(0);
            this.MrdYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MrdYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.MrdYes.Name = "MrdYes";
            this.MrdYes.Ripple = true;
            this.MrdYes.Size = new System.Drawing.Size(52, 30);
            this.MrdYes.TabIndex = 40;
            this.MrdYes.TabStop = true;
            this.MrdYes.Text = "Yes";
            this.MrdYes.UseVisualStyleBackColor = true;
            // 
            // databaseMBDataSet2
            // 
            this.databaseMBDataSet2.DataSetName = "DatabaseMBDataSet2";
            this.databaseMBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsRecordBindingSource
            // 
            this.studentsRecordBindingSource.DataMember = "StudentsRecord";
            this.studentsRecordBindingSource.DataSource = this.databaseMBDataSet2;
            // 
            // studentsRecordTableAdapter
            // 
            this.studentsRecordTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lRNDataGridViewTextBoxColumn
            // 
            this.lRNDataGridViewTextBoxColumn.DataPropertyName = "LRN";
            this.lRNDataGridViewTextBoxColumn.HeaderText = "LRN";
            this.lRNDataGridViewTextBoxColumn.Name = "lRNDataGridViewTextBoxColumn";
            // 
            // lRNNoDataGridViewTextBoxColumn
            // 
            this.lRNNoDataGridViewTextBoxColumn.DataPropertyName = "LRN-No";
            this.lRNNoDataGridViewTextBoxColumn.HeaderText = "LRN-No";
            this.lRNNoDataGridViewTextBoxColumn.Name = "lRNNoDataGridViewTextBoxColumn";
            // 
            // returningDataGridViewTextBoxColumn
            // 
            this.returningDataGridViewTextBoxColumn.DataPropertyName = "Returning";
            this.returningDataGridViewTextBoxColumn.HeaderText = "Returning";
            this.returningDataGridViewTextBoxColumn.Name = "returningDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // mIDataGridViewTextBoxColumn
            // 
            this.mIDataGridViewTextBoxColumn.DataPropertyName = "MI";
            this.mIDataGridViewTextBoxColumn.HeaderText = "MI";
            this.mIDataGridViewTextBoxColumn.Name = "mIDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // indigenousDataGridViewTextBoxColumn
            // 
            this.indigenousDataGridViewTextBoxColumn.DataPropertyName = "Indigenous ";
            this.indigenousDataGridViewTextBoxColumn.HeaderText = "Indigenous ";
            this.indigenousDataGridViewTextBoxColumn.Name = "indigenousDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "Zipcode";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "Zipcode";
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1069, 743);
            this.Controls.Add(this.MrdNo);
            this.Controls.Add(this.MrdYes);
            this.Controls.Add(this.RdNo);
            this.Controls.Add(this.RdYes);
            this.Controls.Add(this.BtnExe);
            this.Controls.Add(this.studentsRecordDataGridView);
            this.Controls.Add(this.BtnLoadRef);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtIndi);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtLrnNo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mabato Records";
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLrnNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstname;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastname;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMI;
        private ns1.BunifuDropdown txtIndi;
        private ns1.BunifuDropdown txtGender;
        private ns1.BunifuDatepicker txtDOB;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private ns1.BunifuMaterialTextbox txtAddress;
        private ns1.BunifuMaterialTextbox txtZipcode;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnNew;
        private ns1.BunifuTextbox txtSearch;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private MaterialSkin.Controls.MaterialFlatButton BtnLoadRef;
        private System.Windows.Forms.DataGridView studentsRecordDataGridView;
        private MaterialSkin.Controls.MaterialFlatButton BtnExe;
        private MaterialSkin.Controls.MaterialRadioButton RdYes;
        private MaterialSkin.Controls.MaterialRadioButton RdNo;
        private MaterialSkin.Controls.MaterialRadioButton MrdNo;
        private MaterialSkin.Controls.MaterialRadioButton MrdYes;
        private DatabaseMBDataSet2 databaseMBDataSet2;
        private System.Windows.Forms.BindingSource studentsRecordBindingSource;
        private DatabaseMBDataSet2TableAdapters.StudentsRecordTableAdapter studentsRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lRNNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indigenousDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
    }
}