using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePharmacy
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void GotoLoginbutton_Click(object sender, EventArgs e)
        {
            Hide();
            if (materialRadioButtonDoctor.Checked)
            {
                DoctorLogin doclog = new DoctorLogin();
                doclog.ShowDialog();
            }
            if (materialRadioButtonPharmacist.Checked)
            {
                PharmacistLogin pharmlog = new PharmacistLogin();
                pharmlog.ShowDialog();
            }
            if (materialRadioButtonClerk.Checked)
            {
                ClerkForm clkfrm = new ClerkForm();
                clkfrm.ShowDialog();
            }
            Close();
        }
    }
}
