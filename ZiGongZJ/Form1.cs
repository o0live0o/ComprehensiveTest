using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Live0xUtils.FormUI;
using ZiGongZJ.Dtos;
using Live0xUtils.DbUtils.SqlServer;
using CI.UIComponents.Helper;
using Live0xUtils.FileUtils;
using System.Reflection;
using System.Collections;
using ZiGongZJ.Extends;
using CCWin;

namespace ZiGongZJ
{
    public partial class Form1 : CCSkinMain
    {
        private StringBuilder m_stringBuilder = new StringBuilder();
        private int[] m_TestArr = new int[] {0,0,0,0,0,0,0,0 };

        public Form1()
        {
            InitializeComponent();
            AutoDocker autoDocker = new AutoDocker();
            autoDocker1.Initialize(this);
           TaskQueue.StartTask();
            this.TopMost = true;
            timer1.Interval = 3 * 1000;
            timer1.Start();
        }

        #region Logic
        //获取列表
        public void ReadCarList()
        {
            // ZJJYXM HPHM ZZL jclsh jyzt jyxm sbkkh ycybh
            string sql = "SELECT TOP 100 YTH_CLLSXXB.ZJJYXM,YTH_CLJCXXB.HPHM,YTH_CLJCXXB.ZZL," +
                "YTH_CLLSXXB.jclsh,YTH_CLLSXXB.jyzt,YTH_CLLSXXB.jyxm,YTH_CLLSXXB.sbkkh,YTH_CLLSXXB.ycybh FROM " +
                "YTH_CLJCXXB INNER JOIN YTH_CLLSXXB " +
                "ON YTH_CLJCXXB.jclsh = YTH_CLLSXXB.jclsh WHERE 1=1 " +
                " AND (YTH_CLLSXXB.jyzt <= 7 or YTH_CLLSXXB.zjzt = 1)" +
                " AND mtcbj = 1 AND   YTH_CLLSXXB.ZJJYXM IS NOT NULL AND YTH_CLLSXXB.ZJJYXM <> '' ";
            if (!string.IsNullOrEmpty(txtSearchHphm.Text.Trim()))
            {
                sql += $" AND YTH_CLJCXXB.HPHM LIKE '%{txtSearchHphm.Text.Trim()}%'";
            }
            sql += " ORDER BY YTH_CLLSXXB.dlrq";
            List<VehilceQueue> vehilceQueues = MssqlHelper.GetInstance().QueryList<VehilceQueue>(sql, null).ToList();
            CGridHelper.FillGrid<VehilceQueue>(dgvVehicle, vehilceQueues);
        }

        //删除文件
        private void DeleteFile(bool deleteStart,bool deleteResult)
        {
            if (deleteStart && File.Exists(AppHelper.AppSetting.ShareFilePath + "DevStart.txt"))
                File.Delete(AppHelper.AppSetting.ShareFilePath + "DevStart.txt");
            if (deleteResult && File.Exists(AppHelper.AppSetting.ShareFilePath + "DevResult.txt"))
                File.Delete(AppHelper.AppSetting.ShareFilePath + "DevResult.txt");
        }

