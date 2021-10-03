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
    public partial class frmRecordAppointmentDetails : Form
    {
        frmMainMenu parent;
        public frmRecordAppointmentDetails()
        {
            InitializeComponent();
        }
        public frmRecordAppointmentDetails(frmMainMenu Parent)

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
        private void frmRecordAppointmentDetails_Load(object sender, EventArgs e)
        {

        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYes.Checked)
            {
                txtCost.Text = "0";
                txtCost.ReadOnly = true;
            }
            else
            {
                txtCost.Text = "";
                txtCost.ReadOnly = false;
            }
         
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Boolean check = Utilities.appDetails(dtpAppDate.Value,cboAppointmentTime.Text,txtAge.Text, txtReasonForVisit.Text,txtResultOfVist.Text,txtCost.Text);

            if (check)
            {

                String name = "record the details of the appointment";
                Boolean check2 = Utilities.buttonConformation(name);

                if (check2)
                {
                    Appointment aAppointment = new Appointment(Convert.ToDateTime(dtpAppDate.Text), cboAppointmentTime.Text.ToUpper(),
                    txtAge.Text.ToUpper(), txtReasonForVisit.Text.ToUpper(), txtResultOfVist.Text.ToUpper(), Convert.ToInt32(txtCost.Text));

                    aAppointment.recordAppointmentDetails();

                    MessageBox.Show("Details of the appointment have been successfully saved");

                    dtpAppDate.CustomFormat = "";
                    cboAppointmentTime.SelectedIndex = -1;
                    txtReasonForVisit.Clear();
                    txtResultOfVist.Clear();
                    txtCost.Clear();
                }
            }
        }

        private void grpAppointmentDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
