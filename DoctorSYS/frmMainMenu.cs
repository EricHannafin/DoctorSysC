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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.exitConformation();
        }

        private void analyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnalyseRevenue nextForm = new frmAnalyseRevenue(this);
            this.Hide();
            nextForm.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnsRegisterPatient_Click(object sender, EventArgs e)
        {
            frmRegisterPatient nextForm = new frmRegisterPatient(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsUpdatePatient_Click(object sender, EventArgs e)
        {
            FrmUpdatePatient nextForm = new FrmUpdatePatient(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsDeregisterPatient_Click(object sender, EventArgs e)
        {
            frmDeregisterPatient nextForm = new frmDeregisterPatient(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsQueryPatient_Click(object sender, EventArgs e)
        {
            frmQueryPatient nextForm = new frmQueryPatient(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsMakeAppointment_Click(object sender, EventArgs e)
        {
            FrmMakeAppointment nextForm = new FrmMakeAppointment(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsCancelAppointment_Click(object sender, EventArgs e)
        {
            FrmCancelAppointment nextForm = new FrmCancelAppointment(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsRecordAppointmentDetails_Click(object sender, EventArgs e)
        {
            frmRecordAppointmentDetails nextForm = new frmRecordAppointmentDetails(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnsAnalyseAppointmentType_Click(object sender, EventArgs e)
        {
            frmAnalysePatientAge nextForm = new frmAnalysePatientAge(this);
            this.Hide();
            nextForm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
