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
    public partial class PharmacistForm : Form
    {
        public PharmacistForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=ONLINEPHARMACY;Integrated Security=True");
        private void prescriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oNLINEPHARMACYDataSet);

        }

        private void PharmacistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.oNLINEPHARMACYDataSet.Prescription);

        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            textBoxPrescription.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Prescription FROM Prescription WHERE AccessID ='" + textBoxCodeVerify.Text + "'", con);
            string Query = "SELECT Prescription FROM Prescription WHERE AccessID ='" + textBoxCodeVerify.Text + "';";
            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
