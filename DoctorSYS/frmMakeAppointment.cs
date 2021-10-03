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
    public partial class FrmMakeAppointment : Form
    {   
        frmMainMenu parent;

          Patient aPatient = new Patient();

        public FrmMakeAppointment(frmMainMenu Parent)

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

        private void FrmMakeAppointment_Load(object sender, EventArgs e)
        {
            
            txtAppointmentId.Text = Appointment.getNextAppointmentId().ToString();
            loadTimes();
        }

        private void loadTimes()
        {

            
            DataSet ds = Appointment.getAvailableTimes(this.dtpDate.Value.ToString("dd-MMM-yy"));

            cboTime.Items.Clear();

            for (int i = 0; i < ds.Tables["T"].Rows.Count; i++)
                cboTime.Items.Add(ds.Tables[0].Rows[i][0]);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean check = Utilities.surnameSearch(txtSurnameSearch.Text);

            if (check)
            {
                grdPatients.DataSource = Patient.getMatchingPatients(txtSurnameSearch.Text.ToUpper()).Tables["PS"];

                loadTimes();

                grdPatients.Visible = true;
            }
        }

        private void grdPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            aPatient.getPatient(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value.ToString()));
           
            txtPatientId.Text = aPatient.getPatientId().ToString();

            grpPatientDetails.Visible = true;

        }

        private void grpPatientDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            Boolean check = Utilities.makeApp(dtpDate.Value, cboTime.Text);

            if (check)
            {
                Appointment aAppointment = new Appointment(Convert.ToInt32(txtAppointmentId.Text), Convert.ToInt32(txtPatientId.Text), Convert.ToDateTime(dtpDate.Text), Convert.ToString(cboTime.Text));
                String name = "confirm the appointment";
                Boolean check2 = Utilities.buttonConformation(name);

                if (check2)
                {
                    aAppointment.makeAppointment();

                    MessageBox.Show("Appointment has been successfully created");

                    grdPatients.Visible = false;
                    grpPatientDetails.Visible = false;
                    txtSurnameSearch.Clear();
                    txtSurnameSearch.Focus();
                    cboTime.ResetText();


                    txtAppointmentId.Text = Appointment.getNextAppointmentId().ToString();
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadTimes();
        }
    }
}
