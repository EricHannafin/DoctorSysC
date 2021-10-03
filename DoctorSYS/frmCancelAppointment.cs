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
    public partial class FrmCancelAppointment : Form
    {
        frmMainMenu parent;

        Appointment aAppointment = new Appointment();
        Patient aPatient = new Patient();
        public FrmCancelAppointment()
        {
            InitializeComponent();
        }
        public FrmCancelAppointment(frmMainMenu Parent)

        {
            InitializeComponent();
            parent = Parent;
        }


        private void FrmCancelAppointment_Load(object sender, EventArgs e)
        {

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

        private void mnsExit_Click(object sender, EventArgs e)
        {
            Boolean check = Utilities.backConformation();

            if (check)
            {
                this.Close();
                parent.Visible = true;
            }           
        }

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grdPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aPatient.getPatient(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value.ToString()));
      
            grdApps.DataSource = Appointment.getFutureApps(aPatient.getPatientId()).Tables["APP"];
            grdApps.Visible = true;
                    
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String name = "cancel the appointment";
            Boolean check2 = Utilities.buttonConformation(name);

            if (check2)
            {
                aAppointment.cancelAppointment();

                MessageBox.Show("Appointment has been successfully removed");

                grdPatients.Visible = false;
                grdApps.Visible = false;
                grpAppDetails.Visible = false;
                txtSurnameSearch.Clear();
                txtSurnameSearch.Focus();
            }
        }

        private void grdApps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            aAppointment.getAppointmentCancel(Convert.ToInt32(grdApps.Rows[grdApps.CurrentCell.RowIndex].Cells[0].Value.ToString()));
          
            
            txtAppointmentId.Text = aAppointment.getAppointmentId().ToString("000");
            txtPatientId.Text = aAppointment.getPatientId().ToString("000");
            dtpDate.Value = aAppointment.getDate();
            txtTime.Text = aAppointment.getTime().ToString();
            

            grpAppDetails.Visible = true;

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            txtTime.ReadOnly = true;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.dtpDate.Enabled = false;
        }
    }
}
