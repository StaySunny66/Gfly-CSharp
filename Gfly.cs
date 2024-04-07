using System;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.IO.Ports;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;


/// <summary>
///  @SatySunny
///  Gfly 飞控协议  
///  ©2023 河北科技师范学院 高旭阳
///  2023 年 12月 11 日
///  禁止商用
///  shilight.cn
/// </summary>

public class GflyCS
{



    // PID 

    public const byte ENABLE = 0x01;
    public const byte DISABLE = 0x00;

    // 委托事件
    public delegate void viewHandelEvent(int dataEvent);
    public delegate void BasicHandelEvent(int dataEvent);


    public event viewHandelEvent viewEvent;
    public event BasicHandelEvent basicViewEvent;

    public const byte LOCK = 0x00;
    public const byte UNLOCK = 0x01;

    public const byte VERSION_BIG = 1;
    public const byte VERSION_SMALL = 0;
    public const byte OS_SUPPORT = 0x00; // 0x00 NO OS  0X01 FreeRTOS  0x01 uCOS

    // GFLY控制指令
    public const byte SETTING = 0XA0;  //GFLY 控制指令

    public const byte FLY_LOCK = 0x00;  //飞机锁定
    public const byte FLY_UNLOCK = 0x01; //飞机解锁
    public const byte PID_ENABLE = 0x02;//PID使能
    public const byte PID_DISABLE = 0x03; //PID失能
    public const byte PID_I_CLEAN = 0x04; //积分清零
    public const byte GFLY_RECK_DATA = 0x05; //获取基本数据
    public const byte PID_RESET = 0x06; //PID恢复默认
    public const byte GFLY_OPEN_LIGHT = 0x07; //开启灯光



    // 控制指令内容结束

    public const byte CMD_START = 0XFF; // 包的开始 
    public const byte BASEDATA = 0X00;  // 基本数据 
    public const byte THROTTLEDETAIL = 0X10;  // 油门数据
    public const byte PRESSDATA = 0X20;       // 气压数据
    public const byte TEMPERATURE = 0X30;     // 温度数据

    public const byte PID_SET = 0x40;         // PIS 设定数据
    ////////////////PID DATA BIT //////////////
    public const byte PID_SET_P = 0x04;
    public const byte PID_SET_I = 0x02;
    public const byte PID_SET_D = 0x01;
    public const byte PID_SET_INNER = 0x00;  // 内环
    public const byte PID_SET_OUTER = 0x10;  // 外环
    public const byte PID_SET_YAW = 0x00;    // PID 偏航角参数
    public const byte PID_SET_PITCH = 0x20;  // PID 翻滚角参数
    public const byte PID_SET_ROLL = 0x40;   // PID 翻滚角参数
    public const byte PID_SET_HIGH = 0x60;   // PID 高度参数

    public const byte PID_FLAG_POS = 0x08;
    public const byte PID_FLAG_NEG = 0x00;


    //////////////////COMMEND INDEX ///////////////////
    /// <summary>
    /// 
    /// </summary>
    //  发送  数据  指令位从1 开始 

    public const byte TXCMD = 0x01;
    public const byte TXDATA1 = 0x02;
    public const byte TXDATA2 = 0x03;
    public const byte TXDATA3 = 0x04;
    public const byte TXDATA4 = 0x05;


    //  接收  数据  指令 位从 0 开始 
    public const byte RECCMD = 0x00;
    public const byte RECDATA1 = 0x01;
    public const byte RECDATA2 = 0x02;
    public const byte RECDATA3 = 0x03;
    public const byte RECDATA4 = 0x04;

    /////////////////////////////////////////



    public const byte FLYACK = 0x50;
    public const byte VERSION = 0x60;
    public const byte HIGHTDEFFULE = 0X70;

    public const byte GPS_J = 0X80;
    public const byte GPS_W = 0X90;
    public const byte GPS_FLAG_POS = 0x20; // +
    public const byte GPS_FLAG_NEG = 0x00; // -


    private int oled_throttl;
    private float oled_pitch;
    private float oled_roll;
    private float oled_yaw;

    public int pidEnable { get; set; }


    public int throttle1 { get; set; }
    public int throttle2 { get; set; }
    public int throttle3 { get; set; }
    public int throttle4 { get; set; }

