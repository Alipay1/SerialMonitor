namespace SerialMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cBoxPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxDataBit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxStopBit = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTx = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTx = new System.Windows.Forms.Button();
            this.btnClearRx = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxRxH = new System.Windows.Forms.CheckBox();
            this.checkBoxTxH = new System.Windows.Forms.CheckBox();
            this.checkBox1NewLine = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 65536;
            this.serialPort1.WriteBufferSize = 65536;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cBoxPort
            // 
            this.cBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxPort.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxPort.FormattingEnabled = true;
            this.cBoxPort.Location = new System.Drawing.Point(96, 4);
            this.cBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPort.Name = "cBoxPort";
            this.cBoxPort.Size = new System.Drawing.Size(158, 25);
            this.cBoxPort.TabIndex = 0;
            this.cBoxPort.DropDown += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(7, 197);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(247, 32);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDTR);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.cBoxPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cBoxBaud);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cBoxDataBit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cBoxStopBit);
            this.panel1.Controls.Add(this.cBoxParity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(262, 293);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Location = new System.Drawing.Point(8, 236);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(51, 21);
            this.checkBoxDTR.TabIndex = 13;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SerialMonitor.Properties.Resources.刷新;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(59, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "StopBit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parity";
            // 
            // cBoxBaud
            // 
            this.cBoxBaud.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxBaud.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxBaud.FormattingEnabled = true;
            this.cBoxBaud.Location = new System.Drawing.Point(96, 44);
            this.cBoxBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBaud.Name = "cBoxBaud";
            this.cBoxBaud.Size = new System.Drawing.Size(158, 25);
            this.cBoxBaud.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataBit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud";
            // 
            // cBoxDataBit
            // 
            this.cBoxDataBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxDataBit.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxDataBit.FormattingEnabled = true;
            this.cBoxDataBit.Location = new System.Drawing.Point(96, 84);
            this.cBoxDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDataBit.Name = "cBoxDataBit";
            this.cBoxDataBit.Size = new System.Drawing.Size(158, 25);
            this.cBoxDataBit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxStopBit.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Location = new System.Drawing.Point(96, 164);
            this.cBoxStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(158, 25);
            this.cBoxStopBit.TabIndex = 10;
            // 
            // cBoxParity
            // 
            this.cBoxParity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxParity.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Location = new System.Drawing.Point(96, 124);
            this.cBoxParity.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(158, 25);
            this.cBoxParity.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(273, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox1, 2);
            this.richTextBox1.Size = new System.Drawing.Size(613, 295);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Receive window";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBoxTx
            // 
            this.richTextBoxTx.AcceptsTab = true;
            this.richTextBoxTx.AutoWordSelection = true;
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxTx, 2);
            this.richTextBoxTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTx.Location = new System.Drawing.Point(3, 304);
            this.richTextBoxTx.Name = "richTextBoxTx";
            this.richTextBoxTx.Size = new System.Drawing.Size(710, 159);
            this.richTextBoxTx.TabIndex = 5;
            this.richTextBoxTx.Text = "Type to send something.";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::SerialMonitor.Properties.Resources.保存;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(133, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTx
            // 
            this.btnTx.AutoEllipsis = true;
            this.btnTx.BackgroundImage = global::SerialMonitor.Properties.Resources.数据导出_01;
            this.btnTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTx.Location = new System.Drawing.Point(10, 90);
            this.btnTx.Name = "btnTx";
            this.btnTx.Size = new System.Drawing.Size(60, 60);
            this.btnTx.TabIndex = 6;
            this.btnTx.UseVisualStyleBackColor = true;
            this.btnTx.Click += new System.EventHandler(this.btnTx_Click);
            // 
            // btnClearRx
            // 
            this.btnClearRx.BackgroundImage = global::SerialMonitor.Properties.Resources.删除;
            this.btnClearRx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearRx.Location = new System.Drawing.Point(133, 3);
            this.btnClearRx.Name = "btnClearRx";
            this.btnClearRx.Size = new System.Drawing.Size(30, 30);
            this.btnClearRx.TabIndex = 4;
            this.btnClearRx.UseVisualStyleBackColor = true;
            this.btnClearRx.Click += new System.EventHandler(this.btnClearRx_Click_1);
            // 
            // btnSet
            // 
            this.btnSet.BackgroundImage = global::SerialMonitor.Properties.Resources.菜单;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSet.Location = new System.Drawing.Point(133, 75);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(30, 30);
            this.btnSet.TabIndex = 8;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // checkBoxRxH
            // 
            this.checkBoxRxH.AutoSize = true;
            this.checkBoxRxH.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRxH.Location = new System.Drawing.Point(10, 9);
            this.checkBoxRxH.Name = "checkBoxRxH";
            this.checkBoxRxH.Size = new System.Drawing.Size(69, 21);
            this.checkBoxRxH.TabIndex = 9;
            this.checkBoxRxH.Text = "HEX Rx";
            this.checkBoxRxH.UseVisualStyleBackColor = false;
            this.checkBoxRxH.CheckedChanged += new System.EventHandler(this.checkBoxRxH_CheckedChanged);
            // 
            // checkBoxTxH
            // 
            this.checkBoxTxH.AutoSize = true;
            this.checkBoxTxH.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTxH.Location = new System.Drawing.Point(10, 36);
            this.checkBoxTxH.Name = "checkBoxTxH";
            this.checkBoxTxH.Size = new System.Drawing.Size(68, 21);
            this.checkBoxTxH.TabIndex = 10;
            this.checkBoxTxH.Text = "HEX Tx";
            this.checkBoxTxH.UseVisualStyleBackColor = false;
            // 
            // checkBox1NewLine
            // 
            this.checkBox1NewLine.AutoSize = true;
            this.checkBox1NewLine.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1NewLine.Location = new System.Drawing.Point(10, 63);
            this.checkBox1NewLine.Name = "checkBox1NewLine";
            this.checkBox1NewLine.Size = new System.Drawing.Size(79, 21);
            this.checkBox1NewLine.TabIndex = 11;
            this.checkBox1NewLine.Text = "With \\r\\n";
            this.checkBox1NewLine.UseVisualStyleBackColor = false;
            this.checkBox1NewLine.CheckedChanged += new System.EventHandler(this.checkBox1NewLine_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxTx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.06644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.93356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 466);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SerialMonitor.Properties.Resources._372627688_03d2a398125e7103803dedf53f5079bf;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btnTx);
            this.panel2.Controls.Add(this.btnClearRx);
            this.panel2.Controls.Add(this.checkBox1NewLine);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.checkBoxTxH);
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Controls.Add(this.checkBoxRxH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(719, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 159);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(905, 505);
            this.Name = "Form1";
            this.Text = "SerialMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cBoxPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxStopBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxDataBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearRx;
        private System.Windows.Forms.RichTextBox richTextBoxTx;
        private System.Windows.Forms.Button btnTx;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.FolderBrowserDialog saveDialog;
        private System.Windows.Forms.CheckBox checkBoxRxH;
        private System.Windows.Forms.CheckBox checkBoxTxH;
        private System.Windows.Forms.CheckBox checkBox1NewLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxDTR;
    }
}

