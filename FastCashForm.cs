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
    public partial class FastCashForm : Form
    {
        public FastCashForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = LoginForm.AccNumber;
        int bal;

        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_availableBal.Text = "Balance " + dt.Rows[0][0].ToString() + " Ks";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void FastCashForm_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addtransaction1()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 1000 + "', '" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction2()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 5000 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void addtransaction3()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 10000 + "', '" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 50000 + "', '" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 80000 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void addtransaction6()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "', '" + 100000 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void btn_1000Ks_Click(object sender, EventArgs e)
        {
            if (bal<1000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction1();
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

        private void btn_5000Ks_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction2();
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

        private void btn_10000Ks_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction3();
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

        private void btn_50000Ks_Click(object sender, EventArgs e)
        {
            if (bal < 50000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 50000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction4();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 80000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 80000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction5();
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

        private void btn_100000Ks_Click(object sender, EventArgs e)
        {
            if (bal < 100000)
            {
                MessageBox.Show("Not Enough Amount Please Check Your Balance Carefully");
            }
            else
            {
                int newbalance = bal - 100000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance='" + newbalance + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfully");
                    Con.Close();
                    addtransaction6();
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
