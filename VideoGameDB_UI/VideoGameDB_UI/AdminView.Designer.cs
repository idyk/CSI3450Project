
namespace VideoGameDB_UI
{
    partial class Form3
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
            this.uploadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.gameStatList = new System.Windows.Forms.ListBox();
            this.gameStatTypeList = new System.Windows.Forms.ListBox();
            this.statList = new System.Windows.Forms.ListBox();
            this.statTypeList = new System.Windows.Forms.ListBox();
            this.gameTypeList = new System.Windows.Forms.ListBox();
            this.gamemodeList = new System.Windows.Forms.ListBox();
            this.gameList = new System.Windows.Forms.ListBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.teamList = new System.Windows.Forms.ListBox();
            this.conditionsList = new System.Windows.Forms.ListBox();
            this.deleteFromTextBox2 = new System.Windows.Forms.TextBox();
            this.thingToChangeLabel = new System.Windows.Forms.Label();
            this.updateChangeTextBox = new System.Windows.Forms.TextBox();
            this.updateToTextBox = new System.Windows.Forms.TextBox();
            this.teamListBoxUpdate = new System.Windows.Forms.ListBox();
            this.playerListBoxUpdate = new System.Windows.Forms.ListBox();
            this.gameListBoxUpdate = new System.Windows.Forms.ListBox();
            this.gamemodeListBoxUpdate = new System.Windows.Forms.ListBox();
            this.gameTypeListUpdate = new System.Windows.Forms.ListBox();
            this.statTypeListUpdate = new System.Windows.Forms.ListBox();
            this.statListBoxUpdate = new System.Windows.Forms.ListBox();
            this.gameStatTypeListUpdate = new System.Windows.Forms.ListBox();
            this.gameStatListUpdate = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(589, 206);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(69, 24);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Visible = false;
            this.uploadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chosen file:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "       ";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "INSERT INTO",
            "DELETE FROM",
            "UPDATE"});
            this.listBox1.Location = new System.Drawing.Point(29, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 154);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "GameStat",
            "GameStatType",
            "Stat",
            "StatType",
            "Gametype",
            "Gamemode",
            "Game",
            "Player",
            "Team"});
            this.listBox2.Location = new System.Drawing.Point(199, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(153, 154);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("November", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(131, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "You are currently in the ADMIN view.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 49);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(58, 15);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "                 ";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(375, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(375, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(375, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(375, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(375, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(589, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 23);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(589, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 23);
            this.textBox4.TabIndex = 18;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(589, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 23);
            this.textBox5.TabIndex = 19;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(589, 256);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 23);
            this.textBox6.TabIndex = 20;
            this.textBox6.Visible = false;
            // 
            // gameStatList
            // 
            this.gameStatList.FormattingEnabled = true;
            this.gameStatList.ItemHeight = 15;
            this.gameStatList.Items.AddRange(new object[] {
            "Player_ID",
            "Game_ID",
            "GameStatType_ID",
            "GameStat_Value"});
            this.gameStatList.Location = new System.Drawing.Point(504, 172);
            this.gameStatList.Name = "gameStatList";
            this.gameStatList.Size = new System.Drawing.Size(120, 34);
            this.gameStatList.TabIndex = 21;
            this.gameStatList.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // gameStatTypeList
            // 
            this.gameStatTypeList.FormattingEnabled = true;
            this.gameStatTypeList.ItemHeight = 15;
            this.gameStatTypeList.Items.AddRange(new object[] {
            "GameStatType_ID",
            "GameStatType_Name"});
            this.gameStatTypeList.Location = new System.Drawing.Point(504, 172);
            this.gameStatTypeList.Name = "gameStatTypeList";
            this.gameStatTypeList.Size = new System.Drawing.Size(120, 34);
            this.gameStatTypeList.TabIndex = 22;
            // 
            // statList
            // 
            this.statList.FormattingEnabled = true;
            this.statList.ItemHeight = 15;
            this.statList.Items.AddRange(new object[] {
            "Player_ID",
            "Gametype_Gamemode_ID",
            "Gametype_Game_ID",
            "StatType_ID",
            "Stat_Value"});
            this.statList.Location = new System.Drawing.Point(504, 172);
            this.statList.Name = "statList";
            this.statList.Size = new System.Drawing.Size(120, 34);
            this.statList.TabIndex = 23;
            this.statList.SelectedIndexChanged += new System.EventHandler(this.statList_SelectedIndexChanged);
            // 
            // statTypeList
            // 
            this.statTypeList.FormattingEnabled = true;
            this.statTypeList.ItemHeight = 15;
            this.statTypeList.Items.AddRange(new object[] {
            "StatType_ID",
            "StatType_Name"});
            this.statTypeList.Location = new System.Drawing.Point(504, 172);
            this.statTypeList.Name = "statTypeList";
            this.statTypeList.Size = new System.Drawing.Size(120, 34);
            this.statTypeList.TabIndex = 24;
            // 
            // gameTypeList
            // 
            this.gameTypeList.FormattingEnabled = true;
            this.gameTypeList.ItemHeight = 15;
            this.gameTypeList.Items.AddRange(new object[] {
            "Gamemode_ID",
            "Game_ID",
            "Gametype_ExpectedTime"});
            this.gameTypeList.Location = new System.Drawing.Point(504, 172);
            this.gameTypeList.Name = "gameTypeList";
            this.gameTypeList.Size = new System.Drawing.Size(120, 34);
            this.gameTypeList.TabIndex = 25;
            // 
            // gamemodeList
            // 
            this.gamemodeList.FormattingEnabled = true;
            this.gamemodeList.ItemHeight = 15;
            this.gamemodeList.Items.AddRange(new object[] {
            "Gamemode_ID",
            "Gamemode_Name"});
            this.gamemodeList.Location = new System.Drawing.Point(504, 172);
            this.gamemodeList.Name = "gamemodeList";
            this.gamemodeList.Size = new System.Drawing.Size(120, 34);
            this.gamemodeList.TabIndex = 26;
            // 
            // gameList
            // 
            this.gameList.FormattingEnabled = true;
            this.gameList.ItemHeight = 15;
            this.gameList.Items.AddRange(new object[] {
            "Game_ID",
            "Game_Title"});
            this.gameList.Location = new System.Drawing.Point(504, 172);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(120, 34);
            this.gameList.TabIndex = 27;
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 15;
            this.playerList.Items.AddRange(new object[] {
            "Player_ID",
            "Player_Username",
            "Team_ID",
            "Account_ID"});
            this.playerList.Location = new System.Drawing.Point(504, 172);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(120, 34);
            this.playerList.TabIndex = 28;
            // 
            // teamList
            // 
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 15;
            this.teamList.Items.AddRange(new object[] {
            "Team_ID",
            "Player_ID_Leader",
            "Team_Name"});
            this.teamList.Location = new System.Drawing.Point(504, 172);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(120, 34);
            this.teamList.TabIndex = 29;
            // 
            // conditionsList
            // 
            this.conditionsList.FormattingEnabled = true;
            this.conditionsList.ItemHeight = 15;
            this.conditionsList.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.conditionsList.Location = new System.Drawing.Point(734, 176);
            this.conditionsList.Name = "conditionsList";
            this.conditionsList.Size = new System.Drawing.Size(45, 34);
            this.conditionsList.TabIndex = 30;
            this.conditionsList.Visible = false;
            // 
            // deleteFromTextBox2
            // 
            this.deleteFromTextBox2.Location = new System.Drawing.Point(794, 176);
            this.deleteFromTextBox2.Name = "deleteFromTextBox2";
            this.deleteFromTextBox2.Size = new System.Drawing.Size(100, 23);
            this.deleteFromTextBox2.TabIndex = 32;
            this.deleteFromTextBox2.Visible = false;
            // 
            // thingToChangeLabel
            // 
            this.thingToChangeLabel.AutoSize = true;
            this.thingToChangeLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thingToChangeLabel.Location = new System.Drawing.Point(433, 179);
            this.thingToChangeLabel.Name = "thingToChangeLabel";
            this.thingToChangeLabel.Size = new System.Drawing.Size(542, 23);
            this.thingToChangeLabel.TabIndex = 33;
            this.thingToChangeLabel.Text = "Change                                    to                               where " +
    "                                   =";
            // 
            // updateChangeTextBox
            // 
            this.updateChangeTextBox.Location = new System.Drawing.Point(667, 179);
            this.updateChangeTextBox.Name = "updateChangeTextBox";
            this.updateChangeTextBox.Size = new System.Drawing.Size(100, 23);
            this.updateChangeTextBox.TabIndex = 34;
            // 
            // updateToTextBox
            // 
            this.updateToTextBox.Location = new System.Drawing.Point(980, 180);
            this.updateToTextBox.Name = "updateToTextBox";
            this.updateToTextBox.Size = new System.Drawing.Size(100, 23);
            this.updateToTextBox.TabIndex = 35;
            // 
            // teamListBoxUpdate
            // 
            this.teamListBoxUpdate.FormattingEnabled = true;
            this.teamListBoxUpdate.ItemHeight = 15;
            this.teamListBoxUpdate.Items.AddRange(new object[] {
            "Team_ID",
            "Player_ID_Leader",
            "Team_Name"});
            this.teamListBoxUpdate.Location = new System.Drawing.Point(827, 176);
            this.teamListBoxUpdate.Name = "teamListBoxUpdate";
            this.teamListBoxUpdate.Size = new System.Drawing.Size(120, 34);
            this.teamListBoxUpdate.TabIndex = 36;
            // 
            // playerListBoxUpdate
            // 
            this.playerListBoxUpdate.FormattingEnabled = true;
            this.playerListBoxUpdate.ItemHeight = 15;
            this.playerListBoxUpdate.Items.AddRange(new object[] {
            "Player_ID",
            "Player_Username",
            "Team_ID",
            "Account_ID"});
            this.playerListBoxUpdate.Location = new System.Drawing.Point(827, 176);
            this.playerListBoxUpdate.Name = "playerListBoxUpdate";
            this.playerListBoxUpdate.Size = new System.Drawing.Size(120, 34);
            this.playerListBoxUpdate.TabIndex = 37;
            this.playerListBoxUpdate.SelectedIndexChanged += new System.EventHandler(this.playerListBoxUpdate_SelectedIndexChanged);
            // 
            // gameListBoxUpdate
            // 
            this.gameListBoxUpdate.FormattingEnabled = true;
            this.gameListBoxUpdate.ItemHeight = 15;
            this.gameListBoxUpdate.Items.AddRange(new object[] {
            "Game_ID",
            "Game_Title"});
            this.gameListBoxUpdate.Location = new System.Drawing.Point(827, 176);
            this.gameListBoxUpdate.Name = "gameListBoxUpdate";
            this.gameListBoxUpdate.Size = new System.Drawing.Size(120, 34);
            this.gameListBoxUpdate.TabIndex = 38;
            // 
            // gamemodeListBoxUpdate
            // 
            this.gamemodeListBoxUpdate.FormattingEnabled = true;
            this.gamemodeListBoxUpdate.ItemHeight = 15;
            this.gamemodeListBoxUpdate.Items.AddRange(new object[] {
            "Gamemode_ID",
            "Gamemode_Name"});
            this.gamemodeListBoxUpdate.Location = new System.Drawing.Point(827, 176);
            this.gamemodeListBoxUpdate.Name = "gamemodeListBoxUpdate";
            this.gamemodeListBoxUpdate.Size = new System.Drawing.Size(120, 34);
            this.gamemodeListBoxUpdate.TabIndex = 39;
            // 
            // gameTypeListUpdate
            // 
            this.gameTypeListUpdate.FormattingEnabled = true;
            this.gameTypeListUpdate.ItemHeight = 15;
            this.gameTypeListUpdate.Items.AddRange(new object[] {
            "Gamemode_ID",
            "Game_ID",
            "Gametype_ExpectedTime"});
            this.gameTypeListUpdate.Location = new System.Drawing.Point(827, 176);
            this.gameTypeListUpdate.Name = "gameTypeListUpdate";
            this.gameTypeListUpdate.Size = new System.Drawing.Size(120, 34);
            this.gameTypeListUpdate.TabIndex = 40;
            // 
            // statTypeListUpdate
            // 
            this.statTypeListUpdate.FormattingEnabled = true;
            this.statTypeListUpdate.ItemHeight = 15;
            this.statTypeListUpdate.Items.AddRange(new object[] {
            "StatType_ID",
            "StatType_Name"});
            this.statTypeListUpdate.Location = new System.Drawing.Point(827, 176);
            this.statTypeListUpdate.Name = "statTypeListUpdate";
            this.statTypeListUpdate.Size = new System.Drawing.Size(120, 34);
            this.statTypeListUpdate.TabIndex = 41;
            // 
            // statListBoxUpdate
            // 
            this.statListBoxUpdate.FormattingEnabled = true;
            this.statListBoxUpdate.ItemHeight = 15;
            this.statListBoxUpdate.Items.AddRange(new object[] {
            "Player_ID",
            "Gametype_Gamemode_ID",
            "Gametype_Game_ID",
            "StatType_ID",
            "Stat_Value"});
            this.statListBoxUpdate.Location = new System.Drawing.Point(827, 176);
            this.statListBoxUpdate.Name = "statListBoxUpdate";
            this.statListBoxUpdate.Size = new System.Drawing.Size(120, 34);
            this.statListBoxUpdate.TabIndex = 42;
            // 
            // gameStatTypeListUpdate
            // 
            this.gameStatTypeListUpdate.FormattingEnabled = true;
            this.gameStatTypeListUpdate.ItemHeight = 15;
            this.gameStatTypeListUpdate.Items.AddRange(new object[] {
            "GameStatType_ID",
            "GameStatType_Name"});
            this.gameStatTypeListUpdate.Location = new System.Drawing.Point(827, 176);
            this.gameStatTypeListUpdate.Name = "gameStatTypeListUpdate";
            this.gameStatTypeListUpdate.Size = new System.Drawing.Size(120, 34);
            this.gameStatTypeListUpdate.TabIndex = 43;
            // 
            // gameStatListUpdate
            // 
            this.gameStatListUpdate.FormattingEnabled = true;
            this.gameStatListUpdate.ItemHeight = 15;
            this.gameStatListUpdate.Items.AddRange(new object[] {
            "Player_ID",
            "Game_ID",
            "GameStatType_ID",
            "GameStat_Value"});
            this.gameStatListUpdate.Location = new System.Drawing.Point(827, 176);
            this.gameStatListUpdate.Name = "gameStatListUpdate";
            this.gameStatListUpdate.Size = new System.Drawing.Size(120, 34);
            this.gameStatListUpdate.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 150);
            this.dataGridView1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(260, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "1. Pick a table to upload to!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // uploadListBox
            // 
            this.uploadListBox.FormattingEnabled = true;
            this.uploadListBox.ItemHeight = 15;
            this.uploadListBox.Items.AddRange(new object[] {
            "GameStat",
            "GameStatType",
            "Stat",
            "StatType",
            "Gametype",
            "Gamemode",
            "Game",
            "Player",
            "Team"});
            this.uploadListBox.Location = new System.Drawing.Point(517, 60);
            this.uploadListBox.Name = "uploadListBox";
            this.uploadListBox.Size = new System.Drawing.Size(223, 64);
            this.uploadListBox.TabIndex = 47;
            this.uploadListBox.Visible = false;
            this.uploadListBox.SelectedIndexChanged += new System.EventHandler(this.uploadListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(260, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "3. Pick the file! When you hit OK, it will go automatically.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(579, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 19);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Update table?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(895, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 34);
            this.button3.TabIndex = 50;
            this.button3.Text = "Have a .csv file? Click here.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(895, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 34);
            this.button4.TabIndex = 51;
            this.button4.Text = "Go back to manual entry mode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(260, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "2. Decide if you are updating the table!";
            this.label11.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 27);
            this.button5.TabIndex = 53;
            this.button5.Text = "Leave admin view";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteLabel.Location = new System.Drawing.Point(417, 180);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(302, 23);
            this.deleteLabel.TabIndex = 54;
            this.deleteLabel.Text = "DELETE                                           WHERE ";
            this.deleteLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1095, 476);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uploadListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gameStatListUpdate);
            this.Controls.Add(this.gameStatTypeListUpdate);
            this.Controls.Add(this.statListBoxUpdate);
            this.Controls.Add(this.statTypeListUpdate);
            this.Controls.Add(this.gameTypeListUpdate);
            this.Controls.Add(this.gamemodeListBoxUpdate);
            this.Controls.Add(this.gameListBoxUpdate);
            this.Controls.Add(this.playerListBoxUpdate);
            this.Controls.Add(this.teamListBoxUpdate);
            this.Controls.Add(this.updateToTextBox);
            this.Controls.Add(this.updateChangeTextBox);
            this.Controls.Add(this.thingToChangeLabel);
            this.Controls.Add(this.deleteFromTextBox2);
            this.Controls.Add(this.conditionsList);
            this.Controls.Add(this.teamList);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.gamemodeList);
            this.Controls.Add(this.gameTypeList);
            this.Controls.Add(this.statTypeList);
            this.Controls.Add(this.statList);
            this.Controls.Add(this.gameStatTypeList);
            this.Controls.Add(this.gameStatList);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadButton);
            this.Name = "Form3";
            this.Text = "VideoGameDB - Admin View";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox gameStatList;
        private System.Windows.Forms.ListBox gameStatTypeList;
        private System.Windows.Forms.ListBox statList;
        private System.Windows.Forms.ListBox statTypeList;
        private System.Windows.Forms.ListBox gameTypeList;
        private System.Windows.Forms.ListBox gamemodeList;
        private System.Windows.Forms.ListBox gameList;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.ListBox teamList;
        private System.Windows.Forms.ListBox conditionsList;
        private System.Windows.Forms.TextBox deleteFromTextBox2;
        private System.Windows.Forms.Label thingToChangeLabel;
        private System.Windows.Forms.TextBox updateChangeTextBox;
        private System.Windows.Forms.TextBox updateToTextBox;
        private System.Windows.Forms.ListBox teamListBoxUpdate;
        private System.Windows.Forms.ListBox playerListBoxUpdate;
        private System.Windows.Forms.ListBox gameListBoxUpdate;
        private System.Windows.Forms.ListBox gamemodeListBoxUpdate;
        private System.Windows.Forms.ListBox gameTypeListUpdate;
        private System.Windows.Forms.ListBox statTypeListUpdate;
        private System.Windows.Forms.ListBox statListBoxUpdate;
        private System.Windows.Forms.ListBox gameStatTypeListUpdate;
        private System.Windows.Forms.ListBox gameStatListUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox uploadListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label deleteLabel;
    }
}