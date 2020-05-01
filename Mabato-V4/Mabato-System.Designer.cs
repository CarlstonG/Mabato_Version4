namespace Mabato_V4
{
    partial class MabatoV4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MabatoV4));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pSA_Birth_No_Label;
            System.Windows.Forms.Label lRNLabel;
            System.Windows.Forms.Label lRN_NoLabel;
            System.Windows.Forms.Label returningLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label indigenous_Label;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label zipcodeLabel;
            this.databaseMBDataSet2 = new Mabato_V4.DatabaseMBDataSet2();
            this.studentsRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsRecordTableAdapter = new Mabato_V4.DatabaseMBDataSet2TableAdapters.StudentsRecordTableAdapter();
            this.tableAdapterManager = new Mabato_V4.DatabaseMBDataSet2TableAdapters.TableAdapterManager();
            this.studentsRecordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentsRecordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentsRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pSA_Birth_No_TextBox = new System.Windows.Forms.TextBox();
            this.lRNComboBox = new System.Windows.Forms.ComboBox();
            this.lRN_NoTextBox = new System.Windows.Forms.TextBox();
            this.returningComboBox = new System.Windows.Forms.ComboBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.indigenous_ComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            pSA_Birth_No_Label = new System.Windows.Forms.Label();
            lRNLabel = new System.Windows.Forms.Label();
            lRN_NoLabel = new System.Windows.Forms.Label();
            returningLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            indigenous_Label = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingNavigator)).BeginInit();
            this.studentsRecordBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsRecordTableAdapter = this.studentsRecordTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mabato_V4.DatabaseMBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsRecordBindingNavigator
            // 
            this.studentsRecordBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsRecordBindingNavigator.BindingSource = this.studentsRecordBindingSource;
            this.studentsRecordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsRecordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsRecordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentsRecordBindingNavigatorSaveItem});
            this.studentsRecordBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsRecordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsRecordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsRecordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsRecordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsRecordBindingNavigator.Name = "studentsRecordBindingNavigator";
            this.studentsRecordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsRecordBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.studentsRecordBindingNavigator.TabIndex = 0;
            this.studentsRecordBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentsRecordBindingNavigatorSaveItem
            // 
            this.studentsRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsRecordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsRecordBindingNavigatorSaveItem.Image")));
            this.studentsRecordBindingNavigatorSaveItem.Name = "studentsRecordBindingNavigatorSaveItem";
            this.studentsRecordBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsRecordBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsRecordBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsRecordBindingNavigatorSaveItem_Click);
            // 
            // studentsRecordDataGridView
            // 
            this.studentsRecordDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsRecordDataGridView.AutoGenerateColumns = false;
            this.studentsRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.studentsRecordDataGridView.DataSource = this.studentsRecordBindingSource;
            this.studentsRecordDataGridView.Location = new System.Drawing.Point(0, 247);
            this.studentsRecordDataGridView.Name = "studentsRecordDataGridView";
            this.studentsRecordDataGridView.Size = new System.Drawing.Size(884, 412);
            this.studentsRecordDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PSA-Birth-No_";
            this.dataGridViewTextBoxColumn2.HeaderText = "PSA-Birth-No_";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LRN";
            this.dataGridViewTextBoxColumn3.HeaderText = "LRN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LRN-No";
            this.dataGridViewTextBoxColumn4.HeaderText = "LRN-No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Returning";
            this.dataGridViewTextBoxColumn5.HeaderText = "Returning";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn8.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn10.HeaderText = "Age";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Indigenous ";
            this.dataGridViewTextBoxColumn11.HeaderText = "Indigenous ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Zipcode";
            this.dataGridViewTextBoxColumn13.HeaderText = "Zipcode";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(9, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 16);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(131, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(199, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // pSA_Birth_No_Label
            // 
            pSA_Birth_No_Label.AutoSize = true;
            pSA_Birth_No_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pSA_Birth_No_Label.Location = new System.Drawing.Point(9, 63);
            pSA_Birth_No_Label.Name = "pSA_Birth_No_Label";
            pSA_Birth_No_Label.Size = new System.Drawing.Size(116, 16);
            pSA_Birth_No_Label.TabIndex = 4;
            pSA_Birth_No_Label.Text = "PSA-Birth-No :";
            // 
            // pSA_Birth_No_TextBox
            // 
            this.pSA_Birth_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "PSA-Birth-No_", true));
            this.pSA_Birth_No_TextBox.Location = new System.Drawing.Point(131, 59);
            this.pSA_Birth_No_TextBox.Name = "pSA_Birth_No_TextBox";
            this.pSA_Birth_No_TextBox.Size = new System.Drawing.Size(199, 20);
            this.pSA_Birth_No_TextBox.TabIndex = 5;
            // 
            // lRNLabel
            // 
            lRNLabel.AutoSize = true;
            lRNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lRNLabel.Location = new System.Drawing.Point(9, 93);
            lRNLabel.Name = "lRNLabel";
            lRNLabel.Size = new System.Drawing.Size(46, 16);
            lRNLabel.TabIndex = 6;
            lRNLabel.Text = "LRN:";
            // 
            // lRNComboBox
            // 
            this.lRNComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "LRN", true));
            this.lRNComboBox.FormattingEnabled = true;
            this.lRNComboBox.Location = new System.Drawing.Point(131, 86);
            this.lRNComboBox.Name = "lRNComboBox";
            this.lRNComboBox.Size = new System.Drawing.Size(168, 21);
            this.lRNComboBox.TabIndex = 7;
            // 
            // lRN_NoLabel
            // 
            lRN_NoLabel.AutoSize = true;
            lRN_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lRN_NoLabel.Location = new System.Drawing.Point(9, 120);
            lRN_NoLabel.Name = "lRN_NoLabel";
            lRN_NoLabel.Size = new System.Drawing.Size(73, 16);
            lRN_NoLabel.TabIndex = 8;
            lRN_NoLabel.Text = "LRN-No:";
            // 
            // lRN_NoTextBox
            // 
            this.lRN_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "LRN-No", true));
            this.lRN_NoTextBox.Location = new System.Drawing.Point(131, 112);
            this.lRN_NoTextBox.Name = "lRN_NoTextBox";
            this.lRN_NoTextBox.Size = new System.Drawing.Size(199, 20);
            this.lRN_NoTextBox.TabIndex = 9;
            // 
            // returningLabel
            // 
            returningLabel.AutoSize = true;
            returningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            returningLabel.Location = new System.Drawing.Point(9, 146);
            returningLabel.Name = "returningLabel";
            returningLabel.Size = new System.Drawing.Size(80, 16);
            returningLabel.TabIndex = 10;
            returningLabel.Text = "Returning:";
            // 
            // returningComboBox
            // 
            this.returningComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Returning", true));
            this.returningComboBox.FormattingEnabled = true;
            this.returningComboBox.Location = new System.Drawing.Point(131, 138);
            this.returningComboBox.Name = "returningComboBox";
            this.returningComboBox.Size = new System.Drawing.Size(168, 21);
            this.returningComboBox.TabIndex = 11;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstnameLabel.Location = new System.Drawing.Point(9, 173);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(82, 16);
            firstnameLabel.TabIndex = 12;
            firstnameLabel.Text = "Firstname:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(131, 165);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(199, 20);
            this.firstnameTextBox.TabIndex = 13;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastnameLabel.Location = new System.Drawing.Point(10, 195);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(81, 16);
            lastnameLabel.TabIndex = 14;
            lastnameLabel.Text = "Lastname:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(131, 191);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(199, 20);
            this.lastnameTextBox.TabIndex = 15;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(395, 35);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(48, 16);
            dOBLabel.TabIndex = 16;
            dOBLabel.Text = "DOB:";
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsRecordBindingSource, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(449, 36);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(157, 20);
            this.dOBDateTimePicker.TabIndex = 17;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(378, 68);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(65, 16);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(449, 67);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(157, 21);
            this.genderComboBox.TabIndex = 19;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(401, 97);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(42, 16);
            ageLabel.TabIndex = 20;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(449, 93);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(157, 20);
            this.ageTextBox.TabIndex = 21;
            // 
            // indigenous_Label
            // 
            indigenous_Label.AutoSize = true;
            indigenous_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            indigenous_Label.Location = new System.Drawing.Point(348, 121);
            indigenous_Label.Name = "indigenous_Label";
            indigenous_Label.Size = new System.Drawing.Size(95, 16);
            indigenous_Label.TabIndex = 22;
            indigenous_Label.Text = "Indigenous :";
            // 
            // indigenous_ComboBox
            // 
            this.indigenous_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Indigenous ", true));
            this.indigenous_ComboBox.FormattingEnabled = true;
            this.indigenous_ComboBox.Location = new System.Drawing.Point(449, 116);
            this.indigenous_ComboBox.Name = "indigenous_ComboBox";
            this.indigenous_ComboBox.Size = new System.Drawing.Size(157, 21);
            this.indigenous_ComboBox.TabIndex = 23;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(371, 156);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 16);
            addressLabel.TabIndex = 24;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(449, 143);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(157, 43);
            this.addressTextBox.TabIndex = 25;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipcodeLabel.Location = new System.Drawing.Point(372, 193);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(71, 16);
            zipcodeLabel.TabIndex = 26;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsRecordBindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(449, 192);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(157, 20);
            this.zipcodeTextBox.TabIndex = 27;
            // 
            // MabatoV4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(pSA_Birth_No_Label);
            this.Controls.Add(this.pSA_Birth_No_TextBox);
            this.Controls.Add(lRNLabel);
            this.Controls.Add(this.lRNComboBox);
            this.Controls.Add(lRN_NoLabel);
            this.Controls.Add(this.lRN_NoTextBox);
            this.Controls.Add(returningLabel);
            this.Controls.Add(this.returningComboBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(indigenous_Label);
            this.Controls.Add(this.indigenous_ComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.studentsRecordDataGridView);
            this.Controls.Add(this.studentsRecordBindingNavigator);
            this.Name = "MabatoV4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mabato System";
            this.Load += new System.EventHandler(this.MabatoV4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseMBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordBindingNavigator)).EndInit();
            this.studentsRecordBindingNavigator.ResumeLayout(false);
            this.studentsRecordBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseMBDataSet2 databaseMBDataSet2;
        private System.Windows.Forms.BindingSource studentsRecordBindingSource;
        private DatabaseMBDataSet2TableAdapters.StudentsRecordTableAdapter studentsRecordTableAdapter;
        private DatabaseMBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsRecordBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentsRecordBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentsRecordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pSA_Birth_No_TextBox;
        private System.Windows.Forms.ComboBox lRNComboBox;
        private System.Windows.Forms.TextBox lRN_NoTextBox;
        private System.Windows.Forms.ComboBox returningComboBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox indigenous_ComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
    }
}