    public float yaw_C { get; set; }  // 偏航角
    public float pitch_C { get; set; }   // 俯仰角
    public float roll_C { get; set; }   // 翻滚角
    public float throttle_C { get; set; }


    public int ErrCount { get; set; }
    public int SendCount { get; set; }
    public int RecCount { get; set; }

    public int SendBufferFreeCount { get; set; }


    /// <summary>
    ///  PID 所有参数
    /// </summary>

    public float PID_INNER_YAW_KP { get; set; }
    public float PID_INNER_YAW_KI { get; set; }
    public float PID_INNER_YAW_KD { get; set; }
    public float PID_INNER_PITCH_KP { get; set; }
    public float PID_INNER_PITCH_KI { get; set; }
    public float PID_INNER_PITCH_KD { get; set; }
    public float PID_INNER_ROLL_KP { get; set; }
    public float PID_INNER_ROLL_KI { get; set; }
    public float PID_INNER_ROLL_KD { get; set; }
    public float PID_INNER_HIGH_KP { get; set; }
    public float PID_INNER_HIGH_KI { get; set; }
    public float PID_INNER_HIGH_KD { get; set; }


    public float PID_OUTER_YAW_KP { get; set; }
    public float PID_OUTER_YAW_KI { get; set; }
    public float PID_OUTER_YAW_KD { get; set; }
    public float PID_OUTER_PITCH_KP { get; set; }
    public float PID_OUTER_PITCH_KI { get; set; }
    public float PID_OUTER_PITCH_KD { get; set; }
    public float PID_OUTER_ROLL_KP { get; set; }
    public float PID_OUTER_ROLL_KI { get; set; }
    public float PID_OUTER_ROLL_KD { get; set; }
    public float PID_OUTER_HIGH_KP { get; set; }
    public float PID_OUTER_HIGH_KI { get; set; }
    public float PID_OUTER_HIGH_KD { get; set; }




    private Queue<byte[]> CmdQueue;




    private SerialPort mSerialPort;





    public GflyCS(SerialPort mSerialPort)
    {
        this.mSerialPort = mSerialPort;
        this.CmdQueue = new Queue<byte[]>();

        System.Timers.Timer timer = new System.Timers.Timer();

        // 设置定时器的时间间隔（以毫秒为单位）
        timer.Interval = 8.4; // 1000毫秒 = 1秒

        // 绑定定时器的Elapsed事件处理程序
        timer.Elapsed += TimerSend;

        // 启动定时器
        timer.Start();

        pidEnable = ENABLE;

        ErrCount = 0;
        SendCount = 0;
        RecCount = 0;
        throttle1 = 0;
        throttle2 = 0;
        throttle3 = 0;
        throttle4 = 0;
        yaw_C = 0.0f;
        pitch_C = 0.0f;
        roll_C = 0.0f;
        throttle_C = 0.0f;
        PID_OUTER_YAW_KP = 0.0f;
        PID_OUTER_YAW_KI = 0.0f;
        PID_OUTER_YAW_KD = 0.0f;
        PID_OUTER_PITCH_KP = 0.0f;
        PID_OUTER_PITCH_KI = 0.0f;
        PID_OUTER_PITCH_KD = 0.0f;
        PID_OUTER_ROLL_KP = 0.0f;
        PID_OUTER_ROLL_KI = 0.0f;
        PID_OUTER_ROLL_KD = 0.0f;
        PID_OUTER_HIGH_KP = 0.0f;
        PID_OUTER_HIGH_KD = 0.0f;
        PID_OUTER_HIGH_KI = 0.0f;

        PID_INNER_YAW_KP = 0.0f;
        PID_INNER_YAW_KI = 0.0f;
        PID_INNER_YAW_KD = 0.0f;
        PID_INNER_PITCH_KP = 0.0f;
        PID_INNER_PITCH_KI = 0.0f;
        PID_INNER_PITCH_KD = 0.0f;
        PID_INNER_ROLL_KP = 0.0f;
        PID_INNER_ROLL_KI = 0.0f;
        PID_INNER_ROLL_KD = 0.0f;
        PID_INNER_HIGH_KP = 0.0f;
        PID_INNER_HIGH_KD = 0.0f;
        PID_INNER_HIGH_KI = 0.0f;


    }

