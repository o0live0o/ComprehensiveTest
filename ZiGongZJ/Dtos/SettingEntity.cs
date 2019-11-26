using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class SettingEntity
    {
        public string ShareFilePath { get; set; }
        public string DataBase { get; set; }
        public string DataBaseServer { get; set; }
        public string DataBaseUser { get; set; }
        public string DataBasePwd { get; set; }
        public string CameraIP { get; set; }
        public string CameraUser { get; set; }
        public string CameraPort { get; set; }
        public string CameraPwd { get; set; }

        public string WebService { get; set; }
    }
}
