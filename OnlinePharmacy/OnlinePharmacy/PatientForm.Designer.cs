namespace OnlinePharmacy
{
    partial class PatientForm
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
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label prescriptionLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label accessIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.oNLINEPHARMACYDataSet = new OnlinePharmacy.ONLINEPHARMACYDataSet();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.PrescriptionTableAdapter();
            this.tableAdapterManager = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager();
            this.prescriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prescriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientIDComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxPrescription = new System.Windows.Forms.TextBox();
            this.linkLabelDatabase = new System.Windows.Forms.LinkLabel();
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.linkLabelAddDrug = new System.Windows.Forms.LinkLabel();
            this.accessIDTextBox = new System.Windows.Forms.TextBox();
            patientIDLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            accessIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingNavigator)).BeginInit();
            this.prescriptionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(118, 92);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 1;
            patientIDLabel.Text = "Patient ID:";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Location = new System.Drawing.Point(112, 194);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(65, 13);
            prescriptionLabel.TabIndex = 5;
            prescriptionLabel.Text = "Prescription:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(110, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 10;
            label1.Text = "Drugs:";
            // 
            // accessIDLabel1
            // 
            accessIDLabel1.AutoSize = true;
            accessIDLabel1.Location = new System.Drawing.Point(116, 126);
            accessIDLabel1.Name = "accessIDLabel1";
            accessIDLabel1.Size = new System.Drawing.Size(59, 13);
            accessIDLabel1.TabIndex = 12;
            accessIDLabel1.Text = "Access ID:";
            // 
            // oNLINEPHARMACYDataSet
            // 
            this.oNLINEPHARMACYDataSet.DataSetName = "ONLINEPHARMACYDataSet";
            this.oNLINEPHARMACYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.oNLINEPHARMACYDataSet;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorInfoTableAdapter = null;
            this.tableAdapterManager.PatientInfoTableAdapter = null;
            this.tableAdapterManager.PharmacyInfoTableAdapter = null;
            this.tableAdapterManager.PrescriptionTableAdapter = this.prescriptionTableAdapter;
            this.tableAdapterManager.UpdateOrder = OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prescriptionBindingNavigator
            // 
            this.prescriptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prescriptionBindingNavigator.BindingSource = this.prescriptionBindingSource;
            this.prescriptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prescriptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prescriptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prescriptionBindingNavigatorSaveItem});
            this.prescriptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prescriptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prescriptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prescriptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prescriptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prescriptionBindingNavigator.Name = "prescriptionBindingNavigator";
            this.prescriptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prescriptionBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.prescriptionBindingNavigator.TabIndex = 0;
            this.prescriptionBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prescriptionBindingNavigatorSaveItem
            // 
            this.prescriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prescriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionBindingNavigatorSaveItem.Image")));
            this.prescriptionBindingNavigatorSaveItem.Name = "prescriptionBindingNavigatorSaveItem";
            this.prescriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prescriptionBindingNavigatorSaveItem.Text = "Save Data";
            this.prescriptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.prescriptionBindingNavigatorSaveItem_Click_1);
            // 
            // patientIDComboBox
            // 
            this.patientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "PatientID", true));
            this.patientIDComboBox.FormattingEnabled = true;
            this.patientIDComboBox.Location = new System.Drawing.Point(189, 89);
            this.patientIDComboBox.Name = "patientIDComboBox";
            this.patientIDComboBox.Size = new System.Drawing.Size(187, 21);
            this.patientIDComboBox.TabIndex = 0;
            this.patientIDComboBox.DropDown += new System.EventHandler(this.patientIDComboBox_DropDown);
            this.patientIDComboBox.DropDownClosed += new System.EventHandler(this.patientIDComboBox_DropDownClosed);
            this.patientIDComboBox.TextChanged += new System.EventHandler(this.patientIDComboBox_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(239, 303);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxPrescription
            // 
            this.textBoxPrescription.Location = new System.Drawing.Point(187, 191);
            this.textBoxPrescription.Multiline = true;
            this.textBoxPrescription.Name = "textBoxPrescription";
            this.textBoxPrescription.Size = new System.Drawing.Size(187, 106);
            this.textBoxPrescription.TabIndex = 2;
            // 
            // linkLabelDatabase
            // 
            this.linkLabelDatabase.AutoSize = true;
            this.linkLabelDatabase.Location = new System.Drawing.Point(372, 25);
            this.linkLabelDatabase.Name = "linkLabelDatabase";
            this.linkLabelDatabase.Size = new System.Drawing.Size(79, 13);
            this.linkLabelDatabase.TabIndex = 9;
            this.linkLabelDatabase.TabStop = true;
            this.linkLabelDatabase.Text = "View Database";
            this.linkLabelDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDatabase_LinkClicked);
            // 
            // comboBoxDrugs
            // 
            this.comboBoxDrugs.FormattingEnabled = true;
            this.comboBoxDrugs.Items.AddRange(new object[] {
            "Paracetamol",
            "Drugs",
            "More Drugs",
            "Crazy Drugs",
            "Ha"});
            this.comboBoxDrugs.Location = new System.Drawing.Point(189, 154);
            this.comboBoxDrugs.Name = "comboBoxDrugs";
            this.comboBoxDrugs.Size = new System.Drawing.Size(187, 21);
            this.comboBoxDrugs.TabIndex = 2;
            this.comboBoxDrugs.DropDown += new System.EventHandler(this.patientIDComboBox_DropDown);
            // 
            // linkLabelAddDrug
            // 
            this.linkLabelAddDrug.AutoSize = true;
            this.linkLabelAddDrug.Location = new System.Drawing.Point(382, 157);
            this.linkLabelAddDrug.Name = "linkLabelAddDrug";
            this.linkLabelAddDrug.Size = new System.Drawing.Size(101, 13);
            this.linkLabelAddDrug.TabIndex = 3;
            this.linkLabelAddDrug.TabStop = true;
            this.linkLabelAddDrug.Text = "Add to Prescriptions";
            this.linkLabelAddDrug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddDrug_LinkClicked);
            // 
            // accessIDTextBox
            // 
            this.accessIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "AccessID", true));
            this.accessIDTextBox.Location = new System.Drawing.Point(189, 119);
            this.accessIDTextBox.Name = "accessIDTextBox";
            this.accessIDTextBox.Size = new System.Drawing.Size(187, 20);
            this.accessIDTextBox.TabIndex = 13;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 360);
            this.Controls.Add(accessIDLabel1);
            this.Controls.Add(this.accessIDTextBox);
            this.Controls.Add(this.linkLabelAddDrug);
            this.Controls.Add(label1);
            this.Controls.Add(this.linkLabelDatabase);
            this.Controls.Add(this.textBoxPrescription);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.comboBoxDrugs);
            this.Controls.Add(this.patientIDComboBox);
            this.Controls.Add(prescriptionLabel);
            this.Controls.Add(this.prescriptionBindingNavigator);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingNavigator)).EndInit();
            this.prescriptionBindingNavigator.ResumeLayout(false);
            this.prescriptionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ONLINEPHARMACYDataSet oNLINEPHARMACYDataSet;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private ONLINEPHARMACYDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prescriptionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prescriptionBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox patientIDComboBox;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxPrescription;
        private System.Windows.Forms.LinkLabel linkLabelDatabase;
        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.LinkLabel linkLabelAddDrug;
        private System.Windows.Forms.TextBox accessIDTextBox;
    }
}