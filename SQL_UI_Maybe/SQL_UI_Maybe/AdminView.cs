using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SQL_UI_Maybe
{

    public partial class Form3 : Form
    {
        private Form form_rtn;
        
        public Form3(Form form_rtn)
        {          
            InitializeComponent();
            this.form_rtn = form_rtn;
            gameStatList.Visible = false;
            gameStatTypeList.Visible = false;
            statList.Visible = false;
            statTypeList.Visible = false;
            gameTypeList.Visible = false;
            gamemodeList.Visible = false;
            teamList.Visible = false;
            playerList.Visible = false;
            gameList.Visible = false;
            gameStatListUpdate.Visible = false;
            gameStatTypeListUpdate.Visible = false;
            statListBoxUpdate.Visible = false;
            statTypeListUpdate.Visible = false;
            gameTypeListUpdate.Visible = false;
            gamemodeListBoxUpdate.Visible = false;
            gameListBoxUpdate.Visible = false;
            playerListBoxUpdate.Visible = false;
            teamListBoxUpdate.Visible = false;
            thingToChangeLabel.Visible = false;
            updateChangeTextBox.Visible = false;
            updateToTextBox.Visible = false;
            deleteLabel.Visible = false;
            thingToChangeLabel.SendToBack();
            deleteLabel.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //127.0.0.1  35.199.39.10
            MySqlConnection connection = new MySqlConnection(Connect.conn_string);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            var filePath = "@" + openFileDialog.FileName;
            var fileContent = string.Empty;

            connection.Open();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                label2.Text = filePath;
                MySqlDataAdapter da = new MySqlDataAdapter();
                var fileStream = openFileDialog.OpenFile();


                //Two attribute files
                if (uploadListBox.Text != null && uploadListBox.Text == "GameStatType" || uploadListBox.Text == "Game" || uploadListBox.Text == "Gamemode" || uploadListBox.Text == "StatType")
                {
                    try
                    {
                        using (TextFieldParser csvParser = new TextFieldParser(filePath))
                        {
                            csvParser.SetDelimiters(new string[] { "," });
                            csvParser.HasFieldsEnclosedInQuotes = true;
                            csvParser.ReadLine();


                            while (!csvParser.EndOfData)
                            {
                                string[] csvText = csvParser.ReadFields();
                                string firstValue = csvText[0];
                                string secondValue = csvText[1];

                                if (checkBox1.Checked && uploadListBox.Text == "GameStatType")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET GameStatType_Name = '" + secondValue + "' WHERE GameStatType_ID = '" + firstValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }
                                else if (checkBox1.Checked && uploadListBox.Text == "Game")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Game_Title = '" + secondValue + "' WHERE Game_ID = '" + firstValue + "';", connection);

                                    command.ExecuteNonQuery();


                                }
                                else if (checkBox1.Checked && uploadListBox.Text == "Gamemode")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Gamemode_Name = '" + secondValue + "' WHERE Gamemode_ID = '" + firstValue + "';", connection);

                                    command.ExecuteNonQuery();


                                }
                                else if (checkBox1.Checked && uploadListBox.Text == "StatType")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET StatType_Name = '" + secondValue + "' WHERE StatType_ID = '" + firstValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }
                                else
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO " + uploadListBox.Text + " VALUES('" + firstValue + "', '" + secondValue + "');", connection);

                                    command.ExecuteNonQuery();

                                }
                            }
                        }
                    }
                    catch(Exception exc)
                    {

                    }
                }

                //Four attribute files
                if (uploadListBox.Text != null && uploadListBox.Text == "GameStat" || uploadListBox.Text == "Player")
                {
                    try
                    {
                        using (TextFieldParser csvParser = new TextFieldParser(filePath))
                        {

                            csvParser.SetDelimiters(new string[] { "," });
                            csvParser.HasFieldsEnclosedInQuotes = true;

                            csvParser.ReadLine();

                            while (!csvParser.EndOfData)
                            {
                                string[] csvText = csvParser.ReadFields();
                                string firstValue = csvText[0];
                                string secondValue = csvText[1];
                                string thirdValue = csvText[2];
                                string fourthValue = csvText[3];


                                if (checkBox1.Checked && uploadListBox.Text == "GameStat")
                                {

                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET GameStat_Value = '" + fourthValue + "' WHERE Player_ID = '" + firstValue + "' AND Game_ID = '" + secondValue + "' AND GameStatType_ID = '" + thirdValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }

                                else if (checkBox1.Checked && uploadListBox.Text == "Player")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Player_Username = '" + secondValue + "' WHERE Player_ID = '" + firstValue + "' AND Team_ID = '" + thirdValue + "' AND Account_ID = '" + fourthValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }

                                else
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO " + uploadListBox.Text + " VALUES('" + firstValue + "', '" + secondValue + "', '" + thirdValue + "', '" + fourthValue + "');", connection);

                                    command.ExecuteNonQuery();

                                }
                            }

                        }
                    }
                    catch(Exception exc)
                    {

                    }
                    connection.Close();
                }

                //Five attribute files
                if (uploadListBox.Text != null && uploadListBox.Text == "Stat")
                {
                    try
                    {
                        using (TextFieldParser csvParser = new TextFieldParser(filePath))
                        {
                            csvParser.SetDelimiters(new string[] { "," });
                            csvParser.HasFieldsEnclosedInQuotes = true;

                            csvParser.ReadLine();

                            while (!csvParser.EndOfData)
                            {
                                string[] csvText = csvParser.ReadFields();
                                string firstValue = csvText[0];
                                string secondValue = csvText[1];
                                string thirdValue = csvText[2];
                                string fourthValue = csvText[3];
                                string fifthValue = csvText[4];

                                if (checkBox1.Checked && uploadListBox.Text == "Stat")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Stat_Value = '" + fifthValue + "' WHERE Player_ID = '" + firstValue + "' AND Gametype_Gamemode_ID = '" + secondValue + "' AND Gametype_Game_ID = '" + thirdValue + "' AND StatType_ID = '" + fourthValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }

                                else
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO " + uploadListBox.Text + " VALUES('" + firstValue + "', '" + secondValue + "', '" + thirdValue + "', '" + fourthValue + "', '" + fifthValue + "');", connection);

                                    command.ExecuteNonQuery();

                                }
                            }
                        }
                    }
                    catch(Exception exc)
                    {

                    }
                }

                //Three attribute files
                if (uploadListBox.Text != null && uploadListBox.Text == "Gametype" || uploadListBox.Text == "Team")
                {
                    try
                    {
                        using (TextFieldParser csvParser = new TextFieldParser(filePath))
                        {
                            csvParser.SetDelimiters(new string[] { "," });
                            csvParser.HasFieldsEnclosedInQuotes = true;

                            csvParser.ReadLine();

                            while (!csvParser.EndOfData)
                            {
                                string[] csvText = csvParser.ReadFields();
                                string firstValue = csvText[0];
                                string secondValue = csvText[1];
                                string thirdValue = csvText[2];

                                if (checkBox1.Checked && uploadListBox.Text == "Gametype")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Gametype_ExpectedTime = '" + thirdValue + "' WHERE Gamemode_ID = '" + firstValue + "' AND Game_ID = '" + secondValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }
                                else if (checkBox1.Checked && uploadListBox.Text == "Team")
                                {
                                    MySqlCommand command = new MySqlCommand("UPDATE " + uploadListBox.Text + " SET Team_Name = '" + thirdValue + "' WHERE Team_ID = '" + firstValue + "' AND Player_ID_Leader = '" + secondValue + "';", connection);

                                    command.ExecuteNonQuery();

                                }
                                else
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO " + uploadListBox.Text + " VALUES('" + firstValue + "', '" + secondValue + "', '" + thirdValue + "');", connection);

                                    command.ExecuteNonQuery();

                                }
                            }
                        }
                    }
                    catch(Exception exc)
                    {

                    }
                }
            }
            connection.Close();

            connection.Open();

            MySqlDataAdapter ada = new MySqlDataAdapter();

            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM " + uploadListBox.Text + ";", connection);

            ada.SelectCommand = selectCommand;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                ada.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }


            connection.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = false;
                updateToTextBox.Visible = false;
                thingToChangeLabel.Visible = false;
                conditionsList.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                gameList.Visible = false;
                gameStatListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;

            }

            if(listBox1.Text == "DELETE FROM")
            {
                updateChangeTextBox.Visible = false;
                updateToTextBox.Visible = false;
                thingToChangeLabel.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
            }

            if(listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = false;
                updateToTextBox.Visible = false;
                thingToChangeLabel.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;

                conditionsList.Visible = false;
                deleteFromTextBox2.Visible = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.Text == "GameStat" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                gameList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;              
                label6.Text = "Player_ID";
                label7.Text = "Game_ID";
                label8.Text = "GameStatType_ID";
                label9.Text = "GameStat_Value";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = false;
                conditionsList.Visible = false;
        
            }
            if(listBox2.Text == "Player" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
                label6.Text = "Player_ID";
                label7.Text = "Player_Username";
                label8.Text = "Team_ID";
                label9.Text = "Account_ID";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = false;
                conditionsList.Visible = false;
   
            }
            if(listBox2.Text == "GameStatType" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "GameStatType_ID";
                label7.Text = "GameStatType_Name";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
  

            }

            if (listBox2.Text == "Game" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "Game_ID";
                label7.Text = "Game_Title";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
        
            }

            if (listBox2.Text == "Gamemode" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "Gamemode_ID";
                label7.Text = "Gamemode_Name";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
      
            }

            if (listBox2.Text == "Gametype" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "Gamemode_ID";
                label7.Text = "Game_ID";
                label8.Text = "GameType_ExpectedTime";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
         
            }

            if (listBox2.Text == "Stat" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label6.Text = "Player_ID";
                label7.Text = "Gametype_Gamemode_ID";
                label8.Text = "Gametype_Game_ID";
                label9.Text = "StatType_ID";
                label10.Text = "Stat_Value";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                conditionsList.Visible = false;
      
            }

            if(listBox2.Text == "StatType" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                teamList.Visible = false;
                playerList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "StatType_ID";
                label7.Text = "StatType_Name";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
         
            }


            if (listBox2.Text == "Team" && listBox1.Text == "INSERT INTO")
            {
                deleteLabel.Visible = false;
                deleteFromTextBox2.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Text = "Team_ID";
                label7.Text = "Player_ID_Leader";
                label8.Text = "Team_Name";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                conditionsList.Visible = false;
         
            }



            //FOR DELETE FROM
            if (listBox2.Text == "GameStat" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;              
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = true;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;
       

            }
            if(listBox2.Text == "Player" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = true;
                teamList.Visible = false;
                conditionsList.Visible = true;
          
            }
            if(listBox2.Text == "GameStatType" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = true;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;
       

            }

            if (listBox2.Text == "Game" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = true;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;
          
            }

            if (listBox2.Text == "Gamemode" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = true;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;
       
            }

            if (listBox2.Text == "Gametype" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = true;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;
      
            }

            if (listBox2.Text == "Stat" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = true;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;

            }

            if(listBox2.Text == "StatType" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = true;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = true;

            }

            if (listBox2.Text == "Team" && listBox1.Text == "DELETE FROM")
            {
                deleteLabel.Visible = true;
                deleteFromTextBox2.Visible = true;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = true;
                conditionsList.Visible = true;
            }

            //FOR UPDATE
            if (listBox2.Text == "GameStat" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;

                gameStatList.Visible = true;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;

                gameStatListUpdate.Visible = true;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
            }
            if (listBox2.Text == "Player" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = true;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = true;
                teamListBoxUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;

            }
            if (listBox2.Text == "GameStatType" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = true;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = true;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;


            }

            if (listBox2.Text == "Game" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = true;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = true;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;

            }

            if (listBox2.Text == "Gamemode" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = true;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = true;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;

            }

            if (listBox2.Text == "Gametype" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = true;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = true;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;

            }

            if (listBox2.Text == "Stat" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = true;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = true;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;

            }

            if (listBox2.Text == "StatType" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = true;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = false;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = true;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = false;

            }

            if (listBox2.Text == "Team" && listBox1.Text == "UPDATE")
            {
                deleteLabel.Visible = false;
                updateChangeTextBox.Visible = true;
                updateToTextBox.Visible = true;
                thingToChangeLabel.Visible = true;
                deleteFromTextBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                gameStatList.Visible = false;
                gameStatTypeList.Visible = false;
                statList.Visible = false;
                statTypeList.Visible = false;
                gameTypeList.Visible = false;
                gamemodeList.Visible = false;
                gameList.Visible = false;
                playerList.Visible = false;
                teamList.Visible = true;
                conditionsList.Visible = false;
                gameStatListUpdate.Visible = false;
                gameStatTypeListUpdate.Visible = false;
                statListBoxUpdate.Visible = false;
                statTypeListUpdate.Visible = false;
                gameTypeListUpdate.Visible = false;
                gamemodeListBoxUpdate.Visible = false;
                gameListBoxUpdate.Visible = false;
                playerListBoxUpdate.Visible = false;
                teamListBoxUpdate.Visible = true;
            }
            //  35.199.39.10   127.0.0.1
            MySqlConnection connection = new MySqlConnection(Connect.conn_string);

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter();

            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM " + listBox2.Text + ";", connection);

            da.SelectCommand = selectCommand;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            uploadListBox.ClearSelected();
            MySqlConnection connection = new MySqlConnection(Connect.conn_string);
           
            connection.Open();
            try
            {
                //INSERT INTO
                if (textBox1.Enabled == true && listBox1.Text == "INSERT INTO" && listBox2.Text != null) {
                    System.Diagnostics.Debug.WriteLine(listBox1.Text);

                    //For entities with FOUR attributes
                    if (listBox2.Text == "GameStat" || listBox2.Text == "Player")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " VALUES(" + textBox1.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ");", connection);
                            command.ExecuteNonQuery();
                        }
                        catch(Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }

                        connection.Close();
                    }

                    //For entities with TWO attributes
                    if(listBox2.Text == "GameStatType" || listBox2.Text == "Game" || listBox2.Text == "Gamemode" || listBox2.Text == "StatType")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " VALUES('" + textBox1.Text + "','" + textBox3.Text + "');", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }

                    //For entities with FIVE attributes
                    if (listBox2.Text == "Stat")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " VALUES('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "');", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }

                    //For entities with THREE attributes
                    if (listBox2.Text == "Gametype" || listBox2.Text == "Team")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " VALUES('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }

                }
                //DELETE FROM
                if (listBox1.Text == "DELETE FROM" && listBox2.Text != null)
                    {        
                    System.Diagnostics.Debug.WriteLine(listBox1.Text);
                    if (listBox2.Text == "GameStat")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + gameStatList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }

                    if (listBox2.Text == "GameStatType")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + gameStatTypeList.Text + " " + conditionsList.Text + "'" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Stat")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + statList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "StatType")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + statTypeList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Gametype")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + gameTypeList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Gamemode")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + gamemodeList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Player")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + playerList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Team")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + teamList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Game")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " WHERE " + gameList.Text + " " + conditionsList.Text + " '" + deleteFromTextBox2.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                }

                //UPDATE
                if (listBox1.Text == "UPDATE" && listBox2.Text != null)
                {
                    System.Diagnostics.Debug.WriteLine(listBox1.Text);

                    if (listBox2.Text == "Player")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + playerList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + playerListBoxUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "GameStat")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + gameStatList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + gameStatListUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "GameStatType")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + gameStatTypeList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + gameStatTypeListUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "StatType")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + statTypeList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + statTypeListUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Gametype")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + gameTypeList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + gameTypeListUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Gamemode")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + gamemodeList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + gamemodeListBoxUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Game")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + gameList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + gameListBoxUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Team")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + teamList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + teamListBoxUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                    if (listBox2.Text == "Stat")
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(listBox1.Text + " " + listBox2.Text + " SET " + statList.Text + " = '" + updateChangeTextBox.Text + "' WHERE " + statListBoxUpdate.Text + " = '" + updateToTextBox.Text + "';", connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exc)
                        {
                            System.Diagnostics.Debug.WriteLine(exc);
                        }
                        connection.Close();
                    }
                }

            }
            catch(Exception exec)
            {
                System.Diagnostics.Debug.WriteLine(exec.Message);
                errorLabel.Text = exec.Message;
            }
            connection.Close();

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter();

            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM " + listBox2.Text + ";", connection);

            da.SelectCommand = selectCommand;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }


            connection.Close();
        }


       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playerListBoxUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteLabel.Visible = false;
            button2.Visible = false;
            label11.Visible = true;
            label3.Visible = true;
            uploadListBox.Visible = true;
            label4.Visible = true;
            uploadButton.Visible = true;
            checkBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            thingToChangeLabel.Visible = false;
            gameStatList.Visible = false;
            gameStatTypeList.Visible = false;
            deleteFromTextBox2.Visible = false;
            gameStatList.Visible = false;
            gameStatTypeList.Visible = false;
            statList.Visible = false;
            statTypeList.Visible = false;
            gameTypeList.Visible = false;
            gamemodeList.Visible = false;
            teamList.Visible = false;
            playerList.Visible = false;
            gameList.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            conditionsList.Visible = false;
            updateToTextBox.Visible = false;
            updateChangeTextBox.Visible = false;
            deleteFromTextBox2.Visible = false;
            gameStatListUpdate.Visible = false;
            statListBoxUpdate.Visible = false;
            statTypeListUpdate.Visible = false;
            gameTypeListUpdate.Visible = false;
            gamemodeListBoxUpdate.Visible = false;
            gameListBoxUpdate.Visible = false;
            playerListBoxUpdate.Visible = false;
            teamListBoxUpdate.Visible = false;
            gameStatTypeListUpdate.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteLabel.Visible = false;
            button2.Visible = true;
            label11.Visible = false;
            button4.Visible = false;
            label3.Visible = false;
            uploadListBox.Visible = false;
            label4.Visible = false;
            uploadButton.Visible = false;
            checkBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button3.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            thingToChangeLabel.Visible = false;
            gameStatList.Visible = false;
            gameStatTypeList.Visible = false;
            deleteFromTextBox2.Visible = false;
            gameStatList.Visible = false;
            gameStatTypeList.Visible = false;
            statList.Visible = false;
            statTypeList.Visible = false;
            gameTypeList.Visible = false;
            gamemodeList.Visible = false;
            teamList.Visible = false;
            playerList.Visible = false;
            gameList.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void uploadListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  35.199.39.10   127.0.0.1
            MySqlConnection connection = new MySqlConnection(Connect.conn_string);

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter();

            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM " + uploadListBox.Text + ";", connection);

            da.SelectCommand = selectCommand;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch(Exception exc)
            {

            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form_rtn.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