        //开始测试
        private void StartTest()
        {
            VehilceQueue vehilceQueue = CGridHelper.GetCurrentData<VehilceQueue>(dgvVehicle);
            if (vehilceQueue != null)
            {
                TaskQueue.ClearQueue();
                TaskQueue.WaitResult = false;
                string sql = $"SELECT * FROM YTH_V_CLLSXXB WHERE JCLSH = @JCLSH ";
                Hashtable paraHashtable = new Hashtable();
                paraHashtable.Add("JCLSH", vehilceQueue.jclsh);
                YTH_V_CLLSXXB cllsxxb = MssqlHelper.GetInstance().Query<YTH_V_CLLSXXB>(sql, paraHashtable);
                TaskQueue.JCLSH = vehilceQueue.jclsh;
                if (cllsxxb.zjjyxm.ToLower().Contains("hw"))
                {
                    SelectMethodForm selectForm = new SelectMethodForm();
                    GlobalVar.IsShowForm = true;
                    selectForm.ShowDialog(this);
                    GlobalVar.IsShowForm = false;
                    if (selectForm.DialogResult == DialogResult.OK )
                    {
                        
                        string jyxm = selectForm.GetMethod();
                        if ("15".Equals(jyxm))
                        {
                            GlobalVar.IsShowForm = true;
                            AlterStandardForm alterStandardForm = new AlterStandardForm();
                            alterStandardForm.ShowDialog(this);
                            GlobalVar.IsShowForm = false;
                        }
                        if(!string.IsNullOrEmpty(jyxm))
                            TaskQueue.AddTask(CreateTxt(cllsxxb, jyxm));
                    }
                }

                if (cllsxxb.zjjyxm.ToLower().Contains("nj") || cllsxxb.zjjyxm.ToLower().Contains("yh") || cllsxxb.zjjyxm.ToLower().Contains("s1"))
                    TaskQueue.AddTask(CreateTxt(cllsxxb, "40", cllsxxb.zjjyxm.ToLower().Contains("nj"), cllsxxb.zjjyxm.ToLower().Contains("yh"), cllsxxb.zjjyxm.ToLower().Contains("s1")));
            }
        }

