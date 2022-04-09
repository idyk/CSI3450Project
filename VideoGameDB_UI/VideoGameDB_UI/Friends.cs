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
    public partial class Friends : Form
    {
        MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        private int player_num;
        private int rec;
        private int req;
        private Form rtn;
        private DataTable currentFriends = new DataTable();
        public Friends(int player_num, Form rtn)
        {
            this.rtn = rtn;
            InitializeComponent();
            this.player_num = player_num;
            initializeFriendsList();
            intializeFrReq();
            
        }
        public void initializeFriendsList()
        { 
            MySqlCommand command_one = new MySqlCommand("select * from friend where Friend_Pending = '0' and Player_ID_Receiver = '"+player_num.ToString()+ "' or Friend_Pending = '0' and Player_ID_Requester = '"+player_num.ToString()+"'", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            sda.SelectCommand = command_one;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            int count = 0;
            while (count < dt.Rows.Count) 
            {
                rec = int.Parse(dt.Rows[count][1].ToString());
                req = int.Parse(dt.Rows[count][0].ToString());
                if (player_num != rec)
                {
                    //This means the player is the requester which means the friend is the reciever
                    MySqlCommand command_two = new MySqlCommand("Select Player_Username from player where Player_ID = '"+rec.ToString()+"'", connection);
                    sda.SelectCommand = command_two;
                    sda.Fill(dt1);
                }
                else
                {
                    //This means the player is the reciever which means friend is the req
                    MySqlCommand command_three = new MySqlCommand("Select Player_Username from player where Player_ID = '" + req.ToString() + "'", connection);
                    sda.SelectCommand = command_three;
                    sda.Fill(dt1);
                }
                count = count + 1;
            }
            friendslist.DataSource = dt1;
            friendslist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            currentFriends.Merge(dt1);
            connection.Close();
        }
        public void intializeFrReq()
        {
            MySqlCommand command_one = new MySqlCommand("select Player_ID_Requester from Friend where Player_ID_Receiver = '"+player_num+"' and Friend_Pending = '1' ", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            sda.SelectCommand = command_one;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            int count = 0;
            string id;
            while (count < dt.Rows.Count)
            {
                id = dt.Rows[count][0].ToString();
                MySqlCommand command_two = new MySqlCommand("select Player_Username from player where Player_ID = '"+id+"'", connection);
                sda.SelectCommand = command_two;
                sda.Fill(dt1);
                count = count + 1;
            }
            dataGridView1.DataSource = dt1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            currentFriends.Merge(dt1);
            connection.Close();
        }

        private void adF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }
            string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MySqlCommand command_one = new MySqlCommand("select Player_ID from player where Player_Username = '"+username+"'", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
           
            connection.Open();
            DataTable dt = new DataTable();
            sda.SelectCommand = command_one;
            sda.Fill(dt);
            string fID;
            int count = 0;

            while (count < dt.Rows.Count)
            {
                fID = dt.Rows[count][0].ToString();
                MySqlCommand command_two = new MySqlCommand("Update friend Set Friend_Pending ='0' where Player_ID_Requester = '"+fID+"' and Player_ID_Receiver = '"+player_num.ToString()+"'", connection);
                command_two.ExecuteNonQuery();
                count = count + 1;

            }
            connection.Close();
            intializeFrReq();
            initializeFriendsList();
        }

        private void refr_Click(object sender, EventArgs e)
        {
            intializeFrReq();
            initializeFriendsList();
        }

        private void rtn_btn_Click(object sender, EventArgs e)
        {
            rtn.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            MySqlCommand command_one = new MySqlCommand("select Player_ID from player where Player_Username = '" + username + "'", connection);
            int hold = 0;
            connection.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = command_one;
            DataTable id = new DataTable();
            DataTable test = new DataTable();
            sda.Fill(id);
            int count = 0;
            int checker = 0;
                if (id.Rows.Count == 0)
                {
                    MessageBox.Show("User Not Found");
                }
                else
                {
                if (int.Parse(id.Rows[0][0].ToString()) != player_num)
                {
                    while (count < currentFriends.Rows.Count)
                    {
                        if (username == currentFriends.Rows[count][0].ToString())
                        {
                            MessageBox.Show("User is already either on your friends list or is pending.");
                            count = currentFriends.Rows.Count + count;
                        }
                        else
                        {
                            checker = checker + 1;
                        }
                        count = count + 1;
                    }
                    if (checker == currentFriends.Rows.Count)
                    {
                        MySqlCommand command_three = new MySqlCommand("select count(*) from friend where Player_ID_Requester = '" + player_num + "' and Player_ID_Receiver = '" + id.Rows[0][0].ToString() + "'", connection);
                        sda.SelectCommand = command_three;
                        sda.Fill(test);
                        hold = int.Parse(test.Rows[0][0].ToString());
                        if (hold == 0)
                        {
                            MySqlCommand command_two = new MySqlCommand("insert into friend values (" + player_num + "," + id.Rows[0][0].ToString() + ",1)", connection);
                            command_two.ExecuteNonQuery();
                            MessageBox.Show("You are now on " + username + "'s friends pending list.");
                        }
                        else
                        {
                            MessageBox.Show("You already sent a request to this person!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You Entered your own username.");
                }
                }
            
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (friendslist.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }
            string username = friendslist.SelectedRows[0].Cells[0].Value.ToString();
            MySqlCommand command_one = new MySqlCommand("select Player_ID from player where Player_Username = '" + username + "'", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            DataTable dt = new DataTable();
            sda.SelectCommand = command_one;
            sda.Fill(dt);
            int id = int.Parse(dt.Rows[0][0].ToString());
            MySqlCommand command_two = new MySqlCommand("delete from friend where Friend_Pending = '0' and Player_ID_Requester = '"+player_num+"' and Player_ID_Receiver = '"+id+"' or Friend_Pending = '0' and Player_ID_Requester = '"+id+"' and Player_ID_Receiver = '"+player_num+"'", connection);
            command_two.ExecuteNonQuery();
            MessageBox.Show("Friend has been removed!");
            connection.Close();
            DataTable zero = new DataTable();
            currentFriends = zero;
            initializeFriendsList();
            intializeFrReq();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error!\nYou must select exactly one entire row.");
                return;
            }
            string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MySqlCommand command_one = new MySqlCommand("select Player_ID from player where Player_Username = '" + username + "'", connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            connection.Open();
            DataTable dt = new DataTable();
            sda.SelectCommand = command_one;
            sda.Fill(dt);
            int id = int.Parse(dt.Rows[0][0].ToString());
            MySqlCommand command_two = new MySqlCommand("delete from friend where Friend_Pending = '1' and Player_ID_Requester = '" + player_num + "' and Player_ID_Receiver = '" + id + "' or Friend_Pending = '1' and Player_ID_Requester = '" + id + "' and Player_ID_Receiver = '" + player_num + "'", connection);
            command_two.ExecuteNonQuery();
            MessageBox.Show("Pending Friend has been removed!");
            connection.Close();
            DataTable zero = new DataTable();
            currentFriends = zero;
            initializeFriendsList();
            intializeFrReq();
        }
    }
}
