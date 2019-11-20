using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class VMAS
    {
        public VMAS()
        {
            JCFF  = "";
            stdHC  = "";
            HC  = "";
            HC_Judge  = "";
            stdCO  = "";
            CO  = "";
            CO_Judge  = "";
            stdNox  = "";
            Nox  = "";
            Nox_Judge  = "";
            HC_Nox  = "";
            HC_Nox_Judge  = "";
            temperature  = "";
            humidity  = "";
            pressure  = "";
            ErrorTimeAdd  = "";
            ErrorTimeCon  = "";
            All_Judge  = "";
            IS_HC_NOX  = "";
            mileage  = "";
            stdHC_Nox = "";
        }

        public string JCFF { get; set; }
        public string stdHC { get; set; }
        public string HC { get; set; }
        public string HC_Judge { get; set; }
        public string stdCO { get; set; }
        public string CO { get; set; }
        public string CO_Judge { get; set; }
        public string stdNox { get; set; }
        public string Nox { get; set; }
        public string Nox_Judge { get; set; }
        public string HC_Nox { get; set; }
        public string HC_Nox_Judge { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string ErrorTimeAdd { get; set; }
        public string ErrorTimeCon { get; set; }
        public string All_Judge { get; set; }
        public string IS_HC_NOX { get; set; }
        public string mileage { get; set; }
        public string stdHC_Nox { get; set; }
    }

    /*
     * WritePrivateProfileString( "RESULT" , "JCFF" , "28" , SysCfg.NetResponseFilePath ) ;
					//HC标准
					str_iGet( strResult , "HCXZ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "stdHC" , strValue , SysCfg.NetResponseFilePath ) ;	              
					//HC结果
					str_iGet( strResult , "HCJG" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "HC" , strValue , SysCfg.NetResponseFilePath ) ;	              
					//HC判定
					str_iGet( strResult , "HC_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "HC_Judge" , strValue , SysCfg.NetResponseFilePath ) ;	          
					//
					str_iGet( strResult , "COXZ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "stdCO" , strValue , SysCfg.NetResponseFilePath ) ;	
					//
					str_iGet( strResult , "COJG" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "CO" , strValue , SysCfg.NetResponseFilePath ) ;	
					//
					str_iGet( strResult , "CO_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "CO_Judge" , strValue , SysCfg.NetResponseFilePath ) ;	
					//
					str_iGet( strResult , "NOXZ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "stdNox" , strValue , SysCfg.NetResponseFilePath ) ;
					//NO
					str_iGet( strResult , "NOJG" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "Nox" , strValue , SysCfg.NetResponseFilePath ) ;	
					//
					str_iGet( strResult , "NO_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "Nox_Judge" , strValue , SysCfg.NetResponseFilePath ) ;	
					//	         HC+NO标准
					//str_iGet( strResult , "HC_NOXZ" , strValue ) ;
					//WritePrivateProfileString( "RESULT" , "stdHC_Nox" , strValue , SysCfg.NetResponseFilePath ) ;  
					//
					//str_iGet( strResult , "HC_NOJG" , strValue ) ;
					//WritePrivateProfileString( "RESULT" , "HC_Nox" , strValue , SysCfg.NetResponseFilePath ) ;	
					//
					//str_iGet( strResult , "HC_NO_PD" , strValue ) ;
					//WritePrivateProfileString( "RESULT" , "HC_Nox_Judge" , strValue , SysCfg.NetResponseFilePath ) ;	
					//	        温度
					str_iGet( strResult , "WD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "temperature" , strValue , SysCfg.NetResponseFilePath ) ;
					//	        湿度
					str_iGet( strResult , "SD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "humidity" , strValue , SysCfg.NetResponseFilePath ) ;
					//	        大气压
					str_iGet( strResult , "DQY" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "pressure" , strValue , SysCfg.NetResponseFilePath ) ;
					//	    累计误差
					str_iGet( strResult , "LJWCSJ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "ErrorTimeAdd" , strValue , SysCfg.NetResponseFilePath ) ;
					//	    连续误差
					str_iGet( strResult , "LXWCSJ" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "ErrorTimeCon" , strValue , SysCfg.NetResponseFilePath ) ;
					//	        结果判定
					str_iGet( strResult , "VMAS_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "All_Judge" , strValue , SysCfg.NetResponseFilePath ) ;
					//0代表HC,NOx分开判定 , 1代表HC,NOx合起来判定
					//str_iGet( strResult , "ZYJS_PD" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "IS_HC_NOX" , "0" , SysCfg.NetResponseFilePath ) ;	    
					//行驶里程
					str_iGet( strResult , "LJXXLC" , strValue ) ;
					WritePrivateProfileString( "RESULT" , "mileage" , strValue , SysCfg.NetResponseFilePath ) ;	   
     * 
     */
}
