namespace VideoGameDB_UI
{
    partial class AccntLink
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Link = new System.Windows.Forms.Button();
            this.bck_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(148, 55);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(110, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link Account to a Player Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Username:";
            // 
            // btn_Link
            // 
            this.btn_Link.Location = new System.Drawing.Point(114, 94);
            this.btn_Link.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Link.Name = "btn_Link";
            this.btn_Link.Size = new System.Drawing.Size(93, 25);
            this.btn_Link.TabIndex = 3;
            this.btn_Link.Text = "Link to Account";
            this.btn_Link.UseVisualStyleBackColor = true;
            this.btn_Link.Click += new System.EventHandler(this.btn_Link_Click);
            // 
            // bck_Btn
            // 
            this.bck_Btn.Location = new System.Drawing.Point(246, 115);
            this.bck_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bck_Btn.Name = "bck_Btn";
            this.bck_Btn.Size = new System.Drawing.Size(70, 23);
            this.bck_Btn.TabIndex = 4;
            this.bck_Btn.Text = "Home";
            this.bck_Btn.UseVisualStyleBackColor = true;
            this.bck_Btn.Click += new System.EventHandler(this.bck_Btn_Click);
            // 
            // AccntLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(326, 146);
            this.Controls.Add(this.bck_Btn);
            this.Controls.Add(this.btn_Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Username);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AccntLink";
            this.Text = "Account Link";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Link;
        private System.Windows.Forms.Button bck_Btn;
    }
}