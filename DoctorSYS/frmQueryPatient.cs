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
   
    public partial class frmQueryPatient : Form
    {
        frmMainMenu parent;

        Patient aPatient = new Patient();
        Appointment aAppointment = new Appointment();
        public frmQueryPatient()
        {
            InitializeComponent();
        }
        public frmQueryPatient(frmMainMenu Parent)

        {
            InitializeComponent();
            parent = Parent;
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            grdPatients.Visible = true;
            btnPrint.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Printed");
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            aPatient.queryPatient(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            this.dtpDateOfBirth.Enabled = false;
            
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
            txtStatus.Text = aPatient.getStatus().ToString();

            grdApps.DataSource = Appointment.getAllApps(aPatient.getPatientId()).Tables["APP"];
            grpPatientDetails.Visible = true;
            
        }

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grpPatientDetails_Enter_1(object sender, EventArgs e)
        {

        }

        private void frmQueryPatient_Load(object sender, EventArgs e)
        {

        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void lblNextAppointment_Click(object sender, EventArgs e)
        {

        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
