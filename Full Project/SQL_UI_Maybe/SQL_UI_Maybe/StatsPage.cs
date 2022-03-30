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
    public partial class StatsPage : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=35.199.39.10;DATABASE=VideoGameDB;UID=root;PWD=root;");
        private List<string> List_Gamemode = new List<string>();
        private Form form_rtn;

        public StatsPage(Form form_rtn)
        {
            InitializeComponent();
            //InitializeChoices();
            this.form_rtn = form_rtn;
        }

        public void InitializeChoices()
        {
            try
            {
                //List for Stat Types
                List<string> List_Stat = new List<string>();

                //Set default values for Stat Operations
                Stat1_DerivedOp.SelectedIndex = 0;
                Stat2_DerivedOp.SelectedIndex = 0;
                Stat3_DerivedOp.SelectedIndex = 0;

                //MySql objects
                MySqlCommand cmd;
                MySqlDataReader rdr;
                
                //Create Game Choices Command
                string select_game = "SELECT Game_Title FROM Game;";

                //Create Gamemode Choices Command
                string select_gamemode = "SELECT Gamemode_Name FROM Gamemode;";

                //Create Stat Type Choices Command
                string select_stat = "SELECT StatType_Name FROM StatType;";

                string select_gamestat = "SELECT GameStatType_Name FROM GameStatType;";

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

                //Initialize Stat Type Choices
                cmd = new MySqlCommand(select_stat, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    List_Stat.Add(rdr[0].ToString());
                }
                rdr.Close();

                cmd = new MySqlCommand(select_gamestat, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    List_Stat.Add(rdr[0].ToString());
                }
                rdr.Close();

                connection.Close();


                //Set Data Sources and Items for Combo Boxes
                cbx_Gamemode.DataSource = List_Gamemode;
                Stat1_Direct.Items.AddRange(List_Stat.ToArray());

                //Set Default Indecies
                cbx_Game.SelectedIndex = 0;
                Stat1_Direct.SelectedIndex = 0;

                //Set the Other Stats Options to match the Direct Stat 1
                Stat1_Derived1.DataSource = Stat1_Direct.Items;
                Stat1_Derived2.DataSource = Stat1_Derived1.Items;
                Stat2_Direct.DataSource = Stat1_Derived2.Items;
                Stat2_Derived1.DataSource = Stat2_Direct.Items;
                Stat2_Derived2.DataSource = Stat2_Derived1.Items;
                Stat3_Direct.DataSource = Stat2_Derived2.Items;
                Stat3_Derived1.DataSource = Stat3_Direct.Items;
                Stat3_Derived2.DataSource = Stat3_Derived1.Items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
                
                //go back to previous page
                this.Close();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //returns to the home screen
            form_rtn.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //create and initialize variables
            string game, gamemode, stat1a, stat1b="", stat2a, stat2b="", stat3a, stat3b="";
            char stat1op = '\0', stat2op = '\0', stat3op = '\0';
            bool stat1_direct, stat2_direct, stat3_direct;
            bool playerSearch = (tab_SearchType.SelectedIndex == 0);
            string sql_names;

            //determine if text box input is valid
            if (playerSearch)
            {
                if (txt_Username.Text.Contains('\"'))
                {
                    MessageBox.Show("Username Text Box Input Invalid!");
                    return;
                }
                sql_names = "SELECT Player_Username " +
                            "FROM Player " +
                            "WHERE Player_Username LIKE \"%" + txt_Username.Text.Trim() + "%\" " +
                            "ORDER BY Player_Username;";
            }
            else
            {
                if (txt_Team.Text.Contains('\"'))
                {
                    MessageBox.Show("Team Name Text Box Input Invalid!");
                    return;
                }
                sql_names = "SELECT Team_Name " +
                            "FROM Team " +
                            "WHERE Team_Name LIKE \"%" + txt_Team.Text.Trim() + "%\" " +
                            "ORDER BY Team_Name;";
            }

            try
            {
                //determine string and boolean values based on user choices
                game = cbx_Game.SelectedItem.ToString();
                gamemode = cbx_Gamemode.SelectedItem.ToString();
                stat1_direct = (tab_Stat1Type.SelectedIndex == 0);
                stat2_direct = (tab_Stat2Type.SelectedIndex == 0);
                stat3_direct = (tab_Stat3Type.SelectedIndex == 0);
                if (stat1_direct)
                    stat1a = Stat1_Direct.SelectedItem.ToString();
                else
                {
                    stat1a = Stat1_Derived1.SelectedItem.ToString();
                    stat1op = Stat1_DerivedOp.SelectedItem.ToString()[0];
                    stat1b = Stat1_Derived2.SelectedItem.ToString();
                }
                if (stat2_direct)
                    stat2a = Stat2_Direct.SelectedItem.ToString();
                else
                {
                    stat2a = Stat2_Derived1.SelectedItem.ToString();
                    stat2op = Stat2_DerivedOp.SelectedItem.ToString()[0];
                    stat2b = Stat2_Derived2.SelectedItem.ToString();
                }
                if (stat3_direct)
                    stat3a = Stat3_Direct.SelectedItem.ToString();
                else
                {
                    stat3a = Stat3_Derived1.SelectedItem.ToString();
                    stat3op = Stat3_DerivedOp.SelectedItem.ToString()[0];
                    stat3b = Stat3_Derived2.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("At least one combo box did not have a valid choice selected.\n" +
                                "Please select a valid option before restarting the search.");
                return;
            }

            //Create the SQL Query
            string sql_stat = "SELECT";
            string sql_gamestat = "SELECT";

            if (playerSearch)
            {
                sql_stat += " Player_Username";
                sql_gamestat += " Player_Username";
            }
            else
            {
                sql_stat += " Team_Name";
                sql_gamestat += " Team_Name";
            }
            sql_stat += ", StatType_Name, SUM(Stat_Value) FROM Stats_Info";
            sql_gamestat += ", GameStatType_Name, SUM(GameStat_Value) FROM GameStats_Info";
            if (!playerSearch)
            {
                sql_stat += " JOIN Team ON Stats_Info.Team_ID = Team.Team_ID";
                sql_gamestat += " JOIN Team ON GameStats_Info.Team_ID = Team.Team_ID";
            }

            if (!game.Equals("All"))
            {
                sql_stat += " WHERE Game_Title = \"" + game + "\"";
                sql_gamestat += " WHERE Game_Title = \"" + game + "\"";
                if (!gamemode.Equals("All"))
                    sql_stat += " and Gamemode_Name = \"" + gamemode + "\"";
            }
            else if (!gamemode.Equals("All"))
                sql_stat += " WHERE Gamemode_Name = \"" + gamemode + "\"";

            if (playerSearch)
            {
                sql_stat += " GROUP BY Player_ID, StatType_Name";
                sql_gamestat += " GROUP BY Player_ID, GameStatType_Name";
            }
            else
            {
                sql_stat += " GROUP BY Team.Team_ID, StatType_Name";
                sql_gamestat += " GROUP BY Team.Team_ID, GameStatType_Name";
            }

            if (!game.Equals("All"))
            {
                sql_stat += ", Game_Title";
                sql_gamestat += ", Game_Title";
                if (!gamemode.Equals("All"))
                    sql_stat += ", Gamemode_Name";
            }
            else if (!gamemode.Equals("All"))
                sql_stat += ", Gamemode_Name";

            if (playerSearch)
            {
                sql_stat += " ORDER BY Player_Username;";
                sql_gamestat += " ORDER BY Player_Username;";
            }
            else
            {
                sql_stat += " ORDER BY Team_Name;";
                sql_gamestat += " ORDER BY Team_Name;";
            }

            //clear the table
            dataGridView1.DataSource = null;

            //create lists for each name and stat
            List<string> names = new List<string>();
            List<double> stat1_vals = new List<double>();
            List<bool> stat1a_beenSet = new List<bool>();
            List<bool> stat1b_beenSet = new List<bool>();
            List<double> stat2_vals = new List<double>();
            List<bool> stat2a_beenSet = new List<bool>();
            List<bool> stat2b_beenSet = new List<bool>();
            List<double> stat3_vals = new List<double>();
            List<bool> stat3a_beenSet = new List<bool>();
            List<bool> stat3b_beenSet = new List<bool>();

            try
            {
                //begin connection
                connection.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                //find the player/team names
                cmd = new MySqlCommand(sql_names, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    names.Add(rdr[0].ToString());
                }
                rdr.Close();

                //stop if no names match the search
                if (names.Count == 0)
                {
                    connection.Close();
                    return;
                }

                //initialize the stat values and booleans
                for (int j = 0; j < names.Count; j++)
                {
                    //Initialize next values
                    if (!stat1_direct && (stat1op == '/'))
                        stat1_vals.Add(double.NaN);
                    else
                        stat1_vals.Add(0);
                    stat1a_beenSet.Add(false);
                    stat1b_beenSet.Add(false);
                    if (!stat2_direct && (stat2op == '/'))
                        stat2_vals.Add(double.NaN);
                    else
                        stat2_vals.Add(0);
                    stat2a_beenSet.Add(false);
                    stat2b_beenSet.Add(false);
                    if (!stat3_direct && (stat3op == '/'))
                        stat3_vals.Add(double.NaN);
                    else
                        stat3_vals.Add(0);
                    stat3a_beenSet.Add(false);
                    stat3b_beenSet.Add(false);
                }

                //determine the stat values
                cmd = new MySqlCommand(sql_stat, connection);
                rdr = cmd.ExecuteReader();
                int i = 0;
                bool bflg = false;
                while (rdr.Read())
                {
                    //The currentnames string is before the query results
                    while (names[i].CompareTo(rdr[0].ToString()) < 0)
                    {
                        //go to next table value
                        i++;

                        //determine if the max index of names has been passed
                        if (i == names.Count)
                        {
                            bflg = true;
                            break;
                        }
                    }

                    //exit the while loop when i is past the number of names found
                    if (bflg)
                        break;

                    //The query result and current names string are the same
                    if (names[i].Equals(rdr[0].ToString()))
                    {
                        //Stat1
                        if (stat1_direct)
                        {
                            if (stat1a.Equals(rdr[1].ToString()))
                            {
                                stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat1a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat1a.Equals(rdr[1].ToString()))
                            {
                                if (stat1b_beenSet[i])
                                {
                                    switch (stat1op)
                                    {
                                        case '+':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat1a_beenSet[i] = true;
                            }
                            if (stat1b.Equals(rdr[1].ToString()))
                            {
                                if (stat1a_beenSet[i])
                                {
                                    switch (stat1op)
                                    {
                                        case '+':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat1_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat1op)
                                    {
                                        case '-':
                                            stat1_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat1b_beenSet[i] = true;
                            }
                        }

                        //Stat2
                        if (stat2_direct)
                        {
                            if (stat2a.Equals(rdr[1].ToString()))
                            {
                                stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat2a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat2a.Equals(rdr[1].ToString()))
                            {
                                if (stat2b_beenSet[i])
                                {
                                    switch (stat2op)
                                    {
                                        case '+':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat2a_beenSet[i] = true;
                            }
                            if (stat2b.Equals(rdr[1].ToString()))
                            {
                                if (stat2a_beenSet[i])
                                {
                                    switch (stat2op)
                                    {
                                        case '+':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat2_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat2op)
                                    {
                                        case '-':
                                            stat2_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat2b_beenSet[i] = true;
                            }
                        }

                        //Stat3
                        if (stat3_direct)
                        {
                            if (stat3a.Equals(rdr[1].ToString()))
                            {
                                stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat3a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat3a.Equals(rdr[1].ToString()))
                            {
                                if (stat3b_beenSet[i])
                                {
                                    switch (stat3op)
                                    {
                                        case '+':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat3a_beenSet[i] = true;
                            }
                            if (stat3b.Equals(rdr[1].ToString()))
                            {
                                if (stat3a_beenSet[i])
                                {
                                    switch (stat3op)
                                    {
                                        case '+':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat3_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat3op)
                                    {
                                        case '-':
                                            stat3_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat3b_beenSet[i] = true;
                            }
                        }
                    }
                }
                rdr.Close();

                //determine the game stat values
                cmd = new MySqlCommand(sql_gamestat, connection);
                rdr = cmd.ExecuteReader();
                i = 0;
                bflg = false;
                while (rdr.Read())
                {
                    //The currentnames string is before the query results
                    while (names[i].CompareTo(rdr[0].ToString()) < 0)
                    {
                        //go to next table value
                        i++;

                        //determine if the max index of names has been passed
                        if (i == names.Count)
                        {
                            bflg = true;
                            break;
                        }
                    }

                    //exit the while loop when i is past the number of names found
                    if (bflg)
                        break;

                    //The query result and current names string are the same
                    if (names[i].Equals(rdr[0].ToString()))
                    {
                        //Stat1
                        if (stat1_direct)
                        {
                            if (stat1a.Equals(rdr[1].ToString()))
                            {
                                stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat1a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat1a.Equals(rdr[1].ToString()))
                            {
                                if (stat1b_beenSet[i])
                                {
                                    switch (stat1op)
                                    {
                                        case '+':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat1a_beenSet[i] = true;
                            }
                            if (stat1b.Equals(rdr[1].ToString()))
                            {
                                if (stat1a_beenSet[i])
                                {
                                    switch (stat1op)
                                    {
                                        case '+':
                                            stat1_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat1_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat1_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat1op)
                                    {
                                        case '-':
                                            stat1_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat1_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat1_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat1b_beenSet[i] = true;
                            }
                        }

                        //Stat2
                        if (stat2_direct)
                        {
                            if (stat2a.Equals(rdr[1].ToString()))
                            {
                                stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat2a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat2a.Equals(rdr[1].ToString()))
                            {
                                if (stat2b_beenSet[i])
                                {
                                    switch (stat2op)
                                    {
                                        case '+':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat2a_beenSet[i] = true;
                            }
                            if (stat2b.Equals(rdr[1].ToString()))
                            {
                                if (stat2a_beenSet[i])
                                {
                                    switch (stat2op)
                                    {
                                        case '+':
                                            stat2_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat2_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat2_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat2op)
                                    {
                                        case '-':
                                            stat2_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat2_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat2_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat2b_beenSet[i] = true;
                            }
                        }

                        //Stat3
                        if (stat3_direct)
                        {
                            if (stat3a.Equals(rdr[1].ToString()))
                            {
                                stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                stat3a_beenSet[i] = true;
                            }
                        }
                        else
                        {
                            if (stat3a.Equals(rdr[1].ToString()))
                            {
                                if (stat3b_beenSet[i])
                                {
                                    switch (stat3op)
                                    {
                                        case '+':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                }
                                stat3a_beenSet[i] = true;
                            }
                            if (stat3b.Equals(rdr[1].ToString()))
                            {
                                if (stat3a_beenSet[i])
                                {
                                    switch (stat3op)
                                    {
                                        case '+':
                                            stat3_vals[i] += Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '-':
                                            stat3_vals[i] -= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '*':
                                            stat3_vals[i] *= Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] /= Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (stat3op)
                                    {
                                        case '-':
                                            stat3_vals[i] = -1.0 * Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        case '/':
                                            stat3_vals[i] = 1.0 / Convert.ToDouble(rdr[2].ToString());
                                            break;

                                        default:
                                            stat3_vals[i] = Convert.ToDouble(rdr[2].ToString());
                                            break;
                                    }
                                }
                                stat3b_beenSet[i] = true;
                            }
                        }
                    }
                }
                rdr.Close();

                //end connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
                return;
            }

            //correct values for null query result cases
            for (int j = 0; j < names.Count; j++)
            {
                //Stat 1
                if (!stat1_direct)
                {
                    if (!stat1a_beenSet[j] && stat1b_beenSet[j])
                    {
                        if ((stat1op == '*') || (stat1op == '/'))
                            stat1_vals[j] *= 0.0;
                    }
                    else if (stat1a_beenSet[j] && !stat1b_beenSet[j])
                    {
                        if (stat1op == '*')
                            stat1_vals[j] *= 0.0;
                        else if (stat1op == '/')
                            stat1_vals[j] /= 0.0;
                    }
                }

                //Stat 2
                if (!stat2_direct)
                {
                    if (!stat2a_beenSet[j] && stat2b_beenSet[j])
                    {
                        if ((stat2op == '*') || (stat2op == '/'))
                            stat2_vals[j] *= 0.0;
                    }
                    else if (stat2a_beenSet[j] && !stat2b_beenSet[j])
                    {
                        if (stat2op == '*')
                            stat2_vals[j] *= 0.0;
                        else if (stat2op == '/')
                            stat2_vals[j] /= 0.0;
                    }
                }

                //Stat 3
                if (!stat3_direct)
                {
                    if (!stat3a_beenSet[j] && stat3b_beenSet[j])
                    {
                        if ((stat3op == '*') || (stat3op == '/'))
                            stat3_vals[j] *= 0.0;
                    }
                    else if (stat3a_beenSet[j] && !stat3b_beenSet[j])
                    {
                        if (stat3op == '*')
                            stat3_vals[j] *= 0.0;
                        else if (stat3op == '/')
                            stat3_vals[j] /= 0.0;
                    }
                }
            }

            //Initialize data table
            DataTable dt = new DataTable();
            if (playerSearch)
                dt.Columns.Add("Player", typeof(String));
            else
                dt.Columns.Add("Team", typeof(String));
            dt.Columns.Add("Stat 1: " + stat1a + stat1op + stat1b, typeof(double));
            dt.Columns.Add("Stat 2: " + stat2a + stat2op + stat2b, typeof(double));
            dt.Columns.Add("Stat 3: " + stat3a + stat3op + stat3b, typeof(double));

            //use insertion sort to sort the table by stat 1
            int[] idx = new int[names.Count];
            for (int j = 0; j < names.Count; j++)
            {
                int k = j - 1;
                while(k >= 0 && ((stat1_vals[idx[k]] < stat1_vals[j]) || (Double.IsNaN(stat1_vals[idx[k]]) && !Double.IsNaN(stat1_vals[j]))))
                {
                    idx[k + 1] = idx[k];
                    k--;
                }
                idx[k + 1] = j;
            }

            //add each player/team and stat to the table
            for (int j = 0; j < names.Count; j++)
            {
                DataRow r = dt.NewRow();
                r[0] = names[idx[j]];
                r[1] = stat1_vals[idx[j]];
                r[2] = stat2_vals[idx[j]];
                r[3] = stat3_vals[idx[j]];
                dt.Rows.Add(r);
            }

            //set the data source of the data grid view
            dataGridView1.DataSource = dt;
        }

        private void cbx_Game_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Game.SelectedIndex == 0)
            {
                cbx_Gamemode.DataSource = List_Gamemode;
            }
            else
            {
                //list for gamemodes associated with the selected game
                List<string> List_gmfg = new List<string>();
                
                //SQL Query
                string select_gamemode = "SELECT Gamemode_Name " +
                                         "FROM Gametype_Info " +
                                         "WHERE Game_Title = \"" + cbx_Game.SelectedItem.ToString() + "\";";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();

                    //return to default choices
                    cbx_Game.SelectedIndex = 0;
                    cbx_Gamemode.DataSource = List_Gamemode;
                }
            }
        }
    }
}
