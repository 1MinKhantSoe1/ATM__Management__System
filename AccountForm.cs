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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void btn_login_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (tbox_Name.Text == "" || tbox_accnumber.Text == "" || tbox_Fname.Text == "" || tbox_phone.Text == "" || rtb_address.Text == "" || tbox_occupation.Text == "" || tbox_occupation.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + tbox_accnumber.Text + "','" + tbox_Name.Text + "', '"+tbox_Fname.Text+"', '"+ DTP_DOB .Value.Date +"', '"+tbox_phone.Text+"', '"+rtb_address.Text+"', '"+ cbo_edu .SelectedItem.ToString()+ "', '"+tbox_occupation.Text+"', '"+tbox_pin.Text+"', '"+bal+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    tbox_accnumber.Text = "";
                    tbox_Fname.Text = "";
                    tbox_Name.Text = "";
                    tbox_occupation.Text = "";
                    tbox_phone.Text = "";
                    tbox_pin.Text = "";
                    cbo_edu.Text = "";
                    rtb_address.Text = "";
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
