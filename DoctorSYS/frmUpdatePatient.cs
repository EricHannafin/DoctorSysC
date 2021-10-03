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
    public partial class FrmUpdatePatient : Form
    {
        frmMainMenu parent;

        Patient aPatient = new Patient();

        public FrmUpdatePatient()
        {
            InitializeComponent();
        }
        public FrmUpdatePatient(frmMainMenu Parent)

        {
            InitializeComponent();
            parent = Parent;
        }

        private void FrmUpdatePatient_Load(object sender, EventArgs e)
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
            Boolean check = Utilities.surnameSearch(txtSurnameSearch.Text);

            if (check)
            {
                grdPatients.DataSource = Patient.getMatchingPatients(txtSurnameSearch.Text.ToUpper()).Tables["PS"];


                grdPatients.Visible = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grpPatientDetails.Visible = true;

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean check = Utilities.textValidationUpdate(txtFirstName.Text, txtSurname.Text, dtpDateOfBirth.Value, txtPhoneNumber.Text, txtStreet.Text, txtTown.Text,
                                         txtEircode.Text, txtPPSN.Text, txtMedicalCard.Text);

            if (check)
            {

                aPatient.setFirstName(txtFirstName.Text);
                aPatient.setSurname(txtSurname.Text);
                aPatient.setDateOfBirth(dtpDateOfBirth.Value);
                aPatient.setPhoneNumber(txtPhoneNumber.Text);
                aPatient.setStreet(txtStreet.Text);
                aPatient.setStreet(txtStreet.Text);
                aPatient.setTown(txtTown.Text);
                aPatient.setEircode(txtEircode.Text);
                aPatient.setPPSN(txtPPSN.Text);
                aPatient.setMedicalCard(txtMedicalCard.Text);

                String name = "update the patient";

                Boolean check2 = Utilities.buttonConformation(name);

                if (check2)
                {
                    aPatient.updatePatient();

                    MessageBox.Show("Patient has been successfully updated");


                    grdPatients.Visible = false;
                    grpPatientDetails.Visible = false;
                    txtSurnameSearch.Clear();
                    txtSurnameSearch.Focus();
                }
            }
            
            }

        private void txtSurnameSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void grdPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
           
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

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void txtSurnameSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
