//CSI3450 TEAM SORT AND DESTROY

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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void guest_Click(object sender, EventArgs e)
        {
            Form GuestPage = new GuestPage(this);
            this.Hide();
            GuestPage.Show();
            
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3(this);
            this.Hide();
            Form3.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form Home = new Home(this, 1, "ShaneSM");
            Home.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
