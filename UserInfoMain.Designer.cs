namespace UserInfo
{
    partial class UserInfoMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvFace = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label25 = new System.Windows.Forms.Label();
            this.cbUserIDDE = new System.Windows.Forms.ComboBox();
            this.UserIDTimer = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadFace = new System.Windows.Forms.Button();
            this.btnDownLoadFace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInfo.Properties.Resources.top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 557);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // lvFace
            // 
            this.lvFace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.sEnabled,
            this.columnHeader15});
            this.lvFace.GridLines = true;
            this.lvFace.Location = new System.Drawing.Point(8, 184);
            this.lvFace.Name = "lvFace";
            this.lvFace.Size = new System.Drawing.Size(525, 280);
            this.lvFace.TabIndex = 68;
            this.lvFace.UseCompatibleStateImageBehavior = false;
            this.lvFace.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UserID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Password";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Privilege";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "FaceIndex";
            this.columnHeader11.Width = 69;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TmpData";
            this.columnHeader12.Width = 57;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Length";
            this.columnHeader13.Width = 40;
            // 
            // sEnabled
            // 
            this.sEnabled.Text = "Enabled";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "AIData";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 520);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "UserID";
            // 
            // cbUserIDDE
            // 
            this.cbUserIDDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserIDDE.FormattingEnabled = true;
            this.cbUserIDDE.Location = new System.Drawing.Point(51, 517);
            this.cbUserIDDE.Name = "cbUserIDDE";
            this.cbUserIDDE.Size = new System.Drawing.Size(180, 21);
            this.cbUserIDDE.TabIndex = 16;
            // 
            // UserIDTimer
            // 
            this.UserIDTimer.Enabled = true;
            this.UserIDTimer.Tick += new System.EventHandler(this.UserIDTimer_Tick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(150, 125);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(138, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(6, 20);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(513, 102);
            this.tabControl3.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtPort);
            this.tabPage3.Controls.Add(this.txtIP);
            this.tabPage3.Controls.Add(this.btnConnect);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(505, 76);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "TCP/IP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.188";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(181, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.btnRsConnect);
            this.tabPage6.Controls.Add(this.txtMachineSN);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.cbBaudRate);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.cbPort);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(505, 76);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "RS232/485";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(183, 43);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(75, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(356, 10);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 20);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "MachineSN";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(206, 10);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "BaudRate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPort.Location = new System.Drawing.Point(71, 10);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl3);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(8, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 146);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // btnUploadFace
            // 
            this.btnUploadFace.Location = new System.Drawing.Point(251, 488);
            this.btnUploadFace.Name = "btnUploadFace";
            this.btnUploadFace.Size = new System.Drawing.Size(130, 23);
            this.btnUploadFace.TabIndex = 69;
            this.btnUploadFace.Text = "UploadFaceTemplates";
            this.btnUploadFace.UseVisualStyleBackColor = true;
            this.btnUploadFace.Click += new System.EventHandler(this.btnUploadFace_Click);
            // 
            // btnDownLoadFace
            // 
            this.btnDownLoadFace.Location = new System.Drawing.Point(51, 488);
            this.btnDownLoadFace.Name = "btnDownLoadFace";
            this.btnDownLoadFace.Size = new System.Drawing.Size(142, 23);
            this.btnDownLoadFace.TabIndex = 70;
            this.btnDownLoadFace.Text = "DownLoadFaceTemplates";
            this.btnDownLoadFace.UseVisualStyleBackColor = true;
            this.btnDownLoadFace.Click += new System.EventHandler(this.btnDownLoadFace_Click);
            // 
            // UserInfoMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(562, 557);
            this.Controls.Add(this.lvFace);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnDownLoadFace);
            this.Controls.Add(this.btnUploadFace);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbUserIDDE);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserInfoMain";
            this.Text = "AIUserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvFace;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader sEnabled;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbUserIDDE;
        private System.Windows.Forms.Timer UserIDTimer;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button btnDownLoadFace;
        private System.Windows.Forms.Button btnUploadFace;
    }
}

