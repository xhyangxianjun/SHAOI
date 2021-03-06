﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Threading.Tasks;
using DealPLC;
using Common;
using DealRobot;
using System.IO;
using DealFile;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using DealComprehensive;
using SetPar;
using ParComprehensive;
using BasicClass;
using DealConfigFile;
using Main_EX;

namespace Main
{
    /// <summary>
    /// PLC的相关定义和实现都在WinInitMain类里面 20181219-zx
    /// </summary>
    partial class MainWindow
    {
        #region PLC触发响应
        /// <summary>
        /// 报警
        /// </summary>
        /// <param name="trrigerSource_e"></param>
        /// <param name="i"></param>
        protected override void LogicPLC_Inst_PLCAlarm_event(TriggerSource_enum trrigerSource_e, int i)
        {
            try
            {
                ShowState("设备发送报警信息!");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 物料信息
        /// </summary>
        /// <param name="trrigerSource_e"></param>
        /// <param name="i"></param>
        protected override void L_I_PLCMaterial_event(TriggerSource_enum trrigerSource_e, int i)
        {
            try
            {

                //ShowState("设备发送物料信息!");
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 语音信息
        /// </summary>
        /// <param name="trrigerSource_e"></param>
        /// <param name="i"></param>
        protected override void L_I_VoiceState_event(TriggerSource_enum trrigerSource_e, int i)
        {
            try
            {
                ShowVoice(i);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 设备状态
        /// </summary>
        /// <param name="trrigerSource_e"></param>
        /// <param name="intState"></param>
        protected override void LogicPLC_Inst_PLCState_event(TriggerSource_enum trrigerSource_e, int intState)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.L_I.WriteError(NameClass, ex);
            }
        }

        /// <summary>
        /// 机器人状态
        /// </summary>
        /// <param name="trrigerSource_e"></param>
        /// <param name="intState"></param>
        protected override void LogicPLC_Inst_RobotState_event(TriggerSource_enum trrigerSource_e, int intState)
        {

        }

        /// <summary>
        /// 数据超限
        /// </summary>
        /// <param name="str"></param>
        protected override void L_I_WriteDataOverFlow(string str)
        {
            ShowAlarm("PLC输出数据超出范围");

            LogicPLC.L_I.PCAlarm();
        }
        #endregion PLC触发响应

        #region PLC换型相关
        /// <summary>
        /// 换型的时候写入PLC的值
        /// </summary>
        public override void WritePLCModelPar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.L_I.WriteError(NameClass, ex);
            }
        }

        #endregion PLC换型相关
    }
}
