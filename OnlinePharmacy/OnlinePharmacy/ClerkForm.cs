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
using System.Data.SqlClient;

namespace OnlinePharmacy
{
    public partial class ClerkForm : MaterialForm
    {
        public ClerkForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Username, Password FROM ClerkInfo WHERE Username = '" + textBoxUsername.Text + "'AND Password = '" + textBoxPassword.Text +"'",con);
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
        }
    }
}
