using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = LoginForm.AccNumber;
        int bal;

        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + tbox_amount.Text + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_availableamount.Text = "Balance "+ dt.Rows[0][0].ToString() + " Ks";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeForm homefm = new HomeForm();
            homefm.Show();
            this.Hide();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (tbox_amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Convert.ToInt32(tbox_amount.Text) <=0)
            {
                MessageBox.Show("Enter A Valid Amount");
            }
            else if (Convert.ToInt32(tbox_amount.Text) > bal)
            {
                MessageBox.Show("Balance Cannot Be Over Limit");
            }
            else
            {
                newbalance = bal - Convert.ToInt32(tbox_amount.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction();
                    HomeForm home = new HomeForm();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
