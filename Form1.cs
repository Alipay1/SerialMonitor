using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

//#if DEBUG
//#define LOG(x) Console.WriteLine(x)
//#else
//#define LOG(x) (x)
//#endif

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public static extern void FreeConsole();//关闭控制台
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxValue();
            InitializeDefaultValue();
#if DEBUG
            AllocConsole();
#endif
        }

        private void InitializeComboBoxValue()
        {
            cBoxPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            cBoxBaud.Items.AddRange(new string[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "1000000", "2000000", "3000000", "12000000" });
            cBoxDataBit.Items.AddRange(new string[] { "7", "8", "9" });
            cBoxParity.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });
            cBoxStopBit.Items.AddRange(new string[] { "1", "1.5", "2" });
        }

        private void InitializeDefaultValue()
        {
            cBoxPort.SelectedIndex = 0;
            cBoxBaud.SelectedItem = "115200";
            cBoxDataBit.SelectedItem = "8";
            cBoxParity.SelectedItem = "None";
            cBoxStopBit.SelectedItem = "1";
            btnConnect.BackColor = Color.LimeGreen;

            checkBox1NewLine.Checked = true;
        }

        string rxBuffer;
        string rxBufferHex;

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //因为要访问UI资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate
                {
                    string serialRead = serialPort1.ReadExisting();

                    rxBuffer += serialRead;
                    rxBufferHex += StringToHex(serialRead);
                    if (checkBoxRxH.Checked)
                    {
                        richTextBox1.Text = rxBufferHex;
                    }
                    else
                    {
                        richTextBox1.Text = rxBuffer;
                    }
                }
                   )
                );

            }
            catch (Exception ex)
            {
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSerialOpen)
                {
                    btnConnect.BackColor = Color.Crimson;
                    btnConnect.Text = "Disconnect";
                    isSerialOpen = !isSerialOpen;

                    setAllSerialComboBox(false);

                    serialPort1.Encoding = Encoding.UTF8;
                    serialPort1.PortName = cBoxPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cBoxBaud.Text);
                    serialPort1.DataBits = Convert.ToInt16(cBoxDataBit.Text);

                    if (cBoxParity.Text.Equals("None"))
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    else if (cBoxParity.Text.Equals("Odd"))
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    else if (cBoxParity.Text.Equals("Even"))
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    else if (cBoxParity.Text.Equals("Mark"))
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    else if (cBoxParity.Text.Equals("Space"))
                        serialPort1.Parity = System.IO.Ports.Parity.Space;

                    if (cBoxStopBit.Text.Equals("1"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    else if (cBoxStopBit.Text.Equals("1.5"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else if (cBoxStopBit.Text.Equals("2"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;


                    serialPort1.Close();
                    serialPort1.Open();

                    if (!serialPort1.IsOpen)
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    btnConnect.BackColor = Color.LimeGreen;
                    btnConnect.Text = "Connect";
                    isSerialOpen = !isSerialOpen;

                    serialPort1.Close();

                    setAllSerialComboBox(true);
                }
            }
            catch(Exception ex)
            {
                serialPort1.Close();
                //serialPort1 = new System.IO.Ports.SerialPort();
                btnConnect.BackColor = Color.Crimson;
                btnConnect.Text = "Connection failed";
                isSerialOpen = !isSerialOpen;



                Console.WriteLine(ex.ToString() );

                setAllSerialComboBox(true);

            }
        }
        /*Function Declarations*/
        private void setAllSerialComboBox(bool state)
        {
            cBoxPort.Enabled = state;
            cBoxBaud.Enabled = state;
            cBoxDataBit.Enabled = state;
            cBoxParity.Enabled = state;
            cBoxStopBit.Enabled = state;
        }
        /*Global Variables Declarations*/
        bool isSerialOpen = true;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cBoxPort.Items.Clear();
            cBoxPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void btnClearRx_Click_1(object sender, EventArgs e)
        {
            //richTextBox1.Clear();
            try
            {
                rxBuffer = rxBuffer.Remove(0);
                rxBufferHex = rxBufferHex.Remove(0);
            }
            catch { }
            if (checkBoxRxH.Checked)
            {
                richTextBox1.Text = rxBufferHex;
            }
            else
            {
                richTextBox1.Text = rxBuffer;
            }
        }

        private void btnTx_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(richTextBoxTx.Text + newLine);
                Console.WriteLine(richTextBoxTx.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saveName = System.DateTime.UtcNow.ToString();
            saveName = saveName.Replace(@"/", @"-");
            saveName = saveName.Replace(@" ", @"-");
            saveName = saveName.Replace(@":", @"-");
            //StreamWriter save = new StreamWriter("./" + saveName + ".txt", Encoding.UTF8);
            System.Console.WriteLine(saveName);
            StreamWriter save = new StreamWriter(new FileStream("SavedData" + saveName + ".txt", FileMode.OpenOrCreate), Encoding.UTF8);
            save.Write(richTextBox1.Text.ToString());
            save.Flush();
            save.Close();

            System.Diagnostics.Process.Start("Explorer", "/select," + Environment.CurrentDirectory + @"\" + "SavedData" + saveName + ".txt");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string selfPath = Environment.CurrentDirectory;
            saveDialog.Description = "SelectSavePath";
            saveDialog.SelectedPath = selfPath;
            saveDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxPort.Text = serialSetting.Default.com;
            cBoxBaud.Text = serialSetting.Default.baud;
            cBoxDataBit.Text = serialSetting.Default.databit;
            cBoxParity.Text = serialSetting.Default.parity;
            cBoxStopBit.Text = serialSetting.Default.stopbit;
            checkBox1NewLine.Checked = serialSetting.Default.newline;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                serialSetting.Default.com = cBoxPort.Text.ToString();
                serialSetting.Default.baud = cBoxBaud.Text.ToString();
                serialSetting.Default.databit = cBoxDataBit.Text.ToString();
                serialSetting.Default.parity = cBoxParity.Text.ToString();
                serialSetting.Default.stopbit = cBoxStopBit.Text.ToString();
                serialSetting.Default.newline = checkBox1NewLine.Checked;
                serialSetting.Default.Save();
            }
            catch
            {
                Close();
            }
        }
        private string StringToHex(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (sb.Length > 0)
                    sb.Append(" ");
                sb.AppendFormat("{0:X2}", (int)c);
            }
            return sb.ToString();
        }
        private void checkBoxRxH_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRxH.Checked)
            {
                richTextBox1.Text = rxBufferHex;
            }
            else
            {
                richTextBox1.Text = rxBuffer;
            }
        }

        string newLine = "\r\n";
        private void checkBox1NewLine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1NewLine.Checked)
            {
                newLine = "\r\n";
            }
            else
            {
                newLine = "";
            }
        }

        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = checkBoxDTR.Checked;
        }
    }

}
