namespace OnlinePharmacy
{
    partial class DoctorForm
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
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label prescriptionLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label accessIDLabel1;
            this.patientIDComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxPrescription = new System.Windows.Forms.TextBox();
            this.linkLabelDatabase = new System.Windows.Forms.LinkLabel();
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.linkLabelAddDrug = new System.Windows.Forms.LinkLabel();
            this.accessIDTextBox = new System.Windows.Forms.TextBox();
            this.linkLabelGenerateCode = new System.Windows.Forms.LinkLabel();
            this.textBoxPatientInfo = new System.Windows.Forms.TextBox();
            patientIDLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            accessIDLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(118, 92);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 1;
            patientIDLabel.Text = "Patient ID:";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Location = new System.Drawing.Point(112, 194);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(65, 13);
            prescriptionLabel.TabIndex = 5;
            prescriptionLabel.Text = "Prescription:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(137, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 10;
            label1.Text = "Drugs:";
            // 
            // accessIDLabel1
            // 
            accessIDLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            accessIDLabel1.AutoSize = true;
            accessIDLabel1.Location = new System.Drawing.Point(102, 128);
            accessIDLabel1.Name = "accessIDLabel1";
            accessIDLabel1.Size = new System.Drawing.Size(73, 13);
            accessIDLabel1.TabIndex = 12;
            accessIDLabel1.Text = "Access Code:";
            // 
            // patientIDComboBox
            // 
            this.patientIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIDComboBox.FormattingEnabled = true;
            this.patientIDComboBox.Location = new System.Drawing.Point(189, 89);
            this.patientIDComboBox.Name = "patientIDComboBox";
            this.patientIDComboBox.Size = new System.Drawing.Size(319, 21);
            this.patientIDComboBox.TabIndex = 0;
            this.patientIDComboBox.DropDown += new System.EventHandler(this.patientIDComboBox_DropDown);
            this.patientIDComboBox.DropDownClosed += new System.EventHandler(this.patientIDComboBox_DropDownClosed);
            this.patientIDComboBox.TextChanged += new System.EventHandler(this.patientIDComboBox_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(239, 303);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(413, 39);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxPrescription
            // 
            this.textBoxPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrescription.Location = new System.Drawing.Point(187, 191);
            this.textBoxPrescription.Multiline = true;
            this.textBoxPrescription.Name = "textBoxPrescription";
            this.textBoxPrescription.Size = new System.Drawing.Size(319, 106);
            this.textBoxPrescription.TabIndex = 2;
            // 
            // linkLabelDatabase
            // 
            this.linkLabelDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelDatabase.AutoSize = true;
            this.linkLabelDatabase.Location = new System.Drawing.Point(513, 64);
            this.linkLabelDatabase.Name = "linkLabelDatabase";
            this.linkLabelDatabase.Size = new System.Drawing.Size(79, 13);
            this.linkLabelDatabase.TabIndex = 9;
            this.linkLabelDatabase.TabStop = true;
            this.linkLabelDatabase.Text = "View Database";
            this.linkLabelDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDatabase_LinkClicked);
            // 
            // comboBoxDrugs
            // 
            this.comboBoxDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDrugs.FormattingEnabled = true;
            this.comboBoxDrugs.Items.AddRange(new object[] {
            "Paracetamol",
            "Drugs",
            "More Drugs",
            "Crazy Drugs",
            "Ha"});
            this.comboBoxDrugs.Location = new System.Drawing.Point(189, 154);
            this.comboBoxDrugs.Name = "comboBoxDrugs";
            this.comboBoxDrugs.Size = new System.Drawing.Size(319, 21);
            this.comboBoxDrugs.TabIndex = 2;
            this.comboBoxDrugs.DropDown += new System.EventHandler(this.patientIDComboBox_DropDown);
            // 
            // linkLabelAddDrug
            // 
            this.linkLabelAddDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddDrug.AutoSize = true;
            this.linkLabelAddDrug.Location = new System.Drawing.Point(513, 154);
            this.linkLabelAddDrug.Name = "linkLabelAddDrug";
            this.linkLabelAddDrug.Size = new System.Drawing.Size(101, 13);
            this.linkLabelAddDrug.TabIndex = 3;
            this.linkLabelAddDrug.TabStop = true;
            this.linkLabelAddDrug.Text = "Add to Prescriptions";
            this.linkLabelAddDrug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddDrug_LinkClicked);
            // 
            // accessIDTextBox
            // 
            this.accessIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessIDTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accessIDTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessIDTextBox.Location = new System.Drawing.Point(189, 119);
            this.accessIDTextBox.Name = "accessIDTextBox";
            this.accessIDTextBox.ReadOnly = true;
            this.accessIDTextBox.Size = new System.Drawing.Size(319, 29);
            this.accessIDTextBox.TabIndex = 13;
            this.accessIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabelGenerateCode
            // 
            this.linkLabelGenerateCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGenerateCode.AutoSize = true;
            this.linkLabelGenerateCode.Location = new System.Drawing.Point(513, 125);
            this.linkLabelGenerateCode.Name = "linkLabelGenerateCode";
            this.linkLabelGenerateCode.Size = new System.Drawing.Size(79, 13);
            this.linkLabelGenerateCode.TabIndex = 14;
            this.linkLabelGenerateCode.TabStop = true;
            this.linkLabelGenerateCode.Text = "Generate Code";
            this.linkLabelGenerateCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGenerateCode_LinkClicked);
            // 
            // textBoxPatientInfo
            // 
            this.textBoxPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatientInfo.Location = new System.Drawing.Point(620, 79);
            this.textBoxPatientInfo.Multiline = true;
            this.textBoxPatientInfo.Name = "textBoxPatientInfo";
            this.textBoxPatientInfo.ReadOnly = true;
            this.textBoxPatientInfo.Size = new System.Drawing.Size(212, 199);
            this.textBoxPatientInfo.TabIndex = 2;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.linkLabelGenerateCode);
            this.Controls.Add(accessIDLabel1);
            this.Controls.Add(this.accessIDTextBox);
            this.Controls.Add(this.linkLabelAddDrug);
            this.Controls.Add(label1);
            this.Controls.Add(this.linkLabelDatabase);
            this.Controls.Add(this.textBoxPatientInfo);
            this.Controls.Add(this.textBoxPrescription);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.comboBoxDrugs);
            this.Controls.Add(this.patientIDComboBox);
            this.Controls.Add(prescriptionLabel);
            this.MaximizeBox = false;
            this.Name = "DoctorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox patientIDComboBox;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxPrescription;
        private System.Windows.Forms.LinkLabel linkLabelDatabase;
        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.LinkLabel linkLabelAddDrug;
        private System.Windows.Forms.TextBox accessIDTextBox;
        private System.Windows.Forms.LinkLabel linkLabelGenerateCode;
        private System.Windows.Forms.TextBox textBoxPatientInfo;
    }
}