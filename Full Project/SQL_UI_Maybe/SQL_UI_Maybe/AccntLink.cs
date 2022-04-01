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
    
    public partial class AccntLink : Form
    {
        private Home form_rtn;
        private int account_num;
        MySqlConnection connection = new MySqlConnection(Connect.conn_string);

        public AccntLink(Home form_rtn, int account_num)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            this.account_num = account_num;
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            int id = 0;

            if (username.Contains('\"') || (username.Length == 0))
            {
                MessageBox.Show("Invalid Username!");
                return;
            }

            string query_ID = "SELECT Player_ID FROM Player ORDER BY Player_ID;";
            try
            {
                MySqlCommand cmd;
                MySqlDataReader rdr;

                connection.Open();

                //perform a query for the IDs
                cmd = new MySqlCommand(query_ID, connection);
                rdr = cmd.ExecuteReader();

                //loop through the ID's until you find a missing one
                while (rdr.Read())
                {
                    if (!rdr[0].ToString().Equals(id.ToString()))
                        break;
                    id++;
                }
                rdr.Close();

                //create the query to link the account to a username
                string query_link = "INSERT INTO Player (Player_ID, Player_Username, Account_ID) " +
                                    "VALUES (" + id + ", \"" + username + "\", " + account_num + ");";

                //run the query to insert the player username
                cmd = new MySqlCommand(query_link, connection);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Invalid Username!");
                    return;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
                return;
            }

            try
            {
                //update the player ID of the home form
                form_rtn.player_num = id;

                //update the page status using isPlayerID = true and username = username
                form_rtn.changePageState(true, username);
            }
            catch (Exception ex)
            {
                form_rtn.connection.Close();
                MessageBox.Show(ex.ToString());
            }

            form_rtn.Show();
            this.Close();
        }
    }
}
