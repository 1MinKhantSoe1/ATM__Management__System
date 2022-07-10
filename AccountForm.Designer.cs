
namespace ATM_Management_System
{
    partial class AccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_accnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_accnumber = new System.Windows.Forms.TextBox();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.tbox_Fname = new System.Windows.Forms.TextBox();
            this.tbox_phone = new System.Windows.Forms.TextBox();
            this.tbox_pin = new System.Windows.Forms.TextBox();
            this.cbo_edu = new System.Windows.Forms.ComboBox();
            this.DTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.tbox_occupation = new System.Windows.Forms.TextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbl_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 84);
            this.panel1.TabIndex = 1;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(952, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(31, 33);
            this.lbl_close.TabIndex = 11;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lbl_accnumber
            // 
            this.lbl_accnumber.AutoSize = true;
            this.lbl_accnumber.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_accnumber.Location = new System.Drawing.Point(73, 173);
            this.lbl_accnumber.Name = "lbl_accnumber";
            this.lbl_accnumber.Size = new System.Drawing.Size(110, 27);
            this.lbl_accnumber.TabIndex = 20;
            this.lbl_accnumber.Text = "ACC NUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(73, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(73, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "FNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(73, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(532, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "PHONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(532, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 27);
            this.label6.TabIndex = 29;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(532, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "OCCUPATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(532, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "EDUCATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(532, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "PIN";
            // 
            // tbox_accnumber
            // 
            this.tbox_accnumber.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_accnumber.Location = new System.Drawing.Point(214, 170);
            this.tbox_accnumber.Name = "tbox_accnumber";
            this.tbox_accnumber.Size = new System.Drawing.Size(183, 32);
            this.tbox_accnumber.TabIndex = 30;
            // 
            // tbox_Name
            // 
            this.tbox_Name.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_Name.Location = new System.Drawing.Point(214, 234);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(183, 32);
            this.tbox_Name.TabIndex = 31;
            // 
            // tbox_Fname
            // 
            this.tbox_Fname.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_Fname.Location = new System.Drawing.Point(214, 303);
            this.tbox_Fname.Name = "tbox_Fname";
            this.tbox_Fname.Size = new System.Drawing.Size(183, 32);
            this.tbox_Fname.TabIndex = 32;
            // 
            // tbox_phone
            // 
            this.tbox_phone.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_phone.Location = new System.Drawing.Point(726, 373);
            this.tbox_phone.Name = "tbox_phone";
            this.tbox_phone.Size = new System.Drawing.Size(183, 32);
            this.tbox_phone.TabIndex = 34;
            // 
            // tbox_pin
            // 
            this.tbox_pin.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_pin.Location = new System.Drawing.Point(726, 168);
            this.tbox_pin.Name = "tbox_pin";
            this.tbox_pin.Size = new System.Drawing.Size(183, 32);
            this.tbox_pin.TabIndex = 35;
            // 
            // cbo_edu
            // 
            this.cbo_edu.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbo_edu.FormattingEnabled = true;
            this.cbo_edu.Items.AddRange(new object[] {
            "Non Gradute",
            "Under Graduate",
            "Post Graduate"});
            this.cbo_edu.Location = new System.Drawing.Point(726, 237);
            this.cbo_edu.Name = "cbo_edu";
            this.cbo_edu.Size = new System.Drawing.Size(183, 35);
            this.cbo_edu.TabIndex = 37;
            // 
            // DTP_DOB
            // 
            this.DTP_DOB.Font = new System.Drawing.Font("Montserrat", 12F);
            this.DTP_DOB.Location = new System.Drawing.Point(726, 451);
            this.DTP_DOB.Name = "DTP_DOB";
            this.DTP_DOB.Size = new System.Drawing.Size(183, 32);
            this.DTP_DOB.TabIndex = 39;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(397, 611);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(183, 47);
            this.btn_login.TabIndex = 40;
            this.btn_login.Text = "Submit";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 773);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 16);
            this.panel2.TabIndex = 41;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_logout.Location = new System.Drawing.Point(426, 702);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(121, 33);
            this.lbl_logout.TabIndex = 20;
            this.lbl_logout.Text = "LOGOUT";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // tbox_occupation
            // 
            this.tbox_occupation.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_occupation.Location = new System.Drawing.Point(726, 307);
            this.tbox_occupation.Name = "tbox_occupation";
            this.tbox_occupation.Size = new System.Drawing.Size(183, 32);
            this.tbox_occupation.TabIndex = 42;
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(214, 376);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(183, 144);
            this.rtb_address.TabIndex = 43;
            this.rtb_address.Text = "";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 789);
            this.Controls.Add(this.rtb_address);
            this.Controls.Add(this.tbox_occupation);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.DTP_DOB);
            this.Controls.Add(this.cbo_edu);
            this.Controls.Add(this.tbox_pin);
            this.Controls.Add(this.tbox_phone);
            this.Controls.Add(this.tbox_Fname);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.tbox_accnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_accnumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_accnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_accnumber;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.TextBox tbox_Fname;
        private System.Windows.Forms.TextBox tbox_phone;
        private System.Windows.Forms.TextBox tbox_pin;
        private System.Windows.Forms.ComboBox cbo_edu;
        private System.Windows.Forms.DateTimePicker DTP_DOB;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.TextBox tbox_occupation;
        private System.Windows.Forms.RichTextBox rtb_address;
    }
}