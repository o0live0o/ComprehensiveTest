using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ
{
    public class CaptureUtils
    {
        public bool Capture(string pflsh,string type)
        {
            bool succ = false;
            uint iLastErr = 0;
            Int32 m_lUserID = -1;
            string str;
           
            if (!CHCNetSDK.NET_DVR_Init())
            {
                str = "NET_DVR_Init error!";
                //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
                return false;
            }

            CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(AppHelper.AppSetting.CameraIP,
                                                                  Int16.Parse(AppHelper.AppSetting.CameraPort), AppHelper.AppSetting.CameraUser,
                                                                    AppHelper.AppSetting.CameraPwd, ref DeviceInfo);

            if (m_lUserID < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //登录失败，输出错误号
                                                                           //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"登录摄像头异常[{pflsh}]"+str);
                return false;
            }
            else
            {
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"登录摄像头[{pflsh}]Login Success!");
                //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = "Login Success!", logType = Log.LogType.Error });
            }

            try
            {

                string sJpegPicFileName = $"{AppHelper.CameraFolder}{pflsh}{type}.jpg";
                int lChannel = Int16.Parse("1");

                CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
                lpJpegPara.wPicQuality = 0; //图像质量 Image quality
                lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 2- 4CIF，0xff- Auto(使用当前码流分辨率)，抓图分辨率需要设备支持，更多取值请参考SDK文档

                //JPEG抓图 Capture a JPEG picture
                if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                    // HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"拍照成功[{pflsh}]");
                }
                else
                {
                    succ = true;
                    str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"拍照失败[{pflsh}]:{str}");
                    //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
                }
            }
            catch (Exception ex)
            {
                str = ex.Message;
                Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"拍照失败[{pflsh}]:{str}");
                //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
            }
            finally
            {
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    Live0xUtils.LogUtils.TxtLog.Append(AppHelper.LogFolder + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", $"拍照失败[{pflsh}]:{str}");
                    //HB.Log.LogC.GetInstance().Add(new Log.LogInfo() { log = str, logType = Log.LogType.Error });
                }
            }
            return succ;
        }
    }
}
