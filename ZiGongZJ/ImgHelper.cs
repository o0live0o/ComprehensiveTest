using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZiGongZJ
{
    public abstract class ImgHelper
    {
        public static string GetImgToBase64(string filePath)
        {
            string base64Str = "";
            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
                br.Close();
                br.Dispose();
                fs.Close();
                fs.Dispose();
                base64Str = Convert.ToBase64String(imgBytesIn);
            }
            return base64Str;
        }
    }
}
