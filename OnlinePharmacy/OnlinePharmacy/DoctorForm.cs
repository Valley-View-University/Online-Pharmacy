﻿using System;
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
        List<String> list = new List<string>();
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        

       

        private void prescriptionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            string Query = "UPDATE Prescription SET Prescription = '" + textBoxPrescription.Text + "',AccessID = '"+ accessIDTextBox.Text +"' WHERE PatientID = '"+ patientIDComboBox.Text +"';";
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader myReader;
                con.Open();

                myReader = cmd.ExecuteReader();
                MessageBox.Show("Data Submitted");
                while (myReader.Read()){}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void patientIDComboBox_DropDown(object sender, EventArgs e)
        {
            patientIDComboBox.Items.Clear();
            String query = "SELECT PatientID FROM PatientInfo";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                patientIDComboBox.Items.Add(dr[0]);
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
            string meal, time, drug;
            if(!radbtnBeforeMeals.Checked && !radbtnAfterMeals.Checked) { MessageBox.Show("Enter the meal time"); }
            if (radbtnAfterMeals.Checked){ meal = radbtnAfterMeals.Tag.ToString(); }
            if (radbtnBeforeMeals.Checked){ meal = radbtnBeforeMeals.Tag.ToString(); }
            if (chkbxMorning.Checked)
            {
                if (chkbxAfternoon.Checked)
                {
                    if (chkbxEvening.Checked)
                    {
                        time = chkbxMorning.Tag.ToString() + ", " + chkbxAfternoon.Tag.ToString() + ", " + chkbxEvening.Tag.ToString();
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(comboBoxDrugs.Text))
            {
                MessageBox.Show("Select Drug");
            }
            else
            {
                if (list.Contains(comboBoxDrugs.Text)){}
                else
                {
                    list.Add(comboBoxDrugs.Text);
                    textBoxPrescription.AppendText(comboBoxDrugs.Text + Environment.NewLine);
                }
            }
        }

        private void patientIDComboBox_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void patientIDComboBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT FirstName, MiddleNAme, LastName FROM Prescription WHERE PatientID = '" + patientIDComboBox.Text + "';";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textBoxPatientInfo.AppendText(Environment.NewLine + ("FIRST NAME:\t\t" + dr[1].ToString()));
                textBoxPatientInfo.AppendText(Environment.NewLine + ("MIDDLE NAME:\t\t" + dr[2].ToString()));
                textBoxPatientInfo.AppendText(Environment.NewLine + ("LAST NAME:\t\t" + dr[3].ToString()));
            }
            con.Close();
        }

        private void linkLabelGenerateCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string randomvalue = RandomString(8);
            accessIDTextBox.Text = randomvalue;
        }
    }
}