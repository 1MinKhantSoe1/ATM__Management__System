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
    public partial class ChangePinForm : Form
    {
        public ChangePinForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minkh\Documents\ATM_Management_System_db.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = LoginForm.AccNumber;

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

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (tbox_newpin.Text == "" || tbox_confirmpin.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (tbox_confirmpin.Text != tbox_newpin.Text)
            {
                MessageBox.Show("NewPin And ConfirmPin Are Different");
            }
            else
            {
                //newbalance = oldbalance + Convert.ToInt32(tbox_amount.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN='" + tbox_newpin.Text + "' where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated");
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
        }
    }
}
