
namespace BFL_SMS.PAL.User_Control
{
    partial class UserControlAddStudent
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAddStudent = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtENName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearchStudent = new System.Windows.Forms.TabPage();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.labelCountStudent = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.tabPageUpStudent = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxUpClass = new System.Windows.Forms.ComboBox();
            this.rdUpMale = new System.Windows.Forms.RadioButton();
            this.rdUpFemale = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpStudent_Reg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUpStudentName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtUpStudentID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlAddStudent.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.tabPageUpStudent.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            this.tabControlAddStudent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageSearchStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageUpStudent);
            this.tabControlAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddStudent.Name = "tabControlAddStudent";
            this.tabControlAddStudent.SelectedIndex = 0;
            this.tabControlAddStudent.Size = new System.Drawing.Size(1081, 640);
            this.tabControlAddStudent.TabIndex = 1;
            this.tabControlAddStudent.SelectedIndexChanged += new System.EventHandler(this.tabControlAddStudent_SelectedIndexChanged);
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.Controls.Add(this.groupBox2);
            this.tabPageAddStudent.Controls.Add(this.groupBox1);
            this.tabPageAddStudent.Controls.Add(this.btnAddClass);
            this.tabPageAddStudent.Controls.Add(this.label2);
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(1073, 594);
            this.tabPageAddStudent.TabIndex = 0;
            this.tabPageAddStudent.Text = "បញ្ចូលពត៌មានសិស្សថ្មី";
            this.tabPageAddStudent.UseVisualStyleBackColor = true;
            this.tabPageAddStudent.Enter += new System.EventHandler(this.tabPageAddStudent_Enter);
            this.tabPageAddStudent.Leave += new System.EventHandler(this.tabPageAddStudent_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.comboBoxClass);
            this.groupBox2.Controls.Add(this.rdMale);
            this.groupBox2.Controls.Add(this.rdFemale);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtENName);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(597, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 294);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ឈ្មោះជាអង់គ្លេស";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(18, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 31);
            this.label15.TabIndex = 21;
            this.label15.Text = "Class :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(10, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 2);
            this.panel3.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "--SELECT--"});
            this.comboBoxClass.Location = new System.Drawing.Point(10, 222);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(281, 41);
            this.comboBoxClass.TabIndex = 15;
            this.comboBoxClass.Click += new System.EventHandler(this.comboBoxClass_Click);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(161, 130);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(45, 31);
            this.rdMale.TabIndex = 14;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "M";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(89, 130);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(42, 31);
            this.rdFemale.TabIndex = 13;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "F";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label17.Location = new System.Drawing.Point(16, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 27);
            this.label17.TabIndex = 12;
            this.label17.Text = "Gender :";
            // 
            // txtENName
            // 
            this.txtENName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtENName.Location = new System.Drawing.Point(10, 82);
            this.txtENName.Margin = new System.Windows.Forms.Padding(4);
            this.txtENName.Name = "txtENName";
            this.txtENName.Size = new System.Drawing.Size(251, 34);
            this.txtENName.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(19, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 27);
            this.label18.TabIndex = 9;
            this.label18.Text = "Student Full Name :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(15, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 2);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(218, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 294);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ឈ្មោះជាភាសាខ្មែរ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName.Location = new System.Drawing.Point(7, 172);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(294, 34);
            this.txtStudentName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(16, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "ឈ្មោះសិស្ស :";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Location = new System.Drawing.Point(12, 208);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(289, 2);
            this.panel10.TabIndex = 0;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.Location = new System.Drawing.Point(12, 82);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(289, 34);
            this.txtStudentID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "អត្តលេខសិស្ស :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 2);
            this.panel1.TabIndex = 0;
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAddClass.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Location = new System.Drawing.Point(218, 425);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(103, 42);
            this.btnAddClass.TabIndex = 12;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Student";
            // 
            // tabPageSearchStudent
            // 
            this.tabPageSearchStudent.Controls.Add(this.dataGridViewStudent);
            this.tabPageSearchStudent.Controls.Add(this.label19);
            this.tabPageSearchStudent.Controls.Add(this.labelCountStudent);
            this.tabPageSearchStudent.Controls.Add(this.label16);
            this.tabPageSearchStudent.Controls.Add(this.panel11);
            this.tabPageSearchStudent.Controls.Add(this.comboBoxSearchBy);
            this.tabPageSearchStudent.Controls.Add(this.labelCount);
            this.tabPageSearchStudent.Controls.Add(this.label8);
            this.tabPageSearchStudent.Controls.Add(this.panel5);
            this.tabPageSearchStudent.Controls.Add(this.txtStudentSearch);
            this.tabPageSearchStudent.Controls.Add(this.label7);
            this.tabPageSearchStudent.Controls.Add(this.pictureBoxSearch);
            this.tabPageSearchStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabPageSearchStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchStudent.Name = "tabPageSearchStudent";
            this.tabPageSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchStudent.Size = new System.Drawing.Size(1073, 594);
            this.tabPageSearchStudent.TabIndex = 1;
            this.tabPageSearchStudent.Text = "Search Student";
            this.tabPageSearchStudent.UseVisualStyleBackColor = true;
            this.tabPageSearchStudent.Enter += new System.EventHandler(this.tabPageSearchStudent_Enter);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewStudent.Location = new System.Drawing.Point(31, 125);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1010, 422);
            this.dataGridViewStudent.TabIndex = 27;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Student Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Reg";
            this.Column3.HeaderText = "Register No";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Class_Name";
            this.Column4.HeaderText = "Class Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Student_Gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Location = new System.Drawing.Point(298, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 31);
            this.label19.TabIndex = 26;
            this.label19.Text = "Search  :";
            // 
            // labelCountStudent
            // 
            this.labelCountStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountStudent.AutoSize = true;
            this.labelCountStudent.BackColor = System.Drawing.Color.White;
            this.labelCountStudent.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCountStudent.Location = new System.Drawing.Point(965, 550);
            this.labelCountStudent.Name = "labelCountStudent";
            this.labelCountStudent.Size = new System.Drawing.Size(39, 31);
            this.labelCountStudent.TabIndex = 25;
            this.labelCountStudent.Text = "{?}";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(763, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 31);
            this.label16.TabIndex = 24;
            this.label16.Text = "Search By :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Location = new System.Drawing.Point(760, 117);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(163, 2);
            this.panel11.TabIndex = 0;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "--SELECT--",
            "ID",
            "Name",
            "Class"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(760, 77);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(160, 41);
            this.comboBoxSearchBy.TabIndex = 22;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.White;
            this.labelCount.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCount.Location = new System.Drawing.Point(1155, 548);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 31);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "{?}";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(842, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "សរុបចំនួនថ្នាក់ :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(287, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 2);
            this.panel5.TabIndex = 0;
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentSearch.Location = new System.Drawing.Point(294, 75);
            this.txtStudentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(261, 34);
            this.txtStudentSearch.TabIndex = 11;
            this.txtStudentSearch.TextChanged += new System.EventHandler(this.txtStudentSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Search Class";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::BFL_SMS.Properties.Resources.search_50px;
            this.pictureBoxSearch.Location = new System.Drawing.Point(558, 77);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(26, 32);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 13;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.MouseHover += new System.EventHandler(this.pictureBoxSearch_MouseHover);
            // 
            // tabPageUpStudent
            // 
            this.tabPageUpStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageUpStudent.Controls.Add(this.groupBox3);
            this.tabPageUpStudent.Controls.Add(this.groupBox4);
            this.tabPageUpStudent.Controls.Add(this.btnDelete);
            this.tabPageUpStudent.Controls.Add(this.btnUpdate);
            this.tabPageUpStudent.Controls.Add(this.label14);
            this.tabPageUpStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpStudent.Name = "tabPageUpStudent";
            this.tabPageUpStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpStudent.Size = new System.Drawing.Size(1073, 594);
            this.tabPageUpStudent.TabIndex = 2;
            this.tabPageUpStudent.Text = "Update And Delete Student";
            this.tabPageUpStudent.UseVisualStyleBackColor = true;
            this.tabPageUpStudent.Enter += new System.EventHandler(this.tabPageUpStudent_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.comboBoxUpClass);
            this.groupBox3.Controls.Add(this.rdUpMale);
            this.groupBox3.Controls.Add(this.rdUpFemale);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtUpStudent_Reg);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(440, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 298);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ឈ្មោះជាអង់គ្លេស";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(18, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Class :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(10, 262);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 2);
            this.panel6.TabIndex = 0;
            // 
            // comboBoxUpClass
            // 
            this.comboBoxUpClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUpClass.FormattingEnabled = true;
            this.comboBoxUpClass.Items.AddRange(new object[] {
            "--SELECT--"});
            this.comboBoxUpClass.Location = new System.Drawing.Point(10, 222);
            this.comboBoxUpClass.Name = "comboBoxUpClass";
            this.comboBoxUpClass.Size = new System.Drawing.Size(281, 41);
            this.comboBoxUpClass.TabIndex = 15;
            this.comboBoxUpClass.Click += new System.EventHandler(this.comboBoxUpClass_Click);
            // 
            // rdUpMale
            // 
            this.rdUpMale.AutoSize = true;
            this.rdUpMale.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUpMale.Location = new System.Drawing.Point(161, 130);
            this.rdUpMale.Name = "rdUpMale";
            this.rdUpMale.Size = new System.Drawing.Size(45, 31);
            this.rdUpMale.TabIndex = 14;
            this.rdUpMale.TabStop = true;
            this.rdUpMale.Text = "M";
            this.rdUpMale.UseVisualStyleBackColor = true;
            // 
            // rdUpFemale
            // 
            this.rdUpFemale.AutoSize = true;
            this.rdUpFemale.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUpFemale.Location = new System.Drawing.Point(89, 130);
            this.rdUpFemale.Name = "rdUpFemale";
            this.rdUpFemale.Size = new System.Drawing.Size(42, 31);
            this.rdUpFemale.TabIndex = 13;
            this.rdUpFemale.TabStop = true;
            this.rdUpFemale.Text = "F";
            this.rdUpFemale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(16, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 27);
            this.label11.TabIndex = 12;
            this.label11.Text = "Gender :";
            // 
            // txtUpStudent_Reg
            // 
            this.txtUpStudent_Reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpStudent_Reg.Location = new System.Drawing.Point(10, 82);
            this.txtUpStudent_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpStudent_Reg.Name = "txtUpStudent_Reg";
            this.txtUpStudent_Reg.Size = new System.Drawing.Size(251, 34);
            this.txtUpStudent_Reg.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(19, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 27);
            this.label12.TabIndex = 9;
            this.label12.Text = "Student Full Name :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(15, 118);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 2);
            this.panel7.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUpStudentName);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.panel9);
            this.groupBox4.Controls.Add(this.txtUpStudentID);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.panel12);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(61, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 298);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ឈ្មោះជាភាសាខ្មែរ";
            // 
            // txtUpStudentName
            // 
            this.txtUpStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpStudentName.Location = new System.Drawing.Point(7, 172);
            this.txtUpStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpStudentName.Name = "txtUpStudentName";
            this.txtUpStudentName.Size = new System.Drawing.Size(294, 34);
            this.txtUpStudentName.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Location = new System.Drawing.Point(16, 135);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 27);
            this.label22.TabIndex = 9;
            this.label22.Text = "ឈ្មោះសិស្ស :";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(12, 208);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(289, 2);
            this.panel9.TabIndex = 0;
            // 
            // txtUpStudentID
            // 
            this.txtUpStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpStudentID.Location = new System.Drawing.Point(12, 82);
            this.txtUpStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpStudentID.Name = "txtUpStudentID";
            this.txtUpStudentID.Size = new System.Drawing.Size(289, 34);
            this.txtUpStudentID.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label23.Location = new System.Drawing.Point(16, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 27);
            this.label23.TabIndex = 6;
            this.label23.Text = "អត្តលេខសិស្ស :";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(12, 118);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(289, 2);
            this.panel12.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(259, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 42);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(130, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 42);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "Update and Delete ";
            // 
            // UserControlAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddStudent);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UserControlAddStudent";
            this.Size = new System.Drawing.Size(1081, 640);
            this.tabControlAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSearchStudent.ResumeLayout(false);
            this.tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.tabPageUpStudent.ResumeLayout(false);
            this.tabPageUpStudent.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddStudent;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageSearchStudent;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtENName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelCountStudent;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBoxUpClass;
        private System.Windows.Forms.RadioButton rdUpMale;
        private System.Windows.Forms.RadioButton rdUpFemale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpStudent_Reg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtUpStudentName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtUpStudentID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
