namespace DoctorSYS
{
    partial class FrmCancelAppointment
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.grpAppDetails = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grdApps = new System.Windows.Forms.DataGridView();
            this.mnuRegisterPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.grpAppDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterPatient.TabIndex = 30;
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
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurname.Location = new System.Drawing.Point(30, 24);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 32;
            this.lblSurname.Text = "Surname";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(598, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(172, 21);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSurnameSearch.TabIndex = 37;
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Location = new System.Drawing.Point(29, 72);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.Size = new System.Drawing.Size(739, 129);
            this.grdPatients.TabIndex = 38;
            this.grdPatients.Visible = false;
            this.grdPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellClick);
            // 
            // grpAppDetails
            // 
            this.grpAppDetails.Controls.Add(this.txtTime);
            this.grpAppDetails.Controls.Add(this.lblTime);
            this.grpAppDetails.Controls.Add(this.txtAppointmentId);
            this.grpAppDetails.Controls.Add(this.lblAppointmentId);
            this.grpAppDetails.Controls.Add(this.txtPatientId);
            this.grpAppDetails.Controls.Add(this.lblPatientId);
            this.grpAppDetails.Controls.Add(this.btnConfirm);
            this.grpAppDetails.Controls.Add(this.dtpDate);
            this.grpAppDetails.Controls.Add(this.lblDate);
            this.grpAppDetails.Controls.Add(this.menuStrip1);
            this.grpAppDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppDetails.Location = new System.Drawing.Point(24, 380);
            this.grpAppDetails.Name = "grpAppDetails";
            this.grpAppDetails.Size = new System.Drawing.Size(744, 166);
            this.grpAppDetails.TabIndex = 45;
            this.grpAppDetails.TabStop = false;
            this.grpAppDetails.Text = "Appointment Details";
            this.grpAppDetails.Visible = false;
            this.grpAppDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(128, 130);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 58;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
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
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPatientId.Location = new System.Drawing.Point(10, 64);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(58, 13);
            this.lblPatientId.TabIndex = 44;
            this.lblPatientId.Text = "PatientId";
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
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(128, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 28;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            // grdApps
            // 
            this.grdApps.AllowUserToAddRows = false;
            this.grdApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdApps.Location = new System.Drawing.Point(29, 224);
            this.grdApps.Name = "grdApps";
            this.grdApps.Size = new System.Drawing.Size(739, 130);
            this.grdApps.TabIndex = 46;
            this.grdApps.Visible = false;
            this.grdApps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdApps_CellClick);
            // 
            // FrmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.grdApps);
            this.Controls.Add(this.grpAppDetails);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.txtSurnameSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Name = "FrmCancelAppointment";
            this.Text = "DoctorSYS-CancelAppointment";
            this.Load += new System.EventHandler(this.FrmCancelAppointment_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.grpAppDetails.ResumeLayout(false);
            this.grpAppDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.GroupBox grpAppDetails;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DataGridView grdApps;
    }
}