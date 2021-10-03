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

    public partial class frmRegisterPatient : Form
    {
        frmMainMenu parent;
      //  public frmRegisterPatient()

     //   {
      //      InitializeComponent();
      //  }

        public frmRegisterPatient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void frmRegisterPatient_Load(object sender, EventArgs e)
        {
            txtPatientId.Text = Patient.getNextPatientId().ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

            Boolean check = Utilities.textValidation(txtFirstName.Text, txtSurname.Text, dtpDateOfBirth.Value, txtTelephoneNumber.Text, txtStreet.Text, txtTown.Text,
                                     txtEircode.Text, txtPPSN.Text, txtMedicalCard.Text);



            if (check)
            {
                Patient aPatient = new Patient(Convert.ToInt32(txtPatientId.Text), txtFirstName.Text.ToUpper(),
                txtSurname.Text.ToUpper(), Convert.ToDateTime(dtpDateOfBirth.Text), txtTelephoneNumber.Text.ToUpper(), txtStreet.Text.ToUpper(),
                txtTown.Text.ToUpper(), txtEircode.Text.ToUpper(), txtPPSN.Text.ToUpper(), txtMedicalCard.Text.ToUpper(), "R");

                String name = "register the patient";

                Boolean check2 = Utilities.buttonConformation(name);

                if (check2)
                {


                    aPatient.registerPatient();

                    MessageBox.Show("Patient has been succesfully registered", " Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    txtFirstName.Clear();
                    txtSurname.Clear();
                    txtTelephoneNumber.Clear();
                    txtStreet.Clear();
                    txtTown.Clear();
                    txtEircode.Clear();
                    txtPPSN.Clear();
                    txtMedicalCard.Clear();


                    txtPatientId.Text = Patient.getNextPatientId().ToString();
                }

            }

         }

            private void grpRegisterPatient_Enter(object sender, EventArgs e)
            {

            }

            private void lblPPSN_Click(object sender, EventArgs e)
            {

            }

            private void lblMedicalCard_Click(object sender, EventArgs e)
            {

            }
        }
    }
