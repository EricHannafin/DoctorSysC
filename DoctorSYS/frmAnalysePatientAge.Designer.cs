namespace DoctorSYS
{
    partial class frmAnalysePatientAge
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuRegisterPatient = new System.Windows.Forms.MenuStrip();
            this.mnsBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.chtAverageAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuRegisterPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAverageAge)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsBack});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(823, 24);
            this.mnuRegisterPatient.TabIndex = 28;
            this.mnuRegisterPatient.Text = "menuStrip1";
            // 
            // mnsBack
            // 
            this.mnsBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsBack.Name = "mnsBack";
            this.mnsBack.Size = new System.Drawing.Size(44, 20);
            this.mnsBack.Text = "Back";
            this.mnsBack.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(106, 40);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 21);
            this.cboTime.TabIndex = 61;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblYear.Location = new System.Drawing.Point(49, 43);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 13);
            this.lblYear.TabIndex = 60;
            this.lblYear.Text = "Year";
            // 
            // chtAverageAge
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAverageAge.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAverageAge.Legends.Add(legend1);
            this.chtAverageAge.Location = new System.Drawing.Point(43, 88);
            this.chtAverageAge.Name = "chtAverageAge";
            this.chtAverageAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAverageAge.Series.Add(series1);
            this.chtAverageAge.Size = new System.Drawing.Size(741, 272);
            this.chtAverageAge.TabIndex = 62;
            this.chtAverageAge.Visible = false;
            this.chtAverageAge.Click += new System.EventHandler(this.chtAnalyseRevenue_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(629, 400);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 39);
            this.btnPrint.TabIndex = 63;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // frmAnalysePatientAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 478);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chtAverageAge);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Name = "frmAnalysePatientAge";
            this.Text = "DoctorSYS-AnalysePatientAge";
            this.Load += new System.EventHandler(this.frmAnalysePatientAge_Load);
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAverageAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsBack;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAverageAge;
        private System.Windows.Forms.Button btnPrint;
    }
}