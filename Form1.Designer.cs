using System.IO.Ports;

namespace Gfly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox13 = new GroupBox();
            trackBar1 = new TrackBar();
            groupBox12 = new GroupBox();
            trackBarYGfgj = new TrackBar();
            groupBox11 = new GroupBox();
            trackBarYGfyj = new TrackBar();
            groupBox4 = new GroupBox();
            progressBarYGym = new ProgressBar();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            progressBarmotor3 = new ProgressBar();
            progressBarmotor1 = new ProgressBar();
            progressBarmotor4 = new ProgressBar();
            progressBarmotor2 = new ProgressBar();
            groupBox5 = new GroupBox();
            debuginf = new TextBox();
            groupBox6 = new GroupBox();
            lockStateLable = new Label();
            label14 = new Label();
            controllerNameLable = new Label();
            label15 = new Label();
            connectStateLable = new Label();
            label13 = new Label();
            panel1 = new Panel();
            LablefreeBuffer = new Label();
            label31 = new Label();
            label30 = new Label();
            button2 = new Button();
            labelErr = new Label();
            label20 = new Label();
            labelRec = new Label();
            label18 = new Label();
            labelSend = new Label();
            label16 = new Label();
            panel2d = new Panel();
            groupBox7 = new GroupBox();
            labelyaw = new Label();
            label26 = new Label();
            panelyaw = new Panel();
            labelroll = new Label();
            label27 = new Label();
            labelpitch = new Label();
            label25 = new Label();
            groupBox8 = new GroupBox();
            PIDEnableButton = new Button();
            button7 = new Button();
            groupBox10 = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            button_send_PID_INNER = new Button();
            label12 = new Label();
            domainUpDownID = new DomainUpDown();
            domainUpDownII = new DomainUpDown();
            domainUpDownIP = new DomainUpDown();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            button6 = new Button();
            radioButton2 = new RadioButton();
            button5 = new Button();
            radioButton1 = new RadioButton();
            groupBox9 = new GroupBox();
            label21 = new Label();
            label19 = new Label();
            button_send_PID_OUTER = new Button();
            label17 = new Label();
            domainUpDownOD = new DomainUpDown();
            domainUpDownOI = new DomainUpDown();
            domainUpDownOP = new DomainUpDown();
            groupBox14 = new GroupBox();
            groupBox16 = new GroupBox();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            groupBox15 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            载入PID参数ToolStripMenuItem = new ToolStripMenuItem();
            保存PID参数ToolStripMenuItem = new ToolStripMenuItem();
            退出软件ToolStripMenuItem = new ToolStripMenuItem();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            界面ToolStripMenuItem = new ToolStripMenuItem();
            飞控设置ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            支持网站ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox17 = new GroupBox();
            groupBox21 = new GroupBox();
            label_HIGH_OUTER_KD = new Label();
            label_HIGH_INNER_KD = new Label();
            label_HIGH_OUTER_KI = new Label();
            label_HIGH_INNER_KI = new Label();
            label_HIGH_OUTER_KP = new Label();
            label_HIGH_INNER_KP = new Label();
            label67 = new Label();
            label68 = new Label();
            label69 = new Label();
            label70 = new Label();
            label71 = new Label();
            groupBox20 = new GroupBox();
            label_YAW_OUTER_KD = new Label();
            label_YAW_INNER_KD = new Label();
            label_YAW_OUTER_KI = new Label();
            label_YAW_INNER_KI = new Label();
            label_YAW_OUTER_KP = new Label();
            label_YAW_INNER_KP = new Label();
            label56 = new Label();
            label57 = new Label();
            label58 = new Label();
            label59 = new Label();
            label60 = new Label();
            groupBox19 = new GroupBox();
            label_PITCH_OUTER_KD = new Label();
            label_PITCH_INNER_KD = new Label();
            label_PITCH_OUTER_KI = new Label();
            label_PITCH_INNER_KI = new Label();
            label_PITCH_OUTER_KP = new Label();
            label_PITCH_INNER_KP = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            groupBox18 = new GroupBox();
            label_ROLL_OUTER_KD = new Label();
            label_ROLL_INNER_KD = new Label();
            label_ROLL_OUTER_KI = new Label();
            label_ROLL_INNER_KI = new Label();
            label_ROLL_OUTER_KP = new Label();
            label_ROLL_INNER_KP = new Label();
            label29 = new Label();
            label28 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            lable_FLY_STATE = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarYGfgj).BeginInit();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarYGfyj).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox16.SuspendLayout();
            groupBox15.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox21.SuspendLayout();
            groupBox20.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox18.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "飞控连接";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "波特率";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "串口号";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "4800", "9600", "115200" });
            comboBox2.Location = new Point(66, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(123, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "连接";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox13);
            groupBox2.Controls.Add(groupBox12);
            groupBox2.Controls.Add(groupBox11);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(12, 473);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "摇杆反馈";
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(trackBar1);
            groupBox13.Location = new Point(21, 161);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(362, 80);
            groupBox13.TabIndex = 11;
            groupBox13.TabStop = false;
            groupBox13.Text = "翻滚";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 18);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = -30;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(347, 56);
            trackBar1.TabIndex = 5;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(trackBarYGfgj);
            groupBox12.Location = new Point(21, 81);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(362, 80);
            groupBox12.TabIndex = 10;
            groupBox12.TabStop = false;
            groupBox12.Text = "翻滚";
            // 
            // trackBarYGfgj
            // 
            trackBarYGfgj.Location = new Point(6, 18);
            trackBarYGfgj.Maximum = 30;
            trackBarYGfgj.Minimum = -30;
            trackBarYGfgj.Name = "trackBarYGfgj";
            trackBarYGfgj.Size = new Size(347, 56);
            trackBarYGfgj.TabIndex = 5;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(trackBarYGfyj);
            groupBox11.Location = new Point(386, 26);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(80, 220);
            groupBox11.TabIndex = 9;
            groupBox11.TabStop = false;
            groupBox11.Text = "俯仰";
            // 
            // trackBarYGfyj
            // 
            trackBarYGfyj.Location = new Point(18, 21);
            trackBarYGfyj.Maximum = 30;
            trackBarYGfyj.Minimum = -30;
            trackBarYGfyj.Name = "trackBarYGfyj";
            trackBarYGfyj.Orientation = Orientation.Vertical;
            trackBarYGfyj.Size = new Size(56, 194);
            trackBarYGfyj.TabIndex = 4;
            trackBarYGfyj.Scroll += trackBarYGfyj_Scroll;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(progressBarYGym);
            groupBox4.Location = new Point(18, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(362, 53);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "油门";
            // 
            // progressBarYGym
            // 
            progressBarYGym.Location = new Point(9, 19);
            progressBarYGym.MarqueeAnimationSpeed = 0;
            progressBarYGym.Maximum = 255;
            progressBarYGym.Name = "progressBarYGym";
            progressBarYGym.Size = new Size(347, 30);
            progressBarYGym.TabIndex = 2;
            progressBarYGym.Click += progressBarYGym_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(progressBarmotor3);
            groupBox3.Controls.Add(progressBarmotor1);
            groupBox3.Controls.Add(progressBarmotor4);
            groupBox3.Controls.Add(progressBarmotor2);
            groupBox3.Location = new Point(498, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(546, 152);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "回馈数据";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 83);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 7;
            label9.Text = "电机3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 83);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 6;
            label8.Text = "电机4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 25);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 5;
            label7.Text = "电机2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 25);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 4;
            label6.Text = "电机1";
            label6.Click += label6_Click;
            // 
            // progressBarmotor3
            // 
            progressBarmotor3.Location = new Point(12, 105);
            progressBarmotor3.Maximum = 254;
            progressBarmotor3.Name = "progressBarmotor3";
            progressBarmotor3.Size = new Size(224, 29);
            progressBarmotor3.TabIndex = 3;
            // 
            // progressBarmotor1
            // 
            progressBarmotor1.Location = new Point(12, 48);
            progressBarmotor1.Maximum = 254;
            progressBarmotor1.Name = "progressBarmotor1";
            progressBarmotor1.Size = new Size(224, 29);
            progressBarmotor1.TabIndex = 2;
            // 
            // progressBarmotor4
            // 
            progressBarmotor4.Location = new Point(316, 105);
            progressBarmotor4.Maximum = 254;
            progressBarmotor4.Name = "progressBarmotor4";
            progressBarmotor4.Size = new Size(224, 29);
            progressBarmotor4.TabIndex = 1;
            // 
            // progressBarmotor2
            // 
            progressBarmotor2.Location = new Point(316, 48);
            progressBarmotor2.Maximum = 254;
            progressBarmotor2.Name = "progressBarmotor2";
            progressBarmotor2.Size = new Size(224, 29);
            progressBarmotor2.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(debuginf);
            groupBox5.Location = new Point(498, 603);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(546, 115);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "调试信息";
            // 
            // debuginf
            // 
            debuginf.BackColor = SystemColors.WindowText;
            debuginf.ForeColor = Color.Lime;
            debuginf.Location = new Point(6, 28);
            debuginf.Multiline = true;
            debuginf.Name = "debuginf";
            debuginf.Size = new Size(534, 75);
            debuginf.TabIndex = 0;
            debuginf.TextChanged += debuginf_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lockStateLable);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(controllerNameLable);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(connectStateLable);
            groupBox6.Controls.Add(label13);
            groupBox6.Location = new Point(248, 31);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(238, 125);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "控制器状态";
            // 
            // lockStateLable
            // 
            lockStateLable.AutoSize = true;
            lockStateLable.Location = new Point(81, 91);
            lockStateLable.Name = "lockStateLable";
            lockStateLable.Size = new Size(69, 20);
            lockStateLable.TabIndex = 5;
            lockStateLable.Text = "锁定归零";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 90);
            label14.Name = "label14";
            label14.Size = new Size(84, 20);
            label14.TabIndex = 4;
            label14.Text = "控制状态：";
            // 
            // controllerNameLable
            // 
            controllerNameLable.AutoSize = true;
            controllerNameLable.Location = new Point(81, 64);
            controllerNameLable.Name = "controllerNameLable";
            controllerNameLable.Size = new Size(69, 20);
            controllerNameLable.TabIndex = 3;
            controllerNameLable.Text = "设备名称";
            controllerNameLable.Click += controllerNameLable_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 64);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 2;
            label15.Text = "设备名称：";
            // 
            // connectStateLable
            // 
            connectStateLable.AutoSize = true;
            connectStateLable.Location = new Point(81, 36);
            connectStateLable.Name = "connectStateLable";
            connectStateLable.Size = new Size(54, 20);
            connectStateLable.TabIndex = 1;
            connectStateLable.Text = "未连接";
            connectStateLable.Click += connectStateLable_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 36);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 0;
            label13.Text = "连接状态：";
            // 
            // panel1
            // 
            panel1.Controls.Add(LablefreeBuffer);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(label30);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(labelErr);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(labelRec);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(labelSend);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(0, 724);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 42);
            panel1.TabIndex = 11;
            panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // LablefreeBuffer
            // 
            LablefreeBuffer.AutoSize = true;
            LablefreeBuffer.Location = new Point(777, 11);
            LablefreeBuffer.Name = "LablefreeBuffer";
            LablefreeBuffer.Size = new Size(18, 20);
            LablefreeBuffer.TabIndex = 12;
            LablefreeBuffer.Text = "0";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(646, 11);
            label31.Name = "label31";
            label31.Size = new Size(129, 20);
            label31.TabIndex = 11;
            label31.Text = "发送空闲缓冲区数";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(899, 11);
            label30.Name = "label30";
            label30.Size = new Size(281, 20);
            label30.TabIndex = 10;
            label30.Text = "©2024 @SatySunny 物联网工程 高旭阳";
            // 
            // button2
            // 
            button2.Location = new Point(521, 7);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "清空计数";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelErr
            // 
            labelErr.AutoSize = true;
            labelErr.Location = new Point(420, 11);
            labelErr.Name = "labelErr";
            labelErr.Size = new Size(44, 20);
            labelErr.TabIndex = 5;
            labelErr.Text = "0 Pts";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(345, 11);
            label20.Name = "label20";
            label20.Size = new Size(69, 20);
            label20.TabIndex = 4;
            label20.Text = "检出丢包";
            // 
            // labelRec
            // 
            labelRec.AutoSize = true;
            labelRec.Location = new Point(221, 11);
            labelRec.Name = "labelRec";
            labelRec.Size = new Size(48, 20);
            labelRec.TabIndex = 3;
            labelRec.Text = " 0 Pts";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(176, 11);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 2;
            label18.Text = "接收：";
            // 
            // labelSend
            // 
            labelSend.AutoSize = true;
            labelSend.Location = new Point(52, 11);
            labelSend.Name = "labelSend";
            labelSend.Size = new Size(44, 20);
            labelSend.TabIndex = 1;
            labelSend.Text = "0 Pts";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 11);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 0;
            label16.Text = "发送：";
            // 
            // panel2d
            // 
            panel2d.Location = new Point(6, 22);
            panel2d.Name = "panel2d";
            panel2d.Size = new Size(256, 221);
            panel2d.TabIndex = 12;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(labelyaw);
            groupBox7.Controls.Add(label26);
            groupBox7.Controls.Add(panelyaw);
            groupBox7.Controls.Add(labelroll);
            groupBox7.Controls.Add(label27);
            groupBox7.Controls.Add(labelpitch);
            groupBox7.Controls.Add(label25);
            groupBox7.Controls.Add(panel2d);
            groupBox7.Location = new Point(498, 31);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(546, 276);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            groupBox7.Text = "飞行器姿态";
            // 
            // labelyaw
            // 
            labelyaw.AutoSize = true;
            labelyaw.Location = new Point(416, 251);
            labelyaw.Name = "labelyaw";
            labelyaw.Size = new Size(37, 20);
            labelyaw.TabIndex = 19;
            labelyaw.Text = "0.0°";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(352, 251);
            label26.Name = "label26";
            label26.Size = new Size(69, 20);
            label26.TabIndex = 18;
            label26.Text = "偏航角：";
            // 
            // panelyaw
            // 
            panelyaw.Location = new Point(284, 22);
            panelyaw.Name = "panelyaw";
            panelyaw.Size = new Size(256, 221);
            panelyaw.TabIndex = 17;
            // 
            // labelroll
            // 
            labelroll.AutoSize = true;
            labelroll.Location = new Point(187, 251);
            labelroll.Name = "labelroll";
            labelroll.Size = new Size(37, 20);
            labelroll.TabIndex = 16;
            labelroll.Text = "0.0°";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(122, 251);
            label27.Name = "label27";
            label27.Size = new Size(69, 20);
            label27.TabIndex = 15;
            label27.Text = "翻滚角：";
            // 
            // labelpitch
            // 
            labelpitch.AutoSize = true;
            labelpitch.Location = new Point(71, 251);
            labelpitch.Name = "labelpitch";
            labelpitch.Size = new Size(37, 20);
            labelpitch.TabIndex = 14;
            labelpitch.Text = "0.0°";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 251);
            label25.Name = "label25";
            label25.Size = new Size(69, 20);
            label25.TabIndex = 13;
            label25.Text = "俯仰角：";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(PIDEnableButton);
            groupBox8.Controls.Add(button7);
            groupBox8.Controls.Add(groupBox10);
            groupBox8.Controls.Add(radioButton4);
            groupBox8.Controls.Add(radioButton3);
            groupBox8.Controls.Add(button6);
            groupBox8.Controls.Add(radioButton2);
            groupBox8.Controls.Add(button5);
            groupBox8.Controls.Add(radioButton1);
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Location = new Point(12, 162);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(474, 305);
            groupBox8.TabIndex = 14;
            groupBox8.TabStop = false;
            groupBox8.Text = "PID";
            // 
            // PIDEnableButton
            // 
            PIDEnableButton.Location = new Point(111, 270);
            PIDEnableButton.Name = "PIDEnableButton";
            PIDEnableButton.Size = new Size(94, 29);
            PIDEnableButton.TabIndex = 19;
            PIDEnableButton.Text = "断开PID";
            PIDEnableButton.UseVisualStyleBackColor = true;
            PIDEnableButton.Click += PIDEnableButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(111, 236);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 17;
            button7.Text = "积分清零";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(label10);
            groupBox10.Controls.Add(label11);
            groupBox10.Controls.Add(button_send_PID_INNER);
            groupBox10.Controls.Add(label12);
            groupBox10.Controls.Add(domainUpDownID);
            groupBox10.Controls.Add(domainUpDownII);
            groupBox10.Controls.Add(domainUpDownIP);
            groupBox10.Location = new Point(249, 44);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(219, 186);
            groupBox10.TabIndex = 16;
            groupBox10.TabStop = false;
            groupBox10.Text = "内环参数";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 94);
            label10.Name = "label10";
            label10.Size = new Size(28, 20);
            label10.TabIndex = 5;
            label10.Text = "D :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 62);
            label11.Name = "label11";
            label11.Size = new Size(21, 20);
            label11.TabIndex = 4;
            label11.Text = "I :";
            // 
            // button_send_PID_INNER
            // 
            button_send_PID_INNER.Location = new Point(6, 126);
            button_send_PID_INNER.Name = "button_send_PID_INNER";
            button_send_PID_INNER.Size = new Size(203, 43);
            button_send_PID_INNER.TabIndex = 7;
            button_send_PID_INNER.Text = "更新";
            button_send_PID_INNER.UseVisualStyleBackColor = true;
            button_send_PID_INNER.Click += button_send_PID_INNER_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 33);
            label12.Name = "label12";
            label12.Size = new Size(26, 20);
            label12.TabIndex = 3;
            label12.Text = "P :";
            // 
            // domainUpDownID
            // 
            domainUpDownID.Location = new Point(38, 94);
            domainUpDownID.Name = "domainUpDownID";
            domainUpDownID.Size = new Size(171, 27);
            domainUpDownID.TabIndex = 2;
            domainUpDownID.Text = "0";
            // 
            // domainUpDownII
            // 
            domainUpDownII.Location = new Point(38, 59);
            domainUpDownII.Name = "domainUpDownII";
            domainUpDownII.Size = new Size(171, 27);
            domainUpDownII.TabIndex = 1;
            domainUpDownII.Text = "0";
            // 
            // domainUpDownIP
            // 
            domainUpDownIP.Location = new Point(38, 26);
            domainUpDownIP.Name = "domainUpDownIP";
            domainUpDownIP.Size = new Size(171, 27);
            domainUpDownIP.TabIndex = 0;
            domainUpDownIP.Text = "0";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(239, 17);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(60, 24);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "高度";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(170, 17);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 24);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "偏航";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(11, 271);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "读取参数";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(102, 17);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "翻滚";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button5
            // 
            button5.Location = new Point(11, 236);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "恢复默认";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(36, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "俯仰";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label21);
            groupBox9.Controls.Add(label19);
            groupBox9.Controls.Add(button_send_PID_OUTER);
            groupBox9.Controls.Add(label17);
            groupBox9.Controls.Add(domainUpDownOD);
            groupBox9.Controls.Add(domainUpDownOI);
            groupBox9.Controls.Add(domainUpDownOP);
            groupBox9.Location = new Point(11, 44);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(219, 186);
            groupBox9.TabIndex = 0;
            groupBox9.TabStop = false;
            groupBox9.Text = "外环参数";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 94);
            label21.Name = "label21";
            label21.Size = new Size(28, 20);
            label21.TabIndex = 5;
            label21.Text = "D :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 62);
            label19.Name = "label19";
            label19.Size = new Size(21, 20);
            label19.TabIndex = 4;
            label19.Text = "I :";
            // 
            // button_send_PID_OUTER
            // 
            button_send_PID_OUTER.Location = new Point(10, 127);
            button_send_PID_OUTER.Name = "button_send_PID_OUTER";
            button_send_PID_OUTER.Size = new Size(199, 43);
            button_send_PID_OUTER.TabIndex = 7;
            button_send_PID_OUTER.Text = "更新";
            button_send_PID_OUTER.UseVisualStyleBackColor = true;
            button_send_PID_OUTER.Click += button_send_PID_OUTER_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 33);
            label17.Name = "label17";
            label17.Size = new Size(26, 20);
            label17.TabIndex = 3;
            label17.Text = "P :";
            // 
            // domainUpDownOD
            // 
            domainUpDownOD.Location = new Point(38, 94);
            domainUpDownOD.Name = "domainUpDownOD";
            domainUpDownOD.Size = new Size(171, 27);
            domainUpDownOD.TabIndex = 2;
            domainUpDownOD.Text = "0";
            // 
            // domainUpDownOI
            // 
            domainUpDownOI.Location = new Point(38, 59);
            domainUpDownOI.Name = "domainUpDownOI";
            domainUpDownOI.Size = new Size(171, 27);
            domainUpDownOI.TabIndex = 1;
            domainUpDownOI.Text = "0";
            // 
            // domainUpDownOP
            // 
            domainUpDownOP.Location = new Point(38, 26);
            domainUpDownOP.Name = "domainUpDownOP";
            domainUpDownOP.Size = new Size(171, 27);
            domainUpDownOP.TabIndex = 0;
            domainUpDownOP.Text = "0";
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(groupBox16);
            groupBox14.Controls.Add(groupBox15);
            groupBox14.Location = new Point(498, 473);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(546, 124);
            groupBox14.TabIndex = 15;
            groupBox14.TabStop = false;
            groupBox14.Text = "飞控数据";
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(label39);
            groupBox16.Controls.Add(label38);
            groupBox16.Controls.Add(label37);
            groupBox16.Location = new Point(274, 20);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(266, 98);
            groupBox16.TabIndex = 1;
            groupBox16.TabStop = false;
            groupBox16.Text = "传感器数据";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(10, 66);
            label39.Name = "label39";
            label39.Size = new Size(38, 20);
            label39.TabIndex = 3;
            label39.Text = "GPS";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(10, 45);
            label38.Name = "label38";
            label38.Size = new Size(39, 20);
            label38.TabIndex = 2;
            label38.Text = "温度";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(10, 25);
            label37.Name = "label37";
            label37.Size = new Size(39, 20);
            label37.TabIndex = 1;
            label37.Text = "气压";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(label5);
            groupBox15.Controls.Add(label4);
            groupBox15.Controls.Add(label3);
            groupBox15.Location = new Point(6, 20);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(256, 98);
            groupBox15.TabIndex = 0;
            groupBox15.TabStop = false;
            groupBox15.Text = "软件信息";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 66);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "构建日期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 46);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "OS支持";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Gfly版本";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 设置ToolStripMenuItem, 关于ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1275, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 载入PID参数ToolStripMenuItem, 保存PID参数ToolStripMenuItem, 退出软件ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(53, 24);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 载入PID参数ToolStripMenuItem
            // 
            载入PID参数ToolStripMenuItem.Name = "载入PID参数ToolStripMenuItem";
            载入PID参数ToolStripMenuItem.Size = new Size(176, 26);
            载入PID参数ToolStripMenuItem.Text = "载入PID参数";
            // 
            // 保存PID参数ToolStripMenuItem
            // 
            保存PID参数ToolStripMenuItem.Name = "保存PID参数ToolStripMenuItem";
            保存PID参数ToolStripMenuItem.Size = new Size(176, 26);
            保存PID参数ToolStripMenuItem.Text = "保存PID参数";
            // 
            // 退出软件ToolStripMenuItem
            // 
            退出软件ToolStripMenuItem.Name = "退出软件ToolStripMenuItem";
            退出软件ToolStripMenuItem.Size = new Size(176, 26);
            退出软件ToolStripMenuItem.Text = "退出软件";
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 界面ToolStripMenuItem, 飞控设置ToolStripMenuItem });
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(53, 24);
            设置ToolStripMenuItem.Text = "选项";
            // 
            // 界面ToolStripMenuItem
            // 
            界面ToolStripMenuItem.Name = "界面ToolStripMenuItem";
            界面ToolStripMenuItem.Size = new Size(152, 26);
            界面ToolStripMenuItem.Text = "界面设置";
            // 
            // 飞控设置ToolStripMenuItem
            // 
            飞控设置ToolStripMenuItem.Name = "飞控设置ToolStripMenuItem";
            飞控设置ToolStripMenuItem.Size = new Size(152, 26);
            飞控设置ToolStripMenuItem.Text = "飞控设置";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 支持网站ToolStripMenuItem, 关于ToolStripMenuItem1 });
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(53, 24);
            关于ToolStripMenuItem.Text = "帮助";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // 支持网站ToolStripMenuItem
            // 
            支持网站ToolStripMenuItem.Name = "支持网站ToolStripMenuItem";
            支持网站ToolStripMenuItem.Size = new Size(152, 26);
            支持网站ToolStripMenuItem.Text = "支持网站";
            // 
            // 关于ToolStripMenuItem1
            // 
            关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            关于ToolStripMenuItem1.Size = new Size(152, 26);
            关于ToolStripMenuItem1.Text = "关于";
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(groupBox21);
            groupBox17.Controls.Add(groupBox20);
            groupBox17.Controls.Add(groupBox19);
            groupBox17.Controls.Add(groupBox18);
            groupBox17.Location = new Point(1050, 41);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(208, 631);
            groupBox17.TabIndex = 19;
            groupBox17.TabStop = false;
            groupBox17.Text = "PID参数";
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(label_HIGH_OUTER_KD);
            groupBox21.Controls.Add(label_HIGH_INNER_KD);
            groupBox21.Controls.Add(label_HIGH_OUTER_KI);
            groupBox21.Controls.Add(label_HIGH_INNER_KI);
            groupBox21.Controls.Add(label_HIGH_OUTER_KP);
            groupBox21.Controls.Add(label_HIGH_INNER_KP);
            groupBox21.Controls.Add(label67);
            groupBox21.Controls.Add(label68);
            groupBox21.Controls.Add(label69);
            groupBox21.Controls.Add(label70);
            groupBox21.Controls.Add(label71);
            groupBox21.Location = new Point(6, 476);
            groupBox21.Name = "groupBox21";
            groupBox21.Size = new Size(193, 149);
            groupBox21.TabIndex = 12;
            groupBox21.TabStop = false;
            groupBox21.Text = "高度 （HIGH）";
            // 
            // label_HIGH_OUTER_KD
            // 
            label_HIGH_OUTER_KD.AutoSize = true;
            label_HIGH_OUTER_KD.Location = new Point(112, 106);
            label_HIGH_OUTER_KD.Name = "label_HIGH_OUTER_KD";
            label_HIGH_OUTER_KD.Size = new Size(76, 20);
            label_HIGH_OUTER_KD.TabIndex = 10;
            label_HIGH_OUTER_KD.Text = "12.36525";
            // 
            // label_HIGH_INNER_KD
            // 
            label_HIGH_INNER_KD.AutoSize = true;
            label_HIGH_INNER_KD.Location = new Point(32, 106);
            label_HIGH_INNER_KD.Name = "label_HIGH_INNER_KD";
            label_HIGH_INNER_KD.Size = new Size(76, 20);
            label_HIGH_INNER_KD.TabIndex = 9;
            label_HIGH_INNER_KD.Text = "13.25896";
            // 
            // label_HIGH_OUTER_KI
            // 
            label_HIGH_OUTER_KI.AutoSize = true;
            label_HIGH_OUTER_KI.Location = new Point(112, 81);
            label_HIGH_OUTER_KI.Name = "label_HIGH_OUTER_KI";
            label_HIGH_OUTER_KI.Size = new Size(76, 20);
            label_HIGH_OUTER_KI.TabIndex = 8;
            label_HIGH_OUTER_KI.Text = "12.36525";
            // 
            // label_HIGH_INNER_KI
            // 
            label_HIGH_INNER_KI.AutoSize = true;
            label_HIGH_INNER_KI.Location = new Point(32, 81);
            label_HIGH_INNER_KI.Name = "label_HIGH_INNER_KI";
            label_HIGH_INNER_KI.Size = new Size(76, 20);
            label_HIGH_INNER_KI.TabIndex = 7;
            label_HIGH_INNER_KI.Text = "13.25896";
            // 
            // label_HIGH_OUTER_KP
            // 
            label_HIGH_OUTER_KP.AutoSize = true;
            label_HIGH_OUTER_KP.Location = new Point(112, 55);
            label_HIGH_OUTER_KP.Name = "label_HIGH_OUTER_KP";
            label_HIGH_OUTER_KP.Size = new Size(76, 20);
            label_HIGH_OUTER_KP.TabIndex = 6;
            label_HIGH_OUTER_KP.Text = "12.36525";
            // 
            // label_HIGH_INNER_KP
            // 
            label_HIGH_INNER_KP.AutoSize = true;
            label_HIGH_INNER_KP.Location = new Point(32, 55);
            label_HIGH_INNER_KP.Name = "label_HIGH_INNER_KP";
            label_HIGH_INNER_KP.Size = new Size(76, 20);
            label_HIGH_INNER_KP.TabIndex = 5;
            label_HIGH_INNER_KP.Text = "13.25896";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Location = new Point(6, 105);
            label67.Name = "label67";
            label67.Size = new Size(20, 20);
            label67.TabIndex = 4;
            label67.Text = "D";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Location = new Point(8, 81);
            label68.Name = "label68";
            label68.Size = new Size(13, 20);
            label68.TabIndex = 3;
            label68.Text = "I";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(6, 57);
            label69.Name = "label69";
            label69.Size = new Size(18, 20);
            label69.TabIndex = 2;
            label69.Text = "P";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(114, 23);
            label70.Name = "label70";
            label70.Size = new Size(39, 20);
            label70.TabIndex = 1;
            label70.Text = "外环";
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(33, 23);
            label71.Name = "label71";
            label71.Size = new Size(39, 20);
            label71.TabIndex = 0;
            label71.Text = "内环";
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(label_YAW_OUTER_KD);
            groupBox20.Controls.Add(label_YAW_INNER_KD);
            groupBox20.Controls.Add(label_YAW_OUTER_KI);
            groupBox20.Controls.Add(label_YAW_INNER_KI);
            groupBox20.Controls.Add(label_YAW_OUTER_KP);
            groupBox20.Controls.Add(label_YAW_INNER_KP);
            groupBox20.Controls.Add(label56);
            groupBox20.Controls.Add(label57);
            groupBox20.Controls.Add(label58);
            groupBox20.Controls.Add(label59);
            groupBox20.Controls.Add(label60);
            groupBox20.Location = new Point(6, 325);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(193, 149);
            groupBox20.TabIndex = 11;
            groupBox20.TabStop = false;
            groupBox20.Text = "偏航角 (YAW)";
            // 
            // label_YAW_OUTER_KD
            // 
            label_YAW_OUTER_KD.AutoSize = true;
            label_YAW_OUTER_KD.Location = new Point(112, 106);
            label_YAW_OUTER_KD.Name = "label_YAW_OUTER_KD";
            label_YAW_OUTER_KD.Size = new Size(76, 20);
            label_YAW_OUTER_KD.TabIndex = 10;
            label_YAW_OUTER_KD.Text = "12.36525";
            // 
            // label_YAW_INNER_KD
            // 
            label_YAW_INNER_KD.AutoSize = true;
            label_YAW_INNER_KD.Location = new Point(32, 106);
            label_YAW_INNER_KD.Name = "label_YAW_INNER_KD";
            label_YAW_INNER_KD.Size = new Size(76, 20);
            label_YAW_INNER_KD.TabIndex = 9;
            label_YAW_INNER_KD.Text = "13.25896";
            // 
            // label_YAW_OUTER_KI
            // 
            label_YAW_OUTER_KI.AutoSize = true;
            label_YAW_OUTER_KI.Location = new Point(112, 81);
            label_YAW_OUTER_KI.Name = "label_YAW_OUTER_KI";
            label_YAW_OUTER_KI.Size = new Size(76, 20);
            label_YAW_OUTER_KI.TabIndex = 8;
            label_YAW_OUTER_KI.Text = "12.36525";
            // 
            // label_YAW_INNER_KI
            // 
            label_YAW_INNER_KI.AutoSize = true;
            label_YAW_INNER_KI.Location = new Point(32, 81);
            label_YAW_INNER_KI.Name = "label_YAW_INNER_KI";
            label_YAW_INNER_KI.Size = new Size(76, 20);
            label_YAW_INNER_KI.TabIndex = 7;
            label_YAW_INNER_KI.Text = "13.25896";
            // 
            // label_YAW_OUTER_KP
            // 
            label_YAW_OUTER_KP.AutoSize = true;
            label_YAW_OUTER_KP.Location = new Point(112, 55);
            label_YAW_OUTER_KP.Name = "label_YAW_OUTER_KP";
            label_YAW_OUTER_KP.Size = new Size(76, 20);
            label_YAW_OUTER_KP.TabIndex = 6;
            label_YAW_OUTER_KP.Text = "12.36525";
            // 
            // label_YAW_INNER_KP
            // 
            label_YAW_INNER_KP.AutoSize = true;
            label_YAW_INNER_KP.Location = new Point(32, 55);
            label_YAW_INNER_KP.Name = "label_YAW_INNER_KP";
            label_YAW_INNER_KP.Size = new Size(76, 20);
            label_YAW_INNER_KP.TabIndex = 5;
            label_YAW_INNER_KP.Text = "13.25896";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(6, 105);
            label56.Name = "label56";
            label56.Size = new Size(20, 20);
            label56.TabIndex = 4;
            label56.Text = "D";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(8, 81);
            label57.Name = "label57";
            label57.Size = new Size(13, 20);
            label57.TabIndex = 3;
            label57.Text = "I";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(6, 57);
            label58.Name = "label58";
            label58.Size = new Size(18, 20);
            label58.TabIndex = 2;
            label58.Text = "P";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(114, 23);
            label59.Name = "label59";
            label59.Size = new Size(39, 20);
            label59.TabIndex = 1;
            label59.Text = "外环";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(33, 23);
            label60.Name = "label60";
            label60.Size = new Size(39, 20);
            label60.TabIndex = 0;
            label60.Text = "内环";
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(label_PITCH_OUTER_KD);
            groupBox19.Controls.Add(label_PITCH_INNER_KD);
            groupBox19.Controls.Add(label_PITCH_OUTER_KI);
            groupBox19.Controls.Add(label_PITCH_INNER_KI);
            groupBox19.Controls.Add(label_PITCH_OUTER_KP);
            groupBox19.Controls.Add(label_PITCH_INNER_KP);
            groupBox19.Controls.Add(label45);
            groupBox19.Controls.Add(label46);
            groupBox19.Controls.Add(label47);
            groupBox19.Controls.Add(label48);
            groupBox19.Controls.Add(label49);
            groupBox19.Location = new Point(6, 173);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(193, 149);
            groupBox19.TabIndex = 11;
            groupBox19.TabStop = false;
            groupBox19.Text = "俯仰角（PITCH）";
            // 
            // label_PITCH_OUTER_KD
            // 
            label_PITCH_OUTER_KD.AutoSize = true;
            label_PITCH_OUTER_KD.Location = new Point(112, 106);
            label_PITCH_OUTER_KD.Name = "label_PITCH_OUTER_KD";
            label_PITCH_OUTER_KD.Size = new Size(76, 20);
            label_PITCH_OUTER_KD.TabIndex = 10;
            label_PITCH_OUTER_KD.Text = "12.36525";
            // 
            // label_PITCH_INNER_KD
            // 
            label_PITCH_INNER_KD.AutoSize = true;
            label_PITCH_INNER_KD.Location = new Point(32, 106);
            label_PITCH_INNER_KD.Name = "label_PITCH_INNER_KD";
            label_PITCH_INNER_KD.Size = new Size(76, 20);
            label_PITCH_INNER_KD.TabIndex = 9;
            label_PITCH_INNER_KD.Text = "13.25896";
            // 
            // label_PITCH_OUTER_KI
            // 
            label_PITCH_OUTER_KI.AutoSize = true;
            label_PITCH_OUTER_KI.Location = new Point(112, 81);
            label_PITCH_OUTER_KI.Name = "label_PITCH_OUTER_KI";
            label_PITCH_OUTER_KI.Size = new Size(76, 20);
            label_PITCH_OUTER_KI.TabIndex = 8;
            label_PITCH_OUTER_KI.Text = "12.36525";
            // 
            // label_PITCH_INNER_KI
            // 
            label_PITCH_INNER_KI.AutoSize = true;
            label_PITCH_INNER_KI.Location = new Point(32, 81);
            label_PITCH_INNER_KI.Name = "label_PITCH_INNER_KI";
            label_PITCH_INNER_KI.Size = new Size(76, 20);
            label_PITCH_INNER_KI.TabIndex = 7;
            label_PITCH_INNER_KI.Text = "13.25896";
            // 
            // label_PITCH_OUTER_KP
            // 
            label_PITCH_OUTER_KP.AutoSize = true;
            label_PITCH_OUTER_KP.Location = new Point(112, 55);
            label_PITCH_OUTER_KP.Name = "label_PITCH_OUTER_KP";
            label_PITCH_OUTER_KP.Size = new Size(76, 20);
            label_PITCH_OUTER_KP.TabIndex = 6;
            label_PITCH_OUTER_KP.Text = "12.36525";
            // 
            // label_PITCH_INNER_KP
            // 
            label_PITCH_INNER_KP.AutoSize = true;
            label_PITCH_INNER_KP.Location = new Point(32, 55);
            label_PITCH_INNER_KP.Name = "label_PITCH_INNER_KP";
            label_PITCH_INNER_KP.Size = new Size(76, 20);
            label_PITCH_INNER_KP.TabIndex = 5;
            label_PITCH_INNER_KP.Text = "13.25896";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(6, 105);
            label45.Name = "label45";
            label45.Size = new Size(20, 20);
            label45.TabIndex = 4;
            label45.Text = "D";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(8, 81);
            label46.Name = "label46";
            label46.Size = new Size(13, 20);
            label46.TabIndex = 3;
            label46.Text = "I";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(6, 57);
            label47.Name = "label47";
            label47.Size = new Size(18, 20);
            label47.TabIndex = 2;
            label47.Text = "P";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(114, 23);
            label48.Name = "label48";
            label48.Size = new Size(39, 20);
            label48.TabIndex = 1;
            label48.Text = "外环";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(33, 23);
            label49.Name = "label49";
            label49.Size = new Size(39, 20);
            label49.TabIndex = 0;
            label49.Text = "内环";
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(label_ROLL_OUTER_KD);
            groupBox18.Controls.Add(label_ROLL_INNER_KD);
            groupBox18.Controls.Add(label_ROLL_OUTER_KI);
            groupBox18.Controls.Add(label_ROLL_INNER_KI);
            groupBox18.Controls.Add(label_ROLL_OUTER_KP);
            groupBox18.Controls.Add(label_ROLL_INNER_KP);
            groupBox18.Controls.Add(label29);
            groupBox18.Controls.Add(label28);
            groupBox18.Controls.Add(label24);
            groupBox18.Controls.Add(label23);
            groupBox18.Controls.Add(label22);
            groupBox18.Location = new Point(6, 22);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(193, 149);
            groupBox18.TabIndex = 0;
            groupBox18.TabStop = false;
            groupBox18.Text = "翻滚角 (ROLL)";
            // 
            // label_ROLL_OUTER_KD
            // 
            label_ROLL_OUTER_KD.AutoSize = true;
            label_ROLL_OUTER_KD.Location = new Point(112, 106);
            label_ROLL_OUTER_KD.Name = "label_ROLL_OUTER_KD";
            label_ROLL_OUTER_KD.Size = new Size(76, 20);
            label_ROLL_OUTER_KD.TabIndex = 10;
            label_ROLL_OUTER_KD.Text = "12.36525";
            // 
            // label_ROLL_INNER_KD
            // 
            label_ROLL_INNER_KD.AutoSize = true;
            label_ROLL_INNER_KD.Location = new Point(32, 106);
            label_ROLL_INNER_KD.Name = "label_ROLL_INNER_KD";
            label_ROLL_INNER_KD.Size = new Size(76, 20);
            label_ROLL_INNER_KD.TabIndex = 9;
            label_ROLL_INNER_KD.Text = "13.25896";
            // 
            // label_ROLL_OUTER_KI
            // 
            label_ROLL_OUTER_KI.AutoSize = true;
            label_ROLL_OUTER_KI.Location = new Point(112, 81);
            label_ROLL_OUTER_KI.Name = "label_ROLL_OUTER_KI";
            label_ROLL_OUTER_KI.Size = new Size(76, 20);
            label_ROLL_OUTER_KI.TabIndex = 8;
            label_ROLL_OUTER_KI.Text = "12.36525";
            // 
            // label_ROLL_INNER_KI
            // 
            label_ROLL_INNER_KI.AutoSize = true;
            label_ROLL_INNER_KI.Location = new Point(32, 81);
            label_ROLL_INNER_KI.Name = "label_ROLL_INNER_KI";
            label_ROLL_INNER_KI.Size = new Size(76, 20);
            label_ROLL_INNER_KI.TabIndex = 7;
            label_ROLL_INNER_KI.Text = "13.25896";
            // 
            // label_ROLL_OUTER_KP
            // 
            label_ROLL_OUTER_KP.AutoSize = true;
            label_ROLL_OUTER_KP.Location = new Point(112, 55);
            label_ROLL_OUTER_KP.Name = "label_ROLL_OUTER_KP";
            label_ROLL_OUTER_KP.Size = new Size(76, 20);
            label_ROLL_OUTER_KP.TabIndex = 6;
            label_ROLL_OUTER_KP.Text = "12.36525";
            // 
            // label_ROLL_INNER_KP
            // 
            label_ROLL_INNER_KP.AutoSize = true;
            label_ROLL_INNER_KP.Location = new Point(32, 55);
            label_ROLL_INNER_KP.Name = "label_ROLL_INNER_KP";
            label_ROLL_INNER_KP.Size = new Size(76, 20);
            label_ROLL_INNER_KP.TabIndex = 5;
            label_ROLL_INNER_KP.Text = "13.25896";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 105);
            label29.Name = "label29";
            label29.Size = new Size(20, 20);
            label29.TabIndex = 4;
            label29.Text = "D";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(8, 81);
            label28.Name = "label28";
            label28.Size = new Size(13, 20);
            label28.TabIndex = 3;
            label28.Text = "I";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 57);
            label24.Name = "label24";
            label24.Size = new Size(18, 20);
            label24.TabIndex = 2;
            label24.Text = "P";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(114, 23);
            label23.Name = "label23";
            label23.Size = new Size(39, 20);
            label23.TabIndex = 1;
            label23.Text = "外环";
            label23.Click += label23_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(33, 23);
            label22.Name = "label22";
            label22.Size = new Size(39, 20);
            label22.TabIndex = 0;
            label22.Text = "内环";
            // 
            // lable_FLY_STATE
            // 
            lable_FLY_STATE.AutoSize = true;
            lable_FLY_STATE.BackColor = SystemColors.Window;
            lable_FLY_STATE.Font = new Font("Microsoft YaHei UI", 18F);
            lable_FLY_STATE.ForeColor = Color.FromArgb(128, 255, 128);
            lable_FLY_STATE.Location = new Point(1085, 676);
            lable_FLY_STATE.Name = "lable_FLY_STATE";
            lable_FLY_STATE.Size = new Size(137, 39);
            lable_FLY_STATE.TabIndex = 20;
            lable_FLY_STATE.Text = "飞控锁定";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1275, 767);
            Controls.Add(lable_FLY_STATE);
            Controls.Add(groupBox17);
            Controls.Add(groupBox14);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(panel1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Gfly地面站";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarYGfgj).EndInit();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarYGfyj).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox21.ResumeLayout(false);
            groupBox21.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private ProgressBar progressBarYGym;
        private TrackBar trackBarYGfgj;
        private TrackBar trackBarYGfyj;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ProgressBar progressBarmotor3;
        private ProgressBar progressBarmotor1;
        private ProgressBar progressBarmotor4;
        private ProgressBar progressBarmotor2;
        private GroupBox groupBox4;
        private TrackBar trackBar5;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private GroupBox groupBox5;
        private TextBox debuginf;
        private GroupBox groupBox6;
        private Label label15;
        private Label connectStateLable;
        private Label label13;
        private Label controllerNameLable;
        private Label lockStateLable;
        private Label label14;
        private Panel panel1;
        private Label labelSend;
        private Label label16;
        private Label labelErr;
        private Label label20;
        private Label labelRec;
        private Label label18;
        private Button button2;
        private TrackBar trackBarPHJ;
        private TrackBar trackBarFGJ;
        private TrackBar trackBarFYJ;
        private Panel panel3d;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private DomainUpDown domainUpDown1;
        private Label label21;
        private Label label19;
        private Label label17;
        private DomainUpDown domainUpDown3;
        private DomainUpDown domainUpDown2;
        private Button button_send_PID_OUTER;
        private Panel panel2d;
        private Label labelroll;
        private Label label27;
        private Label labelpitch;
        private Label label25;
        private Panel panelyaw;
        private Label labelyaw;
        private Label label26;
        private GroupBox groupBox12;
        private GroupBox groupBox11;
        private GroupBox groupBox13;
        private TrackBar trackBar1;
        private GroupBox groupBox14;
        private GroupBox groupBox16;
        private Label label39;
        private Label label38;
        private Label label37;
        private GroupBox groupBox15;
        private Label label5;
        private Label label4;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 支持网站ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem1;
        private ToolStripMenuItem 界面ToolStripMenuItem;
        private ToolStripMenuItem 载入PID参数ToolStripMenuItem;
        private ToolStripMenuItem 保存PID参数ToolStripMenuItem;
        private ToolStripMenuItem 退出软件ToolStripMenuItem;
        private ToolStripMenuItem 飞控设置ToolStripMenuItem;
        private Button button6;
        private Button button5;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private GroupBox groupBox10;
        private Label label10;
        private Label label11;
        private Button button_send_PID_INNER;
        private Label label12;
        private DomainUpDown domainUpDown4;
        private DomainUpDown domainUpDown5;
        private DomainUpDown domainUpDown6;
        private GroupBox groupBox17;
        private GroupBox groupBox18;
        private Label label29;
        private Label label28;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button button7;
        private GroupBox groupBox21;
        private Label label_HIGH_OUTER_KD;
        private Label label_HIGH_INNER_KD;
        private Label label_HIGH_OUTER_KI;
        private Label label_HIGH_INNER_KI;
        private Label label_HIGH_OUTER_KP;
        private Label label_HIGH_INNER_KP;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private GroupBox groupBox20;
        private Label label_YAW_OUTER_KD;
        private Label label_YAW_INNER_KD;
        private Label label_YAW_OUTER_KI;
        private Label label_YAW_INNER_KI;
        private Label label_YAW_OUTER_KP;
        private Label label_YAW_INNER_KP;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private GroupBox groupBox19;
        private Label label_PITCH_OUTER_KD;
        private Label label_PITCH_INNER_KD;
        private Label label_PITCH_OUTER_KI;
        private Label label_PITCH_INNER_KI;
        private Label label_PITCH_OUTER_KP;
        private Label label_PITCH_INNER_KP;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label_ROLL_OUTER_KD;
        private Label label_ROLL_INNER_KD;
        private Label label_ROLL_OUTER_KI;
        private Label label_ROLL_INNER_KI;
        private Label label_ROLL_OUTER_KP;
        private Label label_ROLL_INNER_KP;
        private Label lable_FLY_STATE;
        private Button button9;
        private Label label30;
        private DomainUpDown domainUpDownID;
        private DomainUpDown domainUpDownII;
        private DomainUpDown domainUpDownIP;
        private DomainUpDown domainUpDownOD;
        private DomainUpDown domainUpDownOI;
        private DomainUpDown domainUpDownOP;
        private Label LablefreeBuffer;
        private Label label31;
        private Button PIDEnableButton;
    }
}
