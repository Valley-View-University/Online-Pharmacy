using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePharmacy
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void doctorInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oNLINEPHARMACYDataSet);

        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.HospitalInfo' table. You can move, or remove it, as needed.
            this.hospitalInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.HospitalInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.Prescription' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PharmacyInfo' table. You can move, or remove it, as needed.
            this.pharmacyInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PharmacyInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.PatientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.PatientInfo);
            // TODO: This line of code loads data into the 'oNLINEPHARMACYDataSet.DoctorInfo' table. You can move, or remove it, as needed.
            this.doctorInfoTableAdapter.Fill(this.oNLINEPHARMACYDataSet.DoctorInfo);

        }
    }
}
