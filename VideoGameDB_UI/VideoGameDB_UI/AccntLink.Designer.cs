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
            this.txt_Username.Location = new System.Drawing.Point(197, 85);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(145, 27);
            this.txt_Username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link Account to a Player Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Username:";
            // 
            // btn_Link
            // 
            this.btn_Link.Location = new System.Drawing.Point(151, 145);
            this.btn_Link.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Link.Name = "btn_Link";
            this.btn_Link.Size = new System.Drawing.Size(118, 39);
            this.btn_Link.TabIndex = 3;
            this.btn_Link.Text = "Link to Account";
            this.btn_Link.UseVisualStyleBackColor = true;
            this.btn_Link.Click += new System.EventHandler(this.btn_Link_Click);
            // 
            // bck_Btn
            // 
            this.bck_Btn.Location = new System.Drawing.Point(328, 183);
            this.bck_Btn.Name = "bck_Btn";
            this.bck_Btn.Size = new System.Drawing.Size(94, 29);
            this.bck_Btn.TabIndex = 4;
            this.bck_Btn.Text = "Home";
            this.bck_Btn.UseVisualStyleBackColor = true;
            this.bck_Btn.Click += new System.EventHandler(this.bck_Btn_Click);
            // 
            // AccntLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(434, 224);
            this.Controls.Add(this.bck_Btn);
            this.Controls.Add(this.btn_Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Username);
            this.Margin = new System.Windows.Forms.Padding(2);
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