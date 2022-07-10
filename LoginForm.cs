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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");


        private void lbl_signup_Click(object sender, EventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tbox_pincode.Text == "" || tbox_accnum.Text == "")
            {
                MessageBox.Show("Please Enter Account Number And PIN Code");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNum='" + tbox_accnum.Text + "' and PIN = '" + tbox_pincode.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        AccNumber = tbox_accnum.Text;
                        HomeForm home = new HomeForm();
                        home.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Account Number Or PIN Code");
                    }
                    Con.Close();
                }
                catch
                {
                    MessageBox.Show("Wrong Account Number Or PIN Code");
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                
            }
            
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