        //创建开始测试文本
        private string CreateTxt(YTH_V_CLLSXXB cllsxxb,string jcff, bool testDLX = false,bool testYH = false,bool testSD = false)
        {
            m_stringBuilder.Clear();
            m_stringBuilder.Append("[FILE_STATUS]");
            m_stringBuilder.Append("\r\nSTATUS=0");             // 文件写完后把状态改为1，为1是说明文件写完毕
            m_stringBuilder.Append("\r\n[VEHICLEINFO]");
            m_stringBuilder.Append($"\r\nJCLSH={cllsxxb.jclsh}"); //检测流水号
            m_stringBuilder.Append($"\r\nCLHM={cllsxxb.hphm}");          // 车辆号码
            m_stringBuilder.Append($"\r\nCLZL=" + (cllsxxb.cllx.ToUpper().Contains("K") ? "客车" : "货车"));             // 车辆种类（轿车、客车、货车、三轮汽车或低速货车）
            m_stringBuilder.Append("\r\nDJRQ=" + cllsxxb.ccdjrq.ToCustomerDate("yyyy-MM-dd"));        // 初次登记日期
            m_stringBuilder.Append($"\r\nZKRS=" + (cllsxxb.zkrs.ToInt() == 0 ? 5 : cllsxxb.zkrs.ToInt()));                 // 载客员数
            m_stringBuilder.Append($"\r\nRYZL=" + getRLZL(cllsxxb.rlzl));           // 燃油种类（汽油、柴油、天然气、甲醇或乙醇、液化石油气、   									插电式混合动力）
            m_stringBuilder.Append($"\r\nEDZS=" + (cllsxxb.edzs.ToInt() <= 1000 ? "5000" : cllsxxb.edzs));            //额定转速
            m_stringBuilder.Append($"\r\nZZL={cllsxxb.zzl}");             //总质量
            m_stringBuilder.Append($"\r\nZBZL={cllsxxb.zbzl}");           // 整备质量
            m_stringBuilder.Append($"\r\nQDZS={getQDZS(cllsxxb.qdxs)}");        //（单轴驱动、双轴驱动）
            m_stringBuilder.Append($"\r\nEDNJ={cllsxxb.EDNJ}");             //额定扭矩
            m_stringBuilder.Append($"\r\nEDNJZS={cllsxxb.EDNJZS}");          //  额定扭矩转速
            if("40".Equals(jcff))
                m_stringBuilder.Append($"\r\nEDGL={cllsxxb.EDGL}");            // 额定功率
            else
                m_stringBuilder.Append($"\r\nEDGL={cllsxxb.gl}");
            m_stringBuilder.Append($"\r\nJQFS={cllsxxb.jqfs}");              // 进气方式（自然进气、涡轮增压）
            m_stringBuilder.Append($"\r\nLTGGLX={cllsxxb.ltgglx}");             //轮胎规格类型（0子午线  1斜交轮）
            m_stringBuilder.Append($"\r\nQDZKZZL={cllsxxb.qdzkzzl}");        //驱动轴空载质量（kg）
            m_stringBuilder.Append($"\r\nSYXZ={cllsxxb.syxz}"); //使用性质（危险品运输、其他）
            m_stringBuilder.Append($"\r\nJYLB=等级评定");  //检验类别（等级评定、其他）
            m_stringBuilder.Append($"\r\nYCY={cllsxxb.YCY}");  //引车员
            m_stringBuilder.Append($"\r\nCHZHQ=" + (cllsxxb.sychzhq ?? "0"));               //三元催化（无、有）
            m_stringBuilder.Append($"\r\nGYXTXS={cllsxxb.gyxtxs}"); //供油系统形式（化油器、开环电喷、闭环电喷）
            m_stringBuilder.Append($"\r\nJCFF={jcff}");              // 检测方法（15双怠速，14自由加速，40底盘测功,25ASM ,28VMAS , 26lugdown）
            
            if (testDLX)
                m_TestArr[0] = 1;
            else
                m_TestArr[0] = 0;
            if (testYH)
                m_TestArr[6] = 1;
            else
                m_TestArr[6] = 0;
            if (testSD)
                m_TestArr[3] = 1;
            else
                m_TestArr[3] = 0;
            m_stringBuilder.Append($"\r\nJCXM=" + string.Join("", m_TestArr));        //检测项目(测功机的检验项目)（检测项目=40时，需要填写 ，第一位表示动力性测试例如：10000000，第四位表示速度表效验,第7位表示油耗，当JCXM=10010010表示测试动力性,速度表和油耗）
            m_stringBuilder.Append($"\r\nstdCO_L=0.6");              //怠速CO标准                   （不检测可以不填）
            m_stringBuilder.Append($"\r\nstdHC_L=80");              //怠速HC标准                   （不检测可以不填）
            m_stringBuilder.Append($"\r\nstdCO_H=0.3");             //高怠速CO标准                 （不检测可以不填）
            m_stringBuilder.Append($"\r\nstdHC_H=50");             //高怠速HC标准                 （不检测可以不填）
            m_stringBuilder.Append($"\r\nRPM_XZ=200");          // 转速波动范围限值  （不检测可以不填）
            m_stringBuilder.Append($"\r\nR_x={GlobalVar.GLKQXSXX}");               //过量空气系数标准下限          （不检测可以不填）
            m_stringBuilder.Append($"\r\nR_s={GlobalVar.GLKQXSSX}");               //过量空气系数标准上限          （不检测可以不填）
            m_stringBuilder.Append($"\r\nstdK=1.2");              //自由加速标准                  （不检测可以不填）
            m_stringBuilder.Append($"\r\nCO5025=0.50 ");          //ASM 5025CO  （不检测可以不填）
            m_stringBuilder.Append($"\r\nHC5025=90");             //ASM 5025HC  （不检测可以不填）
            m_stringBuilder.Append($"\r\nNO5025=700");            //ASM5025NO （不检测可以不填） 
            m_stringBuilder.Append($"\r\nCO2540=0.40");           //ASM2540CO （不检测可以不填）
            m_stringBuilder.Append($"\r\nHC2540=80");            // ASM2540HC（不检测可以不填） 
            m_stringBuilder.Append($"\r\nNO2540=650");           // ASM2540NO（不检测可以不填）       
            m_stringBuilder.Append($"\r\nVMASCO=8.0");       // VMAS CO 限值（不检测可以不填）
            m_stringBuilder.Append($"\r\nVMASHC=1.6");       // VMAS HC 限值（不检测可以不填）
            m_stringBuilder.Append($"\r\nVMASNO=1.3");       // VMAS NO 限值（不检测可以不填）
            m_stringBuilder.Append($"\r\nLGDNK=1.2");          // LUGDOWN K 限值（不检测可以不填）
            m_stringBuilder.Append($"\r\nLGDNNO=1500");       //  LUGDOWN NO 限值（不检测可以不填）
            m_stringBuilder.Append($"\r\nLGDNHP=0.4");         // 达标功率限值系数  信息中车辆的额定功率必须有（不检测可以不填
            m_stringBuilder.Append($"\r\nYH_BZ={cllsxxb.EDYH}");
            m_stringBuilder.Append($"\r\nYH_SD={cllsxxb.YHSDD}"); 
            return m_stringBuilder.ToString();
        }
        #endregion

