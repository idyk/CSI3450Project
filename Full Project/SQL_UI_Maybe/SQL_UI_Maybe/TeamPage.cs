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
        private Form form_rtn;
        private List<string> List_Gamemode;

        public TeamPage(Form form_rtn, int player_num, List<string> List_Game, List<string> List_Gamemode)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
            this.player_num = player_num;
            this.List_Gamemode = List_Gamemode;
            cbx_Game.Items.AddRange(List_Game.ToArray());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            form_rtn.Show();
            this.Close();
        }

        private void cbx_Game_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Gamemode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_chngLeader_Click(object sender, EventArgs e)
        {

        }

        private void btn_kick_Click(object sender, EventArgs e)
        {

        }

        private void btn_delTeam_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
        private void btn_leave_Click(object sender, EventArgs e)
        {

        }

        private void btn_join_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void btn_chngTeamName_Click(object sender, EventArgs e)
        {

        }
    }
}
