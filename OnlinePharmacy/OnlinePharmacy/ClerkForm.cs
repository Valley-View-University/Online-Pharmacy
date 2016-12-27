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
                    textBoxPassword.Clear();textBoxUsername.Clear();
                    panelLogin.Visible = false;panel1.Show();
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
            panelLogin.Show();panel1.Hide();
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.DoctorInfo' table. You can move, or remove it, as needed.
            this.doctorInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.DoctorInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PatientInfo);

        }

        

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                panel1.Hide();panelLogin.Show();
            }
        }

        private void linkLabelClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            patientIDTextBox.Clear(); firstNameTextBox.Clear(); middleNameTextBox.Clear(); lastNameTextBox.Clear(); phoneNumberTextBox.Clear();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PatientInfo WHERE PatientID ='" + textBoxSearch.Text + "'", con);
            string Query = "UPDATE PatientInfo SET FirstName ='" + firstNameTextBox.Text + "', MiddleName = '" + middleNameTextBox.Text + "', LastName = '" + lastNameTextBox.Text + "', PhoneNumber = '" + phoneNumberTextBox.Text + "', DoctorID = '" + doctorIDComboBox.Text + "' WHERE PatientID ='" + patientIDTextBox.Text + "';";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    MessageBox.Show("Record Updated");
                    textBoxResult.Clear();
                }
                else
                {
                    MessageBox.Show("No Results found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PatientInfo WHERE PatientID ='" + textBoxSearch.Text + "'", con);
            string Query = "DELETE FROM PatientInfo WHERE PatientID ='" + textBoxSearch.Text + "';";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    DialogResult result = MessageBox.Show("Delete Record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DialogResult result1 = MessageBox.Show("Are you sure? This cannot be Undone?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand(Query, con);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read()) { }
                            MessageBox.Show("Record Deleted");
                            textBoxResult.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Results found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PatientInfo WHERE PatientID ='" + textBoxSearch.Text + "'", con);
            string Query = "SELECT * FROM PatientInfo WHERE PatientID ='" + textBoxSearch.Text + "';";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Search Successful");
                }
                else
                {
                    MessageBox.Show("No Results found");
                }
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxResult.AppendText(Environment.NewLine + ("PATIENT ID:\t\t" + dr["PatientID"].ToString()));
                    textBoxResult.AppendText(Environment.NewLine + ("PATIENT NAME:\t\t" + dr["LastName"].ToString() + " " + dr["FirstName"].ToString() + " " + dr["MiddleName"].ToString()));
                    textBoxResult.AppendText(Environment.NewLine + ("PHONE NUMBER:\t\t" + dr["PhoneNumber"].ToString()));
                    textBoxResult.AppendText(Environment.NewLine + ("DOCTOR ID:\t\t" + dr["DoctorID"].ToString()));

                    patientIDTextBox.Text = dr["PatientID"].ToString();
                    firstNameTextBox.Text = dr["FirstName"].ToString();
                    middleNameTextBox.Text = dr["MiddleName"].ToString();
                    lastNameTextBox.Text = dr["LastName"].ToString();
                    phoneNumberTextBox.Text = dr["PhoneNumber"].ToString();
                    doctorIDComboBox.Text = dr["DoctorID"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void linkLabelDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Database db = new Database();
            Hide();
            db.ShowDialog();
            Show();
        }

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
