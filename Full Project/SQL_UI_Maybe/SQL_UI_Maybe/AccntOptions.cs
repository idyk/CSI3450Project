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

namespace SQL_UI_Maybe
{
    public partial class AccntOptions : Form
    {
        MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        private Home form_rtn;
        private int account_num;

        public AccntOptions(Home form_rtn, int account_num, bool noPlayerID)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            this.account_num = account_num;
            btn_playerUsername.Enabled = !noPlayerID;
            lbl_noLinkMsg.Visible = noPlayerID;
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            string newPassword = txt_password.Text;

            //determine if new password is invalid
            if (newPassword.Contains('\"') || (newPassword.Trim().Length == 0))
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            //create the sql command
            string sql = "UPDATE Account SET Account_Password = \"" + newPassword + "\"" +
                         "WHERE Account_ID = " + account_num + ";";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //attempt to run the sql command
            try
            {
                connection.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nThe password did not update!");
                    return;
                }

                connection.Close();

                MessageBox.Show("Password Updated.");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_accntUsername_Click(object sender, EventArgs e)
        {
            string newUsername = txt_accntUsername.Text.Trim();

            //determine if new username is invalid
            if (newUsername.Contains('\"') || (newUsername.Length == 0))
            {
                MessageBox.Show("Invalid Username!");
                return;
            }

            //create the sql command
            string sql = "UPDATE Account SET Account_Username = \"" + newUsername + "\"" +
                         "WHERE Account_ID = " + account_num + ";";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //attempt to run the sql command
            try
            {
                connection.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nThe account username did not update!");
                    return;
                }

                connection.Close();

                form_rtn.setAccountNameLabel(newUsername);

                MessageBox.Show("Account Username Updated.");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            form_rtn.Show();
            this.Close();
        }

        private void btn_playerUsername_Click(object sender, EventArgs e)
        {
            string newUsername = txt_playerUsername.Text.Trim();

            //determine if new username is invalid
            if (newUsername.Contains('\"') || (newUsername.Length == 0))
            {
                MessageBox.Show("Invalid Username!");
                return;
            }

            //create the sql command
            string sql = "UPDATE Player SET Player_Username = \"" + newUsername + "\"" +
                         "WHERE Account_ID = " + account_num + ";";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //attempt to run the sql command
            try
            {
                connection.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nThe player username did not update!");
                    return;
                }

                connection.Close();

                form_rtn.setUsernameLabel(newUsername);

                MessageBox.Show("Player Username Updated.");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
