using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BalanceForm balancefrm = new BalanceForm();
            balancefrm.Show();
            this.Hide();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            DepositForm deposit = new DepositForm();
            deposit.Show();
            this.Hide();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdraw = new WithdrawForm();
            withdraw.Show();
            this.Hide();
        }

        private void btn_fastcash_Click(object sender, EventArgs e)
        {
            FastCashForm fast = new FastCashForm();
            fast.Show();
            this.Hide();
        }

        private void btn_ministatement_Click(object sender, EventArgs e)
        {
            Mini_StatementForm mini = new Mini_StatementForm();
            mini.Show();
            this.Hide();
        }

        private void btn_changepin_Click(object sender, EventArgs e)
        {
            ChangePinForm change = new ChangePinForm();
            change.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lbl_accnum.Text = "Account Number: " + LoginForm.AccNumber;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
