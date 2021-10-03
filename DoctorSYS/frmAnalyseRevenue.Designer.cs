namespace DoctorSYS
{
    partial class frmAnalyseRevenue
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
            this.chtAnalyseRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuRegisterPatient = new System.Windows.Forms.MenuStrip();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseRevenue)).BeginInit();
            this.mnuRegisterPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtAnalyseRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnalyseRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnalyseRevenue.Legends.Add(legend1);
            this.chtAnalyseRevenue.Location = new System.Drawing.Point(43, 150);
            this.chtAnalyseRevenue.Name = "chtAnalyseRevenue";
            this.chtAnalyseRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyseRevenue.Series.Add(series1);
            this.chtAnalyseRevenue.Size = new System.Drawing.Size(741, 272);
            this.chtAnalyseRevenue.TabIndex = 37;
            this.chtAnalyseRevenue.Visible = false;
            this.chtAnalyseRevenue.Click += new System.EventHandler(this.chtAnalyseRevenue_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(629, 448);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 39);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuRegisterPatient
            // 
            this.mnuRegisterPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsExit});
            this.mnuRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterPatient.Name = "mnuRegisterPatient";
            this.mnuRegisterPatient.Size = new System.Drawing.Size(827, 24);
            this.mnuRegisterPatient.TabIndex = 42;
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
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblYear.Location = new System.Drawing.Point(72, 48);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 13);
            this.lblYear.TabIndex = 43;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(138, 45);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 21);
            this.cboTime.TabIndex = 59;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // frmAnalyseRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 519);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.mnuRegisterPatient);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chtAnalyseRevenue);
            this.Name = "frmAnalyseRevenue";
            this.Text = "DoctorSYS-AnalyseRevenue";
            this.Load += new System.EventHandler(this.frmAnalyseRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseRevenue)).EndInit();
            this.mnuRegisterPatient.ResumeLayout(false);
            this.mnuRegisterPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyseRevenue;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MenuStrip mnuRegisterPatient;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboTime;
    }
}