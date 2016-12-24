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
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DoctorInfo WHERE Username ='" + textBoxDocUsername.Text + "'AND Password ='" + textBoxDocPassword.Text + "'", con);

            try {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Hide();
                    DoctorForm stdata = new DoctorForm();
                    stdata.ShowDialog();
                    Show();
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
            finally {con.Close();}
        }
    }
}
