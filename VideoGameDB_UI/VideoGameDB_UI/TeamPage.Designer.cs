
namespace VideoGameDB_UI
{
    partial class TeamPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbx_Gamemode = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbx_Game = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbl_GmdStats = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbl_GameStats = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_delTeam = new System.Windows.Forms.Button();
            this.btn_kick = new System.Windows.Forms.Button();
            this.btn_chngLeader = new System.Windows.Forms.Button();
            this.tbl_members = new System.Windows.Forms.DataGridView();
            this.lbl_leader = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.tbl_teams = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_teamSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_chngTeamName = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_newTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GmdStats)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GameStats)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_members)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_teams)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(239, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team Options";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(10, 37);
            this.lbl_team.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(138, 13);
            this.lbl_team.TabIndex = 3;
            this.lbl_team.Text = "Your Team: <Team_Name>";
            this.lbl_team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 276);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(563, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Team Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbx_Gamemode);
            this.groupBox5.Location = new System.Drawing.Point(277, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(122, 47);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gamemode";
            // 
            // cbx_Gamemode
            // 
            this.cbx_Gamemode.Enabled = false;
            this.cbx_Gamemode.FormattingEnabled = true;
            this.cbx_Gamemode.Location = new System.Drawing.Point(10, 18);
            this.cbx_Gamemode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Gamemode.Name = "cbx_Gamemode";
            this.cbx_Gamemode.Size = new System.Drawing.Size(110, 21);
            this.cbx_Gamemode.TabIndex = 1;
            this.cbx_Gamemode.SelectedIndexChanged += new System.EventHandler(this.cbx_Gamemode_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbx_Game);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(122, 47);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game";
            // 
            // cbx_Game
            // 
            this.cbx_Game.Enabled = false;
            this.cbx_Game.FormattingEnabled = true;
            this.cbx_Game.Location = new System.Drawing.Point(6, 18);
            this.cbx_Game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Game.Name = "cbx_Game";
            this.cbx_Game.Size = new System.Drawing.Size(113, 21);
            this.cbx_Game.TabIndex = 0;
            this.cbx_Game.SelectedIndexChanged += new System.EventHandler(this.cbx_Game_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbl_GmdStats);
            this.groupBox3.Location = new System.Drawing.Point(277, 63);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(276, 179);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gamemode Stats for Selected Game";
            // 
            // tbl_GmdStats
            // 
            this.tbl_GmdStats.AllowUserToAddRows = false;
            this.tbl_GmdStats.AllowUserToDeleteRows = false;
            this.tbl_GmdStats.AllowUserToOrderColumns = true;
            this.tbl_GmdStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_GmdStats.Location = new System.Drawing.Point(4, 16);
            this.tbl_GmdStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbl_GmdStats.Name = "tbl_GmdStats";
            this.tbl_GmdStats.ReadOnly = true;
            this.tbl_GmdStats.RowHeadersWidth = 82;
            this.tbl_GmdStats.RowTemplate.Height = 33;
            this.tbl_GmdStats.Size = new System.Drawing.Size(266, 159);
            this.tbl_GmdStats.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbl_GameStats);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(262, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Stats";
            // 
            // tbl_GameStats
            // 
            this.tbl_GameStats.AllowUserToAddRows = false;
            this.tbl_GameStats.AllowUserToDeleteRows = false;
            this.tbl_GameStats.AllowUserToOrderColumns = true;
            this.tbl_GameStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_GameStats.Location = new System.Drawing.Point(4, 16);
            this.tbl_GameStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbl_GameStats.Name = "tbl_GameStats";
            this.tbl_GameStats.ReadOnly = true;
            this.tbl_GameStats.RowHeadersWidth = 82;
            this.tbl_GameStats.RowTemplate.Height = 33;
            this.tbl_GameStats.Size = new System.Drawing.Size(253, 159);
            this.tbl_GameStats.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_delTeam);
            this.tabPage2.Controls.Add(this.btn_kick);
            this.tabPage2.Controls.Add(this.btn_chngLeader);
            this.tabPage2.Controls.Add(this.tbl_members);
            this.tabPage2.Controls.Add(this.lbl_leader);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(563, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team Members";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_delTeam
            // 
            this.btn_delTeam.Enabled = false;
            this.btn_delTeam.Location = new System.Drawing.Point(41, 192);
            this.btn_delTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delTeam.Name = "btn_delTeam";
            this.btn_delTeam.Size = new System.Drawing.Size(74, 37);
            this.btn_delTeam.TabIndex = 4;
            this.btn_delTeam.Text = "Delete Team";
            this.btn_delTeam.UseVisualStyleBackColor = true;
            this.btn_delTeam.Visible = false;
            this.btn_delTeam.Click += new System.EventHandler(this.btn_delTeam_Click);
            // 
            // btn_kick
            // 
            this.btn_kick.Enabled = false;
            this.btn_kick.Location = new System.Drawing.Point(41, 116);
            this.btn_kick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_kick.Name = "btn_kick";
            this.btn_kick.Size = new System.Drawing.Size(74, 53);
            this.btn_kick.TabIndex = 3;
            this.btn_kick.Text = "Kick Selected Member";
            this.btn_kick.UseVisualStyleBackColor = true;
            this.btn_kick.Visible = false;
            this.btn_kick.Click += new System.EventHandler(this.btn_kick_Click);
            // 
            // btn_chngLeader
            // 
            this.btn_chngLeader.Enabled = false;
            this.btn_chngLeader.Location = new System.Drawing.Point(41, 28);
            this.btn_chngLeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_chngLeader.Name = "btn_chngLeader";
            this.btn_chngLeader.Size = new System.Drawing.Size(74, 62);
            this.btn_chngLeader.TabIndex = 2;
            this.btn_chngLeader.Text = "Transfer Leadership to Selected Member";
            this.btn_chngLeader.UseVisualStyleBackColor = true;
            this.btn_chngLeader.Visible = false;
            this.btn_chngLeader.Click += new System.EventHandler(this.btn_chngLeader_Click);
            // 
            // tbl_members
            // 
            this.tbl_members.AllowUserToAddRows = false;
            this.tbl_members.AllowUserToDeleteRows = false;
            this.tbl_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_members.Location = new System.Drawing.Point(182, 28);
            this.tbl_members.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbl_members.Name = "tbl_members";
            this.tbl_members.ReadOnly = true;
            this.tbl_members.RowHeadersWidth = 51;
            this.tbl_members.RowTemplate.Height = 25;
            this.tbl_members.Size = new System.Drawing.Size(184, 219);
            this.tbl_members.TabIndex = 1;
            // 
            // lbl_leader
            // 
            this.lbl_leader.AutoSize = true;
            this.lbl_leader.Location = new System.Drawing.Point(182, 12);
            this.lbl_leader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_leader.Name = "lbl_leader";
            this.lbl_leader.Size = new System.Drawing.Size(175, 13);
            this.lbl_leader.TabIndex = 0;
            this.lbl_leader.Text = "Team Leader: <Leader_Username>";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_join);
            this.tabPage3.Controls.Add(this.btn_leave);
            this.tabPage3.Controls.Add(this.tbl_teams);
            this.tabPage3.Controls.Add(this.btn_search);
            this.tabPage3.Controls.Add(this.txt_teamSearch);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(563, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Join/Leave Team";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_join
            // 
            this.btn_join.Enabled = false;
            this.btn_join.Location = new System.Drawing.Point(400, 161);
            this.btn_join.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(64, 53);
            this.btn_join.TabIndex = 5;
            this.btn_join.Text = "Join Selected Team";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.Enabled = false;
            this.btn_leave.Location = new System.Drawing.Point(400, 49);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(64, 53);
            this.btn_leave.TabIndex = 4;
            this.btn_leave.Text = "Leave Current Team";
            this.btn_leave.UseVisualStyleBackColor = true;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // tbl_teams
            // 
            this.tbl_teams.AllowUserToAddRows = false;
            this.tbl_teams.AllowUserToDeleteRows = false;
            this.tbl_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_teams.Location = new System.Drawing.Point(34, 49);
            this.tbl_teams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbl_teams.Name = "tbl_teams";
            this.tbl_teams.ReadOnly = true;
            this.tbl_teams.RowHeadersWidth = 51;
            this.tbl_teams.RowTemplate.Height = 25;
            this.tbl_teams.Size = new System.Drawing.Size(220, 193);
            this.tbl_teams.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(194, 21);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_teamSearch
            // 
            this.txt_teamSearch.Location = new System.Drawing.Point(34, 24);
            this.txt_teamSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_teamSearch.Name = "txt_teamSearch";
            this.txt_teamSearch.Size = new System.Drawing.Size(120, 20);
            this.txt_teamSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Team Name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_chngTeamName);
            this.tabPage4.Controls.Add(this.btn_create);
            this.tabPage4.Controls.Add(this.txt_newTeamName);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(563, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Create/Edit Team";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_chngTeamName
            // 
            this.btn_chngTeamName.Enabled = false;
            this.btn_chngTeamName.Location = new System.Drawing.Point(284, 120);
            this.btn_chngTeamName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_chngTeamName.Name = "btn_chngTeamName";
            this.btn_chngTeamName.Size = new System.Drawing.Size(74, 38);
            this.btn_chngTeamName.TabIndex = 3;
            this.btn_chngTeamName.Text = "Change Team Name";
            this.btn_chngTeamName.UseVisualStyleBackColor = true;
            this.btn_chngTeamName.Click += new System.EventHandler(this.btn_chngTeamName_Click);
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Location = new System.Drawing.Point(170, 120);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(74, 38);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create Team";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_newTeamName
            // 
            this.txt_newTeamName.Location = new System.Drawing.Point(250, 68);
            this.txt_newTeamName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_newTeamName.Name = "txt_newTeamName";
            this.txt_newTeamName.Size = new System.Drawing.Size(122, 20);
            this.txt_newTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Team Name:";
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(10, 335);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(94, 23);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Return to Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(514, 335);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(64, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // TeamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(588, 365);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TeamPage";
            this.Text = "Team";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GmdStats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GameStats)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_members)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_teams)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbx_Gamemode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbx_Game;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbl_GmdStats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbl_GameStats;
        private System.Windows.Forms.Button btn_delTeam;
        private System.Windows.Forms.Button btn_kick;
        private System.Windows.Forms.Button btn_chngLeader;
        private System.Windows.Forms.DataGridView tbl_members;
        private System.Windows.Forms.Label lbl_leader;
        private System.Windows.Forms.Button btn_chngTeamName;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_newTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tbl_teams;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_teamSearch;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_refresh;
    }
}