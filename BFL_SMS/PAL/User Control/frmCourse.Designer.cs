
namespace BFL_SMS.PAL.User_Control
{
    partial class frmCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DVG_CourseShow = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoursPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCoSave = new System.Windows.Forms.Button();
            this.btnCoEdit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_CourseShow)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 78);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnCoSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCoEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 683);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DVG_CourseShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(497, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 683);
            this.panel2.TabIndex = 2;
            // 
            // DVG_CourseShow
            // 
            this.DVG_CourseShow.AllowUserToAddRows = false;
            this.DVG_CourseShow.AllowUserToDeleteRows = false;
            this.DVG_CourseShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG_CourseShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DVG_CourseShow.ColumnHeadersHeight = 40;
            this.DVG_CourseShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DVG_CourseShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DVG_CourseShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVG_CourseShow.Location = new System.Drawing.Point(0, 0);
            this.DVG_CourseShow.Name = "DVG_CourseShow";
            this.DVG_CourseShow.ReadOnly = true;
            this.DVG_CourseShow.RowHeadersWidth = 40;
            this.DVG_CourseShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DVG_CourseShow.RowTemplate.Height = 40;
            this.DVG_CourseShow.Size = new System.Drawing.Size(729, 683);
            this.DVG_CourseShow.TabIndex = 0;
            this.DVG_CourseShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_CourseShow_CellClick);
            this.DVG_CourseShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_CourseShow_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCoursPrice);
            this.panel3.Controls.Add(this.txtCourseName);
            this.panel3.Controls.Add(this.txtCourseID);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 289);
            this.panel3.TabIndex = 0;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(170, 71);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(291, 42);
            this.txtCourseID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "អត្តលេខវគ្គសិក្សាៈ";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(170, 137);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(291, 42);
            this.txtCourseName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(78, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "វគ្គសិក្សាៈ";
            // 
            // txtCoursPrice
            // 
            this.txtCoursPrice.Location = new System.Drawing.Point(170, 213);
            this.txtCoursPrice.Name = "txtCoursPrice";
            this.txtCoursPrice.Size = new System.Drawing.Size(291, 42);
            this.txtCoursPrice.TabIndex = 0;
            this.txtCoursPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(46, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "តម្លៃវគ្គសិក្សាៈ";
            // 
            // btnCoSave
            // 
            this.btnCoSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoSave.Location = new System.Drawing.Point(3, 298);
            this.btnCoSave.Name = "btnCoSave";
            this.btnCoSave.Size = new System.Drawing.Size(164, 46);
            this.btnCoSave.TabIndex = 1;
            this.btnCoSave.Text = "រក្សាទុក";
            this.btnCoSave.UseVisualStyleBackColor = true;
            this.btnCoSave.Click += new System.EventHandler(this.btnCoSave_Click);
            // 
            // btnCoEdit
            // 
            this.btnCoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoEdit.Location = new System.Drawing.Point(173, 298);
            this.btnCoEdit.Name = "btnCoEdit";
            this.btnCoEdit.Size = new System.Drawing.Size(197, 46);
            this.btnCoEdit.TabIndex = 2;
            this.btnCoEdit.Text = "កែប្រែទិន្នន័យ";
            this.btnCoEdit.UseVisualStyleBackColor = true;
            this.btnCoEdit.Click += new System.EventHandler(this.btnCoEdit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "COID";
            this.Column1.HeaderText = "អត្តលេខវគ្គសិក្សា";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CO_NAME";
            this.Column2.HeaderText = "វគ្គសិក្សា";
            this.Column2.MinimumWidth = 250;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CO_PRICE";
            this.Column3.HeaderText = "តម្លៃ";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(376, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "សម្អាត";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Khmer OS Muol Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1226, 72);
            this.label4.TabIndex = 0;
            this.label4.Text = "គ្រប់គ្រងវគ្គសិក្សា";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmCourse";
            this.Size = new System.Drawing.Size(1226, 761);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVG_CourseShow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DVG_CourseShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoursPrice;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnCoSave;
        private System.Windows.Forms.Button btnCoEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
    }
}
