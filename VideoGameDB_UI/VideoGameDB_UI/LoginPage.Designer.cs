
namespace VideoGameDB_UI
{
    partial class LoginPage
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
            this.Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeAccount = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 200);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Username.Location = new System.Drawing.Point(71, 136);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 31);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Password.Location = new System.Drawing.Point(71, 193);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(112, 31);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Video Game Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guest
            // 
            this.guest.Location = new System.Drawing.Point(86, 363);
            this.guest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(82, 20);
            this.guest.TabIndex = 7;
            this.guest.Text = "View as guest";
            this.guest.UseVisualStyleBackColor = true;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Login.Location = new System.Drawing.Point(230, 245);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(334, 20);
            this.Login.TabIndex = 8;
            this.Login.Text = "Log in";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "No account? ";
            // 
            // MakeAccount
            // 
            this.MakeAccount.BackColor = System.Drawing.Color.DarkGray;
            this.MakeAccount.Location = new System.Drawing.Point(172, 363);
            this.MakeAccount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MakeAccount.Name = "MakeAccount";
            this.MakeAccount.Size = new System.Drawing.Size(112, 20);
            this.MakeAccount.TabIndex = 15;
            this.MakeAccount.Text = "Make an account";
            this.MakeAccount.UseVisualStyleBackColor = false;
            this.MakeAccount.Click += new System.EventHandler(this.MakeAccount_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(598, 346);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(77, 37);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Exit the Application";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(725, 390);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.MakeAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LoginPage";
            this.Text = "LogIn";
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
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button MakeAccount;
        private System.Windows.Forms.Button btn_close;
    }
}

