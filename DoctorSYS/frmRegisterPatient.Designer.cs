namespace DoctorSYS
{
    partial class frmRegisterPatient
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblPPSN = new System.Windows.Forms.Label();
            this.lblMedicalCard = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpRegisterPatient = new System.Windows.Forms.GroupBox();
            this.txtMedicalCard = new System.Windows.Forms.TextBox();
            this.txtPPSN = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.mnuRegisterPatient.SuspendLayout();
            this.grpRegisterPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterPatient.TabIndex = 0;
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
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFirstName.Location = new System.Drawing.Point(22, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurname.Location = new System.Drawing.Point(22, 138);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(160, 131);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(133, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateOfBirth.Location = new System.Drawing.Point(22, 181);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(79, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(160, 174);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneNumber.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(22, 236);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(114, 13);
            this.lblTelephoneNumber.TabIndex = 7;
            this.lblTelephoneNumber.Text = "Telephone Number";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(160, 229);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(133, 20);
            this.txtTelephoneNumber.TabIndex = 8;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblStreet.Location = new System.Drawing.Point(22, 282);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(41, 13);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(160, 275);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(318, 20);
            this.txtStreet.TabIndex = 10;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTown.Location = new System.Drawing.Point(474, 47);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(38, 13);
            this.lblTown.TabIndex = 11;
            this.lblTown.Text = "Town";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEircode.Location = new System.Drawing.Point(474, 94);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(50, 13);
            this.lblEircode.TabIndex = 13;
            this.lblEircode.Text = "Eircode";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(592, 94);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(70, 20);
            this.txtEircode.TabIndex = 14;
            // 
            // lblPPSN
            // 
            this.lblPPSN.AutoSize = true;
            this.lblPPSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPSN.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPPSN.Location = new System.Drawing.Point(474, 138);
            this.lblPPSN.Name = "lblPPSN";
            this.lblPPSN.Size = new System.Drawing.Size(40, 13);
            this.lblPPSN.TabIndex = 15;
            this.lblPPSN.Text = "PPSN";
            this.lblPPSN.Click += new System.EventHandler(this.lblPPSN_Click);
            // 
            // lblMedicalCard
            // 
            this.lblMedicalCard.AutoSize = true;
            this.lblMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalCard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMedicalCard.Location = new System.Drawing.Point(474, 181);
            this.lblMedicalCard.Name = "lblMedicalCard";
            this.lblMedicalCard.Size = new System.Drawing.Size(110, 13);
            this.lblMedicalCard.TabIndex = 17;
            this.lblMedicalCard.Text = "Medical Card Num";
            this.lblMedicalCard.Click += new System.EventHandler(this.lblMedicalCard_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.Location = new System.Drawing.Point(518, 256);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(181, 58);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register Patient";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpRegisterPatient
            // 
            this.grpRegisterPatient.Controls.Add(this.txtMedicalCard);
            this.grpRegisterPatient.Controls.Add(this.txtPPSN);
            this.grpRegisterPatient.Controls.Add(this.txtTown);
            this.grpRegisterPatient.Controls.Add(this.txtPatientId);
            this.grpRegisterPatient.Controls.Add(this.lblId);
            this.grpRegisterPatient.Controls.Add(this.btnRegister);
            this.grpRegisterPatient.Controls.Add(this.lblMedicalCard);
            this.grpRegisterPatient.Controls.Add(this.lblPPSN);
            this.grpRegisterPatient.Controls.Add(this.txtEircode);
            this.grpRegisterPatient.Controls.Add(this.lblEircode);
            this.grpRegisterPatient.Controls.Add(this.lblTown);
            this.grpRegisterPatient.Controls.Add(this.txtStreet);
            this.grpRegisterPatient.Controls.Add(this.lblStreet);
            this.grpRegisterPatient.Controls.Add(this.txtTelephoneNumber);
            this.grpRegisterPatient.Controls.Add(this.lblTelephoneNumber);
            this.grpRegisterPatient.Controls.Add(this.dtpDateOfBirth);
            this.grpRegisterPatient.Controls.Add(this.lblDateOfBirth);
            this.grpRegisterPatient.Controls.Add(this.txtSurname);
            this.grpRegisterPatient.Controls.Add(this.lblSurname);
            this.grpRegisterPatient.Controls.Add(this.txtFirstName);
            this.grpRegisterPatient.Controls.Add(this.lblFirstName);
            this.grpRegisterPatient.Location = new System.Drawing.Point(22, 46);
            this.grpRegisterPatient.Name = "grpRegisterPatient";
            this.grpRegisterPatient.Size = new System.Drawing.Size(751, 364);
            this.grpRegisterPatient.TabIndex = 21;
            this.grpRegisterPatient.TabStop = false;
            this.grpRegisterPatient.Text = "Enter Patient Details";
            this.grpRegisterPatient.Enter += new System.EventHandler(this.grpRegisterPatient_Enter);
            // 
            // txtMedicalCard
            // 
            this.txtMedicalCard.Location = new System.Drawing.Point(592, 181);
            this.txtMedicalCard.Name = "txtMedicalCard";
            this.txtMedicalCard.Size = new System.Drawing.Size(70, 20);
            this.txtMedicalCard.TabIndex = 26;
            // 
            // txtPPSN
            // 
            this.txtPPSN.Location = new System.Drawing.Point(592, 138);
            this.txtPPSN.Name = "txtPPSN";
            this.txtPPSN.Size = new System.Drawing.Size(70, 20);
            this.txtPPSN.TabIndex = 25;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(592, 44);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(133, 20);
            this.txtTown.TabIndex = 24;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(160, 47);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(43, 20);
            this.txtPatientId.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblId.Location = new System.Drawing.Point(22, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "PatientId";
            // 
            // frmRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRegisterPatient);
            this.Controls.Add(this.mnuRegisterPatient);
            this.MainMenuStrip = this.mnuRegisterPatient;
            this.Name = "frmRegisterPatient";
            this.Text = "RegisterPatient";
            this.Load += new System.EventHandler(this.frmRegisterPatient_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            this.grpRegisterPatient.ResumeLayout(false);
            this.grpRegisterPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblPPSN;
        private System.Windows.Forms.Label lblMedicalCard;
        private System.Windows.Forms.Button btnRegister;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpRegisterPatient;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPPSN;
        private System.Windows.Forms.TextBox txtMedicalCard;
    }
}