using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
     public class DPCG
    {
        public string JCLSH { get; set; }
        /// <summary>
        /// 开始检测时间
        /// </summary>
        public string RunStartTime { get; set; }
        /// <summary>
        /// 达标功率
        /// </summary>
        public string GK_DBGL { get; set; }
        /// <summary>
        /// 额定车速
        /// </summary>
        public string GK_EDCS { get; set; }
        /// <summary>
        /// 加载力
        /// </summary>
        public string GK_JZL { get; set; }
        /// <summary>
        /// 稳定车速
        /// </summary>
        public string GK_WDCS { get; set; }
        /// <summary>
        /// 温度
        /// </summary>
        public string temperature { get; set; }
        /// <summary>
        /// 大气压
        /// </summary>
        public string pressure { get; set; }
        /// <summary>
        /// 湿度
        /// </summary>
        public string humidity { get; set; }
        /// <summary>
        /// 动力性判定（0未检  1合格  2不合格   3不判  11一级）
        /// </summary>
        public string GK_Judge { get; set; }
        /// <summary>
        /// 速度表效验点
        /// </summary>
        public string _SU_SetSpeed { get; set; }
        /// <summary>
        /// 实测速度
        /// </summary>
        public string _SU_Speed { get; set; }
        /// <summary>
        /// 速度标准下限
        /// </summary>
        public string _SU_std_min { get; set; }
        /// <summary>
        /// 速度标准上限
        /// </summary>
        public string _SU_std_max { get; set; }

        /// <summary>
        /// 速度判定（0未检  1合格  2不合格   3不判）
        /// </summary>
        public string _SU_Judge { get; set; }

        public string YH_SCZ { get; set; }

        public string YH_BZ { get; set; }

        public string YH_SD { get; set; }

        public string YH_JZL { get; set; }

        public string YH_LC { get; set; }

        public string YH_PD { get; set; }
    }
}
