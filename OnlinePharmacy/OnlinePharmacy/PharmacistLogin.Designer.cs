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
            this.linkLabelDocLogin = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPhPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelDocLogin
            // 
            this.linkLabelDocLogin.AutoSize = true;
            this.linkLabelDocLogin.Location = new System.Drawing.Point(316, 359);
            this.linkLabelDocLogin.Name = "linkLabelDocLogin";
            this.linkLabelDocLogin.Size = new System.Drawing.Size(68, 13);
            this.linkLabelDocLogin.TabIndex = 3;
            this.linkLabelDocLogin.TabStop = true;
            this.linkLabelDocLogin.Text = "Doctor Login";
            this.linkLabelDocLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 123);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(36, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Password";
            // 
            // textBoxPhUsername
            // 
            this.textBoxPhUsername.Depth = 0;
            this.textBoxPhUsername.Hint = "";
            this.textBoxPhUsername.Location = new System.Drawing.Point(139, 123);
            this.textBoxPhUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPhUsername.Name = "textBoxPhUsername";
            this.textBoxPhUsername.PasswordChar = '\0';
            this.textBoxPhUsername.SelectedText = "";
            this.textBoxPhUsername.SelectionLength = 0;
            this.textBoxPhUsername.SelectionStart = 0;
            this.textBoxPhUsername.Size = new System.Drawing.Size(148, 23);
            this.textBoxPhUsername.TabIndex = 0;
            this.textBoxPhUsername.UseSystemPasswordChar = false;
            this.textBoxPhUsername.Click += new System.EventHandler(this.textBoxPhUsername_Click);
            // 
            // textBoxPhPassword
            // 
            this.textBoxPhPassword.Depth = 0;
            this.textBoxPhPassword.Hint = "";
            this.textBoxPhPassword.Location = new System.Drawing.Point(139, 159);
            this.textBoxPhPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPhPassword.Name = "textBoxPhPassword";
            this.textBoxPhPassword.PasswordChar = '\0';
            this.textBoxPhPassword.SelectedText = "";
            this.textBoxPhPassword.SelectionLength = 0;
            this.textBoxPhPassword.SelectionStart = 0;
            this.textBoxPhPassword.Size = new System.Drawing.Size(148, 23);
            this.textBoxPhPassword.TabIndex = 1;
            this.textBoxPhPassword.UseSystemPasswordChar = true;
            this.textBoxPhPassword.Click += new System.EventHandler(this.textBoxPhPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Location = new System.Drawing.Point(176, 203);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(139, 244);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.labelErrorMessage.TabIndex = 10;
            // 
            // PharmacistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 393);
            this.ControlBox = false;
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPhPassword);
            this.Controls.Add(this.textBoxPhUsername);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.linkLabelDocLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PharmacistLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelDocLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhPassword;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private System.Windows.Forms.Label labelErrorMessage;
    }
}