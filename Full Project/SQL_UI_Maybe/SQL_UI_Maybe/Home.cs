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
        private Form form_rtn;
        
        public Home(Form form_rtn)
        {
            InitializeComponent();
            this.form_rtn = form_rtn;
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
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
