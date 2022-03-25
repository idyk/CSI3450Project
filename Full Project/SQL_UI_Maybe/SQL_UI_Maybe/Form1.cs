//CSI3450 TEAM SORT AND DESTROY

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void guest_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            this.Hide();
            Form2.Show();
            
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            Form StatsPage = new StatsPage();
            this.Hide();
            StatsPage.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            this.Hide();
            Form3.Show();
        }
    }
}
