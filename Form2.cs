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
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=35.199.39.10;DATABASE=VideoGameDB;UID=root;PWD=root;");
        public Form2()
        {
            InitializeComponent();
            initializeGuestTable();
        }

        public void initializeGuestTable()
        {
            MySqlCommand command_one = new MySqlCommand("SELECT * FROM Stat;", connection);
            MySqlDataAdapter adapter;
            MySqlDataAdapter da = new MySqlDataAdapter();

            connection.Open();
            da.SelectCommand = command_one;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MySqlCommand command_one = new MySqlCommand("SELECT * FROM Stat;", connection);
            MySqlDataAdapter adapter;
            MySqlDataAdapter da = new MySqlDataAdapter();

                connection.Open();
                da.SelectCommand = command_one;

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];

            dataGridView1.DataSource = dt;
                

                connection.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
