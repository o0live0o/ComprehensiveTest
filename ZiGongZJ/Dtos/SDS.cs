using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class SDS
    {
        public SDS()
        {
            JCFF = "";
            JCLSH = "";
            CO_H = "";
            HC_H = "";
            CO_L = "";
            HC_L = "";
            R_H = "";
            stdCO_H = "";
            stdHC_H = "";
            stdCO_L = "";
            stdHC_L = "";
            R_H_MIN = "";
            R_H_MAX = "";
            CO_H_Judge = "";
            HC_H_Judge = "";
            CO_L_Judge = "";
            HC_L_Judge = "";
            R_H_Judge = "";
            temperature = "";
            pressure = "";
            humidity = "";
            OilTempAver = "";
            rev_L = "";
            rev_H = "";
            RunStartTime = "";
            All_Judge = "";
        }
        /// <summary>
        /// 获取或设置（15双怠速，14自由加速，40底盘测功）
        /// </summary>
        public string JCFF
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测流水号
        /// </summary>
        public string JCLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速CO结果
        /// </summary>
        public string CO_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速HC结果
        /// </summary>
        public string HC_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速CO结果
        /// </summary>
        public string CO_L
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速HC结果
        /// </summary>
        public string HC_L
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数结果
        /// </summary>
        public string R_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速CO标准
        /// </summary>
        public string stdCO_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速HC标准
        /// </summary>
        public string stdHC_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速CO标准
        /// </summary>
        public string stdCO_L
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速HC标准
        /// </summary>
        public string stdHC_L
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数标准
        /// </summary>
        public string R_H_MIN
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数标准
        /// </summary>
        public string R_H_MAX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速CO判定（0未检1合格2不合格3不判）
        /// </summary>
        public string CO_H_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速HC判定（0未检1合格2不合格3不判）
        /// </summary>
        public string HC_H_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速CO判定（0未检1合格2不合格3不判）
        /// </summary>
        public string CO_L_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速HC判定（0未检1合格2不合格3不判）
        /// </summary>
        public string HC_L_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数判定（0未检1合格2不合格3不判）
        /// </summary>
        public string R_H_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置温度
        /// </summary>
        public string temperature
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置大气压
        /// </summary>
        public string pressure
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置湿度
        /// </summary>
        public string humidity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置油温
        /// </summary>
        public string OilTempAver
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速转速
        /// </summary>
        public string rev_L
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高怠速转速
        /// </summary>
        public string rev_H
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置开始检测时间
        /// </summary>
        public string RunStartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置双怠速判定（0未检1合格2不合格3不判）
        /// </summary>
        public string All_Judge
        {
            get;
            set;
        }
    }
}
