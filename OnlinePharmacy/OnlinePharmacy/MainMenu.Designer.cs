namespace OnlinePharmacy
{
    partial class MainMenu
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
            this.materialRadioButtonDoctor = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButtonPharmacist = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButtonClerk = new MaterialSkin.Controls.MaterialRadioButton();
            this.GotoLoginbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRadioButtonDoctor
            // 
            this.materialRadioButtonDoctor.AutoSize = true;
            this.materialRadioButtonDoctor.Depth = 0;
            this.materialRadioButtonDoctor.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButtonDoctor.Location = new System.Drawing.Point(124, 9);
            this.materialRadioButtonDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonDoctor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonDoctor.Name = "materialRadioButtonDoctor";
            this.materialRadioButtonDoctor.Ripple = true;
            this.materialRadioButtonDoctor.Size = new System.Drawing.Size(94, 30);
            this.materialRadioButtonDoctor.TabIndex = 0;
            this.materialRadioButtonDoctor.TabStop = true;
            this.materialRadioButtonDoctor.Text = "For Doctor";
            this.materialRadioButtonDoctor.UseVisualStyleBackColor = true;
            // 
            // materialRadioButtonPharmacist
            // 
            this.materialRadioButtonPharmacist.AutoSize = true;
            this.materialRadioButtonPharmacist.Depth = 0;
            this.materialRadioButtonPharmacist.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButtonPharmacist.Location = new System.Drawing.Point(124, 50);
            this.materialRadioButtonPharmacist.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonPharmacist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonPharmacist.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonPharmacist.Name = "materialRadioButtonPharmacist";
            this.materialRadioButtonPharmacist.Ripple = true;
            this.materialRadioButtonPharmacist.Size = new System.Drawing.Size(123, 30);
            this.materialRadioButtonPharmacist.TabIndex = 0;
            this.materialRadioButtonPharmacist.TabStop = true;
            this.materialRadioButtonPharmacist.Text = "For Pharmacist";
            this.materialRadioButtonPharmacist.UseVisualStyleBackColor = true;
            // 
            // materialRadioButtonClerk
            // 
            this.materialRadioButtonClerk.AutoSize = true;
            this.materialRadioButtonClerk.Depth = 0;
            this.materialRadioButtonClerk.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButtonClerk.Location = new System.Drawing.Point(124, 89);
            this.materialRadioButtonClerk.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonClerk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonClerk.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonClerk.Name = "materialRadioButtonClerk";
            this.materialRadioButtonClerk.Ripple = true;
            this.materialRadioButtonClerk.Size = new System.Drawing.Size(84, 30);
            this.materialRadioButtonClerk.TabIndex = 0;
            this.materialRadioButtonClerk.TabStop = true;
            this.materialRadioButtonClerk.Text = "For Clerk";
            this.materialRadioButtonClerk.UseVisualStyleBackColor = true;
            // 
            // GotoLoginbutton
            // 
            this.GotoLoginbutton.Depth = 0;
            this.GotoLoginbutton.Location = new System.Drawing.Point(82, 137);
            this.GotoLoginbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GotoLoginbutton.Name = "GotoLoginbutton";
            this.GotoLoginbutton.Primary = true;
            this.GotoLoginbutton.Size = new System.Drawing.Size(204, 23);
            this.GotoLoginbutton.TabIndex = 1;
            this.GotoLoginbutton.Text = "go to login";
            this.GotoLoginbutton.UseVisualStyleBackColor = true;
            this.GotoLoginbutton.Click += new System.EventHandler(this.GotoLoginbutton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(371, 185);
            this.ControlBox = false;
            this.Controls.Add(this.GotoLoginbutton);
            this.Controls.Add(this.materialRadioButtonClerk);
            this.Controls.Add(this.materialRadioButtonPharmacist);
            this.Controls.Add(this.materialRadioButtonDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonDoctor;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonPharmacist;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonClerk;
        private MaterialSkin.Controls.MaterialRaisedButton GotoLoginbutton;
    }
}