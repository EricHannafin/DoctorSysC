namespace DoctorSYS
{
    partial class frmQueryPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSurnameSearch = new System.Windows.Forms.Label();
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuRegisterPatient = new System.Windows.Forms.MenuStrip();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.grdApps = new System.Windows.Forms.DataGridView();
            this.txtMedicalCard = new System.Windows.Forms.TextBox();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMedicalCard = new System.Windows.Forms.Label();
            this.lblPPSN = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.mnuRegisterPatient.SuspendLayout();
            this.grpPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurnameSearch
            // 
            this.lblSurnameSearch.AutoSize = true;
            this.lblSurnameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurnameSearch.Location = new System.Drawing.Point(21, 34);
            this.lblSurnameSearch.Name = "lblSurnameSearch";
            this.lblSurnameSearch.Size = new System.Drawing.Size(56, 13);
            this.lblSurnameSearch.TabIndex = 5;
            this.lblSurnameSearch.Text = "Surname";
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(109, 34);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSurnameSearch.TabIndex = 7;
            this.txtSurnameSearch.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(608, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Location = new System.Drawing.Point(24, 101);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.Size = new System.Drawing.Size(739, 152);
            this.grdPatients.TabIndex = 25;
            this.grdPatients.Visible = false;
            this.grdPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellClick);
            this.grdPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(564, 214);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 39);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterPatient.TabIndex = 27;
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
            // grpPatientDetails
            // 
            this.grpPatientDetails.Controls.Add(this.grdApps);
            this.grpPatientDetails.Controls.Add(this.txtMedicalCard);
            this.grpPatientDetails.Controls.Add(this.lblAppointments);
            this.grpPatientDetails.Controls.Add(this.txtStatus);
            this.grpPatientDetails.Controls.Add(this.label1);
            this.grpPatientDetails.Controls.Add(this.btnPrint);
            this.grpPatientDetails.Controls.Add(this.txtPPSN);
            this.grpPatientDetails.Controls.Add(this.txtEircode);
            this.grpPatientDetails.Controls.Add(this.txtTown);
            this.grpPatientDetails.Controls.Add(this.txtStreet);
            this.grpPatientDetails.Controls.Add(this.txtPhoneNumber);
            this.grpPatientDetails.Controls.Add(this.txtSurname);
            this.grpPatientDetails.Controls.Add(this.txtFirstName);
            this.grpPatientDetails.Controls.Add(this.txtPatientId);
            this.grpPatientDetails.Controls.Add(this.lblId);
            this.grpPatientDetails.Controls.Add(this.lblMedicalCard);
            this.grpPatientDetails.Controls.Add(this.lblPPSN);
            this.grpPatientDetails.Controls.Add(this.lblEircode);
            this.grpPatientDetails.Controls.Add(this.lblTown);
            this.grpPatientDetails.Controls.Add(this.lblStreet);
            this.grpPatientDetails.Controls.Add(this.lblTelephoneNumber);
            this.grpPatientDetails.Controls.Add(this.dtpDateOfBirth);
            this.grpPatientDetails.Controls.Add(this.lblDateOfBirth);
            this.grpPatientDetails.Controls.Add(this.lblSurnameUpdate);
            this.grpPatientDetails.Controls.Add(this.lblFirstNameUpdate);
            this.grpPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientDetails.Location = new System.Drawing.Point(24, 283);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(744, 332);
            this.grpPatientDetails.TabIndex = 51;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details";
            this.grpPatientDetails.Visible = false;
            this.grpPatientDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter_1);
            // 
            // grdApps
            // 
            this.grdApps.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdApps.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdApps.Location = new System.Drawing.Point(122, 198);
            this.grdApps.Name = "grdApps";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdApps.Size = new System.Drawing.Size(399, 128);
            this.grdApps.TabIndex = 63;
            // 
            // txtMedicalCard
            // 
            this.txtMedicalCard.Location = new System.Drawing.Point(575, 120);
            this.txtMedicalCard.Name = "txtMedicalCard";
            this.txtMedicalCard.ReadOnly = true;
            this.txtMedicalCard.Size = new System.Drawing.Size(70, 20);
            this.txtMedicalCard.TabIndex = 62;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAppointments.Location = new System.Drawing.Point(8, 198);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(83, 13);
            this.lblAppointments.TabIndex = 60;
            this.lblAppointments.Text = "Appointments";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(575, 153);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(19, 20);
            this.txtStatus.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(460, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Status";
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(575, 83);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.ReadOnly = true;
            this.txtPPSN.Size = new System.Drawing.Size(70, 20);
            this.txtPPSN.TabIndex = 54;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(575, 51);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(70, 20);
            this.txtEircode.TabIndex = 53;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(575, 16);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(133, 20);
            this.txtTown.TabIndex = 52;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(128, 172);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(318, 20);
            this.txtStreet.TabIndex = 51;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(128, 146);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(133, 20);
            this.txtPhoneNumber.TabIndex = 50;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(128, 83);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(133, 20);
            this.txtSurname.TabIndex = 49;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 48;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(128, 19);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(43, 20);
            this.txtPatientId.TabIndex = 47;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblId.Location = new System.Drawing.Point(8, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "PatientId";
            // 
            // lblMedicalCard
            // 
            this.lblMedicalCard.AutoSize = true;
            this.lblMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalCard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMedicalCard.Location = new System.Drawing.Point(460, 127);
            this.lblMedicalCard.Name = "lblMedicalCard";
            this.lblMedicalCard.Size = new System.Drawing.Size(110, 13);
            this.lblMedicalCard.TabIndex = 39;
            this.lblMedicalCard.Text = "Medical Card Num";
            // 
            // lblPPSN
            // 
            this.lblPPSN.AutoSize = true;
            this.lblPPSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPSN.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPPSN.Location = new System.Drawing.Point(460, 90);
            this.lblPPSN.Name = "lblPPSN";
            this.lblPPSN.Size = new System.Drawing.Size(40, 13);
            this.lblPPSN.TabIndex = 37;
            this.lblPPSN.Text = "PPSN";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEircode.Location = new System.Drawing.Point(460, 51);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(50, 13);
            this.lblEircode.TabIndex = 35;
            this.lblEircode.Text = "Eircode";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTown.Location = new System.Drawing.Point(460, 16);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(38, 13);
            this.lblTown.TabIndex = 33;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblStreet.Location = new System.Drawing.Point(8, 175);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(41, 13);
            this.lblStreet.TabIndex = 31;
            this.lblStreet.Text = "Street";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneNumber.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(8, 146);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(114, 13);
            this.lblTelephoneNumber.TabIndex = 29;
            this.lblTelephoneNumber.Text = "Telephone Number";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(128, 114);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 28;
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateOfBirth.Location = new System.Drawing.Point(10, 114);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(79, 13);
            this.lblDateOfBirth.TabIndex = 27;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameUpdate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(10, 83);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(56, 13);
            this.lblSurnameUpdate.TabIndex = 25;
            this.lblSurnameUpdate.Text = "Surname";
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameUpdate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(10, 51);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblFirstNameUpdate.TabIndex = 23;
            this.lblFirstNameUpdate.Text = "First Name";
            // 
            // frmQueryPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSurnameSearch);
            this.Controls.Add(this.lblSurnameSearch);
            this.Name = "frmQueryPatient";
            this.Text = "DoctorSYS-QueryPatient";
            this.Load += new System.EventHandler(this.frmQueryPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSurnameSearch;
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMedicalCard;
        private System.Windows.Forms.Label lblPPSN;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.TextBox txtMedicalCard;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.DataGridView grdApps;
        private System.Windows.Forms.Label lblAppointments;
    }
}