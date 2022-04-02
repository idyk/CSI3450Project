using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQL_UI_Maybe
{
    public partial class TeamPage : Form
    {
        private MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        private int player_num;
        private string player_username;
        private Form form_rtn;
        private List<string> List_Gamemode;

        private int team_num = 0, leader_num = 0;
        private bool inTeam = false, leadTeam = false;
        private string team_name = "";

        public TeamPage(Form form_rtn, int player_num, List<string> List_Game, List<string> List_Gamemode)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            this.player_num = player_num;
            this.List_Gamemode = List_Gamemode;
            cbx_Game.Items.AddRange(List_Game.ToArray());
            try
            {
                //perform a teams search for all teams
                updateTeamSearch("");

                //initialize the rest of the teams page
                InitializeValues();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
                form_rtn.Show();
                this.Close();
            }
        }

        private void InitializeValues()
        {
            //First determine if the player is in a team and if they are the leader
            string query = "SELECT Team.Team_ID, Player_ID_Leader, Team_Name " +
                           "FROM Player JOIN Team ON Team.Team_ID = Player.Team_ID " +
                           "WHERE Player_ID = " + player_num + ";";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                team_num = Convert.ToInt32(rdr[0].ToString());
                leader_num = Convert.ToInt32(rdr[1].ToString());
                team_name = rdr[2].ToString();
                inTeam = true;
                leadTeam = (leader_num == player_num);
            }
            rdr.Close();

            connection.Close();

            //update the UI to match the initial state
            updateUIOptions();
        }

        private void updateUIOptions()
        {
            //join/leave button options
            btn_leave.Enabled = inTeam;
            btn_join.Enabled = !inTeam;

            //team leader options for team members
            btn_chngLeader.Enabled = leadTeam;
            btn_chngLeader.Visible = leadTeam;
            btn_kick.Enabled = leadTeam;
            btn_kick.Visible = leadTeam;
            btn_delTeam.Enabled = leadTeam;
            btn_delTeam.Visible = leadTeam;

            //create/edit team name button options
            btn_create.Enabled = !inTeam;
            btn_chngTeamName.Enabled = leadTeam;

            //game and gamemode combo boxes
            cbx_Game.Enabled = inTeam;
            cbx_Gamemode.Enabled = inTeam;

            //update the Team Name
            updateTeamName();

            //update the team members
            updateTeamMembers();

            //update the team leader
            updateTeamLeader();

            //update the statistics
            cbx_Game.SelectedIndex = 0;
            cbx_Gamemode.SelectedIndex = 0;
            updateGamemodeStats("All", "All");
            updateGameStats("All");
        }

        private void updateTeamName()
        {
            if (inTeam)
                lbl_team.Text = "Your Team: " + team_name;
            else
                lbl_team.Text = "No Team Found.";
        }

        private void updateGameStats(string game)
        {
            //clear the table and exit the function if the user is not in a team
            if (!inTeam)
            {
                tbl_GameStats.DataSource = null;
                return;
            }

            bool specificGame = !game.Equals("All");

            //select the query to be used
            string query = "SELECT GameStatType_Name AS \"Stat\", SUM(GameStat_Value) AS \"Value\" " +
                           "FROM GameStats_Info " +
                           "WHERE Team_ID = " + team_num;
            if (specificGame)
                query += " and Game_Title = \"" + game + "\"";
            query += " GROUP BY Team_ID, GameStatType_Name";
            if (specificGame)
                query += ", Game_Title";
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
            tbl_GameStats.DataSource = ds.Tables[0];
        }

        private void updateGamemodeStats(string game, string gamemode)
        {
            //clear the table and exit the function if the user is not in a team
            if (!inTeam)
            {
                tbl_GmdStats.DataSource = null;
                return;
            }

            //set the boolean variables
            bool specificGame = !game.Equals("All");
            bool specificGamemode = !gamemode.Equals("All");

            //construct the query
            string query = "SELECT StatType_Name AS \"Stat\", SUM(Stat_Value) AS \"Value\" " +
                           "FROM Stats_Info " +
                           "WHERE Team_ID = " + team_num;
            if (specificGame)
                query += " and Game_Title = \"" + game + "\"";
            if (specificGamemode)
                query += " and Gamemode_Name = \"" + gamemode + "\"";
            query += " GROUP BY Team_ID, StatType_Name";
            if (specificGame)
                query += ", Game_Title";
            if (specificGamemode)
                query += ", Gamemode_Name";
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
            tbl_GmdStats.DataSource = ds.Tables[0];
        }

        private void updateTeamLeader()
        {
            //inform user and exit if the user is not in a team
            if (!inTeam)
            {
                lbl_leader.Text = "Team Leader: None";
                return;
            }
            
            //Perform a query to determine the username of the team leader
            string leader_username;
            string query = "SELECT Player_Username " +
                           "FROM Player " +
                           "WHERE Player_ID = " + leader_num + ";";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
                leader_username = rdr[0].ToString();
            else
            {
                rdr.Close();
                connection.Close();
                lbl_leader.Text = "No Team Leader Username Found.";
                MessageBox.Show("Error!\nNo Team Leader Username Found.\nPlease refresh the page.");
                return;
            }
            rdr.Close();

            connection.Close();

            //display the leader username
            lbl_leader.Text = "Team Leader: " + leader_username;
        }

        private void updateTeamMembers()
        {
            //clear the table and exit the function if the user is not in a team
            if (!inTeam)
            {
                tbl_members.DataSource = null;
                return;
            }

            //construct the query
            string query = "SELECT Player_Username AS \"Team Members\" " +
                           "FROM Player " +
                           "WHERE Team_ID = " + team_num + " " +
                           "ORDER BY Player_Username;";
            
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
            tbl_members.DataSource = ds.Tables[0];
        }

        private void updateTeamSearch(string teamName)
        {
            //construct the query
            string query = "SELECT Team_Name AS \"Team Name\", Player_Username AS \"Team Leader\" " +
                           "FROM Team JOIN Player ON Team.Player_ID_Leader = Player.Player_ID " +
                           "WHERE Team_Name LIKE \"%" + teamName + "%\" " + 
                           "ORDER BY Team_Name;";

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
            tbl_teams.DataSource = ds.Tables[0];
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            form_rtn.Show();
            this.Close();
        }

        private void cbx_Game_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create game string and index
            string game;
            int game_idx;

            //attempt to retrieve the selected item from the combo boxes
            try
            {
                game_idx = cbx_Game.SelectedIndex;
                game = cbx_Game.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("At least one combo box did not have a valid choice selected.\n" +
                                "Please select a valid option for all combo boxes.");
                return;
            }

            //select the appropriate list of gamemodes
            if (game_idx == 0)
            {
                cbx_Gamemode.DataSource = List_Gamemode;
                cbx_Gamemode.SelectedIndex = 0;
            }
            else
            {
                //list for gamemodes associated with the selected game
                List<string> List_gmfg = new List<string>();

                //SQL Query
                string select_gamemode = "SELECT Gamemode_Name " +
                                         "FROM Gametype_Info " +
                                         "WHERE Game_Title = \"" + game + "\";";
                try
                {
                    connection.Open();

                    //Initialize the gamemode choices for the selected game
                    MySqlCommand cmd = new MySqlCommand(select_gamemode, connection);
                    List_gmfg.Add("All");
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        List_gmfg.Add(rdr[0].ToString());
                    }
                    rdr.Close();

                    connection.Close();

                    cbx_Gamemode.DataSource = List_gmfg;
                    cbx_Gamemode.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.ToString());

                    //return to default choices
                    cbx_Game.SelectedIndex = 0;
                    return;
                }
            }

            try
            {
                //refresh the game stats
                updateGameStats(game);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbx_Gamemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create game and gamemode strings
            string game, gamemode;

            //attempt to retrieve the selected item from the combo boxes
            try
            {
                game = cbx_Game.SelectedItem.ToString();
                gamemode = cbx_Gamemode.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("At least one combo box did not have a valid choice selected.\n" +
                                "Please select a valid option for all combo boxes.");
                return;
            }

            //refresh the gamemode stats
            try
            {
                updateGamemodeStats(game, gamemode);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_chngLeader_Click(object sender, EventArgs e)
        {
            //ensure the user has one row selected
            if (tbl_teams.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }

            string username_lead = tbl_members.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_kick_Click(object sender, EventArgs e)
        {
            //ensure the user has one row selected
            if (tbl_members.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }

            string username_kick = tbl_members.SelectedRows[0].Cells[0].Value.ToString();

            string query = "SELECT Player_Username FROM Player WHERE Player_ID = " + player_num + ";";

            string sql = "UPDATE Player " +
                         "SET Team_ID = Null " +
                         "WHERE Player_Username = \"" + username_kick + "\" and Team_ID = " + team_num + ";";

            try
            {
                connection.Open();

                //check to ensure you aren't kicking yourself
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (username_kick.Equals(rdr[0].ToString()))
                    {
                        rdr.Close();
                        connection.Close();
                        MessageBox.Show("Error!\nYou cannot kick yourself.");
                        return;
                    }
                }
                else
                {
                    rdr.Close();
                    connection.Close();
                    MessageBox.Show("Error!\nPlease refresh the page.");
                    return;
                }
                rdr.Close();

                //kick the player
                cmd = new MySqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to kick the selected player!\nTry reloading the page.");
                    return;
                }

                connection.Close();

                //update the team members
                updateTeamMembers();

                //update the statistics
                cbx_Game.SelectedIndex = 0;
                cbx_Gamemode.SelectedIndex = 0;
                updateGamemodeStats("All", "All");
                updateGameStats("All");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_delTeam_Click(object sender, EventArgs e)
        {
            //execute a transaction to delete your team
            string t1 = "START TRANSACTION;\n" +
                        "UPDATE Player SET Team_ID = Null WHERE Team_ID = " + team_num + ";";

            string t2 = "DELETE FROM Team WHERE Team_ID = " + team_num + ";";

            try
            {
                //remove all users from the team
                MySqlCommand cmd = new MySqlCommand(t1, connection);
                connection.Open();

                //if no users were removed, there was an error
                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to delete your team!");
                    return;
                }

                //delete the team from the team table
                cmd = new MySqlCommand(t2, connection);

                //if no teams were deleted, there was an error
                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to delete your team!");
                    return;
                }

                cmd = new MySqlCommand("COMMIT;", connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                //update the user interface
                inTeam = false;
                leadTeam = false;
                updateUIOptions();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string teamSearch = txt_teamSearch.Text.Trim();

            //determine if the text box input is valid
            if (teamSearch.Contains('\"'))
                MessageBox.Show("Invalid text box search input!");
            else
            {
                //attempt to perform a search for the specified team
                try
                {
                    updateTeamSearch(teamSearch);
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show("The search was unsuccessful.");
                }
            }
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            //exit the function if you are the team leader
            if (leadTeam)
            {
                MessageBox.Show("You cannot leave a team if you are the leader.");
                return;
            }
            
            //create the sql command to leave the current team
            string sql = "UPDATE Player " +
                         "SET Team_ID = Null " +
                         "WHERE Player_ID = " + player_num + ";";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //attempt to run the sql command
            try
            {
                connection.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to leave your current team!");
                    return;
                }

                connection.Close();

                //update the user interface
                inTeam = false;
                updateUIOptions();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            //ensure the user has one row selected
            if (tbl_teams.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }

            //create and initialize variables
            string newTeamName = tbl_teams.SelectedRows[0].Cells[0].Value.ToString();
            int newTeamNum, newLeadNum;

            //construct query
            string query = "SELECT Team_ID, Player_ID_Leader " +
                           "FROM Team " +
                           "WHERE Team_Name = \"" + newTeamName + "\";";

            //attempt to run the query and the sql command
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    newTeamNum = Convert.ToInt32(rdr[0].ToString());
                    newLeadNum = Convert.ToInt32(rdr[1].ToString());
                }
                else
                {
                    rdr.Close();
                    connection.Close();
                    MessageBox.Show("Error!\nSelected Team was not Found.\nPlease refresh the page.");
                    return;
                }
                rdr.Close();

                string sql = "UPDATE Player " +
                             "SET Team_ID = " + newTeamNum + " " +
                             "WHERE Player_ID = " + player_num + ";";

                cmd = new MySqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to join your selected team!");
                    return;
                }

                connection.Close();

                //update the user interface
                team_num = newTeamNum;
                leader_num = newLeadNum;
                team_name = newTeamName;
                inTeam = true;
                leadTeam = false;
                updateUIOptions();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitializeValues();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //declare and initialize variables
            string newTeamName = txt_newTeamName.Text.Trim();
            int id = 0;

            //ensure the text box input is valid
            if (newTeamName.Contains('\"') || (newTeamName.Length == 0))
            {
                MessageBox.Show("Invalid Team Name.");
                return;
            }

            string query_ID = "SELECT Team_ID FROM Team ORDER BY Team_ID;";
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

                //execute a transaction to create a new team
                string transaction = "START TRANSACTION;\n" +
                                     "INSERT INTO Team (Team_ID, Player_ID_Leader, Team_Name) " +
                                     "VALUES (" + id + ", " + player_num + ", \"" + newTeamName + "\");\n" +
                                     "UPDATE Player SET Team_ID = " + id + " WHERE Player_ID = " + player_num + ";";
                cmd = new MySqlCommand(transaction, connection);
                if (cmd.ExecuteNonQuery() < 2)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to create a new team!");
                    return;
                }

                cmd = new MySqlCommand("COMMIT;", connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                //update the user interface
                team_num = id;
                leader_num = player_num;
                team_name = newTeamName;
                inTeam = true;
                leadTeam = true;
                updateUIOptions();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_chngTeamName_Click(object sender, EventArgs e)
        {
            //declare and initialize variables
            string newTeamName = txt_newTeamName.Text.Trim();

            //ensure the text box input is valid
            if (newTeamName.Contains('\"') || (newTeamName.Length == 0))
            {
                MessageBox.Show("Invalid Team Name.");
                return;
            }

            //create sql command the update the database
            string sql = "UPDATE Team " +
                         "SET Team_Name = \"" + newTeamName + "\" " +
                         "WHERE Team_ID = " + team_num + ";";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //Attempt to run the sql command
            try
            {
                connection.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    connection.Close();
                    MessageBox.Show("Error!\nYou were unable to update your team name!");
                    return;
                }

                connection.Close();

                //update the team name
                team_name = newTeamName;
                updateTeamName();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
