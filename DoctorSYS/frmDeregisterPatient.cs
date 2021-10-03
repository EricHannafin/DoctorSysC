using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSYS
{
    public partial class frmDeregisterPatient : Form
    {
        frmMainMenu parent;

        Patient aPatient = new Patient();
        public frmDeregisterPatient()
        {
            InitializeComponent();
        }
        public frmDeregisterPatient(frmMainMenu Parent)

        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmDeregisterPatient_Load(object sender, EventArgs e)
        {

        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            Boolean check = Utilities.backConformation();

            if (check)
            {
                this.Close();
                parent.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurnameSearch.Text == "")
            {
                MessageBox.Show("No data entered");
            }
            else

            grdPatients.DataSource = Patient.getMatchingPatients(txtSurnameSearch.Text.ToUpper()).Tables["PS"];

          
            grdPatients.Visible = true;
            btnDeregister.Visible = true;
        }

        private void btnDeregister_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Patient has been successfully deregistered");
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Boolean check = Utilities.surnameSearch(txtSurnameSearch.Text);

            if (check)
            {
                grdPatients.DataSource = Patient.getMatchingPatients(txtSurnameSearch.Text).Tables["PS"];


                grdPatients.Visible = true;
            }
        }

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grdPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get details for selected patient using patientId in col[0] of the grid
            aPatient.getPatient(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value.ToString()));


            txtPatientId.Text = aPatient.getPatientId().ToString("000");
            txtFirstName.Text = aPatient.getFirstName().ToString();
            txtSurname.Text = aPatient.getSurname().ToString();
            dtpDateOfBirth.Value = aPatient.getDateOfBirth();
            txtPhoneNumber.Text = aPatient.getPhoneNumber().ToString();
            txtStreet.Text = aPatient.getStreet().ToString();
            txtTown.Text = aPatient.getTown().ToString();
            txtEircode.Text = aPatient.getEircode().ToString();
            txtPPSN.Text = aPatient.getPPSN().ToString();
            txtMedicalCard.Text = aPatient.getMedicalCard().ToString();


            grpPatientDetails.Visible = true;
        }

        private void grpPatientDetails_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtTelephoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeregister_Click_2(object sender, EventArgs e)
        {
            String name = "deregister the patient";
            Boolean check = Utilities.buttonConformation(name);

            if (check)
            {
                aPatient.deregisterPatient();

                MessageBox.Show("Patient has been successfully deregistered");

                grdPatients.Visible = false;
                grpPatientDetails.Visible = false;
                txtSurnameSearch.Clear();
                txtSurnameSearch.Focus();
            }
        }
    }
}
