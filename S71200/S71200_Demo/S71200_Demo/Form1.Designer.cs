namespace S71200_Demo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.tbRack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Write = new System.Windows.Forms.Button();
            this.bt_Read = new System.Windows.Forms.Button();
            this.comboxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Disconnect);
            this.groupBox1.Controls.Add(this.bt_Connect);
            this.groupBox1.Controls.Add(this.tbSlot);
            this.groupBox1.Controls.Add(this.tbRack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC配置";
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Disconnect.Location = new System.Drawing.Point(227, 195);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.bt_Disconnect.TabIndex = 7;
            this.bt_Disconnect.Text = "断开";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Connect.Location = new System.Drawing.Point(112, 195);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(75, 23);
            this.bt_Connect.TabIndex = 6;
            this.bt_Connect.Text = "连接";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // tbSlot
            // 
            this.tbSlot.Location = new System.Drawing.Point(112, 131);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.Size = new System.Drawing.Size(190, 21);
            this.tbSlot.TabIndex = 5;
            this.tbSlot.Text = "1";
            // 
            // tbRack
            // 
            this.tbRack.Location = new System.Drawing.Point(112, 86);
            this.tbRack.Name = "tbRack";
            this.tbRack.Size = new System.Drawing.Size(190, 21);
            this.tbRack.TabIndex = 4;
            this.tbRack.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(62, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slot：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rack：";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(112, 37);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(190, 21);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "192.168.1.10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Write);
            this.groupBox2.Controls.Add(this.bt_Read);
            this.groupBox2.Controls.Add(this.comboxType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbWrite);
            this.groupBox2.Controls.Add(this.tbStart);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(39, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读写数据";
            // 
            // bt_Write
            // 
            this.bt_Write.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Write.Location = new System.Drawing.Point(226, 223);
            this.bt_Write.Name = "bt_Write";
            this.bt_Write.Size = new System.Drawing.Size(75, 23);
            this.bt_Write.TabIndex = 14;
            this.bt_Write.Text = "写";
            this.bt_Write.UseVisualStyleBackColor = true;
            this.bt_Write.Click += new System.EventHandler(this.bt_Write_Click);
            // 
            // bt_Read
            // 
            this.bt_Read.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Read.Location = new System.Drawing.Point(111, 223);
            this.bt_Read.Name = "bt_Read";
            this.bt_Read.Size = new System.Drawing.Size(75, 23);
            this.bt_Read.TabIndex = 8;
            this.bt_Read.Text = "读";
            this.bt_Read.UseVisualStyleBackColor = true;
            this.bt_Read.Click += new System.EventHandler(this.bt_Read_Click);
            // 
            // comboxType
            // 
            this.comboxType.FormattingEnabled = true;
            this.comboxType.Items.AddRange(new object[] {
            "Real",
            "Int",
            "DInt"});
            this.comboxType.Location = new System.Drawing.Point(111, 134);
            this.comboxType.Name = "comboxType";
            this.comboxType.Size = new System.Drawing.Size(190, 20);
            this.comboxType.TabIndex = 13;
            this.comboxType.Text = "Real";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(47, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Write";
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(111, 174);
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(190, 21);
            this.tbWrite.TabIndex = 11;
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(111, 85);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(190, 21);
            this.tbStart.TabIndex = 10;
            this.tbStart.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "DataType：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(47, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start：";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(111, 36);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(190, 21);
            this.tbDB.TabIndex = 7;
            this.tbDB.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "DB Number：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.TextBox tbSlot;
        private System.Windows.Forms.TextBox tbRack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.ComboBox comboxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWrite;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Button bt_Write;
        private System.Windows.Forms.Button bt_Read;
    }
}

