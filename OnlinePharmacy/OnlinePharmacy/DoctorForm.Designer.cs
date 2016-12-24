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
            this.linkLabelDatabase = new System.Windows.Forms.LinkLabel();
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.linkLabelAddDrug = new System.Windows.Forms.LinkLabel();
            this.accessIDTextBox = new System.Windows.Forms.TextBox();
            this.linkLabelGenerateCode = new System.Windows.Forms.LinkLabel();
            this.textBoxPatientInfo = new System.Windows.Forms.TextBox();
            this.chkbxMorning = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkbxAfternoon = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkbxEvening = new MaterialSkin.Controls.MaterialCheckBox();
            this.radbtnBeforeMeals = new MaterialSkin.Controls.MaterialRadioButton();
            this.radbtnAfterMeals = new MaterialSkin.Controls.MaterialRadioButton();
            this.listBoxPrescriptions = new System.Windows.Forms.ListBox();
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
            prescriptionLabel.Location = new System.Drawing.Point(102, 298);
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
            this.buttonSubmit.Location = new System.Drawing.Point(303, 438);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(413, 39);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            this.linkLabelAddDrug.Location = new System.Drawing.Point(320, 265);
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
            // chkbxMorning
            // 
            this.chkbxMorning.AutoSize = true;
            this.chkbxMorning.Depth = 0;
            this.chkbxMorning.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkbxMorning.Location = new System.Drawing.Point(189, 182);
            this.chkbxMorning.Margin = new System.Windows.Forms.Padding(0);
            this.chkbxMorning.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbxMorning.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbxMorning.Name = "chkbxMorning";
            this.chkbxMorning.Ripple = true;
            this.chkbxMorning.Size = new System.Drawing.Size(81, 30);
            this.chkbxMorning.TabIndex = 15;
            this.chkbxMorning.Text = "Morning";
            this.chkbxMorning.UseVisualStyleBackColor = true;
            // 
            // chkbxAfternoon
            // 
            this.chkbxAfternoon.AutoSize = true;
            this.chkbxAfternoon.Depth = 0;
            this.chkbxAfternoon.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkbxAfternoon.Location = new System.Drawing.Point(314, 182);
            this.chkbxAfternoon.Margin = new System.Windows.Forms.Padding(0);
            this.chkbxAfternoon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbxAfternoon.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbxAfternoon.Name = "chkbxAfternoon";
            this.chkbxAfternoon.Ripple = true;
            this.chkbxAfternoon.Size = new System.Drawing.Size(92, 30);
            this.chkbxAfternoon.TabIndex = 15;
            this.chkbxAfternoon.Text = "Afternoon";
            this.chkbxAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkbxEvening
            // 
            this.chkbxEvening.AutoSize = true;
            this.chkbxEvening.Depth = 0;
            this.chkbxEvening.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkbxEvening.Location = new System.Drawing.Point(430, 182);
            this.chkbxEvening.Margin = new System.Windows.Forms.Padding(0);
            this.chkbxEvening.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbxEvening.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbxEvening.Name = "chkbxEvening";
            this.chkbxEvening.Ripple = true;
            this.chkbxEvening.Size = new System.Drawing.Size(78, 30);
            this.chkbxEvening.TabIndex = 15;
            this.chkbxEvening.Text = "Evening";
            this.chkbxEvening.UseVisualStyleBackColor = true;
            // 
            // radbtnBeforeMeals
            // 
            this.radbtnBeforeMeals.AutoSize = true;
            this.radbtnBeforeMeals.Depth = 0;
            this.radbtnBeforeMeals.Font = new System.Drawing.Font("Roboto", 10F);
            this.radbtnBeforeMeals.Location = new System.Drawing.Point(189, 212);
            this.radbtnBeforeMeals.Margin = new System.Windows.Forms.Padding(0);
            this.radbtnBeforeMeals.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radbtnBeforeMeals.MouseState = MaterialSkin.MouseState.HOVER;
            this.radbtnBeforeMeals.Name = "radbtnBeforeMeals";
            this.radbtnBeforeMeals.Ripple = true;
            this.radbtnBeforeMeals.Size = new System.Drawing.Size(111, 30);
            this.radbtnBeforeMeals.TabIndex = 16;
            this.radbtnBeforeMeals.TabStop = true;
            this.radbtnBeforeMeals.Text = "Before Meals";
            this.radbtnBeforeMeals.UseVisualStyleBackColor = true;
            // 
            // radbtnAfterMeals
            // 
            this.radbtnAfterMeals.AutoSize = true;
            this.radbtnAfterMeals.Depth = 0;
            this.radbtnAfterMeals.Font = new System.Drawing.Font("Roboto", 10F);
            this.radbtnAfterMeals.Location = new System.Drawing.Point(407, 212);
            this.radbtnAfterMeals.Margin = new System.Windows.Forms.Padding(0);
            this.radbtnAfterMeals.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radbtnAfterMeals.MouseState = MaterialSkin.MouseState.HOVER;
            this.radbtnAfterMeals.Name = "radbtnAfterMeals";
            this.radbtnAfterMeals.Ripple = true;
            this.radbtnAfterMeals.Size = new System.Drawing.Size(101, 30);
            this.radbtnAfterMeals.TabIndex = 16;
            this.radbtnAfterMeals.TabStop = true;
            this.radbtnAfterMeals.Text = "After Meals";
            this.radbtnAfterMeals.UseVisualStyleBackColor = true;
            // 
            // listBoxPrescriptions
            // 
            this.listBoxPrescriptions.FormattingEnabled = true;
            this.listBoxPrescriptions.Location = new System.Drawing.Point(180, 298);
            this.listBoxPrescriptions.Name = "listBoxPrescriptions";
            this.listBoxPrescriptions.Size = new System.Drawing.Size(618, 95);
            this.listBoxPrescriptions.TabIndex = 17;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.listBoxPrescriptions);
            this.Controls.Add(this.radbtnAfterMeals);
            this.Controls.Add(this.radbtnBeforeMeals);
            this.Controls.Add(this.chkbxEvening);
            this.Controls.Add(this.chkbxAfternoon);
            this.Controls.Add(this.chkbxMorning);
            this.Controls.Add(this.linkLabelGenerateCode);
            this.Controls.Add(accessIDLabel1);
            this.Controls.Add(this.accessIDTextBox);
            this.Controls.Add(this.linkLabelAddDrug);
            this.Controls.Add(label1);
            this.Controls.Add(this.linkLabelDatabase);
            this.Controls.Add(this.textBoxPatientInfo);
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
        private System.Windows.Forms.LinkLabel linkLabelDatabase;
        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.LinkLabel linkLabelAddDrug;
        private System.Windows.Forms.TextBox accessIDTextBox;
        private System.Windows.Forms.LinkLabel linkLabelGenerateCode;
        private System.Windows.Forms.TextBox textBoxPatientInfo;
        private MaterialSkin.Controls.MaterialCheckBox chkbxMorning;
        private MaterialSkin.Controls.MaterialCheckBox chkbxAfternoon;
        private MaterialSkin.Controls.MaterialCheckBox chkbxEvening;
        private MaterialSkin.Controls.MaterialRadioButton radbtnBeforeMeals;
        private MaterialSkin.Controls.MaterialRadioButton radbtnAfterMeals;
        private System.Windows.Forms.ListBox listBoxPrescriptions;
    }
}