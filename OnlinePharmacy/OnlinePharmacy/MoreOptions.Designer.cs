namespace OnlinePharmacy
{
    partial class MoreOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreOptions));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageInstructions = new System.Windows.Forms.TabPage();
            this.tabPageLicAgre = new System.Windows.Forms.TabPage();
            this.tabPageAbUs = new System.Windows.Forms.TabPage();
            this.tabPageMoreOpt = new System.Windows.Forms.TabPage();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPageLicAgre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 69);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(818, 44);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageInstructions);
            this.materialTabControl1.Controls.Add(this.tabPageLicAgre);
            this.materialTabControl1.Controls.Add(this.tabPageAbUs);
            this.materialTabControl1.Controls.Add(this.tabPageMoreOpt);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(13, 120);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(817, 256);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPageInstructions
            // 
            this.tabPageInstructions.BackColor = System.Drawing.Color.Gray;
            this.tabPageInstructions.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstructions.Name = "tabPageInstructions";
            this.tabPageInstructions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstructions.Size = new System.Drawing.Size(809, 230);
            this.tabPageInstructions.TabIndex = 0;
            this.tabPageInstructions.Text = "Instructions";
            // 
            // tabPageLicAgre
            // 
            this.tabPageLicAgre.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLicAgre.Controls.Add(this.textBox1);
            this.tabPageLicAgre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLicAgre.Name = "tabPageLicAgre";
            this.tabPageLicAgre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicAgre.Size = new System.Drawing.Size(809, 230);
            this.tabPageLicAgre.TabIndex = 1;
            this.tabPageLicAgre.Text = "License & Agreement";
            // 
            // tabPageAbUs
            // 
            this.tabPageAbUs.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbUs.Name = "tabPageAbUs";
            this.tabPageAbUs.Size = new System.Drawing.Size(809, 230);
            this.tabPageAbUs.TabIndex = 2;
            this.tabPageAbUs.Text = "About Us";
            this.tabPageAbUs.UseVisualStyleBackColor = true;
            // 
            // tabPageMoreOpt
            // 
            this.tabPageMoreOpt.BackColor = System.Drawing.Color.Gray;
            this.tabPageMoreOpt.Location = new System.Drawing.Point(4, 22);
            this.tabPageMoreOpt.Name = "tabPageMoreOpt";
            this.tabPageMoreOpt.Size = new System.Drawing.Size(809, 230);
            this.tabPageMoreOpt.TabIndex = 3;
            this.tabPageMoreOpt.Text = "More Options";
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.linkLabelClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabelClose.Location = new System.Drawing.Point(793, 9);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabelClose.TabIndex = 12;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "Close";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(803, 224);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // MoreOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(842, 388);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelClose);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MoreOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreOptions";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageLicAgre.ResumeLayout(false);
            this.tabPageLicAgre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageInstructions;
        private System.Windows.Forms.TabPage tabPageLicAgre;
        private System.Windows.Forms.TabPage tabPageAbUs;
        private System.Windows.Forms.TabPage tabPageMoreOpt;
        private System.Windows.Forms.LinkLabel linkLabelClose;
        private System.Windows.Forms.TextBox textBox1;
    }
}