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
    public partial class DoctorLogin : MaterialForm
    {
        
        public DoctorLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");

        public static int HospitalID;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM DoctorInfo WHERE Username like'" + textBoxDocUsername.Text + "'AND Password like'" + textBoxDocPassword.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DoctorInfo WHERE Username ='" + textBoxDocUsername.Text + "'AND Password ='" + textBoxDocPassword.Text + "'", con);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    HospitalID = int.Parse(dr["Hospital_Id"].ToString());
                }
                con.Close();
                con.Open();
                DataTable dt = new DataTable();

                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Hide();
                    DoctorForm doc = new DoctorForm();
                    doc.ShowDialog();
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
            finally {con.Close();}
            textBoxDocUsername.Clear();textBoxDocPassword.Clear();
        }

        private void textBoxDocUsername_TextChanged(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void textBoxDocPassword_TextChanged(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }
    }
}
