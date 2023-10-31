
namespace BFL_SMS.PAL.Forms
{
    partial class frmPrinIvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinIvoice));
            this.CR_InvoicePrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CR_InvoicePrint
            // 
            this.CR_InvoicePrint.ActiveViewIndex = -1;
            this.CR_InvoicePrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR_InvoicePrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_InvoicePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CR_InvoicePrint.Location = new System.Drawing.Point(0, 0);
            this.CR_InvoicePrint.Name = "CR_InvoicePrint";
            this.CR_InvoicePrint.ShowCloseButton = false;
            this.CR_InvoicePrint.ShowCopyButton = false;
            this.CR_InvoicePrint.ShowGroupTreeButton = false;
            this.CR_InvoicePrint.ShowLogo = false;
            this.CR_InvoicePrint.ShowParameterPanelButton = false;
            this.CR_InvoicePrint.ShowTextSearchButton = false;
            this.CR_InvoicePrint.Size = new System.Drawing.Size(1000, 895);
            this.CR_InvoicePrint.TabIndex = 0;
            this.CR_InvoicePrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPrinIvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 895);
            this.Controls.Add(this.CR_InvoicePrint);
            this.Font = new System.Drawing.Font("Khmer OS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrinIvoice";
            this.Text = "ចេញវិក្កយបត្រ";
            this.Load += new System.EventHandler(this.frmPrinIvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_InvoicePrint;
    }
}