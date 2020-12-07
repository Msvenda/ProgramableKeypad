namespace KeypadProgrammer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxKeySettings = new System.Windows.Forms.GroupBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.textBoxCurrentKey = new System.Windows.Forms.TextBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.richTextBoxValue = new System.Windows.Forms.RichTextBox();
            this.buttonAddSpecialKey = new System.Windows.Forms.Button();
            this.comboBoxSpecialKeys = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLoopSpeed = new System.Windows.Forms.GroupBox();
            this.radioButton4x = new System.Windows.Forms.RadioButton();
            this.radioButton2x = new System.Windows.Forms.RadioButton();
            this.radioButton1x = new System.Windows.Forms.RadioButton();
            this.checkBoxLooping = new System.Windows.Forms.CheckBox();
            this.buttonSendKeyToKeyboard = new System.Windows.Forms.Button();
            this.groupBoxModifiers = new System.Windows.Forms.GroupBox();
            this.checkBoxAlt = new System.Windows.Forms.CheckBox();
            this.checkBoxWinGui = new System.Windows.Forms.CheckBox();
            this.checkBoxControll = new System.Windows.Forms.CheckBox();
            this.checkBoxShift = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKeyType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChangeInterval = new System.Windows.Forms.Button();
            this.numericUpDownLoopInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTab = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonSlash = new System.Windows.Forms.Button();
            this.buttonNum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.richTextBoxsentCommand = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelComStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxKeySettings.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBoxLoopSpeed.SuspendLayout();
            this.groupBoxModifiers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.keyboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // keyboardToolStripMenuItem
            // 
            this.keyboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.keyboardToolStripMenuItem.Name = "keyboardToolStripMenuItem";
            this.keyboardToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.keyboardToolStripMenuItem.Text = "Keyboard";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxKeySettings);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 324);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxKeySettings
            // 
            this.groupBoxKeySettings.Controls.Add(this.buttonSaveSettings);
            this.groupBoxKeySettings.Controls.Add(this.textBoxCurrentKey);
            this.groupBoxKeySettings.Controls.Add(this.groupBoxValue);
            this.groupBoxKeySettings.Controls.Add(this.groupBoxLoopSpeed);
            this.groupBoxKeySettings.Controls.Add(this.checkBoxLooping);
            this.groupBoxKeySettings.Controls.Add(this.buttonSendKeyToKeyboard);
            this.groupBoxKeySettings.Controls.Add(this.groupBoxModifiers);
            this.groupBoxKeySettings.Controls.Add(this.label4);
            this.groupBoxKeySettings.Controls.Add(this.comboBoxKeyType);
            this.groupBoxKeySettings.Enabled = false;
            this.groupBoxKeySettings.Location = new System.Drawing.Point(306, 4);
            this.groupBoxKeySettings.Name = "groupBoxKeySettings";
            this.groupBoxKeySettings.Size = new System.Drawing.Size(436, 317);
            this.groupBoxKeySettings.TabIndex = 5;
            this.groupBoxKeySettings.TabStop = false;
            this.groupBoxKeySettings.Text = "Key settings";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(212, 285);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(218, 23);
            this.buttonSaveSettings.TabIndex = 15;
            this.buttonSaveSettings.Text = "Save key settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // textBoxCurrentKey
            // 
            this.textBoxCurrentKey.Location = new System.Drawing.Point(11, 20);
            this.textBoxCurrentKey.Name = "textBoxCurrentKey";
            this.textBoxCurrentKey.ReadOnly = true;
            this.textBoxCurrentKey.Size = new System.Drawing.Size(417, 20);
            this.textBoxCurrentKey.TabIndex = 12;
            this.textBoxCurrentKey.TabStop = false;
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.buttonClear);
            this.groupBoxValue.Controls.Add(this.richTextBoxValue);
            this.groupBoxValue.Controls.Add(this.buttonAddSpecialKey);
            this.groupBoxValue.Controls.Add(this.comboBoxSpecialKeys);
            this.groupBoxValue.Controls.Add(this.label5);
            this.groupBoxValue.Enabled = false;
            this.groupBoxValue.Location = new System.Drawing.Point(11, 172);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(417, 107);
            this.groupBoxValue.TabIndex = 11;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Value";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(356, 20);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 49);
            this.buttonClear.TabIndex = 99;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // richTextBoxValue
            // 
            this.richTextBoxValue.DetectUrls = false;
            this.richTextBoxValue.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxValue.Name = "richTextBoxValue";
            this.richTextBoxValue.Size = new System.Drawing.Size(344, 50);
            this.richTextBoxValue.TabIndex = 11;
            this.richTextBoxValue.Text = "";
            // 
            // buttonAddSpecialKey
            // 
            this.buttonAddSpecialKey.Location = new System.Drawing.Point(210, 77);
            this.buttonAddSpecialKey.Name = "buttonAddSpecialKey";
            this.buttonAddSpecialKey.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSpecialKey.TabIndex = 13;
            this.buttonAddSpecialKey.Text = "Add";
            this.buttonAddSpecialKey.UseVisualStyleBackColor = true;
            this.buttonAddSpecialKey.Click += new System.EventHandler(this.buttonAddSpecialKey_Click);
            // 
            // comboBoxSpecialKeys
            // 
            this.comboBoxSpecialKeys.FormattingEnabled = true;
            this.comboBoxSpecialKeys.Location = new System.Drawing.Point(83, 77);
            this.comboBoxSpecialKeys.Name = "comboBoxSpecialKeys";
            this.comboBoxSpecialKeys.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialKeys.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Special Keys:";
            // 
            // groupBoxLoopSpeed
            // 
            this.groupBoxLoopSpeed.Controls.Add(this.radioButton4x);
            this.groupBoxLoopSpeed.Controls.Add(this.radioButton2x);
            this.groupBoxLoopSpeed.Controls.Add(this.radioButton1x);
            this.groupBoxLoopSpeed.Enabled = false;
            this.groupBoxLoopSpeed.Location = new System.Drawing.Point(184, 102);
            this.groupBoxLoopSpeed.Name = "groupBoxLoopSpeed";
            this.groupBoxLoopSpeed.Size = new System.Drawing.Size(244, 48);
            this.groupBoxLoopSpeed.TabIndex = 10;
            this.groupBoxLoopSpeed.TabStop = false;
            this.groupBoxLoopSpeed.Text = "Loop speed";
            // 
            // radioButton4x
            // 
            this.radioButton4x.AutoSize = true;
            this.radioButton4x.Location = new System.Drawing.Point(91, 18);
            this.radioButton4x.Name = "radioButton4x";
            this.radioButton4x.Size = new System.Drawing.Size(36, 17);
            this.radioButton4x.TabIndex = 2;
            this.radioButton4x.Text = "4x";
            this.radioButton4x.UseVisualStyleBackColor = true;
            // 
            // radioButton2x
            // 
            this.radioButton2x.AutoSize = true;
            this.radioButton2x.Location = new System.Drawing.Point(49, 18);
            this.radioButton2x.Name = "radioButton2x";
            this.radioButton2x.Size = new System.Drawing.Size(36, 17);
            this.radioButton2x.TabIndex = 1;
            this.radioButton2x.Text = "2x";
            this.radioButton2x.UseVisualStyleBackColor = true;
            // 
            // radioButton1x
            // 
            this.radioButton1x.AutoSize = true;
            this.radioButton1x.Checked = true;
            this.radioButton1x.Location = new System.Drawing.Point(7, 17);
            this.radioButton1x.Name = "radioButton1x";
            this.radioButton1x.Size = new System.Drawing.Size(36, 17);
            this.radioButton1x.TabIndex = 0;
            this.radioButton1x.TabStop = true;
            this.radioButton1x.Text = "1x";
            this.radioButton1x.UseVisualStyleBackColor = true;
            // 
            // checkBoxLooping
            // 
            this.checkBoxLooping.AutoSize = true;
            this.checkBoxLooping.Location = new System.Drawing.Point(11, 119);
            this.checkBoxLooping.Name = "checkBoxLooping";
            this.checkBoxLooping.Size = new System.Drawing.Size(64, 17);
            this.checkBoxLooping.TabIndex = 9;
            this.checkBoxLooping.Text = "Looping";
            this.checkBoxLooping.UseVisualStyleBackColor = true;
            this.checkBoxLooping.CheckedChanged += new System.EventHandler(this.checkBoxLooping_CheckedChanged);
            // 
            // buttonSendKeyToKeyboard
            // 
            this.buttonSendKeyToKeyboard.Enabled = false;
            this.buttonSendKeyToKeyboard.Location = new System.Drawing.Point(11, 285);
            this.buttonSendKeyToKeyboard.Name = "buttonSendKeyToKeyboard";
            this.buttonSendKeyToKeyboard.Size = new System.Drawing.Size(195, 23);
            this.buttonSendKeyToKeyboard.TabIndex = 14;
            this.buttonSendKeyToKeyboard.Text = "Send key to keyboard";
            this.buttonSendKeyToKeyboard.UseVisualStyleBackColor = true;
            this.buttonSendKeyToKeyboard.Click += new System.EventHandler(this.buttonSendKeyToKeyboard_Click);
            // 
            // groupBoxModifiers
            // 
            this.groupBoxModifiers.Controls.Add(this.checkBoxAlt);
            this.groupBoxModifiers.Controls.Add(this.checkBoxWinGui);
            this.groupBoxModifiers.Controls.Add(this.checkBoxControll);
            this.groupBoxModifiers.Controls.Add(this.checkBoxShift);
            this.groupBoxModifiers.Enabled = false;
            this.groupBoxModifiers.Location = new System.Drawing.Point(184, 48);
            this.groupBoxModifiers.Name = "groupBoxModifiers";
            this.groupBoxModifiers.Size = new System.Drawing.Size(244, 48);
            this.groupBoxModifiers.TabIndex = 8;
            this.groupBoxModifiers.TabStop = false;
            this.groupBoxModifiers.Text = "Modifiers";
            // 
            // checkBoxAlt
            // 
            this.checkBoxAlt.AutoSize = true;
            this.checkBoxAlt.Location = new System.Drawing.Point(195, 20);
            this.checkBoxAlt.Name = "checkBoxAlt";
            this.checkBoxAlt.Size = new System.Drawing.Size(46, 17);
            this.checkBoxAlt.TabIndex = 3;
            this.checkBoxAlt.Text = "ALT";
            this.checkBoxAlt.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinGui
            // 
            this.checkBoxWinGui.AutoSize = true;
            this.checkBoxWinGui.Location = new System.Drawing.Point(122, 20);
            this.checkBoxWinGui.Name = "checkBoxWinGui";
            this.checkBoxWinGui.Size = new System.Drawing.Size(66, 17);
            this.checkBoxWinGui.TabIndex = 2;
            this.checkBoxWinGui.Text = "Win/Gui";
            this.checkBoxWinGui.UseVisualStyleBackColor = true;
            // 
            // checkBoxControll
            // 
            this.checkBoxControll.AutoSize = true;
            this.checkBoxControll.Location = new System.Drawing.Point(61, 20);
            this.checkBoxControll.Name = "checkBoxControll";
            this.checkBoxControll.Size = new System.Drawing.Size(54, 17);
            this.checkBoxControll.TabIndex = 1;
            this.checkBoxControll.Text = "CTRL";
            this.checkBoxControll.UseVisualStyleBackColor = true;
            // 
            // checkBoxShift
            // 
            this.checkBoxShift.AutoSize = true;
            this.checkBoxShift.Location = new System.Drawing.Point(7, 20);
            this.checkBoxShift.Name = "checkBoxShift";
            this.checkBoxShift.Size = new System.Drawing.Size(47, 17);
            this.checkBoxShift.TabIndex = 0;
            this.checkBoxShift.Text = "Shift";
            this.checkBoxShift.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // comboBoxKeyType
            // 
            this.comboBoxKeyType.FormattingEnabled = true;
            this.comboBoxKeyType.Items.AddRange(new object[] {
            "Text",
            "Function"});
            this.comboBoxKeyType.Location = new System.Drawing.Point(48, 64);
            this.comboBoxKeyType.Name = "comboBoxKeyType";
            this.comboBoxKeyType.Size = new System.Drawing.Size(82, 21);
            this.comboBoxKeyType.TabIndex = 7;
            this.comboBoxKeyType.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeyType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChangeInterval);
            this.groupBox2.Controls.Add(this.numericUpDownLoopInterval);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonFunction);
            this.groupBox2.Controls.Add(this.buttonBack);
            this.groupBox2.Controls.Add(this.comboBoxProfile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonTab);
            this.groupBox2.Controls.Add(this.buttonProfile);
            this.groupBox2.Controls.Add(this.buttonEnter);
            this.groupBox2.Controls.Add(this.buttonPoint);
            this.groupBox2.Controls.Add(this.button0);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonPlus);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.buttonMinus);
            this.groupBox2.Controls.Add(this.buttonTimes);
            this.groupBox2.Controls.Add(this.buttonSlash);
            this.groupBox2.Controls.Add(this.buttonNum);
            this.groupBox2.Location = new System.Drawing.Point(6, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard";
            // 
            // buttonChangeInterval
            // 
            this.buttonChangeInterval.Location = new System.Drawing.Point(6, 170);
            this.buttonChangeInterval.Name = "buttonChangeInterval";
            this.buttonChangeInterval.Size = new System.Drawing.Size(102, 23);
            this.buttonChangeInterval.TabIndex = 6;
            this.buttonChangeInterval.Text = "Change Interval";
            this.buttonChangeInterval.UseVisualStyleBackColor = true;
            this.buttonChangeInterval.Click += new System.EventHandler(this.buttonChangeInterval_Click);
            // 
            // numericUpDownLoopInterval
            // 
            this.numericUpDownLoopInterval.DecimalPlaces = 2;
            this.numericUpDownLoopInterval.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownLoopInterval.Location = new System.Drawing.Point(7, 144);
            this.numericUpDownLoopInterval.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLoopInterval.Name = "numericUpDownLoopInterval";
            this.numericUpDownLoopInterval.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownLoopInterval.TabIndex = 5;
            this.numericUpDownLoopInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Loop interval (s):";
            // 
            // buttonFunction
            // 
            this.buttonFunction.Enabled = false;
            this.buttonFunction.Location = new System.Drawing.Point(251, 30);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(36, 23);
            this.buttonFunction.TabIndex = 30;
            this.buttonFunction.TabStop = false;
            this.buttonFunction.Text = "fn";
            this.buttonFunction.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(209, 30);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(36, 23);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "bck";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(52, 30);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(56, 21);
            this.comboBoxProfile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profile:";
            // 
            // buttonTab
            // 
            this.buttonTab.Location = new System.Drawing.Point(167, 30);
            this.buttonTab.Name = "buttonTab";
            this.buttonTab.Size = new System.Drawing.Size(36, 23);
            this.buttonTab.TabIndex = 28;
            this.buttonTab.TabStop = false;
            this.buttonTab.Text = "tab";
            this.buttonTab.UseVisualStyleBackColor = true;
            this.buttonTab.Click += new System.EventHandler(this.buttonTab_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Enabled = false;
            this.buttonProfile.Location = new System.Drawing.Point(125, 30);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(36, 23);
            this.buttonProfile.TabIndex = 27;
            this.buttonProfile.TabStop = false;
            this.buttonProfile.Text = "prof";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(251, 144);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(36, 52);
            this.buttonEnter.TabIndex = 26;
            this.buttonEnter.TabStop = false;
            this.buttonEnter.Text = "ent";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(209, 173);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(36, 23);
            this.buttonPoint.TabIndex = 25;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(125, 173);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 23);
            this.button0.TabIndex = 23;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 21;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 20;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(251, 86);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(36, 52);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 17;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 16;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 15;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(209, 86);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 23);
            this.button9.TabIndex = 13;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(167, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 23);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 23);
            this.button7.TabIndex = 11;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(251, 57);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(36, 23);
            this.buttonMinus.TabIndex = 10;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(209, 57);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(36, 23);
            this.buttonTimes.TabIndex = 9;
            this.buttonTimes.TabStop = false;
            this.buttonTimes.Text = "*";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
            // 
            // buttonSlash
            // 
            this.buttonSlash.Location = new System.Drawing.Point(167, 57);
            this.buttonSlash.Name = "buttonSlash";
            this.buttonSlash.Size = new System.Drawing.Size(36, 23);
            this.buttonSlash.TabIndex = 8;
            this.buttonSlash.TabStop = false;
            this.buttonSlash.Text = "/";
            this.buttonSlash.UseVisualStyleBackColor = true;
            this.buttonSlash.Click += new System.EventHandler(this.buttonSlash_Click);
            // 
            // buttonNum
            // 
            this.buttonNum.Location = new System.Drawing.Point(125, 57);
            this.buttonNum.Name = "buttonNum";
            this.buttonNum.Size = new System.Drawing.Size(36, 23);
            this.buttonNum.TabIndex = 7;
            this.buttonNum.TabStop = false;
            this.buttonNum.Text = "num";
            this.buttonNum.UseVisualStyleBackColor = true;
            this.buttonNum.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxPort);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Settings:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 79);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud rate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(69, 51);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(69, 24);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 0;
            this.comboBoxPort.Click += new System.EventHandler(this.comboBoxPort_Click);
            // 
            // richTextBoxsentCommand
            // 
            this.richTextBoxsentCommand.Location = new System.Drawing.Point(12, 402);
            this.richTextBoxsentCommand.Name = "richTextBoxsentCommand";
            this.richTextBoxsentCommand.ReadOnly = true;
            this.richTextBoxsentCommand.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxsentCommand.Size = new System.Drawing.Size(748, 64);
            this.richTextBoxsentCommand.TabIndex = 3;
            this.richTextBoxsentCommand.TabStop = false;
            this.richTextBoxsentCommand.Text = "";
            this.richTextBoxsentCommand.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabelComStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "COM status:";
            // 
            // statusLabelComStatus
            // 
            this.statusLabelComStatus.Name = "statusLabelComStatus";
            this.statusLabelComStatus.Size = new System.Drawing.Size(86, 17);
            this.statusLabelComStatus.Text = "Not connected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last sent command:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBoxsentCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Keypad Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxKeySettings.ResumeLayout(false);
            this.groupBoxKeySettings.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.groupBoxLoopSpeed.ResumeLayout(false);
            this.groupBoxLoopSpeed.PerformLayout();
            this.groupBoxModifiers.ResumeLayout(false);
            this.groupBoxModifiers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.RichTextBox richTextBoxsentCommand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTab;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonSlash;
        private System.Windows.Forms.Button buttonNum;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelComStatus;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxKeySettings;
        private System.Windows.Forms.GroupBox groupBoxLoopSpeed;
        private System.Windows.Forms.RadioButton radioButton4x;
        private System.Windows.Forms.RadioButton radioButton2x;
        private System.Windows.Forms.RadioButton radioButton1x;
        private System.Windows.Forms.CheckBox checkBoxLooping;
        private System.Windows.Forms.Button buttonSendKeyToKeyboard;
        private System.Windows.Forms.GroupBox groupBoxModifiers;
        private System.Windows.Forms.CheckBox checkBoxAlt;
        private System.Windows.Forms.CheckBox checkBoxWinGui;
        private System.Windows.Forms.CheckBox checkBoxControll;
        private System.Windows.Forms.CheckBox checkBoxShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKeyType;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.RichTextBox richTextBoxValue;
        private System.Windows.Forms.Button buttonAddSpecialKey;
        private System.Windows.Forms.ComboBox comboBoxSpecialKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownLoopInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCurrentKey;
        private System.Windows.Forms.Button buttonChangeInterval;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonClear;
    }
}

