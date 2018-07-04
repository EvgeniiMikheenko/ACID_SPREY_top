using System;
using System.Runtime.InteropServices;

namespace common.devices.ACID_Stend
{
    [StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Unicode)]
    public struct Registers
    {
        public ushort write_reg;     // time, drop/color, heater, save, reset time
        public DateTimeRegisters_t DT;
        public ushort Led_Pump_Flags;
        public ushort Pump_LVL;
        public ushort Red_LVL;
        public ushort Green_LVL;
        public ushort Blue_LVL;
        public ushort White_LVL;
        public ushort IR_LVL;
        public ushort ColorSens_Flags;
        public ushort CRC;
        public ushort Red_freq;
        public ushort Green_freq;
        public ushort Blue_freq;
        public ushort White_freq;
        public ushort Ir_ADC;
        public ushort Drop_ADC;
        public ushort Temperature;
        public ushort StepMotor;
        public DangerRegisters_t Danger_LVL;
        public DangerTimeRegs_t Time_Set;
        public DangerTimeRegs_t Time_Val;
    }


    public struct DateTimeRegisters_t
    {
        public DateRegisters_t Date;
        public TimeRegisters_t Time;
    }

    public struct DateRegisters_t
    {
        public ushort Year;
        public ushort Month;
        public ushort Day;
    }

    public struct TimeRegisters_t
    {
        public ushort Hours;
        public ushort Minutes;
        public ushort Seconds;
    }

    public struct DangerRegisters_t
    {
        public float Red_DNG;
        public float Green_DNG;
        public float Blue_DNG;
        public float White_DNG;
        public float Ir_DNG;
        public float Drop_DNG;
        public float Temperature;
        public ushort Flags;
    }

    public struct DangerTimeRegs_t
    {
        public float Red_time;
        public float Green_time;
        public float Blue_time;
        public float White_time;
        public float Ir_time;
        public float Drop_time;
    }


    public enum State
    {
          Read,
          Write,
          New,
          Set
    }



}

