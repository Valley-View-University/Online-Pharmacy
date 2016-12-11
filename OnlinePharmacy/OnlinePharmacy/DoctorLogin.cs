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
    public partial class DoctorLogin : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbFilename=C: \Users\DR.BATSE\Documents\Visual Studio 2015\ONLINEPHARMACY.mdf;Integrated Security=True");
        
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DoctorInfo WHERE Username ='" + txtBxDocUsername.Text + "'AND Password ='" + txtBxDocPassword.Text + "'", con);
            try {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Database stdata = new Database();
                    stdata.Show();
                }
                else
                {
                    MessageBox.Show("ID or password invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
