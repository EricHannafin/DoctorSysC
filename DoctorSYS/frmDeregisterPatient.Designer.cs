namespace DoctorSYS
{
    partial class frmDeregisterPatient
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
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mnuRegisterPatient = new System.Windows.Forms.MenuStrip();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSurnameSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.txtMedicalCard = new System.Windows.Forms.TextBox();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDeregister = new System.Windows.Forms.Button();
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
            this.mnuRegisterPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.grpPatientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(150, 40);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSurnameSearch.TabIndex = 8;
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterPatient.TabIndex = 28;
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
            this.lblSurnameSearch.Location = new System.Drawing.Point(30, 40);
            this.lblSurnameSearch.Name = "lblSurnameSearch";
            this.lblSurnameSearch.Size = new System.Drawing.Size(56, 13);
            this.lblSurnameSearch.TabIndex = 48;
            this.lblSurnameSearch.Text = "Surname";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(601, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Location = new System.Drawing.Point(33, 110);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.Size = new System.Drawing.Size(723, 150);
            this.grdPatients.TabIndex = 51;
            this.grdPatients.Visible = false;
            this.grdPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellClick);
            this.grdPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellClick);
            // 
            // grpPatientDetails
            // 
            this.grpPatientDetails.Controls.Add(this.txtMedicalCard);
            this.grpPatientDetails.Controls.Add(this.txtPPSN);
            this.grpPatientDetails.Controls.Add(this.txtEircode);
            this.grpPatientDetails.Controls.Add(this.txtTown);
            this.grpPatientDetails.Controls.Add(this.txtStreet);
            this.grpPatientDetails.Controls.Add(this.txtPhoneNumber);
            this.grpPatientDetails.Controls.Add(this.txtSurname);
            this.grpPatientDetails.Controls.Add(this.txtPatientId);
            this.grpPatientDetails.Controls.Add(this.txtFirstName);
            this.grpPatientDetails.Controls.Add(this.lblId);
            this.grpPatientDetails.Controls.Add(this.btnDeregister);
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
            this.grpPatientDetails.Location = new System.Drawing.Point(33, 305);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(744, 241);
            this.grpPatientDetails.TabIndex = 52;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details";
            this.grpPatientDetails.Visible = false;
            this.grpPatientDetails.Enter += new System.EventHandler(this.grpPatientDetails_Enter_1);
            // 
            // txtMedicalCard
            // 
            this.txtMedicalCard.Location = new System.Drawing.Point(582, 113);
            this.txtMedicalCard.Name = "txtMedicalCard";
            this.txtMedicalCard.Size = new System.Drawing.Size(70, 20);
            this.txtMedicalCard.TabIndex = 55;
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(582, 76);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(70, 20);
            this.txtPPSN.TabIndex = 52;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(582, 44);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(70, 20);
            this.txtEircode.TabIndex = 51;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(582, 13);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(133, 20);
            this.txtTown.TabIndex = 50;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(128, 194);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(318, 20);
            this.txtStreet.TabIndex = 49;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(128, 159);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(133, 20);
            this.txtPhoneNumber.TabIndex = 48;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtTelephoneNumber_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(128, 93);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(133, 20);
            this.txtSurname.TabIndex = 47;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(128, 30);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(43, 20);
            this.txtPatientId.TabIndex = 46;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 45;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblId.Location = new System.Drawing.Point(8, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "PatientId";
            // 
            // btnDeregister
            // 
            this.btnDeregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeregister.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeregister.Location = new System.Drawing.Point(564, 171);
            this.btnDeregister.Name = "btnDeregister";
            this.btnDeregister.Size = new System.Drawing.Size(155, 39);
            this.btnDeregister.TabIndex = 42;
            this.btnDeregister.Text = "Deregister";
            this.btnDeregister.UseVisualStyleBackColor = true;
            this.btnDeregister.Click += new System.EventHandler(this.btnDeregister_Click_2);
            // 
            // lblMedicalCard
            // 
            this.lblMedicalCard.AutoSize = true;
            this.lblMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalCard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMedicalCard.Location = new System.Drawing.Point(460, 120);
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
            this.lblPPSN.Location = new System.Drawing.Point(460, 83);
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
            this.lblStreet.Location = new System.Drawing.Point(6, 197);
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
            this.lblTelephoneNumber.Location = new System.Drawing.Point(8, 166);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(114, 13);
            this.lblTelephoneNumber.TabIndex = 29;
            this.lblTelephoneNumber.Text = "Telephone Number";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(128, 127);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 28;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateOfBirth.Location = new System.Drawing.Point(8, 134);
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
            this.lblSurnameUpdate.Location = new System.Drawing.Point(8, 100);
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
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(8, 66);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblFirstNameUpdate.TabIndex = 23;
            this.lblFirstNameUpdate.Text = "First Name";
            // 
            // frmDeregisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSurnameSearch);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Controls.Add(this.txtSurnameSearch);
            this.Name = "frmDeregisterPatient";
            this.Text = "DeregisterPatient";
            this.Load += new System.EventHandler(this.frmDeregisterPatient_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblSurnameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDeregister;
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
    }
}