
namespace ATM_Management_System
{
    partial class BalanceForm
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
            this.lbl_accnum = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(721, 84);
            this.panel1.TabIndex = 2;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(678, 9);
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
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // lbl_accnumber
            // 
            this.lbl_accnumber.AutoSize = true;
            this.lbl_accnumber.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_accnumber.Location = new System.Drawing.Point(134, 168);
            this.lbl_accnumber.Name = "lbl_accnumber";
            this.lbl_accnumber.Size = new System.Drawing.Size(269, 33);
            this.lbl_accnumber.TabIndex = 21;
            this.lbl_accnumber.Text = "ACCOUNT NUMBER: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(134, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "YOUR BALANCE: ";
            // 
            // lbl_accnum
            // 
            this.lbl_accnum.AutoSize = true;
            this.lbl_accnum.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_accnum.Location = new System.Drawing.Point(417, 168);
            this.lbl_accnum.Name = "lbl_accnum";
            this.lbl_accnum.Size = new System.Drawing.Size(121, 33);
            this.lbl_accnum.TabIndex = 23;
            this.lbl_accnum.Text = "AccNum";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_balance.Location = new System.Drawing.Point(417, 254);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(164, 33);
            this.lbl_balance.TabIndex = 24;
            this.lbl_balance.Text = "BalanceInKs";
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_back.Location = new System.Drawing.Point(324, 401);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(59, 26);
            this.lbl_back.TabIndex = 25;
            this.lbl_back.Text = "Back";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 16);
            this.panel2.TabIndex = 42;
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_accnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_accnumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
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
        private System.Windows.Forms.Label lbl_accnum;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Panel panel2;
    }
}