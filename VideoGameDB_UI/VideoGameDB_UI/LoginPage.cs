//CSI3450 TEAM SORT AND DESTROY

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameDB_UI
{
    public partial class LoginPage : Form
    {
        private MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void guest_Click(object sender, EventArgs e)
        {
            Form GuestPage = new GuestPage(this);
            this.Hide();
            GuestPage.Show();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
       
            MySqlCommand command_one = new MySqlCommand("Select count(*) from Account where Account_Username = '" + textBox1.Text + "' and Account_Password = '" + textBox2.Text + "';", connection);
            MySqlCommand command_two = new MySqlCommand("Select Account_ID from Account where Account_Username = '" + textBox1.Text + "' and Account_Password = '" + textBox2.Text + "';", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            DataTable dt = new DataTable();
            DataTable aid = new DataTable();
            DataTable pid = new DataTable();
            sda.SelectCommand = command_one;
            sda.Fill(dt);
            sda.SelectCommand = command_two;
            sda.Fill(aid);
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form Form3 = new Form3(this);
                this.Hide();
                Form3.Show();
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    int aidt = int.Parse(aid.Rows[0][0].ToString());
                    Form Home = new Home(this, aidt, textBox1.Text);
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
       
            }
            connection.Close();
        }

        private void MakeAccount_Click(object sender, EventArgs e)
        {
            Form createAcc = new CreateAcc(this);
            createAcc.Show();
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();
            }
        }
    }
}
