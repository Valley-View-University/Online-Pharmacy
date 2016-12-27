namespace OnlinePharmacy
{
    partial class DoctorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDocUsername = new System.Windows.Forms.TextBox();
            this.textBoxDocPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelMoreInfoOptions = new System.Windows.Forms.LinkLabel();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxDocUsername
            // 
            this.textBoxDocUsername.Location = new System.Drawing.Point(134, 119);
            this.textBoxDocUsername.Name = "textBoxDocUsername";
            this.textBoxDocUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocUsername.TabIndex = 0;
            this.textBoxDocUsername.TextChanged += new System.EventHandler(this.textBoxDocUsername_TextChanged);
            // 
            // textBoxDocPassword
            // 
            this.textBoxDocPassword.Location = new System.Drawing.Point(134, 155);
            this.textBoxDocPassword.Name = "textBoxDocPassword";
            this.textBoxDocPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocPassword.TabIndex = 1;
            this.textBoxDocPassword.UseSystemPasswordChar = true;
            this.textBoxDocPassword.TextChanged += new System.EventHandler(this.textBoxDocPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(145, 211);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelMoreInfoOptions
            // 
            this.linkLabelMoreInfoOptions.AutoSize = true;
            this.linkLabelMoreInfoOptions.Location = new System.Drawing.Point(12, 372);
            this.linkLabelMoreInfoOptions.Name = "linkLabelMoreInfoOptions";
            this.linkLabelMoreInfoOptions.Size = new System.Drawing.Size(145, 13);
            this.linkLabelMoreInfoOptions.TabIndex = 3;
            this.linkLabelMoreInfoOptions.TabStop = true;
            this.linkLabelMoreInfoOptions.Text = "More information and Options";
            this.linkLabelMoreInfoOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMoreInfoOptions_LinkClicked);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(131, 180);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.labelErrorMessage.TabIndex = 4;
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.linkLabelClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabelClose.Location = new System.Drawing.Point(308, 9);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabelClose.TabIndex = 12;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "Close";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 394);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelClose);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.linkLabelMoreInfoOptions);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxDocPassword);
            this.Controls.Add(this.textBoxDocUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorLogin";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDocUsername;
        private System.Windows.Forms.TextBox textBoxDocPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelMoreInfoOptions;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.LinkLabel linkLabelClose;
    }
}