    public int getBufferFreeCount() {

        return 50 - CmdQueue.Count;
    }

    private void addToCmdQueue(byte[] cmd) {

        if (CmdQueue.Count > 50)
        {

            CmdQueue.Dequeue();
            CmdQueue.Enqueue(cmd);

        }
        else {

            CmdQueue.Enqueue(cmd);

        }

    }


    /// <summary>
    // 定时器调用函数  
    ///  7 - 8 MS 发送一次队列数据放置数据阻塞    
    /// 
    /// </summary>
    private void TimerSend(object sender, ElapsedEventArgs e) {

        if (CmdQueue.Count > 0) {

            Byte[] bytes = CmdQueue.Dequeue();

            if (mSerialPort.IsOpen) {
                mSerialPort.BaseStream.WriteAsync(bytes, 0, bytes.Length);
                mSerialPort.BaseStream.Flush();
                SendCount++;
            }


        }

    }


    public void countRest() {


        ErrCount = 0;
        SendCount = 0;
        RecCount = 0;

    }

    /////  基本支持 函数


    /// 偶校验 0 的个数 函数
    //  偶 1 奇 0
    private byte evenParity(byte data)
    {

        int count = 0;

        while (data != 0x00)
        {
            count += data & 1;
            data >>= 1;
        }

        return (byte)((count % 2 == 0) ? 1 : 0);
    }


    private byte dataEvenParity(byte[] packet)
    {
        int i = 0;
        byte checkData = 0x00;
        for (i = 0; i < 3; i++)
        {


            checkData |= evenParity(packet[i + 2]); // 使用位或运算设置新的偶校验位
            checkData <<= 1; // 左移一位，为下一个偶校验位腾出位置
        }
        return checkData;
    }

    private byte dataEvenParityRec(byte[] recPacket)
    {
        int i = 0;
        byte checkData = 0x00;
        for (i = 0; i < 3; i++)
        {


            checkData |= evenParity(recPacket[i + 1]); // 使用位或运算设置新的偶校验位
            checkData <<= 1; // 左移一位，为下一个偶校验位腾出位置

        }
        return checkData;
    }


    /// 发送函数 <summary>
    /// 发送数据包的函数
    /// </summary>
    /// <param name="packet"></param>

    public void sendPacket(byte[] packet)
    {
        packet[0] = 0xff;

        addToCmdQueue(packet);

        /// if (mSerialPort.IsOpen) {
        //    mSerialPort.BaseStream.WriteAsync(packet, 0, 6);
        //mSerialPort.BaseStream.Flush();
        //    SendCount++;
        // }





    }





