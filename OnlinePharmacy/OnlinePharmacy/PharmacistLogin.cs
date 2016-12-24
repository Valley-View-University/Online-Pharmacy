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

namespace OnlinePharmacy
{
    public partial class PharmacistLogin : Form
    {
        public PharmacistLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");

        private void buttonLogin_Click(object sender, EventArgs e)
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
                    MessageBox.Show("ID or password invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoctorLogin dl = new DoctorLogin();
            Hide();
            dl.ShowDialog();
            Show();
        }
    }
}
