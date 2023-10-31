
namespace BFL_SMS.PAL.User_Control
{
    partial class frmReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYearReport = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnDialyReport = new System.Windows.Forms.Button();
            this.dtTodate = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRV_INCOME = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtFromYear = new System.Windows.Forms.DateTimePicker();
            this.dtToYear = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnYearReport);
            this.panel2.Controls.Add(this.btnMonthly);
            this.panel2.Controls.Add(this.btnDialyReport);
            this.panel2.Controls.Add(this.dtTodate);
            this.panel2.Controls.Add(this.dtToYear);
            this.panel2.Controls.Add(this.dtFromYear);
            this.panel2.Controls.Add(this.dtFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 764);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "មកដល់ថ្ងៃទី៖";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ក្នុងថ្ងៃទី៖";
            // 
            // btnYearReport
            // 
            this.btnYearReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYearReport.Image = global::BFL_SMS.Properties.Resources.plus_1_year_48px;
            this.btnYearReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearReport.Location = new System.Drawing.Point(3, 349);
            this.btnYearReport.Name = "btnYearReport";
            this.btnYearReport.Size = new System.Drawing.Size(231, 50);
            this.btnYearReport.TabIndex = 0;
            this.btnYearReport.Text = "ចំណូលប្រចាំឆ្នាំ";
            this.btnYearReport.UseVisualStyleBackColor = false;
            this.btnYearReport.Click += new System.EventHandler(this.btnYearReport_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMonthly.Image = global::BFL_SMS.Properties.Resources.calendar_1_48px;
            this.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthly.Location = new System.Drawing.Point(3, 293);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(231, 50);
            this.btnMonthly.TabIndex = 0;
            this.btnMonthly.Text = "ចំណូលប្រចាំខែ";
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnDialyReport
            // 
            this.btnDialyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDialyReport.Image = global::BFL_SMS.Properties.Resources.minus_1_day_48px;
            this.btnDialyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDialyReport.Location = new System.Drawing.Point(3, 237);
            this.btnDialyReport.Name = "btnDialyReport";
            this.btnDialyReport.Size = new System.Drawing.Size(231, 50);
            this.btnDialyReport.TabIndex = 0;
            this.btnDialyReport.Text = "ចំណូលប្រចាំថ្ងៃ";
            this.btnDialyReport.UseVisualStyleBackColor = false;
            this.btnDialyReport.Click += new System.EventHandler(this.btnDialyReport_Click);
            // 
            // dtTodate
            // 
            this.dtTodate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtTodate.CustomFormat = "yyyy-MM-dd";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(16, 154);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(199, 45);
            this.dtTodate.TabIndex = 156;
            // 
            // dtFrom
            // 
            this.dtFrom.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(16, 58);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(199, 45);
            this.dtFrom.TabIndex = 156;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CRV_INCOME);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(236, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 764);
            this.panel3.TabIndex = 2;
            // 
            // CRV_INCOME
            // 
            this.CRV_INCOME.ActiveViewIndex = -1;
            this.CRV_INCOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_INCOME.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_INCOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_INCOME.Location = new System.Drawing.Point(0, 0);
            this.CRV_INCOME.Name = "CRV_INCOME";
            this.CRV_INCOME.ShowCloseButton = false;
            this.CRV_INCOME.ShowCopyButton = false;
            this.CRV_INCOME.ShowExportButton = false;
            this.CRV_INCOME.ShowGroupTreeButton = false;
            this.CRV_INCOME.ShowLogo = false;
            this.CRV_INCOME.ShowPageNavigateButtons = false;
            this.CRV_INCOME.ShowParameterPanelButton = false;
            this.CRV_INCOME.ShowTextSearchButton = false;
            this.CRV_INCOME.Size = new System.Drawing.Size(958, 764);
            this.CRV_INCOME.TabIndex = 0;
            this.CRV_INCOME.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtFromYear
            // 
            this.dtFromYear.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtFromYear.CustomFormat = "yyyy";
            this.dtFromYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromYear.Location = new System.Drawing.Point(3, 405);
            this.dtFromYear.Name = "dtFromYear";
            this.dtFromYear.Size = new System.Drawing.Size(76, 45);
            this.dtFromYear.TabIndex = 156;
            // 
            // dtToYear
            // 
            this.dtToYear.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtToYear.CustomFormat = "yyyy";
            this.dtToYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToYear.Location = new System.Drawing.Point(152, 405);
            this.dtToYear.Name = "dtToYear";
            this.dtToYear.Size = new System.Drawing.Size(78, 45);
            this.dtToYear.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 36);
            this.label3.TabIndex = 157;
            this.label3.Text = "ដល់ឆ្នាំ";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmReport";
            this.Size = new System.Drawing.Size(1194, 764);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_INCOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYearReport;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnDialyReport;
        public System.Windows.Forms.DateTimePicker dtTodate;
        public System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtToYear;
        public System.Windows.Forms.DateTimePicker dtFromYear;
    }
}
