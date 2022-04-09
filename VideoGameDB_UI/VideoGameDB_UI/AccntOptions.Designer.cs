namespace VideoGameDB_UI
{
    partial class AccntOptions
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
            this.btn_playerUsername = new System.Windows.Forms.Button();
            this.btn_accntUsername = new System.Windows.Forms.Button();
            this.btn_password = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_noLinkMsg = new System.Windows.Forms.Label();
            this.txt_playerUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_accntUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_playerUsername
            // 
            this.btn_playerUsername.Enabled = false;
            this.btn_playerUsername.Location = new System.Drawing.Point(114, 89);
            this.btn_playerUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_playerUsername.Name = "btn_playerUsername";
            this.btn_playerUsername.Size = new System.Drawing.Size(121, 61);
            this.btn_playerUsername.TabIndex = 0;
            this.btn_playerUsername.Text = "Change Player Username";
            this.btn_playerUsername.UseVisualStyleBackColor = true;
            this.btn_playerUsername.Click += new System.EventHandler(this.btn_playerUsername_Click);
            // 
            // btn_accntUsername
            // 
            this.btn_accntUsername.Location = new System.Drawing.Point(117, 95);
            this.btn_accntUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_accntUsername.Name = "btn_accntUsername";
            this.btn_accntUsername.Size = new System.Drawing.Size(121, 61);
            this.btn_accntUsername.TabIndex = 1;
            this.btn_accntUsername.Text = "Change Account Username";
            this.btn_accntUsername.UseVisualStyleBackColor = true;
            this.btn_accntUsername.Click += new System.EventHandler(this.btn_accntUsername_Click);
            // 
            // btn_password
            // 
            this.btn_password.Location = new System.Drawing.Point(115, 91);
            this.btn_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(121, 61);
            this.btn_password.TabIndex = 2;
            this.btn_password.Text = "Change Password";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Options";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(33, 51);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 235);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_noLinkMsg);
            this.tabPage1.Controls.Add(this.txt_playerUsername);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_playerUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(360, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player Username";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_noLinkMsg
            // 
            this.lbl_noLinkMsg.AutoSize = true;
            this.lbl_noLinkMsg.Location = new System.Drawing.Point(18, 153);
            this.lbl_noLinkMsg.Name = "lbl_noLinkMsg";
            this.lbl_noLinkMsg.Size = new System.Drawing.Size(357, 40);
            this.lbl_noLinkMsg.TabIndex = 3;
            this.lbl_noLinkMsg.Text = "You must first link your account to a player username\r\nbefore you can change the " +
    "player username.";
            // 
            // txt_playerUsername
            // 
            this.txt_playerUsername.Location = new System.Drawing.Point(176, 25);
            this.txt_playerUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_playerUsername.Name = "txt_playerUsername";
            this.txt_playerUsername.Size = new System.Drawing.Size(159, 27);
            this.txt_playerUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Player Username:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_accntUsername);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_accntUsername);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(360, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account Username";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_accntUsername
            // 
            this.txt_accntUsername.Location = new System.Drawing.Point(181, 27);
            this.txt_accntUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_accntUsername.Name = "txt_accntUsername";
            this.txt_accntUsername.Size = new System.Drawing.Size(159, 27);
            this.txt_accntUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Account Username:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_password);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_password);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(360, 202);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Password";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(158, 29);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(159, 27);
            this.txt_password.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 295);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(77, 56);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit Options";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // AccntOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(427, 365);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AccntOptions";
            this.Text = "Account Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_playerUsername;
        private System.Windows.Forms.Button btn_accntUsername;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_playerUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_accntUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_noLinkMsg;
    }
}