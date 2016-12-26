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
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label prescriptionLabel;
            this.textBoxCodeVerify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.buttonVerify = new MaterialSkin.Controls.MaterialRaisedButton();
            this.linkLabelPrint = new System.Windows.Forms.LinkLabel();
            this.textBoxPrescriptions = new System.Windows.Forms.TextBox();
            patientIDLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(314, 96);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(82, 13);
            patientIDLabel.TabIndex = 4;
            patientIDLabel.Text = "INFORMATION";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Location = new System.Drawing.Point(314, 227);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(87, 13);
            prescriptionLabel.TabIndex = 6;
            prescriptionLabel.Text = "PRESCRIPTION";
            // 
            // textBoxCodeVerify
            // 
            this.textBoxCodeVerify.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodeVerify.Location = new System.Drawing.Point(235, 34);
            this.textBoxCodeVerify.Name = "textBoxCodeVerify";
            this.textBoxCodeVerify.Size = new System.Drawing.Size(238, 29);
            this.textBoxCodeVerify.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER THE ACCESS CODE HERE:";
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxInformation.Location = new System.Drawing.Point(143, 112);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.Size = new System.Drawing.Size(438, 112);
            this.textBoxInformation.TabIndex = 1;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Depth = 0;
            this.buttonVerify.Location = new System.Drawing.Point(320, 69);
            this.buttonVerify.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Primary = true;
            this.buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.buttonVerify.TabIndex = 1;
            this.buttonVerify.Text = "verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click_1);
            // 
            // linkLabelPrint
            // 
            this.linkLabelPrint.AutoSize = true;
            this.linkLabelPrint.Location = new System.Drawing.Point(314, 358);
            this.linkLabelPrint.Name = "linkLabelPrint";
            this.linkLabelPrint.Size = new System.Drawing.Size(82, 13);
            this.linkLabelPrint.TabIndex = 2;
            this.linkLabelPrint.TabStop = true;
            this.linkLabelPrint.Text = "Print information";
            // 
            // textBoxPrescriptions
            // 
            this.textBoxPrescriptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxPrescriptions.Location = new System.Drawing.Point(143, 243);
            this.textBoxPrescriptions.Multiline = true;
            this.textBoxPrescriptions.Name = "textBoxPrescriptions";
            this.textBoxPrescriptions.ReadOnly = true;
            this.textBoxPrescriptions.Size = new System.Drawing.Size(438, 112);
            this.textBoxPrescriptions.TabIndex = 1;
            // 
            // PharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.linkLabelPrint);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(prescriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrescriptions);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.textBoxCodeVerify);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PharmacistForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistForm";
            this.Load += new System.EventHandler(this.PharmacistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodeVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInformation;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVerify;
        private System.Windows.Forms.LinkLabel linkLabelPrint;
        private System.Windows.Forms.TextBox textBoxPrescriptions;
    }
}