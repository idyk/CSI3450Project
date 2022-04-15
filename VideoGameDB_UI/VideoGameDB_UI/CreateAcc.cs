using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VideoGameDB_UI
{
    public partial class CreateAcc : Form
    {
        MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        Form form_rtn;
        public CreateAcc(Form form_rtn)
        {
            this.form_rtn = form_rtn;
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command_one = new MySqlCommand("Select count(*) from Account where Account_Username = '" + textBox1.Text + "';", connection);
            MySqlCommand command_t = new MySqlCommand("Select Account_ID from Account;", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            sda.SelectCommand = command_one;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataTable det = new DataTable();
            sda.SelectCommand = command_t;
            sda.Fill(det);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Sorry Username in use!");
                connection.Close();
            }
            else
            {
                if (textBox1.ToString() == "admin")
                {
                    MessageBox.Show("Please don't use Admin in your username");
                }
                else
                {
                    if (textBox2.ToString() == textBox3.ToString())
                    {
                        connection.Close();
                        MySqlCommand command_two = new MySqlCommand("Insert Into Account Values ('" + det.Rows.Count + "','" + textBox1.Text + "','" + textBox2.Text + "');", connection);
                        connection.Open();
                        command_two.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Congrats on Signing Up");
                        form_rtn.Show();
                        this.Close();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Your Passwords Dont Match");
                    }
                }
            }
        }

        private void bckhome_Click(object sender, EventArgs e)
        {
            form_rtn.Show();
            this.Close();
        }
    }
}
