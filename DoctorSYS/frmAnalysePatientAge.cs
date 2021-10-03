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
    public partial class frmAnalysePatientAge : Form
    {
        frmMainMenu parent;
        public frmAnalysePatientAge()
        {
            InitializeComponent();
        }
        public frmAnalysePatientAge(frmMainMenu Parent)

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

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Appointment.getAverageAge(cboTime.Text.Substring(2, 2));


            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(Convert.ToInt32(i + 1));
                Amounts[i] = 0;
            }

            for (int i = 0; i < ds.Tables["APPDT"].Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(ds.Tables["APPDT"].Rows[i][1]) - 1] = Convert.ToDecimal(ds.Tables["APPDT"].Rows[i][0]);
            }

            chtAverageAge.Titles.Clear();
            chtAverageAge.Titles.Add("Average Age of Patients in " + cboTime.Text);
            chtAverageAge.ChartAreas[0].AxisX.Interval = 1;
            chtAverageAge.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtAverageAge.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtAverageAge.Series[0].LegendText = "Age in Years";
            chtAverageAge.Series[0].Points.DataBindXY(Months, Amounts);
            chtAverageAge.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtAverageAge.Series[0].Label = "#VALY";
            chtAverageAge.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnalysePatientAge_Load(object sender, EventArgs e)
        {
            Utilities.loadYear(cboTime);
        }

        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default: return "OTH";

            }
        }

        private void chtAnalyseRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            String text = "print this chart?";
            Boolean check = Utilities.buttonConformation(text);

            if (check)
            {
                MessageBox.Show("Chart has been succesfully printed");
            }
        }
    }
}
