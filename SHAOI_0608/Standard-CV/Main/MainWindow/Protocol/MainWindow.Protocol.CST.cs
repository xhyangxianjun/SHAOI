﻿using BasicClass;
using DealConfigFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public partial class Protocols
    {
        #region keys
        /// <summary>
        /// 卡塞1补偿
        /// </summary>
        const string key_std_cominsert1 = "std11";
        /// <summary>
        /// 卡塞偏差阈值
        /// </summary>
        const string key_std_IntervalThread = "std9";
        const string key_std_cstthread = "std10";
        /// <summary>
        /// 卡塞基准值
        /// </summary>
        const string key_std_CstStdValue = "stdCst";
        /// <summary>
        /// 插栏1 补偿值
        /// </summary>
        const string key_adj_InsertX1 = "adj11";
        #endregion

        /// <summary>
        /// 插栏宽度检测阈值
        /// </summary>
        public static double CSTThread_DevX
        {
            get
            {
                //要有0值保护
                return stdCSTThreadX == 0 ? 5 : stdCSTThreadX;
            }
        }
        public static double CSTThread_HeightDev
        {
            get
            {
                return stdCSTThread_HeightDev == 0 ? 2 : stdCSTThread_HeightDev;
            }
        }
        /// <summary>
        /// 插栏层间距检测阈值
        /// </summary>
        public static double CSTThread_LayerSpacing
        {
            get
            {
                return stdCSTThreadInterval == 0 ? 0.2 : stdCSTThreadInterval;
            }
        }
        /// <summary>
        /// 左右龙骨高度差
        /// </summary>
        public static double CSTThread_KeelHeight
        {
            get
            {
                return stdCSTDeltaHeightThread == 0 ? 1.2 : stdCSTDeltaHeightThread;
            }
        }
        public static double CSTThread_KeelSpacing
        {
            get
            {
                return stdCSTKeelIntervalThread == 0 ? 2 : stdCSTKeelIntervalThread;
            }
        }

        public static Point2D CstStdValue
        {
            get
            {
                return new Point2D(ParStd.Value1(key_std_CstStdValue), ParStd.Value2(key_std_CstStdValue));
            }
            set
            {
                ParStd.SetValue1(key_std_CstStdValue, value.DblValue1);
                ParStd.SetValue2(key_std_CstStdValue, value.DblValue2);
            }
        }

        #region std
        /// <summary>
        /// 卡塞X偏差阈值
        /// </summary>
        static double stdCSTThreadX
        {
            get
            {
                string key = key_std_cstthread;
                return ParStd.Value1(key);
            }
        }
        /// <summary>
        /// 卡塞Z偏差阈值
        /// </summary>
        static double stdCSTThread_HeightDev
        {
            get
            {
                string key = key_std_cstthread;
                return ParStd.Value2(key);
            }
        }
        /// <summary>
        /// 卡塞层间距偏差阈值
        /// </summary>
        static double stdCSTThreadInterval
        {
            get
            {
                string key = key_std_cstthread;
                return ParStd.Value3(key);
            }
        }

        static double stdCSTKeelIntervalThread
        {
            get
            {
                string key = key_std_IntervalThread;
                return ParStd.Value1(key);
            }
        }

        static double stdCSTDeltaHeightThread
        {
            get
            {
                string key = key_std_IntervalThread;
                return ParStd.Value2(key);
            }
        }

        /// <summary>
        /// 调整值-插栏1补偿X
        /// </summary>
        public static double adjInsertComX1
        {
            get
            {
                string key = key_adj_InsertX1;
                return ParAdjust.Value1(key);
            }
        }

        /// <summary>
        /// 基准值-插栏1基准补偿
        /// </summary>
        public static double stdInsertComX1
        {
            get
            {
                string key = key_std_cominsert1;
                return ParStd.Value1(key);
            }
        }
        #endregion
    }
}
