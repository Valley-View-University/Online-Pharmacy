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
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxPrescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            patientIDLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCodeVerify);
            this.Controls.Add(this.buttonVerify);
            this.Name = "PharmacistForm";
            this.Text = "PharmacistForm";
            this.Load += new System.EventHandler(this.PharmacistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodeVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textBoxPrescription;
        private System.Windows.Forms.TextBox textBox1;
    }
}