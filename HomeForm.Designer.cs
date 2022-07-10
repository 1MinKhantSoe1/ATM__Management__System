
namespace ATM_Management_System
{
    partial class HomeForm
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
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_fastcash = new System.Windows.Forms.Button();
            this.btn_ministatement = new System.Windows.Forms.Button();
            this.btn_changepin = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_accnum = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(834, 84);
            this.panel1.TabIndex = 0;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(792, 9);
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
            this.label1.Location = new System.Drawing.Point(201, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Your Transaction Please";
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deposit.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_deposit.ForeColor = System.Drawing.Color.White;
            this.btn_deposit.Location = new System.Drawing.Point(114, 159);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(222, 47);
            this.btn_deposit.TabIndex = 12;
            this.btn_deposit.Text = "DEPOSIT";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_withdraw.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_withdraw.Location = new System.Drawing.Point(525, 159);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(222, 47);
            this.btn_withdraw.TabIndex = 13;
            this.btn_withdraw.Text = "WITHDRAW";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_fastcash
            // 
            this.btn_fastcash.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_fastcash.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_fastcash.ForeColor = System.Drawing.Color.White;
            this.btn_fastcash.Location = new System.Drawing.Point(114, 254);
            this.btn_fastcash.Name = "btn_fastcash";
            this.btn_fastcash.Size = new System.Drawing.Size(222, 47);
            this.btn_fastcash.TabIndex = 14;
            this.btn_fastcash.Text = "FAST CASH";
            this.btn_fastcash.UseVisualStyleBackColor = false;
            this.btn_fastcash.Click += new System.EventHandler(this.btn_fastcash_Click);
            // 
            // btn_ministatement
            // 
            this.btn_ministatement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ministatement.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ministatement.ForeColor = System.Drawing.Color.White;
            this.btn_ministatement.Location = new System.Drawing.Point(525, 254);
            this.btn_ministatement.Name = "btn_ministatement";
            this.btn_ministatement.Size = new System.Drawing.Size(222, 47);
            this.btn_ministatement.TabIndex = 15;
            this.btn_ministatement.Text = "MINI STATEMENT";
            this.btn_ministatement.UseVisualStyleBackColor = false;
            this.btn_ministatement.Click += new System.EventHandler(this.btn_ministatement_Click);
            // 
            // btn_changepin
            // 
            this.btn_changepin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_changepin.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_changepin.ForeColor = System.Drawing.Color.White;
            this.btn_changepin.Location = new System.Drawing.Point(114, 353);
            this.btn_changepin.Name = "btn_changepin";
            this.btn_changepin.Size = new System.Drawing.Size(222, 47);
            this.btn_changepin.TabIndex = 16;
            this.btn_changepin.Text = "CHANGE PIN";
            this.btn_changepin.UseVisualStyleBackColor = false;
            this.btn_changepin.Click += new System.EventHandler(this.btn_changepin_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(525, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 47);
            this.button5.TabIndex = 17;
            this.button5.Text = "BALANCE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 16);
            this.panel2.TabIndex = 18;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_logout.Location = new System.Drawing.Point(366, 496);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(121, 33);
            this.lbl_logout.TabIndex = 19;
            this.lbl_logout.Text = "LOGOUT";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // lbl_accnum
            // 
            this.lbl_accnum.AutoSize = true;
            this.lbl_accnum.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_accnum.Location = new System.Drawing.Point(308, 99);
            this.lbl_accnum.Name = "lbl_accnum";
            this.lbl_accnum.Size = new System.Drawing.Size(229, 33);
            this.lbl_accnum.TabIndex = 47;
            this.lbl_accnum.Text = "Account Number";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.lbl_accnum);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_changepin);
            this.Controls.Add(this.btn_ministatement);
            this.Controls.Add(this.btn_fastcash);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_fastcash;
        private System.Windows.Forms.Button btn_ministatement;
        private System.Windows.Forms.Button btn_changepin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_accnum;
    }
}