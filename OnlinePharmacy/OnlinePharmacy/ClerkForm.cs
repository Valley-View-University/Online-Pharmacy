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
            string Query = "INSERT INTO LogBooks(Username, LastSignIn) values('" + textBoxUsername.Text + "','" + DateTime.Now + "');";
            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader myReader;
                    con.Close();
                    con.Open();
                    
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read()) { }
                    
                    MessageBox.Show("Login Successful.");
                    panelLogin.Hide();
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

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }


        private void patientInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oNLINEPHARMACYDataSet);

        }

        private void patientInfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oNLINEPHARMACYDataSet);

        }

        private void ClerkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PatientInfo);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String Query = "INSERT INTO PatientInfo (PatientID, FirstName, MiddleName, LastName, PhoneNumber, DoctorID)" + "VALUES ('" + patientIDTextBox.Text + "','" + firstNameTextBox.Text + "','" + middleNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + phoneNumberTextBox.Text + "','" + doctorIDComboBox.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader myReader;
            if (string.IsNullOrWhiteSpace(patientIDTextBox.Text) || string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(doctorIDComboBox.Text))
            {
                MessageBox.Show("Some fields are empty");
            }
            else
            {
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Information Saved");
                    while (myReader.Read()) { }
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.Close(); }
            }
        }
    }
}
