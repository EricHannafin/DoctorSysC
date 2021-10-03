namespace DoctorSYS
{
    partial class frmRecordAppointmentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuRegisterPatient = new System.Windows.Forms.MenuStrip();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.lblReasonForVisit = new System.Windows.Forms.Label();
            this.txtReasonForVisit = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.lblMedicalCard = new System.Windows.Forms.Label();
            this.cboAppointmentTime = new System.Windows.Forms.ComboBox();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.txtResultOfVist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.mnuRegisterPatient.SuspendLayout();
            this.grpAppointmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterPatient.TabIndex = 31;
            this.mnuRegisterPatient.Text = "menuStrip1";
            // 
            // mnsExit
            // 
            this.mnsExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(44, 20);
            this.mnsExit.Text = "Back";
            this.mnsExit.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateOfBirth.Location = new System.Drawing.Point(28, 68);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(108, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Appointment Date";
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Location = new System.Drawing.Point(160, 68);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppDate.TabIndex = 6;
            // 
            // lblReasonForVisit
            // 
            this.lblReasonForVisit.AutoSize = true;
            this.lblReasonForVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonForVisit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblReasonForVisit.Location = new System.Drawing.Point(28, 195);
            this.lblReasonForVisit.Name = "lblReasonForVisit";
            this.lblReasonForVisit.Size = new System.Drawing.Size(97, 13);
            this.lblReasonForVisit.TabIndex = 9;
            this.lblReasonForVisit.Text = "Reason for Visit";
            // 
            // txtReasonForVisit
            // 
            this.txtReasonForVisit.Location = new System.Drawing.Point(160, 195);
            this.txtReasonForVisit.Name = "txtReasonForVisit";
            this.txtReasonForVisit.Size = new System.Drawing.Size(318, 20);
            this.txtReasonForVisit.TabIndex = 10;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRecord.Location = new System.Drawing.Point(516, 256);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(181, 58);
            this.btnRecord.TabIndex = 20;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // grpAppointmentDetails
            // 
            this.grpAppointmentDetails.Controls.Add(this.txtAge);
            this.grpAppointmentDetails.Controls.Add(this.lblPatientAge);
            this.grpAppointmentDetails.Controls.Add(this.txtCost);
            this.grpAppointmentDetails.Controls.Add(this.lblCost);
            this.grpAppointmentDetails.Controls.Add(this.chkYes);
            this.grpAppointmentDetails.Controls.Add(this.lblMedicalCard);
            this.grpAppointmentDetails.Controls.Add(this.cboAppointmentTime);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentTime);
            this.grpAppointmentDetails.Controls.Add(this.txtResultOfVist);
            this.grpAppointmentDetails.Controls.Add(this.label1);
            this.grpAppointmentDetails.Controls.Add(this.btnRecord);
            this.grpAppointmentDetails.Controls.Add(this.txtReasonForVisit);
            this.grpAppointmentDetails.Controls.Add(this.lblReasonForVisit);
            this.grpAppointmentDetails.Controls.Add(this.dtpAppDate);
            this.grpAppointmentDetails.Controls.Add(this.lblDateOfBirth);
            this.grpAppointmentDetails.Location = new System.Drawing.Point(25, 43);
            this.grpAppointmentDetails.Name = "grpAppointmentDetails";
            this.grpAppointmentDetails.Size = new System.Drawing.Size(751, 364);
            this.grpAppointmentDetails.TabIndex = 32;
            this.grpAppointmentDetails.TabStop = false;
            this.grpAppointmentDetails.Text = "Record Appointment Details";
            this.grpAppointmentDetails.Enter += new System.EventHandler(this.grpAppointmentDetails_Enter);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(160, 318);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(54, 20);
            this.txtCost.TabIndex = 65;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCost.Location = new System.Drawing.Point(28, 325);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(32, 13);
            this.lblCost.TabIndex = 64;
            this.lblCost.Text = "Cost";
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(160, 284);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(44, 17);
            this.chkYes.TabIndex = 62;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // lblMedicalCard
            // 
            this.lblMedicalCard.AutoSize = true;
            this.lblMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalCard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMedicalCard.Location = new System.Drawing.Point(28, 288);
            this.lblMedicalCard.Name = "lblMedicalCard";
            this.lblMedicalCard.Size = new System.Drawing.Size(81, 13);
            this.lblMedicalCard.TabIndex = 61;
            this.lblMedicalCard.Text = "Medical Card";
            // 
            // cboAppointmentTime
            // 
            this.cboAppointmentTime.FormattingEnabled = true;
            this.cboAppointmentTime.Items.AddRange(new object[] {
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11.30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45"});
            this.cboAppointmentTime.Location = new System.Drawing.Point(160, 113);
            this.cboAppointmentTime.Name = "cboAppointmentTime";
            this.cboAppointmentTime.Size = new System.Drawing.Size(121, 21);
            this.cboAppointmentTime.TabIndex = 60;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAppointmentTime.Location = new System.Drawing.Point(28, 113);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(108, 13);
            this.lblAppointmentTime.TabIndex = 59;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // txtResultOfVist
            // 
            this.txtResultOfVist.Location = new System.Drawing.Point(160, 233);
            this.txtResultOfVist.Name = "txtResultOfVist";
            this.txtResultOfVist.Size = new System.Drawing.Size(133, 20);
            this.txtResultOfVist.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(28, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Result of Visit";
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPatientAge.Location = new System.Drawing.Point(28, 151);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(73, 13);
            this.lblPatientAge.TabIndex = 66;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(160, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(22, 20);
            this.txtAge.TabIndex = 67;
            // 
            // frmRecordAppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAppointmentDetails);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Name = "frmRecordAppointmentDetails";
            this.Text = "DoctorSYS-RecordAppointmentDetails";
            this.Load += new System.EventHandler(this.frmRecordAppointmentDetails_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            this.grpAppointmentDetails.ResumeLayout(false);
            this.grpAppointmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.Label lblReasonForVisit;
        private System.Windows.Forms.TextBox txtReasonForVisit;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.GroupBox grpAppointmentDetails;
        private System.Windows.Forms.TextBox txtResultOfVist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.Label lblMedicalCard;
        private System.Windows.Forms.ComboBox cboAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPatientAge;
    }
}