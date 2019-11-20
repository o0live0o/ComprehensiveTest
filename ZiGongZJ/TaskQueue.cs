using Live0xUtils.DbUtils.SqlServer;
using Live0xUtils.FileUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZiGongZJ.Dtos;
using ZiGongZJ.Extends;

namespace ZiGongZJ
{
    public abstract class TaskQueue
    {
        private static Queue<string> m_taskQueue = new Queue<string>();

        private readonly static object m_lock = new object();

        private static Thread m_thread = null;

        public static EventWaitHandle m_ew = new AutoResetEvent(false);

        private static EventWaitHandle m_waitResult = new AutoResetEvent(false);

        private static Hashtable hashtable = new Hashtable();

        public static bool WaitResult = true;

        public static string JCLSH = "";

        public static string YCY = "";

        public static bool IsStartTask = true;

        public static void AddTask(string s)
        {
            lock (m_lock)
                m_taskQueue.Enqueue(s);
            m_ew.Set();
        }

        public static void ClearQueue()
        {
            m_taskQueue.Clear();
            YCY = "";
            JCLSH = "";
        }

        public static void StartTask()
        {
            IsStartTask = true;
            m_thread = new Thread(()=> {
                while (IsStartTask)
                {
                    string taskAim = null;
                    if (m_taskQueue.Count > 0)
                    {
                        lock (m_lock)
                        {
                            if (m_taskQueue.Count > 0)
                            {
                                taskAim = m_taskQueue.Dequeue();
                            }
                        }
                    }
                    if (taskAim != null)
                        WriteFile(taskAim);
                    else
                        m_ew.WaitOne();
                    Thread.Sleep(10);
                }
            });
            m_thread.Start();
        }

