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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = LoginForm.AccNumber;

        private void addtransaction()
        {
            string TrType = "Deposit";
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
        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeForm homefm = new HomeForm();
            homefm.Show();
            this.Hide();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (tbox_amount.Text == "" || Convert.ToInt32(tbox_amount.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(tbox_amount.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='"+newbalance+"' where AccNum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(tbox_amount.Text+" Ks Deposit Successfully");
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
        int oldbalance, newbalance;

        private void DepositForm_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
    }
}
