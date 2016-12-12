namespace OnlinePharmacy
{
    partial class PharmacistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistForm));
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label prescriptionLabel;
            this.textBoxCodeVerify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.oNLINEPHARMACYDataSet = new OnlinePharmacy.ONLINEPHARMACYDataSet();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.PrescriptionTableAdapter();
            this.tableAdapterManager = new OnlinePharmacy.ONLINEPHARMACYDataSetTableAdapters.TableAdapterManager();
            this.prescriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prescriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBoxPrescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            patientIDLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingNavigator)).BeginInit();
            this.prescriptionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCodeVerify
            // 
            this.textBoxCodeVerify.Location = new System.Drawing.Point(183, 33);
            this.textBoxCodeVerify.Name = "textBoxCodeVerify";
            this.textBoxCodeVerify.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeVerify.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODE:";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(198, 59);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.buttonVerify.TabIndex = 0;
            this.buttonVerify.Text = "VERIFY";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
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
            this.prescriptionBindingNavigator.Size = new System.Drawing.Size(438, 25);
            this.prescriptionBindingNavigator.TabIndex = 3;
            this.prescriptionBindingNavigator.Text = "bindingNavigator1";
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
            // prescriptionBindingNavigatorSaveItem
            // 
            this.prescriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prescriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionBindingNavigatorSaveItem.Image")));
            this.prescriptionBindingNavigatorSaveItem.Name = "prescriptionBindingNavigatorSaveItem";
            this.prescriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prescriptionBindingNavigatorSaveItem.Text = "Save Data";
            this.prescriptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.prescriptionBindingNavigatorSaveItem_Click);
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(83, 100);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 4;
            patientIDLabel.Text = "Patient ID:";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Location = new System.Drawing.Point(83, 126);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(65, 13);
            prescriptionLabel.TabIndex = 6;
            prescriptionLabel.Text = "Prescription:";
            // 
            // textBoxPrescription
            // 
            this.textBoxPrescription.Location = new System.Drawing.Point(173, 126);
            this.textBoxPrescription.Multiline = true;
            this.textBoxPrescription.Name = "textBoxPrescription";
            this.textBoxPrescription.ReadOnly = true;
            this.textBoxPrescription.Size = new System.Drawing.Size(173, 109);
            this.textBoxPrescription.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            // 
            // PharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 370);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(prescriptionLabel);
            this.Controls.Add(this.prescriptionBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCodeVerify);
            this.Controls.Add(this.buttonVerify);
            this.Name = "PharmacistForm";
            this.Text = "PharmacistForm";
            this.Load += new System.EventHandler(this.PharmacistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oNLINEPHARMACYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingNavigator)).EndInit();
            this.prescriptionBindingNavigator.ResumeLayout(false);
            this.prescriptionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodeVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVerify;
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
        private System.Windows.Forms.TextBox textBoxPrescription;
        private System.Windows.Forms.TextBox textBox1;
    }
}