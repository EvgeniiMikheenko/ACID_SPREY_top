using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Modbus.Device;
using ZedGraph;
namespace ACID_SPRAY_top
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Form_Update = new BackgroundWorker();
            Form_Update.WorkerSupportsCancellation = true;
            Form_Update.WorkerReportsProgress = true;
            Form_Update.DoWork += Form_Update_DoWork;
            Form_Update.ProgressChanged += Form_Update_ProgressChanged;

            Form_Update.RunWorkerAsync();
            



            is_connected = false;
            stateForm = WorkState.Idle;
            // Dev = new Device();



            m_mbMaster = ModbusSerialMaster.CreateRtu(COM);
            m_mbMaster.Transport.ReadTimeout = 100;
            m_mbMaster.Transport.Retries = 3;
            m_mbMaster.Transport.SlaveBusyUsesRetryCount = true;
            m_mbMaster.Transport.WaitToRetryMilliseconds = 100;

            m_bgwModbusUpdater = new BackgroundWorker();

            m_bgwModbusUpdater.WorkerSupportsCancellation = true;
            m_bgwModbusUpdater.WorkerReportsProgress = true;
            m_bgwModbusUpdater.DoWork += M_bgwModbusUpdater_DoWork;
            m_bgwModbusUpdater.ProgressChanged += M_bgwModbusUpdater_ProgressChanged;

            m_bgwModbusUpdater.RunWorkerAsync();

            Regs = new common.devices.ACID_Stend.Registers();

            myPane = zedGraphControl1.GraphPane;
            myPane2 = DropGraph.GraphPane;
            myPane3 = IR_graph.GraphPane;
            ColorSelect.SelectedItem = "White";
            ScalSelect.SelectedItem = "2%";
            LEDTrack.Value = 0;
            LEDLabel.Text = LEDTrack.Value.ToString();
            OE_check.Checked = true;

            IRTrack.Value = 0;
            IR_val_lbl.Text = IRTrack.Value.ToString();


            PUMPTrack.Value = 0;
            PUMPLabel.Text = PUMPTrack.Value.ToString();

            Heater_flag = false;



            TBList.Add(PUMPTrack);


            TBList.Add(IRTrack);


            TBList.Add(LEDTrack);




            CBList.Add(ColorSelect);


            CBList.Add(ScalSelect);


            BtnList.Add(set_min_btn);


            BtnList.Add(set_red_max_btn);


            BtnList.Add(set_green_max);

            BtnList.Add(set_blue_max);

            BtnList.Add(set_white_max);


            ZGList.Add(zedGraphControl1);


            ZGList.Add(DropGraph);


            ZGList.Add(IR_graph);


            CHList.Add(Heater);
            CHList.Add(OE_check);



            EnableControl(false);
        }
      //  List<object> ObjList = new List<object>();
        List<Button> BtnList = new List<Button>();
        List<TrackBar> TBList = new List<TrackBar>();
        List<ComboBox> CBList = new List<ComboBox>();
        List<CheckBox> CHList = new List<CheckBox>();
        List<ZedGraphControl> ZGList = new List<ZedGraphControl>();
        GraphPane myPane;
        GraphPane myPane2;
        GraphPane myPane3;
        PointPairList RED = new PointPairList();
        PointPairList GREEN = new PointPairList();
        PointPairList BLUE = new PointPairList();
        PointPairList WHITE = new PointPairList();
        PointPairList Drop = new PointPairList();
        PointPairList IR = new PointPairList();
        private void M_bgwModbusUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        public int sleeptime = 100;
        private void M_bgwModbusUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            {
                while (true)
                {
                    if (m_bgwModbusUpdater.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    switch (stateRegs)
                    {
                        case WorkState.Idle:
                            break;
                        case WorkState.Update:
                            ModbusUpdate();
                            m_bgwModbusUpdater.ReportProgress(1);


                            // this.Text = (string.IsNullOrEmpty(m_lastError)) ? "Form1" : ("Form1... Error: " + m_state);

                            break;
                        default:
                            break;
                    }

                    Thread.Sleep(sleeptime);
                }
            }
        }

        object m_syncObject = new object();
        public enum State
        {
            Read,
            Write,
            New,
            Set
        }
        public State state { get; set; }
        ushort[] rdBuf;
        ushort[] txBuf;
        byte slaveaddr = 0x01;
        ushort read_start_addr = 0x00;
        ushort read_regs_number = 64;
        static public uint error_cntF;
        ushort Heater_bit = (1 << 14);
        private bool ModbusUpdate()
        {
            try
            {
                lock (m_syncObject)
                {
                    switch (state)
                    {
                        case State.Read:
                            try
                            {
                                rdBuf = m_mbMaster.ReadHoldingRegisters(slaveaddr, read_start_addr, read_regs_number);
                                Regs = BufToStruct<common.devices.ACID_Stend.Registers, ushort>(rdBuf);
                                state = State.New;
                            }
                            catch
                            {
                                m_lastError = "Ошибка чтения";
                                error_cntF++;
                                return false;
                            }
                            break;
                        case State.Write:
                            try
                            {
                                Regs.ColorSens_Flags = ColorSensFlags;
                                Regs.White_LVL = LED_val;
                                Regs.Pump_LVL = PUMP_val;
                                Regs.IR_LVL = IR_val;
                                ushort aa;
                                if (Heater_flag)
                                    aa = 1;
                                else
                                    aa = 0;
                                Regs.write_reg = (ushort)((Regs.write_reg & ~(Heater_bit))|( aa * Heater_bit ));

                                txBuf = StructToBuff<ushort, common.devices.ACID_Stend.Registers>(Regs);
                                m_mbMaster.WriteMultipleRegisters(slaveaddr, read_start_addr, txBuf);
                                state = State.Set;
                            }
                            catch(Exception ex)
                            {
                                m_lastError = "Ошибка записи";
                                error_cntF++;
                                return false;
                            }
                            break;
                        case State.New:
                            break;
                        case State.Set:
                            state = State.Read;
                            break;
                    }


                }
                
                return true;
            }
            catch (Exception ex)
            {
                m_lastError = ex.Message;
                return false;
            }
        }
        public WorkState stateRegs { get; set; }
        public static IModbusMaster m_mbMaster;
        readonly BackgroundWorker m_bgwModbusUpdater;
        public common.devices.ACID_Stend.Registers Regs;
        public bool Csisopen { get; set; }
        public static bool is_connected { get; set; }
        public static bool is_open { get; set; } = false;
        private  WorkState stateForm = new WorkState();
      //  Device Dev;

        public enum WorkState
        {
            Idle,
            Update
        }

        readonly BackgroundWorker Form_Update;

        private void Regs_Update_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Regs_Update_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
        }




        private void Form_Update_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }
        common.devices.ACID_Stend.Registers FormData;
        int tick = 0;
        private void Form_Update_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                switch(stateForm)
                {
                    case WorkState.Idle:
                        EnableControl(false);
                        break;
                    case WorkState.Update:
                        EnableControl(true);
                        if (state == State.New)
                        {
                            tick++;
                            RED.Add(tick,   Regs.Red_freq);
                            BLUE.Add(tick,  Regs.Blue_freq);
                            GREEN.Add(tick, Regs.Green_freq);
                            WHITE.Add(tick, Regs.White_freq);
                            Drop.Add(tick, Regs.Drop_ADC);
                            IR.Add(tick, Regs.Ir_ADC);
                            myPane.CurveList.Clear();
                            myPane2.CurveList.Clear();
                            myPane3.CurveList.Clear();
                            LineItem Curve = myPane.AddCurve("RED", RED, Color.Red, SymbolType.None);
                            LineItem Curve1 = myPane.AddCurve("BLUE", BLUE, Color.Blue, SymbolType.None);
                            LineItem Curve2 = myPane.AddCurve("GREEN", GREEN, Color.Green, SymbolType.None);
                            LineItem Curve3 = myPane.AddCurve("WHITE", WHITE, Color.Black, SymbolType.None);

                            LineItem Curve4 = myPane2.AddCurve("DropADC", Drop, Color.Black, SymbolType.None);





                            LineItem IR_line = myPane3.AddCurve("IR", IR, Color.Black, SymbolType.None);

                            
                            

                            zedGraphControl1.AxisChange();
                            DropGraph.AxisChange();
                            IR_graph.AxisChange();
                            // Обновляем график
                            zedGraphControl1.Invalidate();
                            DropGraph.Invalidate();
                            IR_graph.Invalidate();
                            DropVal.Invoke((MethodInvoker)delegate
                            {
                                DropVal.Text = Regs.Drop_ADC.ToString();
                            });
                            //DropVal.Text = Regs.Drop_ADC.ToString();

                            TempVal.Invoke((MethodInvoker)delegate
                                {
                                    TempVal.Text = Regs.Temperature.ToString();
                                });
                           // TempVal.Text = Regs.Temperature.ToString();

                            scale_color();

                            state = State.Read;
                        }
                        break;


                }
            }

            //throw new NotImplementedException();
        }
        private void FormDataUpdate(common.devices.ACID_Stend.Registers Data)
        {

            //upd_regs

        }
        private void FormUpdate(common.devices.ACID_Stend.Registers Regs)
        {
            //upd_form
        }
        private bool CheckNewData(common.devices.ACID_Stend.Registers Form, common.devices.ACID_Stend.Registers Device)
        {
            ushort[] Buf_new = StructToBuff<ushort, common.devices.ACID_Stend.Registers>(Form);
            ushort[] Buf_dev = StructToBuff<ushort, common.devices.ACID_Stend.Registers>(Device);
            for(int i = 0; i < Buf_new.Length; i++)
            {
                if (Buf_new[i] != Buf_dev[i])
                    return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectMenu_Click(object sender, EventArgs e)
        {
            string[] av_port = System.IO.Ports.SerialPort.GetPortNames();
            ConnectMenu.DropDownItems.Clear();

            ConnectMenu.DropDownItems.Add("Отключить");
            ConnectMenu.DropDownItems.Add("Настройка");
            foreach (string port in av_port)
                ConnectMenu.DropDownItems.Add(port);
        }



        public void COM_set(int br, int db, int par, int sb, Int32 ad)
        {

            switch (br)
            {
                case 0:
                    COM.BaudRate = 9600;
                    break;
                case 1:
                    COM.BaudRate = 115200;
                    break;
            }

            switch (par)
            {
                case 0:
                    COM.Parity = System.IO.Ports.Parity.None;
                    break;
                case 1:
                    COM.Parity = System.IO.Ports.Parity.Even;
                    break;
                case 2:
                    COM.Parity = System.IO.Ports.Parity.Odd;
                    break;
            }

            switch (sb)
            {
                case 0:
                    COM.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case 1:
                    COM.StopBits = System.IO.Ports.StopBits.One;
                    break;

            }


            //m_slaveAddr = (byte)ad;

            COM.DataBits = db + 7;
            //COM.Parity = par;
            //COM.StopBits = sb;


        }
        string m_lastError;
        private void ConnectMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string item = e.ClickedItem.ToString(); //ToolStripItemClickedEventArgs.ClickedItem;
            if (item == "Отключить" && COM.IsOpen)
            {
                COM.Close();
                is_connected = false;
                stateForm = WorkState.Idle;
               // Connectbtn.Enabled = false;
                stateRegs = WorkState.Idle;
                
                //return;
            }
            else if (item == "Настройка")
            {
                if (!is_open)
                {
                    if (COM.IsOpen)
                        COM.Close();

                    stateRegs = WorkState.Idle;
                    stateForm = WorkState.Idle;



                    Form Cs = new ACID_SPRAY_top.COM_settings();

                    Cs.Show();
                    is_open = true;
                    Csisopen = true;

                    
                }



            }
            else
            {

                if (COM.IsOpen)
                    COM.Close();

                COM.PortName = item;
                try
                {
                    COM.Open();

                    is_connected = true;

                    stateForm = WorkState.Update;
                    stateRegs = WorkState.Update;
                }
                catch (Exception ex)
                {
                    m_lastError = ex.Message;
                }


            }
        }

        public void EnableControl(bool act)
        {


            try
            {
                foreach (Button btn in BtnList)
                {
                    btn.Invoke((MethodInvoker)delegate
                    {
                        btn.Enabled = act;
                    });
                }

                foreach (ZedGraphControl graph in ZGList)
                {
                    graph.Invoke((MethodInvoker)delegate
                    {
                        graph.Enabled = act;
                    });
                }

                foreach (TrackBar trc in TBList)
                {
                    trc.Invoke((MethodInvoker)delegate
                    {
                        trc.Enabled = act;
                    });
                }
                foreach(ComboBox cmb in CBList)
                {
                    cmb.Invoke((MethodInvoker)delegate
                        {
                            cmb.Enabled = act;
                        });
                }

                foreach(CheckBox check in CHList)
                {
                    check.Invoke((MethodInvoker)delegate
                    {
                        check.Enabled = act;
                    });
                }


            }
            catch(Exception ex)
            {
                m_lastError = ex.ToString();
            }

                //PUMPTrack.Enabled = act;
                //IRTrack.Enabled = act;
                //LEDTrack.Enabled = act;
                //OE_check.Enabled = act;
                //ColorSelect.Enabled = act;
                //ScalSelect.Enabled = act;
                //set_min_btn.Enabled = act;
                //set_red_max_btn.Enabled = act;
                //set_green_max.Enabled = act;
                //set_blue_max.Enabled = act;
                //set_white_max.Enabled = act;
                //zedGraphControl1.Enabled = act;
                //DropGraph.Enabled = act;
                //IR_graph.Enabled = act;

            //else
            //{
            //    PUMPTrack.Enabled = act;
            //    IRTrack.Enabled = act;
            //    LEDTrack.Enabled = act;
            //    OE_check.Enabled = act;
            //    ColorSelect.Enabled = act;
            //    ScalSelect.Enabled = act;
            //    set_min_btn.Enabled = act;
            //    set_red_max_btn.Enabled = act;
            //    set_green_max.Enabled = act;
            //    set_blue_max.Enabled = act;
            //    set_white_max.Enabled = act;
            //    zedGraphControl1.Enabled = act;
            //    DropGraph.Enabled = act;
            //    IR_graph.Enabled = act;
            //}


        }

        public static Tret BufToStruct<Tret, Tparams>(Tparams[] buf) where Tret : struct
        {
            GCHandle handle = GCHandle.Alloc(buf, GCHandleType.Pinned);		// Выделить память

            IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(buf, 0);	// и взять адрес
            Tret ret = (Tret)Marshal.PtrToStructure(ptr, typeof(Tret));		// создать структуру
            handle.Free();													// Освобождить дескриптор

            return ret;
        }

        public static Tret[] StructToBuff<Tret, Tparams>(Tparams value) where Tparams : struct
        {
            Tret tmp = default(Tret);
            Tret[] buf = new Tret[Marshal.SizeOf(value) / Marshal.SizeOf(tmp)];

            GCHandle handle = GCHandle.Alloc(buf, GCHandleType.Pinned);		// Выделить память
            IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(buf, 0);	// и взять адрес
            Marshal.StructureToPtr(value, ptr, true);						// копировать в массив
            handle.Free();													// Освобождить дескриптор

            return buf;

        }
        ushort ColorSensFlags;
        private void ColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorSensFlags = 0;
            if (ColorSelect.SelectedIndex == 0)
                ColorSensFlags = 1 << 3;
            else if (ColorSelect.SelectedIndex == 1)
                ColorSensFlags = 1 << 0;
            else if (ColorSelect.SelectedIndex == 2)
                ColorSensFlags = 1 << 1;
            else if (ColorSelect.SelectedIndex == 3)
                ColorSensFlags = 1 << 2;
            else if (ColorSelect.SelectedIndex == 4)
                ColorSensFlags = 1 << 13;

            if (ScalSelect.SelectedIndex == 0)
                ColorSensFlags += 1 << 10;
            else if (ScalSelect.SelectedIndex == 1)
                ColorSensFlags += 1 << 9;
            else if (ScalSelect.SelectedIndex == 2)
                ColorSensFlags += 1 << 8;
            else if (ScalSelect.SelectedIndex == 3)
                ColorSensFlags += 1 << 11;



            if (OE_check.Checked)
                ColorSensFlags += 1 << 12;


            Regs.ColorSens_Flags = ColorSensFlags;
            state = State.Write;

        }
        ushort LED_val;
        ushort IR_val;
        ushort PUMP_val;
        bool Heater_flag;
        private void LEDTrack_Scroll(object sender, EventArgs e)
        {
            if (sender == LEDTrack)
            {
                LEDLabel.Text = LEDTrack.Value.ToString();
                LED_val = (ushort)LEDTrack.Value;
            }
            else if (sender == IRTrack)
            {
                IR_val_lbl.Text = IRTrack.Value.ToString();
                IR_val = (ushort)IRTrack.Value;
            }
            else if (sender == PUMPTrack)
            {
                PUMPLabel.Text = PUMPTrack.Value.ToString();
                PUMP_val = (ushort)(-0.85 * PUMPTrack.Value + 85);
            }
            else if (sender == Heater)
            {
                if (Heater.Checked)
                {
                    Heater.Text = "Нагрев вкл";
                    Heater_flag = true;
                }
                else
                {
                    Heater.Text = "Нагрев выкл";
                    Heater_flag = false;
                }
            }
            state = State.Write;

        }
        public ushort Red_LVL_min;
        public ushort Green_LVL_min;
        public ushort Blue_LVL_min;
        public ushort White_LVL_min;

        public ushort Red_LVL_max;
        public ushort Green_LVL_max;
        public ushort Blue_LVL_max;
        public ushort White_LVL_max;
        ushort scale_flag = 0;
        private void set_min_btn_Click(object sender, EventArgs e)
        {
            if (tick == 0)
                return;

            red_min_lbl.Text = Regs.Red_freq.ToString();
            blue_min_lbl.Text = Regs.Blue_freq.ToString();
            green_min_lbl.Text = Regs.Green_freq.ToString();
            white_min_lbl.Text = Regs.White_freq.ToString();
            Red_LVL_min = Regs.Red_freq;
            Green_LVL_min = Regs.Green_freq;
            Blue_LVL_min = Regs.Blue_freq;
            White_LVL_min = Regs.White_freq;

            scale_flag |= 1 << 0;


        }

        private void set_red_max_btn_Click(object sender, EventArgs e)
        {
            red_max_lbl.Text = Regs.Red_freq.ToString();
            Red_LVL_max = Regs.Red_freq;

            scale_flag |= 1 << 1;
        }

        private void set_green_max_Click(object sender, EventArgs e)
        {
            green_max_lbl.Text = Regs.Green_freq.ToString();
            Green_LVL_max = Regs.Green_freq;

            scale_flag |= 1 << 2;
        }

        private void set_blue_max_Click(object sender, EventArgs e)
        {
            blue_max_lbl.Text = Regs.Blue_freq.ToString();
            Blue_LVL_max = Regs.Blue_freq;

            scale_flag |= 1 << 3;
        }

        private void set_white_max_Click(object sender, EventArgs e)
        {
            white_max_lbl.Text = Regs.White_freq.ToString();
            White_LVL_max = Regs.White_freq;

            scale_flag |= 1 << 4;
        }

        private void scale_color()
        {
            if ( scale_flag != 31 )
                return;
            else
            {
                try
                {
                    float rrr = ((float)(Regs.Red_freq - Red_LVL_min) / (float)(Red_LVL_max - Red_LVL_min) * 255);
                    float ttt = ((float)(Regs.Green_freq - Green_LVL_min) / (float)(Green_LVL_max - Green_LVL_min) * 255);
                    float yyy = ((float)(Regs.Blue_freq - Blue_LVL_min) / (float)(Blue_LVL_max - Blue_LVL_min) * 255);

                    red_scaled_lbl.Invoke((MethodInvoker)delegate
                    {
                        red_scaled_lbl.Text = rrr.ToString();
                    });
                    // red_scaled_lbl.Text =1.ToString();

                    green_scaled_lbl.Invoke((MethodInvoker)delegate
                    {
                        green_scaled_lbl.Text = ttt.ToString();
                    });
                    //*green_scaled_lbl.Text = 2.ToString();

                    blue_scaled_lbl.Invoke((MethodInvoker)delegate
                    {
                        blue_scaled_lbl.Text = yyy.ToString();
                    });
                    
                    //blue_scaled_lbl.Text = 3.ToString();
                }
                catch(Exception ex)
                {
                    red_scaled_lbl.Text = ex.ToString();
                }
            }
        }

       
    }
}