    ///// 以下是命令的包装
    ///基本数据发送
    public void basicDataSend(int throttle, float pitch, float roll, float yaw)
    {
        byte[] packet = new byte[6];

        if (oled_yaw == yaw && oled_throttl == throttle && oled_roll == roll && oled_pitch == pitch) {

            return;

        }
        //指令封装
        packet[1] = BASEDATA;

        //数据封装
        packet[2] = (byte)throttle;
        packet[3] = (byte)((pitch - (-60.0f)) / 0.5f);
        packet[4] = (byte)((roll - (-60.0f)) / 0.5f);
        packet[5] = (byte)((yaw - (-180.0f)) / 2);

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);
        oled_pitch = pitch;
        oled_roll = roll;
        oled_throttl = throttle;
        oled_yaw = yaw;

    }

    ///基本数据解析
    public void basicDataPrash(byte[] packet)
    {
        throttle_C = packet[1];
        pitch_C = (packet[2] * 0.5f) - 60.0f;
        roll_C = (packet[3] * 0.5f) - 60.0f;
        yaw_C = (packet[4] * 2) - 180.0f;

        viewEvent?.Invoke(BASEDATA);
    }



    /// <summary>
    ///  油门数据 发送 
    /// </summary>
    /// <param name="throttle1"> 油门1 </param>
    /// <param name="throttle2"> 油门2 </param>
    /// <param name="throttle3"> 油门3 </param>
    /// <param name="throttle4"> 油门4 </param>
    public void throttleDataSend(byte throttle1, byte throttle2, byte throttle3, byte throttle4)
    {

        byte[] packet = new byte[6];
        //指令封装
        packet[1] = THROTTLEDETAIL;

        //数据封装
        packet[2] = throttle1;
        packet[3] = throttle2;
        packet[4] = throttle3;
        packet[5] = throttle4;

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);
    }


    ///油门数据解析 <summary>
    /// 油门数据解析
    /// </summary>
    /// <param name="packet"> 数据包 </param>
    public void throttleDataPrash(byte[] packet)
    {

        throttle1 = packet[1];
        throttle2 = packet[2];
        throttle3 = packet[3];
        throttle4 = packet[4];

        viewEvent?.Invoke(THROTTLEDETAIL);
    }



    /// <summary>
    /// 气压数据发送
    /// </summary>
    /// <param name="pressData"></param>
    public void pressDataSend(float pressData)
    {
        byte[] packet = new byte[6];
        byte flag;
        //指令封装
        packet[1] = PRESSDATA;

        //数据封装
        int data = (int)(pressData * 100);
        if (data >= 0) flag = 0x01;
        else flag = 0x00;


        packet[2] = flag;
        packet[3] = (byte)((data / 100) / 254);
        packet[4] = (byte)((data / 100) % 254);
        packet[5] = (byte)(data % 100);

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);

    }


    ///油门数据解析 <summary>
    /// 油门数据解析
    /// </summary>
    /// <param name="packet"></param>
    public void pressDataPrash(byte[] packet)
    {

        float pressData = packet[2] * 254 + packet[3];
        pressData += packet[4] / 100.0f;
        if (packet[1] == 0x00) pressData = -pressData;
        // 气压转换完毕
        // 执行你的操作    



    }


    /// <summary>
    /// 温度数据 发送
    /// </summary>
    /// <param name="temp1"></param>
    /// <param name="temp2"></param>
    /// <param name="temp3"></param>
    /// <param name="temp4"></param>
    public void temperatureDataSend(float temp1, float temp2, float temp3, float temp4)
    {
        byte[] packet = new byte[6];
        //指令封装
        packet[1] = THROTTLEDETAIL;

        //数据封装
        packet[2] = (byte)((temp1 - (-20.0f)) / 0.25f);
        packet[3] = (byte)((temp2 - (-20.0f)) / 0.25f);
        packet[4] = (byte)((temp3 - (-20.0f)) / 0.25f);
        packet[5] = (byte)((temp4 - (-20.0f)) / 0.25f);

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);

    }

    ///温度数据解析 <summary>
    /// 温度数据解析
    /// </summary>
    /// <param name="packet"></param>
    public void temperatureDataPrash(byte[] packet)
    {

        float temperature1;
        float temperature2;
        float temperature3;
        float temperature4;

        temperature1 = packet[1];
        temperature2 = (packet[2] * 0.25f) - 20.0f;
        temperature3 = (packet[3] * 0.25f) - 20.0f;
        temperature4 = (packet[4] * 0.25f) - 20.0f;
        // 温度转换完毕
        // 执行你的操作    

    }





    // PID 发送 范围 ± 160.00000
    //  P_I_D_opt(表示 PID 其中的 哪一项？)  ->
    //  Witch_opt -> 表示 PID 的 内环还是外环  PID 数据为 四个PID的哪一个？
    //  val 表示 范围为 -160.00000 - + 160.00000 的PID 常数值
    public void pidSendData(byte P_I_D_opt, byte Witch_opt, float val)
    {
        int va;
        byte[] packet = new byte[6];

        //指令封装
        packet[1] = PID_SET;
        //数据封装




        packet[2] = (byte)(P_I_D_opt | Witch_opt);
        if (val >= 0) packet[2] |= PID_FLAG_POS;
        if (val < 0)
        {
            va = (int)(-val * (100000.0f));
        }
        else {
            va = (int)(val * (100000.0f));

        }

        packet[3] = (byte)(va / 254 / 254);
        packet[4] = (byte)(va / 254 % 254);
        packet[5] = (byte)(va % 254);
        ///偶校验封装
        packet[1] |= dataEvenParity(packet);
        //发送指令
        sendPacket(packet);
    }

    // PID 解析 PID 发送 范围 ± 160.00000 -->> ± 16000000
    public void pidSendPrash(byte[] packet)
    {
        //指令封装

        float va;
        byte P_I_D_opt;
        byte Witch_opt;
        byte Witch_pid;
        byte flag;

        P_I_D_opt = (byte)(packet[RECDATA1] & 0x07);  /// P I D ?
        Witch_opt = (byte)(packet[RECDATA1] & 0x10);  /// 内 外  
        flag = (byte)(packet[RECDATA1] & 0x08);       /// 正 负
        Witch_pid = (byte)(packet[RECDATA1] & 0xE0);  /// 四个自由度的PID值


        va = packet[RECDATA4] + packet[RECDATA3] * 254 + packet[RECDATA2] * 254 * 254;
        va = va / 100000.0f;
        if (flag == PID_FLAG_NEG) va = -va;

        Debug.WriteLine("va = " + va.ToString());

        if (Witch_opt == PID_SET_INNER)
        {
            switch (P_I_D_opt)
            {
                case PID_SET_P:
                    switch (Witch_pid) {

                        case PID_SET_ROLL:

                            PID_INNER_ROLL_KP = va;

                            break;
                        case PID_SET_PITCH:

                            PID_INNER_PITCH_KP = va;

                            break;
                        case PID_SET_YAW:

                            PID_INNER_YAW_KP = va;

                            break;
                        case PID_SET_HIGH:

                            PID_INNER_HIGH_KP = va;


                            break;

                    }
                    break;
                case PID_SET_I:
                    switch (Witch_pid)
                    {

                        case PID_SET_ROLL:

                            PID_INNER_ROLL_KI = va;

                            break;
                        case PID_SET_PITCH:

                            PID_INNER_PITCH_KI = va;
                            Debug.WriteLine("PID_INNER_PITCH_KI = " + PID_INNER_PITCH_KI.ToString());

                            break;
                        case PID_SET_YAW:

                            PID_INNER_YAW_KI = va;

                            break;
                        case PID_SET_HIGH:

                            PID_INNER_HIGH_KI = va;


                            break;

                    }
                    break;
                case PID_SET_D:

                    switch (Witch_pid)
                    {

                        case PID_SET_ROLL:

                            PID_INNER_ROLL_KD = va;

                            break;
                        case PID_SET_PITCH:

                            PID_INNER_PITCH_KD = va;

                            break;
                        case PID_SET_YAW:

                            PID_INNER_YAW_KD = va;

                            break;
                        case PID_SET_HIGH:

                            PID_INNER_HIGH_KD = va;


                            break;

                    }


                    break;

                default:
                    break;
            }


        }
        if (Witch_opt == PID_SET_OUTER)
        {
            switch (P_I_D_opt)
            {
                case PID_SET_P:
                    switch (Witch_pid)
                    {

                        case PID_SET_ROLL:

                            PID_OUTER_ROLL_KP = va;

                            break;
                        case PID_SET_PITCH:

                            PID_OUTER_PITCH_KP = va;

                            break;
                        case PID_SET_YAW:

                            PID_OUTER_YAW_KP = va;

                            break;
                        case PID_SET_HIGH:

                            PID_OUTER_HIGH_KP = va;


                            break;

                    }
                    break;
                case PID_SET_I:
                    switch (Witch_pid)
                    {

                        case PID_SET_ROLL:

                            PID_OUTER_ROLL_KI = va;

                            break;
                        case PID_SET_PITCH:

                            PID_OUTER_PITCH_KI = va;

                            break;
                        case PID_SET_YAW:

                            PID_OUTER_YAW_KI = va;

                            break;
                        case PID_SET_HIGH:

                            PID_OUTER_HIGH_KI = va;


                            break;

                    }
                    break;
                case PID_SET_D:

                    switch (Witch_pid)
                    {

                        case PID_SET_ROLL:

                            PID_OUTER_ROLL_KD = va;

                            break;
                        case PID_SET_PITCH:

                            PID_OUTER_PITCH_KD = va;

                            break;
                        case PID_SET_YAW:

                            PID_OUTER_YAW_KD = va;

                            break;
                        case PID_SET_HIGH:

                            PID_OUTER_HIGH_KD = va;


                            break;

                    }


                    break;

                default:
                    break;
            }


        }

        /// PID 设置指令
        // 更新 更新 UI

        viewEvent?.Invoke(PID_SET);

    }


    /// 发送响应 
    public void sendAck(byte ackCmd)
    {
        byte[] packet = new byte[6];

        packet[1] = FLYACK;

        //数据封装
        packet[2] = ackCmd;
        packet[3] = 0x00;
        packet[4] = 0x00;
        packet[5] = 0x00;

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);

    }

    /// 发送响应 
    public void AckPrash(byte[] packet)
    {
        byte ackCmd;
        ackCmd = packet[RECDATA1];

        basicViewEvent?.Invoke(packet[RECDATA2]);
        switch (packet[RECDATA1])
        {

            case FLY_UNLOCK:

                
                
                break;
            case FLY_LOCK:

             


                break;
            case PID_ENABLE:

               


                break;
            case PID_DISABLE:

            


                break;
            case PID_I_CLEAN:

               


                break;
            case GFLY_RECK_DATA:

               


                break;
            case PID_RESET:

              


                break;
            case GFLY_OPEN_LIGHT:

                


                break;
        }



    } 

    /// 发送版本信息 
    public void sendVersionData()
    {
        byte[] packet = new byte[6];
        packet[1] = VERSION;

        //数据封装
        packet[2] = VERSION_BIG;
        packet[3] = VERSION_SMALL;
        packet[4] = OS_SUPPORT;
        packet[5] = 0x00;

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);
        //发送指令
        sendPacket(packet);
    }

    /// 发送版本信息 
    public void versionPrash(byte[] packet)
    {

        byte  versionBig;
        byte  versionSmall;
        byte  osSupport;

        versionBig = packet[2];
        versionSmall = packet[2];
        osSupport = packet[2];

        // ok


    }



    public void sendSetting(byte setting) {

        byte[] packet = new byte[6];
  
        packet[1] = SETTING;
        //数据封装
        packet[2] = setting;

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);
    }



    /// 发送GPS信息
    public void sendGpsData(byte GPS_opt, byte  driection, float gpsData)
    {
        byte[]  packet = new byte[6];
        int va = (int)(gpsData * 100000.0f);

        packet[1] = GPS_opt;
        //数据封装
        packet[2] = (byte)(va / 254 / 254 / 254 % 32);
        if (va >= 0) packet[2] |= GPS_FLAG_POS;
        packet[3] = (byte)(va / 254 / 254 % 254);
        packet[4] = (byte)(va / 254 % 254);
        packet[5] = (byte)(va % 254);

        ///偶校验封装
        packet[1] |= dataEvenParity(packet);

        //发送指令
        sendPacket(packet);

    }

    // 处理指令
    public void cmdPrash(byte[]  recPacket)
    {
        //指令错误校验
        if ((recPacket[0] & 0x0F) != dataEvenParityRec(recPacket))
        {

            string hexString = BitConverter.ToString(recPacket).Replace("-", " ");
            Debug.WriteLine("收到错误包 Packet  HEX :" + hexString);
            

            ErrCount++;
            return;
        }
        RecCount++;

        string shexString = BitConverter.ToString(recPacket).Replace("-", " ");
        Debug.WriteLine("收到正确包 Packet  HEX :" + shexString);

        switch (recPacket[0] & 0xF0)
        {
            case BASEDATA:
                /* code */
                basicDataPrash(recPacket);
                break;
            case THROTTLEDETAIL:
                throttleDataPrash(recPacket);

                /* code */
                break;
            case PRESSDATA:
                pressDataPrash(recPacket);
                /* code */
                break;
            case TEMPERATURE:
                temperatureDataPrash(recPacket);
                /* code */
                break;
            case PID_SET:
                pidSendPrash(recPacket);
                /* code */
                break;
            case FLYACK:
                AckPrash(recPacket);
                /* code */
                break;
            case VERSION:
                versionPrash(recPacket);
                /* code */
                break;
            case HIGHTDEFFULE:
                /* code */
                break;
            case GPS_W:
                /* code */
                break;
            case GPS_J:
                /* code */
                break;
        }



    }



}












