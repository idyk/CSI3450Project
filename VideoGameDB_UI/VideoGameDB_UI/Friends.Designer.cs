
namespace VideoGameDB_UI
{
    partial class Friends
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Friend = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.friendslist = new System.Windows.Forms.DataGridView();
            this.frRequest = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.adF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refr = new System.Windows.Forms.Button();
            this.rtn_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Friend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendslist)).BeginInit();
            this.frRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friends";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Friend);
            this.tabControl1.Controls.Add(this.frRequest);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 351);
            this.tabControl1.TabIndex = 1;
            // 
            // Friend
            // 
            this.Friend.Controls.Add(this.button1);
            this.Friend.Controls.Add(this.friendslist);
            this.Friend.Location = new System.Drawing.Point(4, 29);
            this.Friend.Name = "Friend";
            this.Friend.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Friend.Size = new System.Drawing.Size(767, 318);
            this.Friend.TabIndex = 0;
            this.Friend.Text = "Friends List";
            this.Friend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Friend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // friendslist
            // 
            this.friendslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendslist.Location = new System.Drawing.Point(7, 73);
            this.friendslist.Name = "friendslist";
            this.friendslist.RowHeadersWidth = 51;
            this.friendslist.RowTemplate.Height = 29;
            this.friendslist.Size = new System.Drawing.Size(299, 188);
            this.friendslist.TabIndex = 0;
            // 
            // frRequest
            // 
            this.frRequest.Controls.Add(this.button3);
            this.frRequest.Controls.Add(this.adF);
            this.frRequest.Controls.Add(this.dataGridView1);
            this.frRequest.Location = new System.Drawing.Point(4, 29);
            this.frRequest.Name = "frRequest";
            this.frRequest.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.frRequest.Size = new System.Drawing.Size(767, 318);
            this.frRequest.TabIndex = 1;
            this.frRequest.Text = "Pending Request";
            this.frRequest.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 272);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove Pending";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adF
            // 
            this.adF.Location = new System.Drawing.Point(336, 209);
            this.adF.Name = "adF";
            this.adF.Size = new System.Drawing.Size(169, 29);
            this.adF.TabIndex = 1;
            this.adF.Text = "Add Friend";
            this.adF.UseVisualStyleBackColor = true;
            this.adF.Click += new System.EventHandler(this.adF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(299, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(767, 318);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "AddFriend";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Friend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 27);
            this.textBox1.TabIndex = 0;
            // 
            // refr
            // 
            this.refr.Location = new System.Drawing.Point(690, 12);
            this.refr.Name = "refr";
            this.refr.Size = new System.Drawing.Size(94, 29);
            this.refr.TabIndex = 2;
            this.refr.Text = "Refresh";
            this.refr.UseVisualStyleBackColor = true;
            this.refr.Click += new System.EventHandler(this.refr_Click);
            // 
            // rtn_btn
            // 
            this.rtn_btn.Location = new System.Drawing.Point(690, 68);
            this.rtn_btn.Name = "rtn_btn";
            this.rtn_btn.Size = new System.Drawing.Size(94, 29);
            this.rtn_btn.TabIndex = 3;
            this.rtn_btn.Text = "Home";
            this.rtn_btn.UseVisualStyleBackColor = true;
            this.rtn_btn.Click += new System.EventHandler(this.rtn_btn_Click);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.rtn_btn);
            this.Controls.Add(this.refr);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Friends";
            this.Text = "Friends";
            this.tabControl1.ResumeLayout(false);
            this.Friend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendslist)).EndInit();
            this.frRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Friend;
        private System.Windows.Forms.TabPage frRequest;
        private System.Windows.Forms.DataGridView friendslist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adF;
        private System.Windows.Forms.Button refr;
        private System.Windows.Forms.Button rtn_btn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}