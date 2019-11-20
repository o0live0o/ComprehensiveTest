using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ZiGongZJ.Dtos;

namespace ZiGongZJ
{
    public class AppHelper
    {
        public static volatile object _lockObj = new object();

        private static AppHelper _appHelper = new AppHelper();

        public static string SettingPath = AppDomain.CurrentDomain.BaseDirectory + @"\SysxConfig\SettingConfig.json";
        public static string ConfigFolder = AppDomain.CurrentDomain.BaseDirectory + @"\SysxConfig\";    //配置文件夹路径
        public static string LogFolder = AppDomain.CurrentDomain.BaseDirectory + (AppDomain.CurrentDomain.BaseDirectory.EndsWith(@"\") ? "" : @"\") + @"TestLog\";
        public static string CameraFolder = AppDomain.CurrentDomain.BaseDirectory + (AppDomain.CurrentDomain.BaseDirectory.EndsWith(@"\") ? "" : @"\") + @"Img\";
        public static SettingEntity AppSetting = null;

        private AppHelper() 
        {
        }

        public static AppHelper GetInstance()
        {
            return _appHelper;
        }

        public void Init()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);
            if (!Directory.Exists(LogFolder))
                Directory.CreateDirectory(LogFolder);
            if (!Directory.Exists(CameraFolder))
                Directory.CreateDirectory(CameraFolder);
            if (!File.Exists(SettingPath))
            {
                File.WriteAllText(SettingPath, JsonConvert.SerializeObject(new SettingEntity()));
            }
            if (!File.Exists(SettingPath))
            {
                throw new Exception("初始化数据失败：" + SettingPath);
            }
            string configStr = File.ReadAllText(SettingPath);

            AppSetting = JsonConvert.DeserializeObject<SettingEntity>(configStr);

            if (AppSetting != null)
            {
                Live0xUtils.DbUtils.SqlServer.MssqlHelper.GetInstance().Init(AppSetting.DataBaseServer, AppSetting.DataBase, AppSetting.DataBaseUser, AppSetting.DataBasePwd);
            }
        }

        
    }
}
