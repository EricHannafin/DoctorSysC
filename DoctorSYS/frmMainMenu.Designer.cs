namespace DoctorSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnsPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRegisterPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsUpdatePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDeregisterPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQueryPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMakeAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCancelAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRecordAppointmentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAnalyseRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAnalysePatientAge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(30, 54);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(747, 365);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsPatients,
            this.mnsAppointments,
            this.mnsAdmin,
            this.mnsExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(807, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            this.mnuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMainMenu_ItemClicked);
            // 
            // mnsPatients
            // 
            this.mnsPatients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsRegisterPatient,
            this.mnsUpdatePatient,
            this.mnsDeregisterPatient,
            this.mnsQueryPatient});
            this.mnsPatients.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsPatients.Name = "mnsPatients";
            this.mnsPatients.Size = new System.Drawing.Size(62, 20);
            this.mnsPatients.Text = "Patients";
            this.mnsPatients.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // mnsRegisterPatient
            // 
            this.mnsRegisterPatient.Name = "mnsRegisterPatient";
            this.mnsRegisterPatient.Size = new System.Drawing.Size(171, 22);
            this.mnsRegisterPatient.Text = "Register Patient";
            this.mnsRegisterPatient.Click += new System.EventHandler(this.mnsRegisterPatient_Click);
            // 
            // mnsUpdatePatient
            // 
            this.mnsUpdatePatient.Name = "mnsUpdatePatient";
            this.mnsUpdatePatient.Size = new System.Drawing.Size(171, 22);
            this.mnsUpdatePatient.Text = "Update Patient";
            this.mnsUpdatePatient.Click += new System.EventHandler(this.mnsUpdatePatient_Click);
            // 
            // mnsDeregisterPatient
            // 
            this.mnsDeregisterPatient.Name = "mnsDeregisterPatient";
            this.mnsDeregisterPatient.Size = new System.Drawing.Size(171, 22);
            this.mnsDeregisterPatient.Text = "Deregister Patient";
            this.mnsDeregisterPatient.Click += new System.EventHandler(this.mnsDeregisterPatient_Click);
            // 
            // mnsQueryPatient
            // 
            this.mnsQueryPatient.Name = "mnsQueryPatient";
            this.mnsQueryPatient.Size = new System.Drawing.Size(171, 22);
            this.mnsQueryPatient.Text = "Query Patient";
            this.mnsQueryPatient.Click += new System.EventHandler(this.mnsQueryPatient_Click);
            // 
            // mnsAppointments
            // 
            this.mnsAppointments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMakeAppointment,
            this.mnsCancelAppointment,
            this.mnsRecordAppointmentDetails});
            this.mnsAppointments.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsAppointments.Name = "mnsAppointments";
            this.mnsAppointments.Size = new System.Drawing.Size(92, 20);
            this.mnsAppointments.Text = "Appointments";
            // 
            // mnsMakeAppointment
            // 
            this.mnsMakeAppointment.Name = "mnsMakeAppointment";
            this.mnsMakeAppointment.Size = new System.Drawing.Size(221, 22);
            this.mnsMakeAppointment.Text = "Make Appointment";
            this.mnsMakeAppointment.Click += new System.EventHandler(this.mnsMakeAppointment_Click);
            // 
            // mnsCancelAppointment
            // 
            this.mnsCancelAppointment.Name = "mnsCancelAppointment";
            this.mnsCancelAppointment.Size = new System.Drawing.Size(221, 22);
            this.mnsCancelAppointment.Text = "Cancel Appointment";
            this.mnsCancelAppointment.Click += new System.EventHandler(this.mnsCancelAppointment_Click);
            // 
            // mnsRecordAppointmentDetails
            // 
            this.mnsRecordAppointmentDetails.Name = "mnsRecordAppointmentDetails";
            this.mnsRecordAppointmentDetails.Size = new System.Drawing.Size(221, 22);
            this.mnsRecordAppointmentDetails.Text = "Record Appointment Details";
            this.mnsRecordAppointmentDetails.Click += new System.EventHandler(this.mnsRecordAppointmentDetails_Click);
            // 
            // mnsAdmin
            // 
            this.mnsAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAnalyseRevenue,
            this.mnsAnalysePatientAge});
            this.mnsAdmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsAdmin.Name = "mnsAdmin";
            this.mnsAdmin.Size = new System.Drawing.Size(54, 20);
            this.mnsAdmin.Text = "Admin";
            // 
            // mnsAnalyseRevenue
            // 
            this.mnsAnalyseRevenue.Name = "mnsAnalyseRevenue";
            this.mnsAnalyseRevenue.Size = new System.Drawing.Size(180, 22);
            this.mnsAnalyseRevenue.Text = "Analyse Revenue";
            this.mnsAnalyseRevenue.Click += new System.EventHandler(this.analyToolStripMenuItem_Click);
            // 
            // mnsAnalysePatientAge
            // 
            this.mnsAnalysePatientAge.Name = "mnsAnalysePatientAge";
            this.mnsAnalysePatientAge.Size = new System.Drawing.Size(180, 22);
            this.mnsAnalysePatientAge.Text = "Analyse Patient Age";
            this.mnsAnalysePatientAge.Click += new System.EventHandler(this.mnsAnalyseAppointmentType_Click);
            // 
            // mnsExit
            // 
            this.mnsExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(40, 20);
            this.mnsExit.Text = "Exit";
            this.mnsExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnsPatients;
        private System.Windows.Forms.ToolStripMenuItem mnsAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnsAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.ToolStripMenuItem mnsRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsUpdatePatient;
        private System.Windows.Forms.ToolStripMenuItem mnsDeregisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsQueryPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsMakeAppointment;
        private System.Windows.Forms.ToolStripMenuItem mnsCancelAppointment;
        private System.Windows.Forms.ToolStripMenuItem mnsRecordAppointmentDetails;
        private System.Windows.Forms.ToolStripMenuItem mnsAnalyseRevenue;
        private System.Windows.Forms.ToolStripMenuItem mnsAnalysePatientAge;
    }
}

