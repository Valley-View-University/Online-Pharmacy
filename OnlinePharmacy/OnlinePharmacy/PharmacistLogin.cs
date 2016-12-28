using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace OnlinePharmacy
{
    public partial class PharmacistLogin : MaterialForm
    {
        public PharmacistLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoctorLogin dl = new DoctorLogin();
            Hide();
            dl.ShowDialog();
            Show();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PharmacyInfo WHERE Username ='" + textBoxPhUsername.Text + "'AND Password ='" + textBoxPhPassword.Text + "'", con);

            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Hide();
                    PharmacistForm stdata = new PharmacistForm();
                    stdata.ShowDialog();
                    Show();
                }
                else
                {
                    labelErrorMessage.Text = "Username or password invalid";
                    //MessageBox.Show("Username or password invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            textBoxPhUsername.Clear();textBoxPhPassword.Clear();
        }

        private void textBoxPhUsername_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void textBoxPhPassword_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
