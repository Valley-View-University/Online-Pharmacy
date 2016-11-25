namespace OnlinePharmacy
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDoctorInfo = new System.Windows.Forms.TabPage();
            this.tabPagePatient = new System.Windows.Forms.TabPage();
            this.tabPagePharmacyInfo = new System.Windows.Forms.TabPage();
            this.oNLINEPHARMACYDataSet = new OnlinePharmacy.ONLINEPHARMACYDataSet();
            this.doctorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorInfoTableAdapter = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.DoctorInfoTableAdapter();
            this.tableAdapterManager = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager();
            this.doctorInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctorInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctorInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientInfoTableAdapter = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.PatientInfoTableAdapter();
            this.patientInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmacy_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_InfoTableAdapter = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.Pharmacy_InfoTableAdapter();
            this.pharmacy_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageDoctorInfo.SuspendLayout();
            this.tabPagePatient.SuspendLayout();
            this.tabPagePharmacyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoBindingNavigator)).BeginInit();
            this.doctorInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDoctorInfo);
            this.tabControl1.Controls.Add(this.tabPagePatient);
            this.tabControl1.Controls.Add(this.tabPagePharmacyInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDoctorInfo
            // 
            this.tabPageDoctorInfo.Controls.Add(this.doctorInfoDataGridView);
            this.tabPageDoctorInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoctorInfo.Name = "tabPageDoctorInfo";
            this.tabPageDoctorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctorInfo.Size = new System.Drawing.Size(913, 416);
            this.tabPageDoctorInfo.TabIndex = 0;
            this.tabPageDoctorInfo.Text = "Doctor Info";
            this.tabPageDoctorInfo.UseVisualStyleBackColor = true;
            // 
            // tabPagePatient
            // 
            this.tabPagePatient.Controls.Add(this.patientInfoDataGridView);
            this.tabPagePatient.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatient.Name = "tabPagePatient";
            this.tabPagePatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatient.Size = new System.Drawing.Size(913, 441);
            this.tabPagePatient.TabIndex = 1;
            this.tabPagePatient.Text = "Patient Info";
            this.tabPagePatient.UseVisualStyleBackColor = true;
            // 
            // tabPagePharmacyInfo
            // 
            this.tabPagePharmacyInfo.Controls.Add(this.pharmacy_InfoDataGridView);
            this.tabPagePharmacyInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPagePharmacyInfo.Name = "tabPagePharmacyInfo";
            this.tabPagePharmacyInfo.Size = new System.Drawing.Size(913, 466);
            this.tabPagePharmacyInfo.TabIndex = 2;
            this.tabPagePharmacyInfo.Text = "Pharmacy Info";
            this.tabPagePharmacyInfo.UseVisualStyleBackColor = true;
            // 
            // oNLINEPHARMACYDataSet
            // 
            this.oNLINEPHARMACYDataSet.DataSetName = "ONLINEPHARMACYDataSet";
            this.oNLINEPHARMACYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorInfoBindingSource
            // 
            this.doctorInfoBindingSource.DataMember = "DoctorInfo";
            this.doctorInfoBindingSource.DataSource = this.oNLINEPHARMACYDataSet;
            // 
            // doctorInfoTableAdapter
            // 
            this.doctorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorInfoTableAdapter = this.doctorInfoTableAdapter;
            this.tableAdapterManager.PatientInfoTableAdapter = this.patientInfoTableAdapter;
            this.tableAdapterManager.Pharmacy_InfoTableAdapter = this.pharmacy_InfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorInfoBindingNavigator
            // 
            this.doctorInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorInfoBindingNavigator.BindingSource = this.doctorInfoBindingSource;
            this.doctorInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorInfoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doctorInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorInfoBindingNavigatorSaveItem});
            this.doctorInfoBindingNavigator.Location = new System.Drawing.Point(0, 467);
            this.doctorInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorInfoBindingNavigator.Name = "doctorInfoBindingNavigator";
            this.doctorInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorInfoBindingNavigator.Size = new System.Drawing.Size(921, 25);
            this.doctorInfoBindingNavigator.TabIndex = 1;
            this.doctorInfoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // doctorInfoBindingNavigatorSaveItem
            // 
            this.doctorInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorInfoBindingNavigatorSaveItem.Image")));
            this.doctorInfoBindingNavigatorSaveItem.Name = "doctorInfoBindingNavigatorSaveItem";
            this.doctorInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.doctorInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorInfoBindingNavigatorSaveItem_Click);
            // 
            // doctorInfoDataGridView
            // 
            this.doctorInfoDataGridView.AutoGenerateColumns = false;
            this.doctorInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.doctorInfoDataGridView.DataSource = this.doctorInfoBindingSource;
            this.doctorInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorInfoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.doctorInfoDataGridView.Name = "doctorInfoDataGridView";
            this.doctorInfoDataGridView.Size = new System.Drawing.Size(907, 410);
            this.doctorInfoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // patientInfoBindingSource
            // 
            this.patientInfoBindingSource.DataMember = "PatientInfo";
            this.patientInfoBindingSource.DataSource = this.oNLINEPHARMACYDataSet;
            // 
            // patientInfoTableAdapter
            // 
            this.patientInfoTableAdapter.ClearBeforeFill = true;
            // 
            // patientInfoDataGridView
            // 
            this.patientInfoDataGridView.AutoGenerateColumns = false;
            this.patientInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.patientInfoDataGridView.DataSource = this.patientInfoBindingSource;
            this.patientInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInfoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.patientInfoDataGridView.Name = "patientInfoDataGridView";
            this.patientInfoDataGridView.Size = new System.Drawing.Size(907, 435);
            this.patientInfoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn6.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Doctor Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Doctor Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Middle Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn11.HeaderText = "Age";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn12.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Hospital Name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Hospital Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Hospital Address";
            this.dataGridViewTextBoxColumn14.HeaderText = "Hospital Address";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Hospital Phone Number";
            this.dataGridViewTextBoxColumn15.HeaderText = "Hospital Phone Number";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // pharmacy_InfoBindingSource
            // 
            this.pharmacy_InfoBindingSource.DataMember = "Pharmacy Info";
            this.pharmacy_InfoBindingSource.DataSource = this.oNLINEPHARMACYDataSet;
            // 
            // pharmacy_InfoTableAdapter
            // 
            this.pharmacy_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_InfoDataGridView
            // 
            this.pharmacy_InfoDataGridView.AutoGenerateColumns = false;
            this.pharmacy_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacy_InfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.pharmacy_InfoDataGridView.DataSource = this.pharmacy_InfoBindingSource;
            this.pharmacy_InfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacy_InfoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pharmacy_InfoDataGridView.Name = "pharmacy_InfoDataGridView";
            this.pharmacy_InfoDataGridView.Size = new System.Drawing.Size(913, 466);
            this.pharmacy_InfoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PharmacyID";
            this.dataGridViewTextBoxColumn16.HeaderText = "PharmacyID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Pharmacy Name";
            this.dataGridViewTextBoxColumn17.HeaderText = "Pharmacy Name";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Pharmacy Address";
            this.dataGridViewTextBoxColumn18.HeaderText = "Pharmacy Address";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Pharmacist FullName";
            this.dataGridViewTextBoxColumn19.HeaderText = "Pharmacist FullName";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn20.HeaderText = "Username";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn21.HeaderText = "Password";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn22.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn23.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 492);
            this.Controls.Add(this.doctorInfoBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDoctorInfo.ResumeLayout(false);
            this.tabPagePatient.ResumeLayout(false);
            this.tabPagePharmacyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoBindingNavigator)).EndInit();
            this.doctorInfoBindingNavigator.ResumeLayout(false);
            this.doctorInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDoctorInfo;
        private System.Windows.Forms.TabPage tabPagePatient;
        private System.Windows.Forms.TabPage tabPagePharmacyInfo;
        private ONLINEPHARMACYDataSet oNLINEPHARMACYDataSet;
        private System.Windows.Forms.BindingSource doctorInfoBindingSource;
        private ONLINEPHARMACYDataSetTableAdapters.DoctorInfoTableAdapter doctorInfoTableAdapter;
        private ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView doctorInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ONLINEPHARMACYDataSetTableAdapters.PatientInfoTableAdapter patientInfoTableAdapter;
        private System.Windows.Forms.BindingSource patientInfoBindingSource;
        private System.Windows.Forms.DataGridView patientInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private ONLINEPHARMACYDataSetTableAdapters.Pharmacy_InfoTableAdapter pharmacy_InfoTableAdapter;
        private System.Windows.Forms.BindingSource pharmacy_InfoBindingSource;
        private System.Windows.Forms.DataGridView pharmacy_InfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}