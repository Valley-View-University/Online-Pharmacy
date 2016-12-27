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

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void PatientForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = DoctorLogin.HospitalID.ToString();
            
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PatientInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PrescriptionTable' table. You can move, or remove it, as needed.
            this.prescriptionTableTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PrescriptionTable);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PrescriptionTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.

        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DoctorLogin doclog = new DoctorLogin();
            int ID = int.Parse(textBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter();
            string Query = "INSERT INTO PrescriptionTable (PatientID, AccessCode, Prescriptions, PatientName, HospitalID) values('" + textBoxID.Text + "','" + accessIDTextBox.Text + "','" + textBoxPrescriptions.Text + "','" + textBoxPatientName.Text + "','"+ ID +"');";
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();

                if (string.IsNullOrWhiteSpace(accessIDTextBox.Text) || string.IsNullOrWhiteSpace(textBoxPrescriptions.Text) || string.IsNullOrWhiteSpace(patientIDComboBox.Text))
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
            String query = "SELECT LastName FROM PatientInfo";

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
            
            string meal = "", time = "";
            if (!radbtnBeforeMeals.Checked && !radbtnAfterMeals.Checked || (!chkbxMorning.Checked && !chkbxAfternoon.Checked && !chkbxEvening.Checked))
            {
                MessageBox.Show("Some fields are empty or unchecked");
            }
            else
            {
                if (radbtnAfterMeals.Checked) { meal = radbtnAfterMeals.Text; }
                if (radbtnBeforeMeals.Checked) { meal = radbtnBeforeMeals.Text; }

                if (chkbxMorning.Checked) { time = chkbxMorning.Text; }
                if (chkbxAfternoon.Checked) { time = chkbxAfternoon.Text; }
                if (chkbxEvening.Checked) { time = chkbxEvening.Text; }

                if (chkbxMorning.Checked && chkbxAfternoon.Checked) { time = chkbxMorning.Text + ", " + chkbxAfternoon.Text; }
                if (chkbxEvening.Checked && chkbxAfternoon.Checked && chkbxEvening.Checked) { time = (chkbxMorning.Text + ", " + chkbxAfternoon.Text + ", " + chkbxEvening.Text); }

                if (string.IsNullOrWhiteSpace(comboBoxDrugs.Text)) { MessageBox.Show("Select Drug"); }
                else
                {
                    if (list.Contains(comboBoxDrugs.Text)) { }
                    else
                    {
                        list.Add(comboBoxDrugs.Text);
                        textBoxPrescriptions.AppendText(comboBoxDrugs.Text + ",\t\t " + meal + ",\t\t " + time + Environment.NewLine);
                    }
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
            /*string query = "DELETE TOP(1) FROM PrescriptionTable WHERE PatientID = 1";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }*/
        }

        private void patientIDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string Query = "SELECT PatientID, FirstName, MiddleName, LastName FROM PatientInfo WHERE LastName = '" + patientIDComboBox.Text + "';";

            try {
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxPatientName.Text = dr["LastName"].ToString() +" "+ dr["FirstName"].ToString() + " " + dr["MiddleName"].ToString();
                    textBoxID.Text = dr["PatientID"].ToString();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void linkLabelClearPrescriptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrescriptions.Text))
            {
                MessageBox.Show("No prescriptions given");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear Prescription?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    textBoxPrescriptions.Clear();
                }
            }
        }
    }
}
