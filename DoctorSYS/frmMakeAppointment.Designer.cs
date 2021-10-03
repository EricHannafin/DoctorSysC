namespace DoctorSYS
{
    partial class FrmMakeAppointment
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
            this.lblSurnameSearch = new System.Windows.Forms.Label();
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRegisterPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.grpPatientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(804, 24);
            this.mnuRegisterPatient.TabIndex = 29;
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
            // lblSurnameSearch
            // 
            this.lblSurnameSearch.AutoSize = true;
            this.lblSurnameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurnameSearch.Location = new System.Drawing.Point(23, 35);
            this.lblSurnameSearch.Name = "lblSurnameSearch";
            this.lblSurnameSearch.Size = new System.Drawing.Size(56, 13);
            this.lblSurnameSearch.TabIndex = 30;
            this.lblSurnameSearch.Text = "Surname";
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(114, 35);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSurnameSearch.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(598, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Location = new System.Drawing.Point(14, 102);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.Size = new System.Drawing.Size(739, 152);
            this.grdPatients.TabIndex = 33;
            this.grdPatients.Visible = false;
            this.grdPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellClick);
            // 
            // grpPatientDetails
            // 
            this.grpPatientDetails.Controls.Add(this.dtpDate);
            this.grpPatientDetails.Controls.Add(this.cboTime);
            this.grpPatientDetails.Controls.Add(this.lblTime);
            this.grpPatientDetails.Controls.Add(this.txtAppointmentId);
            this.grpPatientDetails.Controls.Add(this.lblAppointmentId);
            this.grpPatientDetails.Controls.Add(this.txtPatientId);
            this.grpPatientDetails.Controls.Add(this.lblId);
            this.grpPatientDetails.Controls.Add(this.btnConfirm);
            this.grpPatientDetails.Controls.Add(this.lblDate);
            this.grpPatientDetails.Controls.Add(this.menuStrip1);
            this.grpPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientDetails.Location = new System.Drawing.Point(26, 292);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(744, 166);
            this.grpPatientDetails.TabIndex = 44;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Appointment Details";
            this.grpPatientDetails.Visible = false;
            this.grpPatientDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(128, 89);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 59;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(128, 130);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 21);
            this.cboTime.TabIndex = 58;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime.Location = new System.Drawing.Point(10, 130);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 56;
            this.lblTime.Text = "Time";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(128, 30);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.ReadOnly = true;
            this.txtAppointmentId.Size = new System.Drawing.Size(43, 20);
            this.txtAppointmentId.TabIndex = 55;
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.AutoSize = true;
            this.lblAppointmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAppointmentId.Location = new System.Drawing.Point(10, 30);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(92, 13);
            this.lblAppointmentId.TabIndex = 54;
            this.lblAppointmentId.Text = "Appointment Id";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(128, 61);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(43, 20);
            this.txtPatientId.TabIndex = 46;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblId.Location = new System.Drawing.Point(10, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "PatientId";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.Location = new System.Drawing.Point(513, 104);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(155, 39);
            this.btnConfirm.TabIndex = 42;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDate.Location = new System.Drawing.Point(10, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 583);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSurnameSearch);
            this.Controls.Add(this.lblSurnameSearch);
            this.Controls.Add(this.mnuRegisterPatient);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMakeAppointment";
            this.Text = "DoctorSYS-MakeAppointment";
            this.Load += new System.EventHandler(this.FrmMakeAppointment_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblSurnameSearch;
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}