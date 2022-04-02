﻿
namespace SQL_UI_Maybe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Button();
            this.Friends = new System.Windows.Forms.Button();
            this.Team = new System.Windows.Forms.Button();
            this.GameStats = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.MakeAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 23);
            this.textBox2.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(83, 157);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 31);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(83, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(112, 31);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Video Game Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guest
            // 
            this.guest.Location = new System.Drawing.Point(100, 419);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(95, 23);
            this.guest.TabIndex = 7;
            this.guest.Text = "View as guest";
            this.guest.UseVisualStyleBackColor = true;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Log in";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "No account? ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(464, 336);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(111, 23);
            this.Stats.TabIndex = 10;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Friends
            // 
            this.Friends.Location = new System.Drawing.Point(613, 336);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(110, 23);
            this.Friends.TabIndex = 11;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(464, 389);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(111, 23);
            this.Team.TabIndex = 12;
            this.Team.Text = "Team";
            this.Team.UseVisualStyleBackColor = true;
            // 
            // GameStats
            // 
            this.GameStats.Location = new System.Drawing.Point(613, 389);
            this.GameStats.Name = "GameStats";
            this.GameStats.Size = new System.Drawing.Size(110, 23);
            this.GameStats.TabIndex = 13;
            this.GameStats.Text = "Game Stats";
            this.GameStats.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(332, 336);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(98, 23);
            this.Admin.TabIndex = 14;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // MakeAccount
            // 
            this.MakeAccount.Location = new System.Drawing.Point(201, 419);
            this.MakeAccount.Name = "MakeAccount";
            this.MakeAccount.Size = new System.Drawing.Size(130, 23);
            this.MakeAccount.TabIndex = 15;
            this.MakeAccount.Text = "Make an account";
            this.MakeAccount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MakeAccount);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.GameStats);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.Friends);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button Friends;
        private System.Windows.Forms.Button Team;
        private System.Windows.Forms.Button GameStats;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button MakeAccount;
    }
}
