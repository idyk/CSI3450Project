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
    public partial class Home : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=35.199.39.10;DATABASE=VideoGameDB;UID=root;PWD=root;");
        private List<string> List_Gamemode = new List<string>();
        private Form form_rtn;
        private int player_num, accnt_num;
        
        public Home(Form form_rtn, int accnt_num, string accnt_name)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            this.accnt_num = accnt_num;
            InitializeOptions(accnt_name);
        }

        private void InitializeOptions(string accnt_name)
        {
            //display account name
            lbl_Account.Text = "Signed in as: " + accnt_name;
            
            //MySql objects
            MySqlCommand cmd;
            MySqlDataReader rdr;

            //Create Game Choices Command
            string select_game = "SELECT Game_Title FROM Game;";

            //Create Gamemode Choices Command
            string select_gamemode = "SELECT Gamemode_Name FROM Gamemode;";

            //Create Player Username Search Command
            string select_player = "SELECT Player_ID, Player_Username FROM Player WHERE Account_ID = " + accnt_num + ";";

            try
            {
                connection.Open();

                //Initialize Game Choices
                cmd = new MySqlCommand(select_game, connection);
                cbx_Game.Items.Add("All");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cbx_Game.Items.Add(rdr[0].ToString());
                }
                rdr.Close();

                //Initialize Gamemode Choices
                cmd = new MySqlCommand(select_gamemode, connection);
                List_Gamemode.Add("All");
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    List_Gamemode.Add(rdr[0].ToString());
                }
                rdr.Close();

                //Find the player username for the account currently logged in
                bool flg = false;
                string username = "";
                cmd = new MySqlCommand(select_player, connection);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    player_num = Convert.ToInt32(rdr[0].ToString());
                    username = rdr[1].ToString();
                    flg = true;
                }
                rdr.Close();

                connection.Close();

                changePageState(flg, username);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void changePageState(bool isPlayerID, string username = "")
        {
            //return the combo box selections to default
            cbx_Gamemode.DataSource = List_Gamemode;
            cbx_Game.SelectedIndex = 0;

            //set the username label and refresh the stats if there is a player ID
            if (isPlayerID)
            {
                lbl_Username.Text = "Player Username: " + username;
                refreshGameStats("All");
                refreshGamemodeStats("All", "All");
            }
            else
                lbl_Username.Text = "No Player Username Found.";

            //enable the link account button if there is not a player ID
            btn_Link.Enabled = !isPlayerID;
            btn_Link.Visible = !isPlayerID;

            //enable the other buttons and combo boxes if there is a player ID
            btn_Friends.Enabled = isPlayerID;
            btn_Team.Enabled = isPlayerID;
            btn_AcntOptn.Enabled = isPlayerID;
            cbx_Game.Enabled = isPlayerID;
            cbx_Gamemode.Enabled = isPlayerID;
        }

        private void refreshGameStats(string game)
        {
            //clear the table
            dataGridView1.DataSource = null;

            //select the query to be used
            string query;
            if (game.Equals("All"))
                query = "SELECT GameStatType_Name, SUM(GameStat_Value) " +
                        "FROM GameStat JOIN GameStatType ON GameStat.GameStatType_ID = GameStatType.GameStatType_ID " +
                                      "JOIN Game ON GameStat.Game_ID = Game.Game_ID " +
                        "GROUP BY Player_ID, GameStatType_Name " +
                        "WHERE Player_ID = " + player_num + ";";
            else
                query = "SELECT GameStatType_Name, GameStat_Value " +
                        "FROM GameStat JOIN GameStatType ON GameStat.GameStatType_ID = GameStatType.GameStatType_ID " +
                                      "JOIN Game ON GameStat.Game_ID = Game.Game_ID " +
                        "WHERE Game_Title = " + game + " and Player_ID = " + player_num + ";";

            //create mySQL interfacing objects
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            //fill a data set using the adapter
            connection.Open();

            da.SelectCommand = cmd;
            da.Fill(ds);

            connection.Close();

            //set the table to display the data
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void refreshGamemodeStats(string game, string gamemode)
        {
            //clear the table
            dataGridView2.DataSource = null;

            //set the boolean variables
            bool game_sum = game.Equals("All");
            bool gamemode_sum = gamemode.Equals("All");
            
            //construct the query
            string query = "SELECT StatType_Name";
            if (game_sum || gamemode_sum)
                query += ", SUM(Stat_Value)";
            else
                query += ", Stat_Value";
            query += " FROM Stat JOIN StatType ON Stat.StatType_ID = StatType.StatType_ID " +
                                "JOIN Gametype_Info ON Stat.Gametype_Gamemode_ID = Gametype_Info.Gamemode_ID " +
                                                  "and Stat.Gametype_Game_ID = Gametype_Info.Game_ID";
            if (game_sum || gamemode_sum)
            {
                query += " GROUP BY Player_ID, StatType_Name";
                if (!game_sum)
                    query += ", Game_Title";
                if (!gamemode_sum)
                    query += ", Gamemode_Name";
            }
            query += " WHERE Player_ID = " + player_num;
            if (!game_sum)
                query += " and Game_Title = " + game;
            if (!gamemode_sum)
                query += " and Gamemode_Name = " + gamemode;
            query += ";";

            //create mySQL interfacing objects
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            //fill a data set using the adapter
            connection.Open();

            da.SelectCommand = cmd;
            da.Fill(ds);

            connection.Close();

            //set the table to display the data
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            //return to home screen
            form_rtn.Show();
            this.Close();
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {

        }

        private void btn_Friends_Click(object sender, EventArgs e)
        {

        }

        private void btn_Team_Click(object sender, EventArgs e)
        {

        }

        private void btn_StatsPage_Click(object sender, EventArgs e)
        {
            Form StatsPage = new StatsPage(this);
            this.Hide();
            StatsPage.Show();
        }

        private void btn_AcntOptn_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Game_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Gamemode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
