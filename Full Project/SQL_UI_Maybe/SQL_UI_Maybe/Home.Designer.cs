namespace SQL_UI_Maybe
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Link = new System.Windows.Forms.Button();
            this.btn_StatsPage = new System.Windows.Forms.Button();
            this.btn_Friends = new System.Windows.Forms.Button();
            this.btn_Team = new System.Windows.Forms.Button();
            this.btn_AcntOptn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbx_Gamemode = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbx_Game = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(578, 7);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(68, 35);
            this.btn_SignOut.TabIndex = 0;
            this.btn_SignOut.Text = "Sign Out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(466, 7);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(103, 30);
            this.lbl_Account.TabIndex = 1;
            this.lbl_Account.Text = "Signed in as:\r\n<Account Name>\r\n";
            this.lbl_Account.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(8, 7);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(170, 15);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Player Username: <Username>";
            // 
            // btn_Link
            // 
            this.btn_Link.Enabled = false;
            this.btn_Link.Location = new System.Drawing.Point(10, 24);
            this.btn_Link.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Link.Name = "btn_Link";
            this.btn_Link.Size = new System.Drawing.Size(108, 38);
            this.btn_Link.TabIndex = 3;
            this.btn_Link.Text = "Link Account to Game Username";
            this.btn_Link.UseVisualStyleBackColor = true;
            this.btn_Link.Visible = false;
            this.btn_Link.Click += new System.EventHandler(this.btn_Link_Click);
            // 
            // btn_StatsPage
            // 
            this.btn_StatsPage.Location = new System.Drawing.Point(359, 84);
            this.btn_StatsPage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StatsPage.Name = "btn_StatsPage";
            this.btn_StatsPage.Size = new System.Drawing.Size(107, 28);
            this.btn_StatsPage.TabIndex = 5;
            this.btn_StatsPage.Text = "Stats Search";
            this.btn_StatsPage.UseVisualStyleBackColor = true;
            this.btn_StatsPage.Click += new System.EventHandler(this.btn_StatsPage_Click);
            // 
            // btn_Friends
            // 
            this.btn_Friends.Enabled = false;
            this.btn_Friends.Location = new System.Drawing.Point(10, 84);
            this.btn_Friends.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Friends.Name = "btn_Friends";
            this.btn_Friends.Size = new System.Drawing.Size(107, 28);
            this.btn_Friends.TabIndex = 6;
            this.btn_Friends.Text = "Friends";
            this.btn_Friends.UseVisualStyleBackColor = true;
            this.btn_Friends.Click += new System.EventHandler(this.btn_Friends_Click);
            // 
            // btn_Team
            // 
            this.btn_Team.Enabled = false;
            this.btn_Team.Location = new System.Drawing.Point(180, 84);
            this.btn_Team.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Team.Name = "btn_Team";
            this.btn_Team.Size = new System.Drawing.Size(107, 28);
            this.btn_Team.TabIndex = 7;
            this.btn_Team.Text = "Team";
            this.btn_Team.UseVisualStyleBackColor = true;
            this.btn_Team.Click += new System.EventHandler(this.btn_Team_Click);
            // 
            // btn_AcntOptn
            // 
            this.btn_AcntOptn.Location = new System.Drawing.Point(539, 84);
            this.btn_AcntOptn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AcntOptn.Name = "btn_AcntOptn";
            this.btn_AcntOptn.Size = new System.Drawing.Size(107, 28);
            this.btn_AcntOptn.TabIndex = 8;
            this.btn_AcntOptn.Text = "Account Options";
            this.btn_AcntOptn.UseVisualStyleBackColor = true;
            this.btn_AcntOptn.Click += new System.EventHandler(this.btn_AcntOptn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(636, 287);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Stats";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbx_Gamemode);
            this.groupBox5.Location = new System.Drawing.Point(313, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 54);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gamemode";
            // 
            // cbx_Gamemode
            // 
            this.cbx_Gamemode.Enabled = false;
            this.cbx_Gamemode.FormattingEnabled = true;
            this.cbx_Gamemode.Location = new System.Drawing.Point(11, 21);
            this.cbx_Gamemode.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Gamemode.Name = "cbx_Gamemode";
            this.cbx_Gamemode.Size = new System.Drawing.Size(127, 23);
            this.cbx_Gamemode.TabIndex = 1;
            this.cbx_Gamemode.SelectedIndexChanged += new System.EventHandler(this.cbx_Gamemode_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbx_Game);
            this.groupBox4.Location = new System.Drawing.Point(4, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game";
            // 
            // cbx_Game
            // 
            this.cbx_Game.Enabled = false;
            this.cbx_Game.FormattingEnabled = true;
            this.cbx_Game.Location = new System.Drawing.Point(7, 21);
            this.cbx_Game.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Game.Name = "cbx_Game";
            this.cbx_Game.Size = new System.Drawing.Size(131, 23);
            this.cbx_Game.TabIndex = 0;
            this.cbx_Game.SelectedIndexChanged += new System.EventHandler(this.cbx_Game_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(313, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(319, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gamemode Stats for Selected Game";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(311, 184);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(4, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(305, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Stats";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(295, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AcntOptn);
            this.Controls.Add(this.btn_Team);
            this.Controls.Add(this.btn_Friends);
            this.Controls.Add(this.btn_StatsPage);
            this.Controls.Add(this.btn_Link);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.btn_SignOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Link;
        private System.Windows.Forms.Button btn_StatsPage;
        private System.Windows.Forms.Button btn_Friends;
        private System.Windows.Forms.Button btn_Team;
        private System.Windows.Forms.Button btn_AcntOptn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_Gamemode;
        private System.Windows.Forms.ComboBox cbx_Game;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

