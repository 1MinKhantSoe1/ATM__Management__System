﻿
namespace ATM_Management_System
{
    partial class ChangePinForm
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
            this.lbl_accnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbox_newpin = new System.Windows.Forms.TextBox();
            this.tbox_confirmpin = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.lbl_back = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_accnumber
            // 
            this.lbl_accnumber.AutoSize = true;
            this.lbl_accnumber.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_accnumber.Location = new System.Drawing.Point(155, 173);
            this.lbl_accnumber.Name = "lbl_accnumber";
            this.lbl_accnumber.Size = new System.Drawing.Size(139, 33);
            this.lbl_accnumber.TabIndex = 22;
            this.lbl_accnumber.Text = "NEW PIN: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(155, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONFIRM PIN: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbl_close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 84);
            this.panel1.TabIndex = 24;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 16);
            this.panel2.TabIndex = 43;
            // 
            // tbox_newpin
            // 
            this.tbox_newpin.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_newpin.Location = new System.Drawing.Point(376, 174);
            this.tbox_newpin.Name = "tbox_newpin";
            this.tbox_newpin.Size = new System.Drawing.Size(183, 32);
            this.tbox_newpin.TabIndex = 44;
            // 
            // tbox_confirmpin
            // 
            this.tbox_confirmpin.Font = new System.Drawing.Font("Montserrat", 12F);
            this.tbox_confirmpin.Location = new System.Drawing.Point(376, 246);
            this.tbox_confirmpin.Name = "tbox_confirmpin";
            this.tbox_confirmpin.Size = new System.Drawing.Size(183, 32);
            this.tbox_confirmpin.TabIndex = 45;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_change.Font = new System.Drawing.Font("Montserrat", 13.8F);
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(376, 322);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(183, 47);
            this.btn_change.TabIndex = 46;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_back.Location = new System.Drawing.Point(439, 398);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(59, 26);
            this.lbl_back.TabIndex = 47;
            this.lbl_back.Text = "Back";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // ChangePinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tbox_confirmpin);
            this.Controls.Add(this.tbox_newpin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_accnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePinForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_accnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbox_newpin;
        private System.Windows.Forms.TextBox tbox_confirmpin;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label lbl_back;
    }
}