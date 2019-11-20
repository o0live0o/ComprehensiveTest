using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class LD
    {
        public LD()
        {
            JCFF  = "";
            MaxHP  = "";
            stdMaxHP  = "";
            MaxHP_Judge  = "";
            VelK100  = "";
            VelK90  = "";
            VelK80  = "";
            stdVelK  = "";
            VelK_Judge  = "";
            temperature  = "";
            humidity  = "";
            pressure  = "";
            All_Judge  = "";
            VelMaxHP  = "";
            oiltemp  = "";
            DSZS  = "";
            CalcVelMaxHP  = "";
        }

        public string JCFF { get; set; }
        public string MaxHP { get; set; }
        public string stdMaxHP { get; set; }
        public string MaxHP_Judge { get; set; }
        public string VelK100 { get; set; }
        public string VelK90 { get; set; }
        public string VelK80 { get; set; }
        public string stdVelK { get; set; }
        public string VelK_Judge { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string All_Judge { get; set; }
        public string VelMaxHP { get; set; }
        public string oiltemp { get; set; }
        public string DSZS { get; set; }
        public string CalcVelMaxHP { get; set; }

        public string NO80 { get; set; }
        
        public string NO_PD { get; set; }

    }
}
/*
 * 					WritePrivateProfileString( "RESULT" , "JCFF" , "13" , SysCfg.NetResponseFilePath ) ; 

					//最大轮边功率
					str_iGet( strResult , "GLJG" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "MaxHP" , strValue , SysCfg.NetResponseFilePath ) ; 
					//功率限值
					str_iGet( strResult , "GLXZ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "stdMaxHP" , strValue , SysCfg.NetResponseFilePath ) ; 
					//功率判定
					str_iGet( strResult , "GL_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "MaxHP_Judge" , strValue , SysCfg.NetResponseFilePath ) ; 
					//100%点烟度值
					str_iGet( strResult , "GXSXS100" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "VelK100" , strValue , SysCfg.NetResponseFilePath ) ; 
					//90%点烟度值
					str_iGet( strResult , "GXSXS90" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "VelK90" , strValue , SysCfg.NetResponseFilePath ) ; 
					//80%点烟度值
					str_iGet( strResult , "GXSXS80" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "VelK80" , strValue , SysCfg.NetResponseFilePath ) ; 
					//烟度标准
					str_iGet( strResult , "GXSXSXZ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "stdVelK" , strValue , SysCfg.NetResponseFilePath ) ; 
					//烟度判定
					str_iGet( strResult , "GXSXS_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "VelK_Judge" , strValue , SysCfg.NetResponseFilePath ) ; 
					//温度
					str_iGet( strResult , "LDWD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "temperature" , strValue , SysCfg.NetResponseFilePath ) ; 
					//湿度
					str_iGet( strResult , "LDSD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "humidity" , strValue , SysCfg.NetResponseFilePath ) ; 
					//大气压
					str_iGet( strResult , "LDDQY" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "pressure" , strValue , SysCfg.NetResponseFilePath ) ; 
					//结果判定
					str_iGet( strResult , "LD_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "All_Judge" , strValue , SysCfg.NetResponseFilePath ) ; 
					//最大功率下的速度  
					str_iGet( strResult , "SCZDGLXDSD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "VelMaxHP" , strValue , SysCfg.NetResponseFilePath ) ; 
					//油温
					str_iGet( strResult , "LDYW" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "oiltemp" , strValue , SysCfg.NetResponseFilePath ) ; 
					//怠速转速
					str_iGet( strResult , "ZSJG" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "DSZS" , strValue , SysCfg.NetResponseFilePath ) ; 
					//计算最大功率下的速度
					str_iGet( strResult , "JSZDGLXDSD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "CalcVelMaxHP" , strValue , SysCfg.NetResponseFilePath ) ;
 */
