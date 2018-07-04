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


namespace ACID_SPRAY_top 
{
    class Device : Form1
    {
        public Device()
        {
            stateRegs = new WorkState();
            stateRegs = WorkState.Idle;


            //Regs_Update = new BackgroundWorker();
            //Regs_Update.WorkerSupportsCancellation = true;
            //Regs_Update.WorkerReportsProgress = true;
            //Regs_Update.DoWork += Regs_Update_DoWork;
            //Regs_Update.ProgressChanged += Regs_Update_ProgressChanged;


            m_mbMaster = ModbusSerialMaster.CreateRtu(COM);
            m_mbMaster.Transport.ReadTimeout = 100;
            m_mbMaster.Transport.Retries = 3;
            m_mbMaster.Transport.SlaveBusyUsesRetryCount = true;
            m_mbMaster.Transport.WaitToRetryMilliseconds = 100;
            m_bgwModbusUpdater = new BackgroundWorker();

            m_bgwModbusUpdater.WorkerSupportsCancellation = true;
            m_bgwModbusUpdater.WorkerReportsProgress = true;
            m_bgwModbusUpdater.DoWork += M_bgwModbusUpdater_DoWork; ;
            m_bgwModbusUpdater.ProgressChanged += M_bgwModbusUpdater_ProgressChanged; ;

            m_bgwModbusUpdater.RunWorkerAsync();

            Regs = new common.devices.ACID_Stend.Registers();

            
            
            
        }

        public common.devices.ACID_Stend.Registers Regs;

        

        private void M_bgwModbusUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
        public int sleeptimeD = 1000;
        private void M_bgwModbusUpdater_DoWork(object sender, DoWorkEventArgs e)
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

                Thread.Sleep(sleeptimeD);
            }
            //throw new NotImplementedException();
        }
        string m_lastError;
        static public uint error_cnt;
        object m_syncObject = new object();
        ushort[] rdBuf;
        ushort[] txBuf;
        byte slaveaddr = 0x01;
        ushort read_start_addr = 0x00;
        ushort read_regs_number = 69;
        private bool ModbusUpdate()
        {
            try
            {
                lock (m_syncObject)
                {
                    switch(state)
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
                                error_cnt++;
                                return false;
                            }
                            break;
                        case State.Write:
                            try
                            {
                                txBuf = StructToBuff<ushort, common.devices.ACID_Stend.Registers>(Regs);
                                m_mbMaster.WriteMultipleRegisters(slaveaddr, read_start_addr, txBuf);
                                state = State.Set;
                            }
                            catch
                            {
                                m_lastError = "Ошибка записи";
                                error_cnt++;
                                return false;
                            }
                            break;
                        case State.New:
                            break;
                        case State.Set:
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

        public static IModbusMaster m_mbMaster;
        readonly BackgroundWorker m_bgwModbusUpdater;
        private void Regs_Update_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
           
        }

        private void Regs_Update_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
        }
        public enum State
        {
            Read,
            Write,
            New,
            Set
        }
        public WorkState stateRegs { get; set; }
        public State state { get; set; }
        readonly BackgroundWorker Regs_Update;

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


    }


}
