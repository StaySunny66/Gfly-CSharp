using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using SharpDX.XInput;
using Timer = System.Windows.Forms.Timer;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gfly
 

{
    public partial class Form1 : Form
    {


        private float pitch = 0;  // 俯仰角
        private float roll = 0;   // 翻滚角
        private float yaw = 0;

        SerialPort mySerialPort;
        GflyCS gflyCS;
        short YMZ = 0;
        short FYJ = 0;
        short FGJ = 0;
        bool islocked = true;


        Controller controller;
        public Form1()
        {
            InitializeComponent();

            panel2d.Paint += pitchandrollPanel_Paint;
            panelyaw.Paint += yawPanel_Paint;
            this.DoubleBuffered = true;

            string[] ports = SerialPort.GetPortNames(); // 获取可用串口列表
            comboBox1.Items.AddRange(ports);

            try
            {

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 1;

            }
            catch (Exception e)

            {

                Debug.WriteLine(e.ToString());

            }


            Timer timer = new Timer();
            timer.Interval = 10; // 设置定时器间隔为100毫秒
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer timerView = new Timer();
            timerView.Interval = 10; // 设置定时器间隔为100毫秒
            timerView.Tick += Timer_View;
            timerView.Start();



            Thread newThread = new Thread(RxTask);
            newThread.Start();


        }

        private void yawPanel_Paint(object? sender, PaintEventArgs e)
        {
            drow_yaw();
        }

        void drow_yaw()
        {

            Bitmap bufferimage = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bufferimage);

            g.Clear(panelyaw.BackColor);

            // 获取视图中心点
            int centerX = panelyaw.Width / 2;
            int centerY = panelyaw.Height / 2;

            // 计算箭头的长度和方向
            int arrowLength = 100;
            float radians = (float)(yaw * Math.PI / 180);
            int arrowX = (int)(centerX + arrowLength * Math.Cos(radians));
            int arrowY = (int)(centerY + arrowLength * Math.Sin(radians));

            // 创建Pen对象，设置线条粗细
            using (Pen linePen = new Pen(Color.Black, 3.0f))
            {
                // 绘制箭头线
                g.DrawLine(linePen, centerX, centerY, arrowX, arrowY);

                // 创建Pen对象，设置箭头粗细
                using (Pen arrowPen = new Pen(Color.Black, 3.0f))
                {
                    // 绘制箭头头部
                    DrawArrowhead(g, arrowPen, centerX, centerY, arrowX, arrowY);
                }
            }

            using (Graphics gg = panelyaw.CreateGraphics())
            {

                gg.DrawImage(bufferimage, new Point(0, 0)); // 可以根据需要设置位置


            }




        }

        private void DrawArrowhead(Graphics g, Pen arrowPen, int x1, int y1, int x2, int y2)
        {
            // 计算箭头头部的三个点
            const int arrowheadSize = 10;

            double angle = Math.Atan2(y2 - y1, x2 - x1);
            double angle1 = angle - Math.PI / 6;
            double angle2 = angle + Math.PI / 6;

            int x3 = (int)(x2 - arrowheadSize * Math.Cos(angle1));
            int y3 = (int)(y2 - arrowheadSize * Math.Sin(angle1));

            int x4 = (int)(x2 - arrowheadSize * Math.Cos(angle2));
            int y4 = (int)(y2 - arrowheadSize * Math.Sin(angle2));

            // 绘制箭头头部
            g.DrawLine(arrowPen, x2, y2, x3, y3);
            g.DrawLine(arrowPen, x2, y2, x4, y4);
        }


        void drow()
        {

            Bitmap bufferimage = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bufferimage);
            g.Clear(panelyaw.BackColor);
            // 计算圆心坐标
            int centerX = panel2d.Width / 2;
            int centerY = panel2d.Height / 2;

            // 计算圆的半径
            int radius = Math.Min(centerX, centerY) - 10;

            // 绘制圆
            g.FillEllipse(Brushes.LightGray, centerX - radius, centerY - radius, radius * 2, radius * 2);

            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            // 计算气泡的坐标
            int bubbleX = centerX - (int)((radius) * Math.Sin(Math.PI * roll / 180.0));
            int bubbleY = centerY + (int)((radius) * Math.Sin(Math.PI * pitch / 180.0));

            // 绘制气泡
            g.FillEllipse(Brushes.DeepSkyBlue, bubbleX - 10, bubbleY - 10, 20, 20);


            using (Graphics gg = panel2d.CreateGraphics())
            {
                // 使用DrawImage方法将Bitmap绘制到Panel上
                gg.DrawImage(bufferimage, new Point(0, 0)); // 可以根据需要设置位置
            }

        }


        private void pitchandrollPanel_Paint(object? sender, PaintEventArgs e)
        {

            drow();

        }
        /// <summary>
        ///  基本事件回调
        /// </summary>
        /// <param name="DataEvent"></param>

        private void basicviewHandelEvent(int DataEvent)
        {

            Debug.WriteLine("basicviewHandelEvent" + DataEvent.ToString());
            this.Invoke(new Action(() =>
            {

                switch (DataEvent)
                {

                    case GflyCS.FLY_UNLOCK:

                        lable_FLY_STATE.Text = "飞机解锁";
                        lable_FLY_STATE.ForeColor = Color.Red;
                        debuginf.Text += "飞控->PID 飞机已解锁 \r\n";


                        break;
                    case GflyCS.FLY_LOCK:

                        lable_FLY_STATE.Text = "飞机锁定";
                        lable_FLY_STATE.ForeColor = Color.Green;
                        debuginf.Text += "飞控->PID 飞机已锁定 \r\n";




                        break;
                    case GflyCS.PID_ENABLE:

                        PIDEnableButton.Text = "断开PID";
                        debuginf.Text += "飞控->PID 已连接 \r\n";



                        break;
                    case GflyCS.PID_DISABLE:

                        PIDEnableButton.Text = "连接PID";
                        debuginf.Text += "飞控->PID 已断开 \r\n";

                        break;

                    case GflyCS.PID_I_CLEAN:

                        // 不做擦奥做
                        debuginf.Text += "飞控->PID 清空完成 \r\n";
                        break;
                    case GflyCS.GFLY_RECK_DATA:

                        debuginf.Text += "飞控->收到数据更新请求 \r\n";

                        break;
                    case GflyCS.PID_RESET:
                        debuginf.Text += "飞控->PID积分项目清空完成 \r\n";


                        break;
                    case GflyCS.GFLY_OPEN_LIGHT:
                        debuginf.Text += "飞控->灯光开启 \r\n";


                        break;


                }

                debuginf.SelectionStart = debuginf.Text.Length;
                debuginf.ScrollToCaret();






            }));



        }
        /// <summary>
        ///   界面事件回调
        /// </summary>
        /// <param name="DataEvent"></param>
        private void viewHandelEvent(int DataEvent)
        {

            // Debug.WriteLine("Event ID:" + DataEvent + "Value" + Value);
            this.Invoke(new Action(() =>
            {
                switch (DataEvent)
                {
                    case GflyCS.BASEDATA:
                        pitch = gflyCS.pitch_C;
                        roll = gflyCS.roll_C;
                        yaw = gflyCS.yaw_C;
                        labelpitch.Text = pitch + "°";
                        labelroll.Text = roll + "°";
                        labelyaw.Text = yaw + "°";
                        drow_yaw(); drow();
                        ; break;

                    case GflyCS.THROTTLEDETAIL:
                        // 油门更新

                        progressBarmotor1.Value = gflyCS.throttle1;
                        progressBarmotor2.Value = gflyCS.throttle2;
                        progressBarmotor4.Value = gflyCS.throttle3;
                        progressBarmotor3.Value = gflyCS.throttle4;

                        break;


                    case GflyCS.PID_SET:
                        // PID 界面显示更新

                        label_ROLL_INNER_KP.Text = gflyCS.PID_INNER_ROLL_KP.ToString();
                        label_ROLL_INNER_KI.Text = gflyCS.PID_INNER_ROLL_KI.ToString();
                        label_ROLL_INNER_KD.Text = gflyCS.PID_INNER_ROLL_KD.ToString();

                        label_ROLL_OUTER_KP.Text = gflyCS.PID_OUTER_ROLL_KP.ToString();
                        label_ROLL_OUTER_KI.Text = gflyCS.PID_OUTER_ROLL_KI.ToString();
                        label_ROLL_OUTER_KD.Text = gflyCS.PID_OUTER_ROLL_KD.ToString();

                        label_PITCH_INNER_KP.Text = gflyCS.PID_INNER_PITCH_KP.ToString();
                        label_PITCH_INNER_KI.Text = gflyCS.PID_INNER_PITCH_KI.ToString();
                        label_PITCH_INNER_KD.Text = gflyCS.PID_INNER_PITCH_KD.ToString();

                        label_PITCH_OUTER_KP.Text = gflyCS.PID_OUTER_PITCH_KP.ToString();
                        label_PITCH_OUTER_KI.Text = gflyCS.PID_OUTER_PITCH_KI.ToString();
                        label_PITCH_OUTER_KD.Text = gflyCS.PID_OUTER_PITCH_KD.ToString();

                        label_YAW_INNER_KP.Text = gflyCS.PID_INNER_YAW_KP.ToString();
                        label_YAW_INNER_KI.Text = gflyCS.PID_INNER_YAW_KI.ToString();
                        label_YAW_INNER_KD.Text = gflyCS.PID_INNER_YAW_KD.ToString();

                        label_YAW_OUTER_KP.Text = gflyCS.PID_OUTER_YAW_KP.ToString();
                        label_YAW_OUTER_KI.Text = gflyCS.PID_OUTER_YAW_KI.ToString();
                        label_YAW_OUTER_KD.Text = gflyCS.PID_OUTER_YAW_KD.ToString();

                        label_HIGH_INNER_KP.Text = gflyCS.PID_INNER_HIGH_KP.ToString();
                        label_HIGH_INNER_KI.Text = gflyCS.PID_INNER_HIGH_KI.ToString();
                        label_HIGH_INNER_KD.Text = gflyCS.PID_INNER_HIGH_KD.ToString();

                        label_HIGH_OUTER_KP.Text = gflyCS.PID_OUTER_HIGH_KP.ToString();
                        label_HIGH_OUTER_KI.Text = gflyCS.PID_OUTER_HIGH_KI.ToString();
                        label_HIGH_OUTER_KD.Text = gflyCS.PID_OUTER_HIGH_KD.ToString();

                        break;




                }


            }));



        }


        //接收任务
        private void RxTask()
        {

            byte[] C_T = new byte[6];
            byte T;
            int cmd_index = -1;
            while (true)
            {
                if (mySerialPort != null)
                {
                    if (mySerialPort.IsOpen)
                    {
                    Sta:
                        try
                        {
                            T = (byte)mySerialPort.ReadByte();
                            ///  Debug.WriteLine(T.ToString("X2"));

                            if (T == 0xff)
                            {
                                //读取到 开始接收数据起始
                                // Debug.WriteLine("开始位已读取");
                                if (cmd_index == -1) cmd_index = 0;
                                else
                                {
                                    cmd_index = 0;
                                    // Debug.WriteLine("发生错误");
                                }
                            }
                            else
                            {
                                //读取到 不是 0XFF  那可能就是数据喽 ~
                                if (cmd_index != -1) C_T[cmd_index++] = T;
                            }

                            if (cmd_index == 5)
                            {
                                cmd_index = -1;
                                gflyCS.cmdPrash(C_T);

                            }



                        }
                        catch (Exception e)
                        {

                            Debug.WriteLine("估计是那个小子 把串口线拔了");



                        }




                    }
                }
            }
        }

        private void Timer_View(object sender, EventArgs e)
        {

            if (gflyCS != null)
            {

                labelErr.Text = gflyCS.ErrCount + " Pts";
                labelRec.Text = gflyCS.RecCount + " Pts";
                labelSend.Text = gflyCS.SendCount + " Pts";
                LablefreeBuffer.Text = gflyCS.getBufferFreeCount().ToString();

            }


            if (mySerialPort.IsOpen)
            {

                button1.Text = "已打开";
                button1.ForeColor = Color.Green;


            }
            else
            {

                button1.Text = "连接";
                button1.ForeColor = Color.Green;

            }







        }


        // 发送端口 
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (controller != null)
            {
                if (controller.IsConnected)
                {
                    var state = controller.GetState();
                    connectStateLable.Text = "已连接";
                    controllerNameLable.Text = "Xbox 360";


                    // debuginf.Text = "Left Thumb: " + state.Gamepad.LeftThumbX + ", " + state.Gamepad.LeftThumbY + "\r\n" +
                    //    "Right Thumb: " + state.Gamepad.RightThumbX + ", " + state.Gamepad.RightThumbY + "\r\n" +
                    //    "Buttons: " + state.Gamepad.Buttons;


                    if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B))
                    {
                        // 急停按钮
                        gflyCS.sendSetting(GflyCS.LOCK);


                        islocked
                             = true;


                    }

                    if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y))
                    {
                        // 解锁按钮
                        islocked = false;
                        gflyCS.sendSetting(GflyCS.UNLOCK);



                    }



                    if (islocked)
                    {
                        lockStateLable.Text = "锁定归零";
                        lockStateLable.ForeColor = Color.Red;
                        YMZ = 0;
                        FYJ = 0;
                        FGJ = 0;

                    }
                    else
                    {
                        lockStateLable.Text = "已解锁";
                        lockStateLable.ForeColor = Color.Green;


                        // 数据采集
                        // 油门
                        // 摇杆 线性范围过短  使用 累积油门模式 
                        short ymadd = (short)((2.0) * (state.Gamepad.LeftThumbY) / (32767.0));

                        YMZ += ymadd;

                        if (YMZ < 0) { YMZ = 0; }
                        if (YMZ >= 255) { YMZ = 254; }

                        FYJ = (short)((10.0) * (state.Gamepad.RightThumbY / 32768.0));
                        FGJ = (short)((10.0) * (state.Gamepad.RightThumbX / 32768.0));

                    }


                    progressBarYGym.Value = YMZ;
                    //  俯仰角 和 翻滚角
                    trackBarYGfgj.Value = FGJ;
                    trackBarYGfyj.Value = FYJ;

                    gflyCS.basicDataSend(YMZ, -FYJ, -FGJ, 0);






                }
                else
                {

                    connectStateLable.Text = "未连接";
                    controllerNameLable.Text = "不适用";


                }


            }


            // 在这里更新界面或执行其他操作
            // 例如：更新文本框、图形界面等来显示手柄状态信息
            // textBox1.Text = "Left Thumb: " + state.Gamepad.LeftThumbX + ", " + state.Gamepad.LeftThumbY;
            // textBox2.Text = "Right Thumb: " + state.Gamepad.RightThumbX + ", " + state.Gamepad.RightThumbY;
            // label1.Text = "Buttons: " + state.Gamepad.Buttons;
        }

        /// <summary>
        /// 生命周期  在 form1  加载 时 执行 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Load(object sender, EventArgs e)
        {


            controller = new Controller(UserIndex.One);
            mySerialPort = new SerialPort();
            gflyCS = new GflyCS(mySerialPort);
            gflyCS.viewEvent += viewHandelEvent;
            gflyCS.basicViewEvent += basicviewHandelEvent;

            //await RxTask();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (mySerialPort.IsOpen)
            {

                mySerialPort.Close();
                Debug.WriteLine("关闭串口");

            }
            else
            {

                // 开始 连接 
                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {



                    String port = comboBox1.SelectedItem.ToString();
                    int baudRate = int.Parse(comboBox2.SelectedItem.ToString());

                    mySerialPort.PortName = port;
                    mySerialPort.BaudRate = baudRate;
                    mySerialPort.Parity = Parity.None;
                    mySerialPort.StopBits = StopBits.One;
                    mySerialPort.DataBits = 8;
                    mySerialPort.Handshake = Handshake.None;
                    try
                    {

                        mySerialPort.Open();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("连接失败！");

                    }
                }
                else
                {

                    MessageBox.Show("请选择串口号和波特率！");
                }





            }








        }




        private void connectStateLable_Click(object sender, EventArgs e)
        {

        }

        private void controllerNameLable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// 清空计数
            if (gflyCS != null) gflyCS.countRest();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void debuginf_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }



        // pid 算法参数发送

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBarYGym_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBarYGfyj_Scroll(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            gflyCS.sendSetting(GflyCS.GFLY_RECK_DATA);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // 俯仰

            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {

                domainUpDownIP.Text = gflyCS.PID_INNER_PITCH_KP.ToString();
                domainUpDownII.Text = gflyCS.PID_INNER_PITCH_KI.ToString();
                domainUpDownID.Text = gflyCS.PID_INNER_PITCH_KD.ToString();

                domainUpDownOP.Text = gflyCS.PID_OUTER_PITCH_KP.ToString();
                domainUpDownOI.Text = gflyCS.PID_OUTER_PITCH_KI.ToString();
                domainUpDownOD.Text = gflyCS.PID_OUTER_PITCH_KD.ToString();





                // RadioButton 被选中
                string radioButtonName = radioButton.Name;
                Debug.WriteLine(radioButtonName + " 被选中");
            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // 翻滚
            RadioButton radioButton = (RadioButton)sender;


            if (radioButton.Checked)
            {

                domainUpDownIP.Text = gflyCS.PID_INNER_ROLL_KP.ToString();
                domainUpDownII.Text = gflyCS.PID_INNER_ROLL_KI.ToString();
                domainUpDownID.Text = gflyCS.PID_INNER_ROLL_KD.ToString();

                domainUpDownOP.Text = gflyCS.PID_OUTER_ROLL_KP.ToString();
                domainUpDownOI.Text = gflyCS.PID_OUTER_ROLL_KI.ToString();
                domainUpDownOD.Text = gflyCS.PID_OUTER_ROLL_KD.ToString();
                // RadioButton 被选中
                string radioButtonName = radioButton.Name;
                Debug.WriteLine(radioButtonName + " 被选中");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // 偏航
            RadioButton radioButton = (RadioButton)sender;


            if (radioButton.Checked)
            {

                domainUpDownIP.Text = gflyCS.PID_INNER_YAW_KP.ToString();
                domainUpDownII.Text = gflyCS.PID_INNER_YAW_KI.ToString();
                domainUpDownID.Text = gflyCS.PID_INNER_YAW_KD.ToString();

                domainUpDownOP.Text = gflyCS.PID_OUTER_YAW_KP.ToString();
                domainUpDownOI.Text = gflyCS.PID_OUTER_YAW_KI.ToString();
                domainUpDownOD.Text = gflyCS.PID_OUTER_YAW_KD.ToString();
                // RadioButton 被选中
                string radioButtonName = radioButton.Name;
                Debug.WriteLine(radioButtonName + " 被选中");
            }



        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            //高度
            RadioButton radioButton = (RadioButton)sender;


            if (radioButton.Checked)
            {
                domainUpDownIP.Text = gflyCS.PID_INNER_HIGH_KP.ToString();
                domainUpDownII.Text = gflyCS.PID_INNER_HIGH_KI.ToString();
                domainUpDownID.Text = gflyCS.PID_INNER_HIGH_KD.ToString();

                domainUpDownOP.Text = gflyCS.PID_OUTER_HIGH_KP.ToString();
                domainUpDownOI.Text = gflyCS.PID_OUTER_HIGH_KI.ToString();
                domainUpDownOD.Text = gflyCS.PID_OUTER_HIGH_KD.ToString();
                // RadioButton 被选中
                string radioButtonName = radioButton.Name;
                Debug.WriteLine(radioButtonName + " 被选中");
            }

        }




        /// <summary>
        ///  内环 PID 发送 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_send_PID_INNER_Click(object sender, EventArgs e)
        {
            float KP, KI, KD;

            KP = float.Parse(domainUpDownIP.Text);
            KI = float.Parse(domainUpDownII.Text);
            KD = float.Parse(domainUpDownID.Text);


            if (radioButton1.Checked)
            {

                // 俯仰
                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_INNER | GflyCS.PID_SET_PITCH, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_INNER | GflyCS.PID_SET_PITCH, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_INNER | GflyCS.PID_SET_PITCH, KD);

            }
            else if (radioButton2.Checked)
            {

                // 翻滚
                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_INNER | GflyCS.PID_SET_ROLL, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_INNER | GflyCS.PID_SET_ROLL, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_INNER | GflyCS.PID_SET_ROLL, KD);


            }
            else if (radioButton3.Checked)
            {

                // 偏航

                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_INNER | GflyCS.PID_SET_YAW, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_INNER | GflyCS.PID_SET_YAW, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_INNER | GflyCS.PID_SET_YAW, KD);


            }
            else if (radioButton4.Checked)
            {

                //高度

                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_INNER | GflyCS.PID_SET_HIGH, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_INNER | GflyCS.PID_SET_HIGH, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_INNER | GflyCS.PID_SET_HIGH, KD);

            }
            else
            {
                // 用户可能 没有 进行 任何 选择设置项

                MessageBox.Show("请选择要设定的 PID 项");


            }

        }

        /// <summary>
        ///  外环 PID 发送 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button_send_PID_OUTER_Click(object sender, EventArgs e)
        {

            float KP, KI, KD;

            KP = float.Parse(domainUpDownOP.Text);
            KI = float.Parse(domainUpDownOI.Text);
            KD = float.Parse(domainUpDownOD.Text);

            if (!mySerialPort.IsOpen)
            {

                MessageBox.Show("串口未连接");
                return;

            }


            if (radioButton1.Checked)
            {

                // 俯仰
                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_PITCH, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_PITCH, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_PITCH, KD);

            }
            else if (radioButton2.Checked)
            {

                // 翻滚
                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_ROLL, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_ROLL, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_ROLL, KD);


            }
            else if (radioButton3.Checked)
            {

                // 偏航

                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_YAW, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_YAW, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_YAW, KD);


            }
            else if (radioButton4.Checked)
            {

                //高度

                gflyCS.pidSendData(GflyCS.PID_SET_P, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_HIGH, KP);
                gflyCS.pidSendData(GflyCS.PID_SET_I, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_HIGH, KI);
                gflyCS.pidSendData(GflyCS.PID_SET_D, GflyCS.PID_SET_OUTER | GflyCS.PID_SET_HIGH, KD);

            }
            else
            {
                // 用户可能 没有 进行 任何 选择设置项
                MessageBox.Show("请选择要设定的 PID 项");


            }

        }

        private void PIDEnableButton_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button pidButton = (System.Windows.Forms.Button)sender;

            if (pidButton.Text == "断开PID")
            {
                gflyCS.sendSetting(GflyCS.PID_DISABLE);

            }
            else
            {

                gflyCS.sendSetting(GflyCS.PID_ENABLE);


            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            gflyCS.sendSetting(GflyCS.PID_I_CLEAN);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
