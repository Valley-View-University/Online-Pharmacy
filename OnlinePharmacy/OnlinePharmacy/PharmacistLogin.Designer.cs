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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPhPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.linkLabelMoreInfoOptions = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            // linkLabelClose
            // 
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.linkLabelClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabelClose.Location = new System.Drawing.Point(363, 9);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabelClose.TabIndex = 11;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "Close";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // linkLabelMoreInfoOptions
            // 
            this.linkLabelMoreInfoOptions.AutoSize = true;
            this.linkLabelMoreInfoOptions.Location = new System.Drawing.Point(251, 371);
            this.linkLabelMoreInfoOptions.Name = "linkLabelMoreInfoOptions";
            this.linkLabelMoreInfoOptions.Size = new System.Drawing.Size(145, 13);
            this.linkLabelMoreInfoOptions.TabIndex = 12;
            this.linkLabelMoreInfoOptions.TabStop = true;
            this.linkLabelMoreInfoOptions.Text = "More information and Options";
            this.linkLabelMoreInfoOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMoreInfoOptions_LinkClicked);
            // 
            // PharmacistLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabelClose;
            this.ClientSize = new System.Drawing.Size(408, 393);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelMoreInfoOptions);
            this.Controls.Add(this.linkLabelClose);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPhPassword);
            this.Controls.Add(this.textBoxPhUsername);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PharmacistLogin";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhPassword;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.LinkLabel linkLabelClose;
        private System.Windows.Forms.LinkLabel linkLabelMoreInfoOptions;
    }
}