        #region ClickEvents
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReadCarList();
        }

        private void tsbSetting_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            GlobalVar.IsShowForm = true;
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
            GlobalVar.IsShowForm = false;
            this.TopMost = true;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            StartTest();
        }
        #endregion

        #region TypeChange
        private string getQDZS(string s)
        {
            string qdzs = "1";
            if ("1".Equals(s))
            {
                qdzs = "1";
            }
            else if ("2".Equals(s))
            {
                qdzs = "1";
            }
            else if ("3".Equals(s))
            {
                qdzs = "1";
            }
            else if ("4".Equals(s))
            {
                qdzs = "2";
            }
            else if ("5".Equals(s))
            {
                qdzs = "2";
            }
            else if ("6".Equals(s))
            {
                qdzs = "1";
            }
            else if ("7".Equals(s))
            {
                qdzs = "1";
            }
            else if ("8".Equals(s))
            {
                qdzs = "2";
            }
            else if ("9".Equals(s))
            {
                qdzs = "2";
            }
            else if ("10".Equals(s))
            {
                qdzs = "2";
            }
            else if ("11".Equals(s))
            {
                qdzs = "1";
            }
            else if ("12".Equals(s))
            {
                qdzs = "1";
            }
            else if ("13".Equals(s))
            {
                qdzs = "2";
            }
            else if ("14".Equals(s))
            {
                qdzs = "2";
            }
            else if ("15".Equals(s))
            {
                qdzs = "2";
            }
            else if ("16".Equals(s))
            {
                qdzs = "2";
            }
            else if ("17".Equals(s))
            {
                qdzs = "2";
            }
            else if ("18".Equals(s))
            {
                qdzs = "2";
            }

            if ("1".Equals(qdzs))
            {
                return "单轴驱动";
            }
            else
            {
                return "双轴驱动";
            }

            return qdzs;
        }

        private string getRLZL(string s)
        {
            string rlzl = "汽油";
            if (s.Contains("A"))
            {
                rlzl = "汽油";
            }
            else if (s.Contains("B"))
            {
                rlzl = "柴油";
            }
            else
            {
                rlzl = "天然气";
            }
            return rlzl;
        }
        #endregion

        private void FillEntityByIni<T>(T t)
        {
            PropertyInfo[] propertyInfos = t.GetType().GetProperties();
            foreach (PropertyInfo info in propertyInfos)
            {
                info.SetValue(t, IniHelper.ReadIni("RESULT", info.Name, AppHelper.AppSetting.ShareFilePath + "DevResult.txt"), null);
            }
            DeleteFile(false,true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "关闭程序");
            TaskQueue.IsStartTask = false;
            TaskQueue.WaitResult = false;
            TaskQueue.m_ew.Set();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.ShowInTaskbar = true;  //显示在系统任务栏
                    this.WindowState = FormWindowState.Normal;  //还原窗体
                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width /2, 0);

                    this.notifyIcon1.Visible = false;  //托盘图标隐藏
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//最小化      
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X,0);
        }

        private void Form1_SysBottomClick(object sender, CCWin.SkinControl.SysButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", AppHelper.LogFolder) ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!GlobalVar.IsShowForm)
                this.TopMost = true;
        }

        private void dgvVehicle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StartTest();
        }
    }
}
