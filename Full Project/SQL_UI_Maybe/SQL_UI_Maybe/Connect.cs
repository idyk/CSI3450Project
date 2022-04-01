using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_UI_Maybe
{
    public static class Connect
    {
        //public const string conn_string = "SERVER=35.199.39.10;DATABASE=VideoGameDB;UID=root;PWD=root;";
        public const string conn_string = "SERVER=localhost;DATABASE=VideoGameDB;UID=appProg;PWD=root;";

        /*private static MySqlConnection connection;
        private static MySqlCommand command = null;
        private static DataTable table;
        private static MySqlDataAdapter adapter;
        
        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "35.199.39.10";
                builder.UserID = "root";
                builder.Password = "root";
                builder.Database = "VideoGameDB";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Connected!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't connect!");
            }
        }


        public static MySqlCommand QueryTest()
        {
            MessageBox.Show("ufsdfsd");
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Account;";
            command.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();
            return command;
        }
        */
    }
}
