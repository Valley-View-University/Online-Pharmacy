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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        List<string> timeOfDay = new List<string>();
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
       

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PatientInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            string Query = "UPDATE PrescriptionTable SET Prescriptions = '" + listBoxPrescriptions.Items.ToString() + "',AccessCode = '"+ accessIDTextBox.Text +"' FROM PatientInfo INNER JOIN PrescriptionTable ON PrescriptionTable.PatientID = PatientInfo.PatientID WHERE PatientName = '"+ patientIDComboBox.Text +"';";
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();

                if (string.IsNullOrWhiteSpace(accessIDTextBox.Text) || string.IsNullOrWhiteSpace(listBoxPrescriptions.Items.ToString()) || string.IsNullOrWhiteSpace(patientIDComboBox.Text))
                {
                    MessageBox.Show("Some fields are empty");
                }
                else
                {
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Submitted");
                    while (myReader.Read()) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void patientIDComboBox_DropDown(object sender, EventArgs e)
        {
            //patientIDComboBox.Items.Clear();
            String query = "SELECT PatientID FROM PatientInfo";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               // patientIDComboBox.Items.Add(dr[0]);
            }
            con.Close();

        }

        private void linkLabelDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Database db = new Database();
            db.ShowDialog();
            Show();
        }

        private void linkLabelAddDrug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string meal = "", time = "", drug="";
            if(!radbtnBeforeMeals.Checked && !radbtnAfterMeals.Checked) { MessageBox.Show("Enter the meal time"); }
            if (radbtnAfterMeals.Checked){ meal = radbtnAfterMeals.Text; }
            if (radbtnBeforeMeals.Checked){ meal = radbtnBeforeMeals.Text; }

            if (chkbxMorning.Checked){time = chkbxMorning.Text;}if (chkbxAfternoon.Checked){time = chkbxAfternoon.Text;}if (chkbxEvening.Checked){time = chkbxEvening.Text;}

            if (chkbxMorning.Checked && chkbxAfternoon.Checked){time = chkbxMorning.Text + ", " + chkbxAfternoon.Text;}
            if (chkbxEvening.Checked && chkbxAfternoon.Checked && chkbxEvening.Checked){time = (chkbxMorning.Text + ", " + chkbxAfternoon.Text + ", " + chkbxEvening.Text);}
                  
            if (string.IsNullOrWhiteSpace(comboBoxDrugs.Text)){MessageBox.Show("Select Drug");}
            else
            {
                if (list.Contains(comboBoxDrugs.Text)){}
                else
                {
                    list.Add(comboBoxDrugs.Text);
                    listBoxPrescriptions.Items.Add(comboBoxDrugs.Text + ",\t\t " + meal + ",\t\t " + time);
                }
            }

            
        }

        private void patientIDComboBox_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void patientIDComboBox_TextChanged(object sender, EventArgs e)
        {
            /*string query = "SELECT FirstName, MiddleNAme, LastName FROM Prescription WHERE PatientID = '" + patientIDComboBox.Text + "';";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textBoxPatientInfo.AppendText(Environment.NewLine + ("FIRST NAME:\t\t" + dr[1].ToString()));
                textBoxPatientInfo.AppendText(Environment.NewLine + ("MIDDLE NAME:\t\t" + dr[2].ToString()));
                textBoxPatientInfo.AppendText(Environment.NewLine + ("LAST NAME:\t\t" + dr[3].ToString()));
            }
            con.Close();*/
        }

        private void linkLabelGenerateCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string randomvalue = RandomString(8);
            accessIDTextBox.Text = randomvalue;
        }
    }
}
