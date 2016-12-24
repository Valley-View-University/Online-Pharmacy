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
    public partial class PharmacistForm : Form
    {
        public PharmacistForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");
       

        private void PharmacistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.
            
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Prescription WHERE AccessID ='" + textBoxCodeVerify.Text + "'", con);
            string Query = "SELECT Prescription FROM Prescription WHERE AccessID ='" + textBoxCodeVerify.Text + "';";
            string Query1 = "SELECT PatientID FROM Prescription WHERE AccessID ='" + textBoxCodeVerify.Text + "';";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Code Verified Successful");
                }
                else
                {
                    MessageBox.Show("Code invalid");
                }
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxPrescription.AppendText(Environment.NewLine + (dr[0].ToString()));
                }
                con.Close();

                con.Open();

                SqlCommand cmd1 = new SqlCommand(Query1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {
                    textBox1.AppendText(Environment.NewLine + (dr1[0].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void prescriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