        public static void WriteFile(string s)
        {
            try
            {
                DeleteFile(true, true);
                File.WriteAllText($"{AppHelper.AppSetting.ShareFilePath}DevStart.txt", s, Encoding.GetEncoding("GB2312"));
                IniHelper.WriteIni("FILE_STATUS", "STATUS", "1", AppHelper.AppSetting.ShareFilePath + "DevStart.txt");
                WaitResult = true;
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"开始测试[{JCLSH}]……");
                while (WaitResult && !File.Exists(AppHelper.AppSetting.ShareFilePath + "DevResult.txt")
                    && !"1".Equals(IniHelper.ReadIni("FILE_STATUS", "STATUS", AppHelper.AppSetting.ShareFilePath + "DevResult.txt")))
                {
                    Thread.Sleep(50);
                }
                if (File.Exists(AppHelper.AppSetting.ShareFilePath + "DevResult.txt") && "1".Equals(IniHelper.ReadIni("FILE_STATUS", "STATUS", AppHelper.AppSetting.ShareFilePath + "DevResult.txt")))
                    ReadResult();
                else
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"取消读取结果[{JCLSH}]");
            }
            catch (Exception ex)
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd")+".txt",ex.Message);
            }
        }

        private static void ReadResult()
        {
            bool IsSave = false;
            string jcff = IniHelper.ReadIni("RESULT", "JCFF", AppHelper.AppSetting.ShareFilePath + "DevResult.txt");
            Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", string.Join(" ",File.ReadAllLines(AppHelper.AppSetting.ShareFilePath + "DevResult.txt", Encoding.GetEncoding("GB2312"))));
            if ("40".Equals(jcff))
            {
                Task.Factory.StartNew(() => { Capture(JCLSH); });
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"读取测功结果[{JCLSH}]");
                YTH_CHECKDATA_ZJ zj = null;
                DPCG dpcg = new DPCG();
                FillEntityByIni(dpcg);
                zj = new YTH_CHECKDATA_ZJ();

                zj.GK_Judge = dpcg.GK_Judge.ChangePD();
                zj.GK_DBGL = dpcg.GK_DBGL;
                zj.GK_EDCS = dpcg.GK_EDCS;
                zj.GK_JZL = dpcg.GK_JZL;
                zj.GK_WDCS = dpcg.GK_WDCS;

                zj.CSPD = dpcg._SU_Judge.ChangePD();
                zj.CSZ = dpcg._SU_Speed;


                zj.YH_PD = dpcg.YH_PD.ChangePD();
                zj.YH_SCZ = dpcg.YH_SCZ;
                zj.YH_SD = dpcg.YH_SD;
                zj.YH_JZL = dpcg.YH_JZL;
                zj.YH_LC = dpcg.YH_LC;
                zj.JCLSH = JCLSH;
                zj.YH_BZ = dpcg.YH_BZ;
                zj.YCY = YCY;
                hashtable.Clear();
                string[] ignoreField = zj.GetType().GetProperties().Where(p => p.GetValue(zj, null) == null || string.IsNullOrEmpty(p.GetValue(zj, null).ToString())).Select(p => p.Name).ToArray();
                zj.GetType().GetProperties().Where(p => p.GetValue(zj, null) != null && !string.IsNullOrEmpty(p.GetValue(zj, null).ToString())).ToList().ForEach(p => hashtable.Add($"{p.Name}", p.GetValue(zj, null)));
                IsSave = MssqlHelper.GetInstance().InsertOrUpdate(zj, hashtable, new string[] { "JCLSH" }, ignoreField);
            }
            else if ("15".Equals(jcff)) //双怠速
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "读取双怠速结果");
                SDS sds = new SDS();
                FillEntityByIni(sds);
                YTH_CHECKDATA yth = new YTH_CHECKDATA();
                yth.JCFFID = "15";
                yth.GLKQXSXX = GlobalVar.GLKQXSXX;
                yth.GLKQXSSX = GlobalVar.GLKQXSSX;
                yth.GLKQXSJG = sds.R_H;
                yth.GLKQXSPD = sds.R_H_Judge.ChangePD();
                yth.DDSCOXZ = sds.stdCO_L;
                yth.DDSCOJG = sds.CO_L;
                yth.DDSCOPD = sds.CO_L_Judge.ChangePD();
                yth.DDSHCXZ = sds.stdHC_L; ;
                yth.DDSHCJG = sds.HC_L;
                yth.DDSHCPD = sds.HC_L_Judge.ChangePD();
                yth.DDSZS = sds.rev_L;
                yth.GDSZS = sds.rev_H;
                yth.GDSCOXZ = sds.stdCO_H;
                yth.GDSCOJG = sds.CO_H_Judge.ChangePD();
                yth.GDSCOPD = sds.CO_H_Judge;
                yth.GDSHCXZ = sds.stdHC_H;
                yth.GDSHCJG = sds.HC_H;
                yth.GDSHCPD = sds.HC_H_Judge.ChangePD();
                yth.IGHJWD = sds.OilTempAver;
                yth.IGHJSD = sds.humidity;
                yth.IGHJDQY = sds.pressure;
                yth.JCZT = sds.All_Judge.ChangePD();
                yth.YCY = YCY;
                yth.JCLSH = JCLSH;
                yth.KSJCSJ = sds.RunStartTime;
                yth.JSJCSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                hashtable.Clear();
                string[] ignoreField = yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) == null || string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).Select(p => p.Name).ToArray();
                yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) != null && !string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).ToList().ForEach(p => hashtable.Add($"{p.Name}", p.GetValue(yth, null)));
                IsSave = MssqlHelper.GetInstance().InsertOrUpdate(yth, hashtable, new string[] { "JCLSH" }, ignoreField);
                GlobalVar.GLKQXSSX = "1.05";
                GlobalVar.GLKQXSXX = "0.95";
            }
            else if ("14".Equals(jcff)) //不透光
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "读取不透光结果");
                ZYJS zyjs = new ZYJS();
                FillEntityByIni(zyjs);
                YTH_CHECKDATA yth = new YTH_CHECKDATA();
                yth.JCLSH = JCLSH;
                yth.YCY = YCY;
                yth.JCFFID = "14";
                yth.BTGPFXZ = zyjs.stdVelK;
                yth.BTGPFJG1 = zyjs.VelK1;
                yth.BTGPFJG2 = zyjs.VelK12;
                yth.BTGPFJG3 = zyjs.VelK13;
                yth.BTGPFPJZ = zyjs.VelKAver;
                yth.BTGDSZS = zyjs.dsRev;
                yth.IGHJWD = zyjs.temperature;
                yth.IGHJSD = zyjs.humidity;
                yth.IGHJDQY = zyjs.pressure;
                yth.JCZT = zyjs.All_Judge.ChangePD();
                yth.YCY = YCY;
                yth.JCLSH = JCLSH;
                yth.KSJCSJ = zyjs.RunStartTime;
                yth.JSJCSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                hashtable.Clear();
                string[] ignoreField = yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) == null || string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).Select(p => p.Name).ToArray();
                yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) != null && !string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).ToList().ForEach(p => hashtable.Add($"{p.Name}", p.GetValue(yth, null)));
                IsSave = MssqlHelper.GetInstance().InsertOrUpdate(yth, hashtable, new string[] { "JCLSH" }, ignoreField);
            }
            else if ("28".Equals(jcff)) //VMAS
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "读取VMAS");
                VMAS vmas = new VMAS();
                FillEntityByIni(vmas);
                YTH_CHECKDATA yth = new YTH_CHECKDATA();
                yth.JCFFID = "28";
                if ("0".Equals(vmas.IS_HC_NOX))
                {
                    yth.HCPFXZ = vmas.stdHC;
                    yth.HCPFJG = vmas.HC;
                    yth.HCPFPD = vmas.HC_Judge.ChangePD();
                    yth.NOXPFXZ = vmas.stdNox;
                    yth.NOXPFJG = vmas.Nox;
                    yth.NOXPFPD = vmas.Nox_Judge.ChangePD();
                }
                else
                {
                    yth.HCPFJG = vmas.HC;
                    yth.HCPFPD = vmas.HC_Judge.ChangePD();
                    yth.NOXPFJG = vmas.Nox;
                    yth.NOXPFPD = vmas.Nox_Judge.ChangePD();

                    yth.HC_NOXXZ = vmas.stdHC_Nox;
                    yth.HC_NOXJG = vmas.HC_Nox;
                    yth.HC_NOXPD = vmas.HC_Nox_Judge.ChangePD();
                }
                yth.JUDGETYPE = vmas.IS_HC_NOX;

                yth.COPFXZ = vmas.stdCO;
                yth.COPFJG = vmas.CO;
                yth.COPFPD = vmas.CO_Judge.ChangePD();

                yth.IGHJWD = vmas.temperature;
                yth.IGHJSD = vmas.humidity;
                yth.IGHJDQY = vmas.pressure;
                yth.JCZT = vmas.All_Judge.ChangePD();
                yth.YCY = YCY;
                yth.JCLSH = JCLSH;
                yth.KSJCSJ = DateTime.Now.AddMinutes(-3).ToString("yyyy-MM-dd HH:mm:ss");
                yth.JSJCSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                hashtable.Clear();
                string[] ignoreField = yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) == null || string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).Select(p => p.Name).ToArray();
                yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) != null && !string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).ToList().ForEach(p => hashtable.Add($"{p.Name}", p.GetValue(yth, null)));
                IsSave = MssqlHelper.GetInstance().InsertOrUpdate(yth, hashtable, new string[] { "JCLSH" }, ignoreField);

            }
            else if ("13".Equals(jcff)) //LD
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "读取LD");
                LD ld = new LD();
                FillEntityByIni(ld);
                YTH_CHECKDATA yth = new YTH_CHECKDATA();
                yth.JCFFID = "13";
                yth.ZDLBGLXZ = ld.stdMaxHP;
                yth.SCZDLBGL = ld.MaxHP;
                //yth.FDJEDZSSX = ld.MaxHP;
                //yth.FDJEDZSXX = ld.MaxHP;
                yth.SCFDJEDZS = ld.DSZS;
                yth.LDPFXZ = ld.stdVelK;
                yth.PFJG100 = ld.VelK100;
                yth.PFJG80 = ld.VelK80;
                yth.PFJG90 = ld.NO80;
                
                yth.LDHJWD = ld.temperature;
                yth.LDHJSD = ld.humidity;
                yth.LDHJDQY = ld.pressure;
                
                yth.JCZT = ld.All_Judge.ChangePD();
                yth.YCY = YCY;
                yth.JCLSH = JCLSH;
                yth.KSJCSJ = DateTime.Now.AddMinutes(-3).ToString("yyyy-MM-dd HH:mm:ss");
                yth.JSJCSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                hashtable.Clear();
                string[] ignoreField = yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) == null || string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).Select(p => p.Name).ToArray();
                yth.GetType().GetProperties().Where(p => p.GetValue(yth, null) != null && !string.IsNullOrEmpty(p.GetValue(yth, null).ToString())).ToList().ForEach(p => hashtable.Add($"{p.Name}", p.GetValue(yth, null)));
                IsSave = MssqlHelper.GetInstance().InsertOrUpdate(yth, hashtable, new string[] { "JCLSH" }, ignoreField);

            }
            Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", "保存结果" + IsSave);
        }

        public static void Capture(string jclsh)
        {
            try
            {
                image_path img = new image_path();
                CaptureUtils captureUtils = new CaptureUtils();
                bool succ = captureUtils.Capture(jclsh, "103");
                if (succ && File.Exists($"{AppHelper.CameraFolder}{jclsh}103.jpg"))
                {
                    Hashtable imgHashtable = new Hashtable();

                    img.jclsh = jclsh+"103";
                    img.test_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    img.fimage = ImgHelper.GetImgToBase64($"{AppHelper.CameraFolder}{jclsh}103.jpg");
                    string[] ignoreField = img.GetType().GetProperties().Where(p => p.GetValue(img, null) == null || string.IsNullOrEmpty(p.GetValue(img, null).ToString())).Select(p => p.Name).ToArray();
                    img.GetType().GetProperties().Where(p => p.GetValue(img, null) != null && !string.IsNullOrEmpty(p.GetValue(img, null).ToString())).ToList().ForEach(p => imgHashtable.Add($"{p.Name}", p.GetValue(img, null)));
                    succ = MssqlHelper.GetInstance().InsertOrUpdate(img, imgHashtable, new string[] { "jclsh" }, ignoreField);
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"保存图片{jclsh}" + succ);
                    imgHashtable.Clear();
                }
                else
                {
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"没有找到图片{jclsh}");
                }
            }
            catch (Exception ex)
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"保存图片异常{jclsh}:" + ex.Message);
            }
        }

        private static void DeleteFile(bool deleteStart, bool deleteResult)
        {
            try
            {
                if (deleteStart && File.Exists(AppHelper.AppSetting.ShareFilePath + "DevStart.txt"))
                    File.Delete(AppHelper.AppSetting.ShareFilePath + "DevStart.txt");
                if (deleteResult && File.Exists(AppHelper.AppSetting.ShareFilePath + "DevResult.txt"))
                    File.Delete(AppHelper.AppSetting.ShareFilePath + "DevResult.txt");
            }
            catch (Exception ex)
            {
                File.WriteAllText("删除文件异常",ex.Message);
            }
        }

        private static  void FillEntityByIni<T>(T t)
        {
            PropertyInfo[] propertyInfos = t.GetType().GetProperties();
            foreach (PropertyInfo info in propertyInfos)
            {
                info.SetValue(t, IniHelper.ReadIni("RESULT", info.Name, AppHelper.AppSetting.ShareFilePath + "DevResult.txt"), null);
            }
            DeleteFile(false, true);
        }
    }
}
