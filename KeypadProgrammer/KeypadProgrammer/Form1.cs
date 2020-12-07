using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeypadProgrammer
{
    public partial class Form1 : Form
    {

        KeyData[][] keyMaps;
        Dictionary<String, int> specialKeys;
        Dictionary<String, int> functionKeys;

        private SerialPort port;

        private int currentKey = -1;
        private int keyMode = -1;

        private bool connected = false;

        public Form1()
        {
            
            InitializeComponent();

            comboBoxProfile.DataSource = new int[] { 1, 2, 3, 4 };

            functionKeys = new Dictionary<string, int>();
            functionKeys.Add("Play/Pause", 0xcd);
            functionKeys.Add("Previous", 0xb6);
            functionKeys.Add("Next", 0xb5);
            functionKeys.Add("Volume Up", 0xe9);
            functionKeys.Add("Volume Down", 0xea);
            functionKeys.Add("Mute", 0xe2);

            specialKeys = new Dictionary<string, int>();
            specialKeys.Add("Enter", 0x28);
            specialKeys.Add("Escape", 0x29);
            specialKeys.Add("Backspace", 0x2a);
            specialKeys.Add("Tab", 0x2b);
            specialKeys.Add("Up", 0x4f);
            specialKeys.Add("Left", 0x50);
            specialKeys.Add("Down", 0x51);
            specialKeys.Add("Right", 0x52);
            specialKeys.Add("Insert", 0x49);
            specialKeys.Add("Home", 0x4a);
            specialKeys.Add("Page up", 0x4b);
            specialKeys.Add("Page down", 0x4e);
            specialKeys.Add("Delete", 0x4c);
            specialKeys.Add("End", 0x4d);
            specialKeys.Add("Print Screen", 0x46);
            specialKeys.Add("Scroll Lock", 0x47);
            specialKeys.Add("Pause", 0x48);
            for(int i = 0; i < 12; i++)
            {
                String keyStr = "F" + (i + 1);
                specialKeys.Add(keyStr, 0x3a + i);
            }
        }

        private void keyboardButtonPressed(Button button, int key)
        {
            currentKey = key;
            KeyData keyData = keyMaps[comboBoxProfile.SelectedIndex][currentKey];
            if (keyData != null)
            {
                comboBoxKeyType.SelectedIndex = keyData.Type;
                if(keyData.Type == 0)
                {
                    groupBoxModifiers.Enabled = true;
                }
                else
                {
                    groupBoxModifiers.Enabled = false;
                }
                if (keyData.Modifiers[0] == true)
                {
                    checkBoxAlt.Checked = true;
                }
                if (keyData.Modifiers[1] == true)
                {
                    checkBoxWinGui.Checked = true;
                }
                if (keyData.Modifiers[2] == true)
                {
                    checkBoxControll.Checked = true;
                }
                if (keyData.Modifiers[3] == true)
                {
                    checkBoxShift.Checked = true;
                }
                if(keyData.Looping > 0)
                {
                    checkBoxLooping.Checked = true;
                    groupBoxLoopSpeed.Enabled = true;
                    switch (keyData.Looping)
                    {
                        case 1: radioButton1x.Checked = true; break;
                        case 2: radioButton2x.Checked = true; break;
                        case 3: radioButton4x.Checked = true; break;
                    }
                }
                else
                {
                    checkBoxLooping.Checked = false;
                    groupBoxLoopSpeed.Enabled = false;
                }
                richTextBoxValue.Text = keyData.Value;
            }
            String str = "Profile: " + comboBoxProfile.Text + ", Key: " + button.Text; 
            textBoxCurrentKey.Text = str;
            if (!groupBoxKeySettings.Enabled) { 
                groupBoxKeySettings.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyMaps = SettingsManager.getMaps();
            comboBoxPort.DataSource = SerialPort.GetPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                try
                {
                    port.Close();
                    statusLabelComStatus.Text = "Disconnected";
                    connected = false;
                    btnConnect.Text = "Connect";
                    buttonSendKeyToKeyboard.Enabled = connected;

                }
                catch (Exception exception)
                {
                    statusLabelComStatus.Text = "Could not close connection";
                }
                return;
            }
            if(comboBoxBaudRate.SelectedItem == null)
            {
                return;
            }
            port = new SerialPort(comboBoxPort.SelectedItem.ToString(), Convert.ToInt32(comboBoxBaudRate.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
            try
            {
                port.Open();
                statusLabelComStatus.Text = "Connected";
                connected = true;
                btnConnect.Text = "Disconect";
            }
            catch(Exception exception)
            {
                statusLabelComStatus.Text = "Could not open connection";
            }

            if(!buttonSendKeyToKeyboard.Enabled)
            {
                buttonSendKeyToKeyboard.Enabled = true;
            }
        }

        private void port_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(port.ReadExisting());
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            richTextBoxsentCommand.Text += value;
        }

        private void comboBoxPort_Click(object sender, EventArgs e)
        {
            comboBoxPort.DataSource = SerialPort.GetPortNames();
        }

        private void checkBoxLooping_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxLoopSpeed.Enabled = checkBoxLooping.Checked;
        }

        private void comboBoxKeyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!groupBoxValue.Enabled)
            {
                groupBoxValue.Enabled = true;
            }
             
            richTextBoxValue.Clear();
            if(comboBoxKeyType.SelectedIndex == 0)
            {
                keyMode = 0;
                groupBoxModifiers.Enabled = true;
                richTextBoxValue.ReadOnly = false;
                comboBoxSpecialKeys.DataSource = specialKeys.Keys.ToList<String>();
            }
            else
            {
                keyMode = 1;
                groupBoxModifiers.Enabled = false;
                richTextBoxValue.ReadOnly = false;
                comboBoxSpecialKeys.DataSource = functionKeys.Keys.ToList<String>();
            }
        }

        private void buttonTab_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonTab, 1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonBack, 2);
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonNum, 4);
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonSlash, 5);
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonTimes, 6);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonMinus, 7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button7, 8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button8, 9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button9, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button4, 11);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button5, 12);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button6, 13);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonPlus, 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button1, 15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button2, 16);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button3, 17);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(button0, 18);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonPoint, 19);
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            keyboardButtonPressed(buttonEnter, 20);
        }


        private void buttonAddSpecialKey_Click(object sender, EventArgs e)
        {
            int keyCode = -1;
            String key = comboBoxSpecialKeys.SelectedItem.ToString();
            
            if (keyMode == 0)
            {
                keyCode = specialKeys[key];
            }
            else
            {
                keyCode = functionKeys[key];
            }
            richTextBoxValue.Text += "$" +  keyCode.ToString("X");

            richTextBoxValue.Focus();
            richTextBoxValue.SelectionStart = richTextBoxValue.Text.Length;
            return;


        }


        private void buttonSendKeyToKeyboard_Click(object sender, EventArgs e)
        {
            KeyData keyData = getKeyData();
            keyMaps[keyData.Profile][keyData.Key] = keyData;
            byte[] data = keyData.getProgramerBytes();
            try
            {
                port.Write(data, 0, data.Length);
                showSentData(data, data.Length);
            }
            catch (Exception ex)
            {
                showError(ex);
            }
        }

        private KeyData getKeyData()
        {
            KeyData keyData = new KeyData();
            keyData.Profile = (byte)comboBoxProfile.SelectedIndex;
            keyData.Key = (byte)currentKey;
            keyData.Value = richTextBoxValue.Text;
            keyData.Type = (byte)keyMode;


            if (checkBoxLooping.Checked)
            {
                if (radioButton1x.Checked)
                {
                    keyData.Looping = 1;
                }
                else if (radioButton2x.Checked)
                {
                    keyData.Looping = 2;
                }
                else
                {
                    keyData.Looping = 3;
                }
            }
            byte inputMod = 0;
            if (checkBoxAlt.Checked)
            {
                keyData.Modifiers[0] = true;
            }
            if (checkBoxWinGui.Checked)
            {
                keyData.Modifiers[1] = true;
            }
            if (checkBoxControll.Checked)
            {
                keyData.Modifiers[2] = true;
            }
            if (checkBoxShift.Checked)
            {
                keyData.Modifiers[3] = true;
            }

            return keyData;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];
            data[0] = 0xff;
            data[1] = 0x00;
            data[2] = 0xfe;
            try
            {
                port.Write(data, 0, 3);
                showSentData(data, 3);
            }
            catch (Exception ex)
            {
                showError(ex);
            }
        }

        private void showSentData(byte[] data, int len)
        {
            richTextBoxsentCommand.Text = "";
            for (int i = 0; i < len; i++)
            {
                richTextBoxsentCommand.Text += data[i].ToString("X2") + " ";
            }
        }
        private void showError(Exception e)
        {
            richTextBoxsentCommand.Text = "An error occured while writing to keyboard:\n" + e.Message;
        }

        private void buttonChangeInterval_Click(object sender, EventArgs e)
        {
            int milisTime = (int)(numericUpDownLoopInterval.Value * 1000);
            byte[] bytes = BitConverter.GetBytes(milisTime);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            byte[] data = new byte[5];
            data[0] = 0xff;
            data[1] = 0x02;
            data[2] = bytes[2];
            data[3] = bytes[3];
            data[4] = 0xfe;
            try
            {
                port.Write(data, 0, 5);
                showSentData(data, 5);
            }
            catch(Exception ex)
            {
                showError(ex);
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxValue.Clear();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            KeyData data = getKeyData();
            keyMaps[data.Profile][data.Key] = data;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsManager.saveMaps(keyMaps);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Keyboard Settings|*.kpd";
            saveFileDialog1.Title = "Save Keyboard settings";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                SettingsManager.saveMaps(keyMaps, saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Keyboard Settings|*.kpd";
            openFileDialog1.Title = "Load keyboard settings";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                keyMaps = SettingsManager.getMaps(openFileDialog1.FileName);
            }
            
        }
    }
}
