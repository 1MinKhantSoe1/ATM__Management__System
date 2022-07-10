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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='"+lbl_accnum.Text+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_balance.Text = dt.Rows[0][0].ToString() + " Ks";
            Con.Close();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            lbl_accnum.Text = LoginForm.AccNumber;
            getbalance();
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
    }
}
