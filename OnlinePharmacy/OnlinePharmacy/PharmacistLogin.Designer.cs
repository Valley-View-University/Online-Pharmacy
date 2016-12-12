namespace OnlinePharmacy
{
    partial class PharmacistLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPhPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelDocLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(124, 140);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPhPassword
            // 
            this.textBoxPhPassword.Location = new System.Drawing.Point(113, 84);
            this.textBoxPhPassword.Name = "textBoxPhPassword";
            this.textBoxPhPassword.PasswordChar = '#';
            this.textBoxPhPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhPassword.TabIndex = 5;
            // 
            // textBoxPhUsername
            // 
            this.textBoxPhUsername.Location = new System.Drawing.Point(113, 48);
            this.textBoxPhUsername.Name = "textBoxPhUsername";
            this.textBoxPhUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // linkLabelDocLogin
            // 
            this.linkLabelDocLogin.AutoSize = true;
            this.linkLabelDocLogin.Location = new System.Drawing.Point(220, 9);
            this.linkLabelDocLogin.Name = "linkLabelDocLogin";
            this.linkLabelDocLogin.Size = new System.Drawing.Size(68, 13);
            this.linkLabelDocLogin.TabIndex = 8;
            this.linkLabelDocLogin.TabStop = true;
            this.linkLabelDocLogin.Text = "Doctor Login";
            this.linkLabelDocLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PharmacistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 334);
            this.Controls.Add(this.linkLabelDocLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPhPassword);
            this.Controls.Add(this.textBoxPhUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PharmacistLogin";
            this.Text = "PharmacistLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPhPassword;
        private System.Windows.Forms.TextBox textBoxPhUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelDocLogin;
    }
}