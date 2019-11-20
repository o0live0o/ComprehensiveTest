using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class ZYJS
    {
        public ZYJS()
        {
            JCFF = "";
            JCLSH = "";
            VelK1 = "";
            VelK12 = "";
            VelK13 = "";
            VelKAver = "";
            stdVelK = "";
            dsRev = "";
            Oiltemp = "";
            temperature = "";
            pressure = "";
            humidity = "";
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
        /// 获取或设置12312312312213
        /// </summary>
        public string JCLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置第一次值
        /// </summary>
        public string VelK1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置第二次值
        /// </summary>
        public string VelK12
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置第三次值
        /// </summary>
        public string VelK13
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置平均值
        /// </summary>
        public string VelKAver
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置光系数系数标准
        /// </summary>
        public string stdVelK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置怠速转速
        /// </summary>
        public string dsRev
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置油温
        /// </summary>
        public string Oiltemp
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
        /// 获取或设置开始检测时间
        /// </summary>
        public string RunStartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置自由加速（0未检1合格2不合格3不判
        /// </summary>
        public string All_Judge
        {
            get;
            set;
        }

    }

}
