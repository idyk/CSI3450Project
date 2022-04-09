using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoGameDB_UI
{
    public partial class GuestPage : Form
    {
        MySqlConnection connection = new MySqlConnection(Connect.conn_string);
        Form form_rtn;
        public GuestPage(Form form_rtn)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            initializeGuestTable();
        }

        public void initializeGuestTable()
        {
            MySqlCommand command_one = new MySqlCommand("SELECT Game_Title AS Title FROM Game;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            connection.Open();
            da.SelectCommand = command_one;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            //MySqlCommand command_one = new MySqlCommand("SELECT * FROM Player;", connection);
            //MySqlDataAdapter da = new MySqlDataAdapter();

            //connection.Open();
            //da.SelectCommand = command_one;

            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            //da.Fill(ds);
            //dt = ds.Tables[0];
            //dataGridView1.DataSource = dt;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //connection.Close();          
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            form_rtn.Show();
            this.Close();
        }
    }
}
