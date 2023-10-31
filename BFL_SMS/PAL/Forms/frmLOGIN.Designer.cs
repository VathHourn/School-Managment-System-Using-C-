
namespace BFL_SMS.PAL.Forms
{
    partial class frmLOGIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOGIN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox2Show = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3Max = new System.Windows.Forms.PictureBox();
            this.pictureBox2Min = new System.Windows.Forms.PictureBox();
            this.pictureBox1Close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Close)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblForgetPass);
            this.groupBox1.Controls.Add(this.pictureBoxError);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.pictureBox2Show);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnLOGIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(95, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login First";
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.Font = new System.Drawing.Font("Khmer OS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.Navy;
            this.lblForgetPass.Location = new System.Drawing.Point(188, 307);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(163, 34);
            this.lblForgetPass.TabIndex = 7;
            this.lblForgetPass.Text = "Forget Password ";
            this.lblForgetPass.Click += new System.EventHandler(this.lblForgetPass_Click);
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxError.Image = global::BFL_SMS.Properties.Resources.high_priority_48px;
            this.pictureBoxError.Location = new System.Drawing.Point(118, 276);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(42, 31);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 6;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Khmer OS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(157, 279);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(209, 28);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Invalid Username or Password ";
            this.lblError.Visible = false;
            // 
            // pictureBox2Show
            // 
            this.pictureBox2Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2Show.Image = global::BFL_SMS.Properties.Resources.eye_24px;
            this.pictureBox2Show.Location = new System.Drawing.Point(360, 225);
            this.pictureBox2Show.Name = "pictureBox2Show";
            this.pictureBox2Show.Size = new System.Drawing.Size(42, 31);
            this.pictureBox2Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Show.TabIndex = 4;
            this.pictureBox2Show.TabStop = false;
            this.pictureBox2Show.Click += new System.EventHandler(this.pictureBox2Show_Click);
            this.pictureBox2Show.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BFL_SMS.Properties.Resources.hide_24px;
            this.pictureBox1.Location = new System.Drawing.Point(360, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(99, 102);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(306, 48);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLOGIN.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.White;
            this.btnLOGIN.Image = global::BFL_SMS.Properties.Resources.sign_in_form_password_50px;
            this.btnLOGIN.Location = new System.Drawing.Point(99, 357);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(306, 61);
            this.btnLOGIN.TabIndex = 2;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(99, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 48);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(646, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 702);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(720, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Management System";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::BFL_SMS.Properties.Resources.Logo;
            this.pictureBox4.Location = new System.Drawing.Point(662, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(523, 485);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3Max
            // 
            this.pictureBox3Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3Max.Image = global::BFL_SMS.Properties.Resources.maximize_window_26px;
            this.pictureBox3Max.Location = new System.Drawing.Point(1092, 30);
            this.pictureBox3Max.Name = "pictureBox3Max";
            this.pictureBox3Max.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3Max.TabIndex = 2;
            this.pictureBox3Max.TabStop = false;
            // 
            // pictureBox2Min
            // 
            this.pictureBox2Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2Min.Image = global::BFL_SMS.Properties.Resources.minimize_window_26px;
            this.pictureBox2Min.Location = new System.Drawing.Point(1055, 30);
            this.pictureBox2Min.Name = "pictureBox2Min";
            this.pictureBox2Min.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Min.TabIndex = 1;
            this.pictureBox2Min.TabStop = false;
            this.pictureBox2Min.Click += new System.EventHandler(this.pictureBox2Min_Click);
            this.pictureBox2Min.MouseHover += new System.EventHandler(this.pictureBox2Min_MouseHover);
            // 
            // pictureBox1Close
            // 
            this.pictureBox1Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1Close.Image = global::BFL_SMS.Properties.Resources.close_window_26px;
            this.pictureBox1Close.Location = new System.Drawing.Point(1129, 30);
            this.pictureBox1Close.Name = "pictureBox1Close";
            this.pictureBox1Close.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Close.TabIndex = 0;
            this.pictureBox1Close.TabStop = false;
            this.pictureBox1Close.Click += new System.EventHandler(this.pictureBox1Close_Click);
            this.pictureBox1Close.MouseHover += new System.EventHandler(this.pictureBox1Close_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 701);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(1191, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 701);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1199, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Location = new System.Drawing.Point(-1, 703);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1199, 10);
            this.panel5.TabIndex = 7;
            // 
            // frmLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3Max);
            this.Controls.Add(this.pictureBox2Min);
            this.Controls.Add(this.pictureBox1Close);
            this.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLOGIN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1Close;
        private System.Windows.Forms.PictureBox pictureBox2Min;
        private System.Windows.Forms.PictureBox pictureBox3Max;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2Show;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}