using Live0xUtils.DbUtils.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Dtos
{
    public class YTH_CHECKDATA_ZJ
    {
        public YTH_CHECKDATA_ZJ()
        {
            JCLSH = "";
            WJY = "";
            WJBHGX = "";
            WJHGX = "";
            DPJYY = "";
            DPBHGX = "";
            DPHGX = "";
            DTJYY = "";
            DTBHGX = "";
            DTHGX = "";
            YCY = "";
            JZQDLSCGL = "";
            EDNJGL = "";
            EDNJGLB = "";
            EDNJGLBPD = "";
            JZQDSCGL = "";
            EDGL = "";
            EDGLB = "";
            EDGLBPD = "";
            BGLYH = "";
            BGLYHPD = "";
            FDJWFHGLZ = "";
            FDJWFHGLZPD = "";
            FDJFWHGLBZ = "";
            JZEDDPSCGL = "";
            JZEDDPSCGLBZ = "";
            JZEDDPSCGLBZPD = "";
            GLZDXTSJ = "";
            YZYLZ = "";
            YZZLZ = "";
            YZQHYZDL = "";
            YZQHZZDL = "";
            YZZDL = "";
            YZQCZZDL = "";
            YZQCYZDL = "";
            YZBPHL = "";
            YZZZZL = "";
            YZYZZL = "";
            YZZZZLBZ = "";
            YZYZZLBZ = "";
            YZZDLPD = "";
            YZBPHLPD = "";
            YZZZZLPD = "";
            YZYZZLPD = "";
            YZZDPD = "";
            YZZTCZDL = "";
            YZYTCZDL = "";
            EZYLZ = "";
            EZZLZ = "";
            EZQHYZDL = "";
            EZQHZZDL = "";
            EZZDL = "";
            EZQCZZDL = "";
            EZQCYZDL = "";
            EZBPHL = "";
            EZZZZL = "";
            EZYZZL = "";
            EZZZZLBZ = "";
            EZYZZLBZ = "";
            EZZDLPD = "";
            EZBPHLPD = "";
            EZZZZLPD = "";
            EZYZZLPD = "";
            EZZDPD = "";
            EZZTCZDL = "";
            EZYTCZDL = "";
            SZYLZ = "";
            SZZLZ = "";
            SZQHYZDL = "";
            SZQHZZDL = "";
            SZZDL = "";
            SZQCZZDL = "";
            SZQCYZDL = "";
            SZBPHL = "";
            SZZZZL = "";
            SZYZZL = "";
            SZZZZLBZ = "";
            SZYZZLBZ = "";
            SZZDLPD = "";
            SZBPHLPD = "";
            SZZZZLPD = "";
            SZYZZLPD = "";
            SZZDPD = "";
            SZZTCZDL = "";
            SZYTCZDL = "";
            SIZYLZ = "";
            SIZZLZ = "";
            SIZQHYZDL = "";
            SIZQHZZDL = "";
            SIZZDL = "";
            SIZQCZZDL = "";
            SIZQCYZDL = "";
            SIZBPHL = "";
            SIZZZZL = "";
            SIZYZZL = "";
            SIZZZZLBZ = "";
            SIZYZZLBZ = "";
            SIZZDLPD = "";
            SIZBPHLPD = "";
            SIZZZZLPD = "";
            SIZYZZLPD = "";
            SIZZDPD = "";
            SIZZTCZDL = "";
            SIZYTCZDL = "";
            ZCZZ = "";
            ZCZDLZ = "";
            ZCZDL = "";
            ZCZDPD = "";
            TCZZDLZ = "";
            TCYZDLZ = "";
            TCZDL = "";
            TCZDLPD = "";
            ZDXTSJ = "";
            ZDXTSJPD = "";
            LSZDJL = "";
            LSZDJLPD = "";
            MFDD = "";
            MFDDPD = "";
            LSZDWDX = "";
            LSDLKD = "";
            LSTCZDPD = "";
            LSTCPD = "";
            LSTCSJ = "";
            CHZ = "";
            CHPD = "";
            ZXPZDL = "";
            ZXPZDLPD = "";
            XJXLQZ = "";
            XJXLQY = "";
            XJXLHZ = "";
            XJXLHY = "";
            XJXLQZPD = "";
            XJXLQYPD = "";
            XJXLHZPD = "";
            XJXLHYPD = "";
            XJPD = "";
            TZZYCZQZ = "";
            TZZYCZHZ = "";
            TZZYCZQZPD = "";
            TZZYCZHZPD = "";
            CSZ = "";
            CSBZ = "";
            CSPD = "";
            HXJL = "";
            HXZL = "";
            HXJLPD = "";
            HXZLPD = "";
            FYMFX = "";
            FYMFXPD = "";
            ZWYGQD = "";
            ZWYGQDPD = "";
            YWYGQD = "";
            YWYGQDPD = "";
            ZJDG = "";
            YJDG = "";
            ZJDGZ = "";
            YJDGZ = "";
            ZJDGPD = "";
            YJDGPD = "";
            ZJGSPPYZ = "";
            YJGSPPYZ = "";
            ZJGSPPYPD = "";
            YJGSPPYPD = "";
            ZYDG = "";
            YYDH = "";
            ZYDGZ = "";
            YYDHZ = "";
            ZYDGPD = "";
            YYDHPD = "";
            ZYGSPPYZ = "";
            YYGSPPYZ = "";
            ZYGSPPYPD = "";
            YYGSPPYPD = "";
            ZLFGQDZ = "";
            YLFGQDZ = "";
            DDSCO = "";
            DDSCOPD = "";
            DDSHC = "";
            DDSHCPD = "";
            DDSNO = "";
            DDSNOPD = "";
            DDSCO2 = "";
            DDSCO2PD = "";
            DDSO2 = "";
            DDSO2PD = "";
            GDSCO = "";
            GDSCOPD = "";
            GDSHC = "";
            GDSHCPD = "";
            GDSNO = "";
            GDSNOPD = "";
            GDSCO2 = "";
            GDSCO2PD = "";
            GDSO2 = "";
            GDSO2PD = "";
            GDSKQXS = "";
            GDSKQXSPD = "";
            SDSPD = "";
            ASMCO = "";
            ASMHC = "";
            ASMNO = "";
            ASMCO1 = "";
            ASMHC1 = "";
            ASMNO1 = "";
            GXSXS1 = "";
            GXSXS2 = "";
            GXSXS3 = "";
            GXSXS = "";
            GXSXSPD = "";
            YDZ = "";
            YDZPD = "";
            ASMCOPD = "";
            ASMHCPD = "";
            ASMNOPD = "";
            ASMCO1PD = "";
            ASMHC1PD = "";
            ASMNO1PD = "";
            JYST_CO = "";
            JYST_HC = "";
            JYST_NOX = "";
            JYST_HC_NOX = "";
            JYST_COPD = "";
            JYST_HCPD = "";
            JYST_NOXPD = "";
            JYST_HC_NOXPD = "";
            JYSTPD = "";
            JZJS_100K = "";
            JZJS_90K = "";
            JZJS_80K = "";
            JZJS_ZDGL = "";
            JZJS_100KPD = "";
            JZJS_90KPD = "";
            JZJS_80KPD = "";
            JZJS_ZDGLPD = "";
            JZJSPD = "";
            LBSJ = "";
            LBSJPD = "";
            DJPD = "";
            PJ = "";
            JYJG = "";
            WGJG24 = "";
            WGPJ24 = "";
            WGJG25 = "";
            WGPJ25 = "";
            WGJG26 = "";
            WGPJ26 = "";
            WGJG27 = "";
            WGPJ27 = "";
            WGJG28 = "";
            WGPJ28 = "";
            WGJG29 = "";
            WGPJ29 = "";
            WGJG30 = "";
            WGPJ30 = "";
            WGJG31 = "";
            WGPJ31 = "";
            WGJG32 = "";
            WGPJ32 = "";
            WGJG33 = "";
            WGPJ33 = "";
            WGJG34 = "";
            WGPJ34 = "";
            WGJG35 = "";
            WGPJ35 = "";
            WGJG36 = "";
            WGPJ36 = "";
            WGJG37 = "";
            WGPJ37 = "";
            WGJG38 = "";
            WGPJ38 = "";
            WGJG39 = "";
            WGPJ39 = "";
            WGJG40 = "";
            WGPJ40 = "";
            WGJG41 = "";
            WGPJ41 = "";
            WGJG42 = "";
            WGPJ42 = "";
            WGJG43 = "";
            WGPJ43 = "";
            WGJG44 = "";
            WGPJ44 = "";
            WGJG45 = "";
            WGPJ45 = "";
            WGJG46 = "";
            WGPJ46 = "";
            WGJG47 = "";
            WGPJ47 = "";
            WJPD = "";
            ZGQ = "";
            ZGQPD = "";
            GK_DBGL = "";
            GK_EDCS = "";
            GK_JZL = "";
            GK_WDCS = "";
            GK_Judge = "";
            YH_SCZ = "";
            YH_BZ = "";
            YH_SD = "";
            YH_JZL = "";
            YH_LC = "";
            YH_PD = "";
            temperature = "";
            humidity = "";
            pressure = "";
            CHZ2 = "";
            CHPD2 = "";
            ydz1 = "";
            ydz2 = "";
            ydz3 = "";
            znjdg = "";
            znydg = "";
            wzzlzczdl = "";
            wzylzczdl = "";
            lzzlzczdl = "";
            lzylzczdl = "";
            ynjdg = "";
            ynydg = "";
            YLYGCZPCZ = "";
            YLYGSPPCZ = "";
            YLJGCZPCZ = "";
            YLJGSPPCZ = "";
            ZLYGQDZPD = "";
            ZLYGCZPCZPD = "";
            ZLYGSPPCZPD = "";
            ZLJGCZPCZPD = "";
            ZLJGSPPCZPD = "";
            YLYGQDZPD = "";
            YLYGCZPCZPD = "";
            YLYGSPPCZPD = "";
            YLJGCZPCZPD = "";
            YLJGSPPCZPD = "";
            YZZLDTLH = "";
            YZYLDTLH = "";
            EZZLDTLH = "";
            EZYLDTLH = "";
            SZZLDTLH = "";
            SZYLDTLH = "";
            SIZZLDTLH = "";
            SIZYLDTLH = "";
            CYCPD = "";
            LSZDCSD = "";
            LSZDWDXPD = "";
            QYCPD = "";
            WZZLDTLH = "";
            WZYLDTLH = "";
            LZZLDTLH = "";
            LZYLDTLH = "";
            ZLYGCZPCZ = "";
            ZLYGSPPCZ = "";
            ZLJGCZPCZ = "";
            ZLJGSPPCZ = "";
            AXLE1_DJPD = "";
            AXLE2_DJPD = "";
            AXLE3_DJPD = "";
            AXLE4_DJPD = "";
            wj_pjx = "";
            wj_ybx = "";
            wj_pjx_desc = "";
            wj_ybx_desc = "";
            JYST_COXZ = "";
            JYST_HCXZ = "";
            JYST_NOXZ = "";
            JYST_HCNOXZ = "";
            DDSCO_xz = "";
            GDSCO_xz = "";
            DDSHDC_xz = "";
            GDSHC_xz = "";
            DDSHC_xz = "";
            BTGPFJG1 = "";
            BTGPFJG2 = "";
            BTGPFJG3 = "";
            BTGPFPJZ = "";
            BTGPFXZ = "";
            ZDLBGLXZ = "";
            SCZDLBGL = "";
            LDPFXZ = "";
            PFJG100 = "";
            PFJG90 = "";
            PFJG80 = "";
            ZYDGPY = "";
            ZJDGPY = "";
            YYDGPY = "";
            YJDGPY = "";
        }
        /// <summary>
        /// 获取或设置JCLSH
        /// </summary>
        [KeyField]
        public string JCLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WJY
        /// </summary>
        public string WJY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WJBHGX
        /// </summary>
        public string WJBHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WJHGX
        /// </summary>
        public string WJHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPJYY
        /// </summary>
        public string DPJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPBHGX
        /// </summary>
        public string DPBHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPHGX
        /// </summary>
        public string DPHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DTJYY
        /// </summary>
        public string DTJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DTBHGX
        /// </summary>
        public string DTBHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DTHGX
        /// </summary>
        public string DTHGX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YCY
        /// </summary>
        public string YCY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZQDLSCGL
        /// </summary>
        public string JZQDLSCGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJGL
        /// </summary>
        public string EDNJGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJGLB
        /// </summary>
        public string EDNJGLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJGLBPD
        /// </summary>
        public string EDNJGLBPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZQDSCGL
        /// </summary>
        public string JZQDSCGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDGL
        /// </summary>
        public string EDGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDGLB
        /// </summary>
        public string EDGLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDGLBPD
        /// </summary>
        public string EDGLBPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BGLYH
        /// </summary>
        public string BGLYH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BGLYHPD
        /// </summary>
        public string BGLYHPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJWFHGLZ
        /// </summary>
        public string FDJWFHGLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJWFHGLZPD
        /// </summary>
        public string FDJWFHGLZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJFWHGLBZ
        /// </summary>
        public string FDJFWHGLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZEDDPSCGL
        /// </summary>
        public string JZEDDPSCGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZEDDPSCGLBZ
        /// </summary>
        public string JZEDDPSCGLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZEDDPSCGLBZPD
        /// </summary>
        public string JZEDDPSCGLBZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLZDXTSJ
        /// </summary>
        public string GLZDXTSJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYLZ
        /// </summary>
        public string YZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZLZ
        /// </summary>
        public string YZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZQHYZDL
        /// </summary>
        public string YZQHYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZQHZZDL
        /// </summary>
        public string YZQHZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZDL
        /// </summary>
        public string YZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZQCZZDL
        /// </summary>
        public string YZQCZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZQCYZDL
        /// </summary>
        public string YZQCYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZBPHL
        /// </summary>
        public string YZBPHL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZZZL
        /// </summary>
        public string YZZZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYZZL
        /// </summary>
        public string YZYZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZZZLBZ
        /// </summary>
        public string YZZZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYZZLBZ
        /// </summary>
        public string YZYZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZDLPD
        /// </summary>
        public string YZZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZBPHLPD
        /// </summary>
        public string YZBPHLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZZZLPD
        /// </summary>
        public string YZZZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYZZLPD
        /// </summary>
        public string YZYZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZDPD
        /// </summary>
        public string YZZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZTCZDL
        /// </summary>
        public string YZZTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYTCZDL
        /// </summary>
        public string YZYTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYLZ
        /// </summary>
        public string EZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZLZ
        /// </summary>
        public string EZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZQHYZDL
        /// </summary>
        public string EZQHYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZQHZZDL
        /// </summary>
        public string EZQHZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZDL
        /// </summary>
        public string EZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZQCZZDL
        /// </summary>
        public string EZQCZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZQCYZDL
        /// </summary>
        public string EZQCYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZBPHL
        /// </summary>
        public string EZBPHL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZZZL
        /// </summary>
        public string EZZZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYZZL
        /// </summary>
        public string EZYZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZZZLBZ
        /// </summary>
        public string EZZZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYZZLBZ
        /// </summary>
        public string EZYZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZDLPD
        /// </summary>
        public string EZZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZBPHLPD
        /// </summary>
        public string EZBPHLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZZZLPD
        /// </summary>
        public string EZZZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYZZLPD
        /// </summary>
        public string EZYZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZDPD
        /// </summary>
        public string EZZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZTCZDL
        /// </summary>
        public string EZZTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYTCZDL
        /// </summary>
        public string EZYTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYLZ
        /// </summary>
        public string SZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZLZ
        /// </summary>
        public string SZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZQHYZDL
        /// </summary>
        public string SZQHYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZQHZZDL
        /// </summary>
        public string SZQHZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZDL
        /// </summary>
        public string SZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZQCZZDL
        /// </summary>
        public string SZQCZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZQCYZDL
        /// </summary>
        public string SZQCYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZBPHL
        /// </summary>
        public string SZBPHL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZZZL
        /// </summary>
        public string SZZZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYZZL
        /// </summary>
        public string SZYZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZZZLBZ
        /// </summary>
        public string SZZZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYZZLBZ
        /// </summary>
        public string SZYZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZDLPD
        /// </summary>
        public string SZZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZBPHLPD
        /// </summary>
        public string SZBPHLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZZZLPD
        /// </summary>
        public string SZZZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYZZLPD
        /// </summary>
        public string SZYZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZDPD
        /// </summary>
        public string SZZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZTCZDL
        /// </summary>
        public string SZZTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYTCZDL
        /// </summary>
        public string SZYTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYLZ
        /// </summary>
        public string SIZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZLZ
        /// </summary>
        public string SIZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZQHYZDL
        /// </summary>
        public string SIZQHYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZQHZZDL
        /// </summary>
        public string SIZQHZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZDL
        /// </summary>
        public string SIZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZQCZZDL
        /// </summary>
        public string SIZQCZZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZQCYZDL
        /// </summary>
        public string SIZQCYZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZBPHL
        /// </summary>
        public string SIZBPHL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZZZL
        /// </summary>
        public string SIZZZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYZZL
        /// </summary>
        public string SIZYZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZZZLBZ
        /// </summary>
        public string SIZZZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYZZLBZ
        /// </summary>
        public string SIZYZZLBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZDLPD
        /// </summary>
        public string SIZZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZBPHLPD
        /// </summary>
        public string SIZBPHLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZZZLPD
        /// </summary>
        public string SIZZZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYZZLPD
        /// </summary>
        public string SIZYZZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZDPD
        /// </summary>
        public string SIZZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZTCZDL
        /// </summary>
        public string SIZZTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYTCZDL
        /// </summary>
        public string SIZYTCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCZZ
        /// </summary>
        public string ZCZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCZDLZ
        /// </summary>
        public string ZCZDLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCZDL
        /// </summary>
        public string ZCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCZDPD
        /// </summary>
        public string ZCZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TCZZDLZ
        /// </summary>
        public string TCZZDLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TCYZDLZ
        /// </summary>
        public string TCYZDLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TCZDL
        /// </summary>
        public string TCZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TCZDLPD
        /// </summary>
        public string TCZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDXTSJ
        /// </summary>
        public string ZDXTSJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDXTSJPD
        /// </summary>
        public string ZDXTSJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSZDJL
        /// </summary>
        public string LSZDJL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSZDJLPD
        /// </summary>
        public string LSZDJLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MFDD
        /// </summary>
        public string MFDD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MFDDPD
        /// </summary>
        public string MFDDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSZDWDX
        /// </summary>
        public string LSZDWDX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSDLKD
        /// </summary>
        public string LSDLKD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSTCZDPD
        /// </summary>
        public string LSTCZDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSTCPD
        /// </summary>
        public string LSTCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSTCSJ
        /// </summary>
        public string LSTCSJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHZ
        /// </summary>
        public string CHZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHPD
        /// </summary>
        public string CHPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXPZDL
        /// </summary>
        public string ZXPZDL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXPZDLPD
        /// </summary>
        public string ZXPZDLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLQZ
        /// </summary>
        public string XJXLQZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLQY
        /// </summary>
        public string XJXLQY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLHZ
        /// </summary>
        public string XJXLHZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLHY
        /// </summary>
        public string XJXLHY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLQZPD
        /// </summary>
        public string XJXLQZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLQYPD
        /// </summary>
        public string XJXLQYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLHZPD
        /// </summary>
        public string XJXLHZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXLHYPD
        /// </summary>
        public string XJXLHYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJPD
        /// </summary>
        public string XJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TZZYCZQZ
        /// </summary>
        public string TZZYCZQZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TZZYCZHZ
        /// </summary>
        public string TZZYCZHZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TZZYCZQZPD
        /// </summary>
        public string TZZYCZQZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TZZYCZHZPD
        /// </summary>
        public string TZZYCZHZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSZ
        /// </summary>
        public string CSZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSBZ
        /// </summary>
        public string CSBZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSPD
        /// </summary>
        public string CSPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXJL
        /// </summary>
        public string HXJL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXZL
        /// </summary>
        public string HXZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXJLPD
        /// </summary>
        public string HXJLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXZLPD
        /// </summary>
        public string HXZLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FYMFX
        /// </summary>
        public string FYMFX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FYMFXPD
        /// </summary>
        public string FYMFXPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZWYGQD
        /// </summary>
        public string ZWYGQD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZWYGQDPD
        /// </summary>
        public string ZWYGQDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YWYGQD
        /// </summary>
        public string YWYGQD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YWYGQDPD
        /// </summary>
        public string YWYGQDPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJDG
        /// </summary>
        public string ZJDG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJDG
        /// </summary>
        public string YJDG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJDGZ
        /// </summary>
        public string ZJDGZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJDGZ
        /// </summary>
        public string YJDGZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJDGPD
        /// </summary>
        public string ZJDGPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJDGPD
        /// </summary>
        public string YJDGPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJGSPPYZ
        /// </summary>
        public string ZJGSPPYZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJGSPPYZ
        /// </summary>
        public string YJGSPPYZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJGSPPYPD
        /// </summary>
        public string ZJGSPPYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJGSPPYPD
        /// </summary>
        public string YJGSPPYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYDG
        /// </summary>
        public string ZYDG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYDH
        /// </summary>
        public string YYDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYDGZ
        /// </summary>
        public string ZYDGZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYDHZ
        /// </summary>
        public string YYDHZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYDGPD
        /// </summary>
        public string ZYDGPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYDHPD
        /// </summary>
        public string YYDHPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYGSPPYZ
        /// </summary>
        public string ZYGSPPYZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYGSPPYZ
        /// </summary>
        public string YYGSPPYZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYGSPPYPD
        /// </summary>
        public string ZYGSPPYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYGSPPYPD
        /// </summary>
        public string YYGSPPYPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLFGQDZ
        /// </summary>
        public string ZLFGQDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLFGQDZ
        /// </summary>
        public string YLFGQDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSCO
        /// </summary>
        public string DDSCO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSCOPD
        /// </summary>
        public string DDSCOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSHC
        /// </summary>
        public string DDSHC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSHCPD
        /// </summary>
        public string DDSHCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSNO
        /// </summary>
        public string DDSNO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSNOPD
        /// </summary>
        public string DDSNOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSCO2
        /// </summary>
        public string DDSCO2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSCO2PD
        /// </summary>
        public string DDSCO2PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSO2
        /// </summary>
        public string DDSO2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSO2PD
        /// </summary>
        public string DDSO2PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSCO
        /// </summary>
        public string GDSCO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSCOPD
        /// </summary>
        public string GDSCOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSHC
        /// </summary>
        public string GDSHC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSHCPD
        /// </summary>
        public string GDSHCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSNO
        /// </summary>
        public string GDSNO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSNOPD
        /// </summary>
        public string GDSNOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSCO2
        /// </summary>
        public string GDSCO2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSCO2PD
        /// </summary>
        public string GDSCO2PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSO2
        /// </summary>
        public string GDSO2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSO2PD
        /// </summary>
        public string GDSO2PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSKQXS
        /// </summary>
        public string GDSKQXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSKQXSPD
        /// </summary>
        public string GDSKQXSPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SDSPD
        /// </summary>
        public string SDSPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMCO
        /// </summary>
        public string ASMCO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMHC
        /// </summary>
        public string ASMHC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMNO
        /// </summary>
        public string ASMNO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMCO1
        /// </summary>
        public string ASMCO1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMHC1
        /// </summary>
        public string ASMHC1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMNO1
        /// </summary>
        public string ASMNO1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GXSXS1
        /// </summary>
        public string GXSXS1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GXSXS2
        /// </summary>
        public string GXSXS2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GXSXS3
        /// </summary>
        public string GXSXS3
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GXSXS
        /// </summary>
        public string GXSXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GXSXSPD
        /// </summary>
        public string GXSXSPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YDZ
        /// </summary>
        public string YDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YDZPD
        /// </summary>
        public string YDZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMCOPD
        /// </summary>
        public string ASMCOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMHCPD
        /// </summary>
        public string ASMHCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMNOPD
        /// </summary>
        public string ASMNOPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMCO1PD
        /// </summary>
        public string ASMCO1PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMHC1PD
        /// </summary>
        public string ASMHC1PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ASMNO1PD
        /// </summary>
        public string ASMNO1PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_CO
        /// </summary>
        public string JYST_CO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HC
        /// </summary>
        public string JYST_HC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_NOX
        /// </summary>
        public string JYST_NOX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HC_NOX
        /// </summary>
        public string JYST_HC_NOX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_COPD
        /// </summary>
        public string JYST_COPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HCPD
        /// </summary>
        public string JYST_HCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_NOXPD
        /// </summary>
        public string JYST_NOXPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HC_NOXPD
        /// </summary>
        public string JYST_HC_NOXPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYSTPD
        /// </summary>
        public string JYSTPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_100K
        /// </summary>
        public string JZJS_100K
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_90K
        /// </summary>
        public string JZJS_90K
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_80K
        /// </summary>
        public string JZJS_80K
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_ZDGL
        /// </summary>
        public string JZJS_ZDGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_100KPD
        /// </summary>
        public string JZJS_100KPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_90KPD
        /// </summary>
        public string JZJS_90KPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_80KPD
        /// </summary>
        public string JZJS_80KPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJS_ZDGLPD
        /// </summary>
        public string JZJS_ZDGLPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZJSPD
        /// </summary>
        public string JZJSPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LBSJ
        /// </summary>
        public string LBSJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LBSJPD
        /// </summary>
        public string LBSJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DJPD
        /// </summary>
        public string DJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PJ
        /// </summary>
        public string PJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYJG
        /// </summary>
        public string JYJG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG24
        /// </summary>
        public string WGJG24
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ24
        /// </summary>
        public string WGPJ24
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG25
        /// </summary>
        public string WGJG25
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ25
        /// </summary>
        public string WGPJ25
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG26
        /// </summary>
        public string WGJG26
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ26
        /// </summary>
        public string WGPJ26
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG27
        /// </summary>
        public string WGJG27
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ27
        /// </summary>
        public string WGPJ27
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG28
        /// </summary>
        public string WGJG28
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ28
        /// </summary>
        public string WGPJ28
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG29
        /// </summary>
        public string WGJG29
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ29
        /// </summary>
        public string WGPJ29
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG30
        /// </summary>
        public string WGJG30
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ30
        /// </summary>
        public string WGPJ30
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG31
        /// </summary>
        public string WGJG31
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ31
        /// </summary>
        public string WGPJ31
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG32
        /// </summary>
        public string WGJG32
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ32
        /// </summary>
        public string WGPJ32
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG33
        /// </summary>
        public string WGJG33
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ33
        /// </summary>
        public string WGPJ33
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG34
        /// </summary>
        public string WGJG34
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ34
        /// </summary>
        public string WGPJ34
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG35
        /// </summary>
        public string WGJG35
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ35
        /// </summary>
        public string WGPJ35
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG36
        /// </summary>
        public string WGJG36
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ36
        /// </summary>
        public string WGPJ36
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG37
        /// </summary>
        public string WGJG37
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ37
        /// </summary>
        public string WGPJ37
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG38
        /// </summary>
        public string WGJG38
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ38
        /// </summary>
        public string WGPJ38
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG39
        /// </summary>
        public string WGJG39
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ39
        /// </summary>
        public string WGPJ39
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG40
        /// </summary>
        public string WGJG40
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ40
        /// </summary>
        public string WGPJ40
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG41
        /// </summary>
        public string WGJG41
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ41
        /// </summary>
        public string WGPJ41
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG42
        /// </summary>
        public string WGJG42
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ42
        /// </summary>
        public string WGPJ42
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG43
        /// </summary>
        public string WGJG43
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ43
        /// </summary>
        public string WGPJ43
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG44
        /// </summary>
        public string WGJG44
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ44
        /// </summary>
        public string WGPJ44
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG45
        /// </summary>
        public string WGJG45
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ45
        /// </summary>
        public string WGPJ45
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG46
        /// </summary>
        public string WGJG46
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ46
        /// </summary>
        public string WGPJ46
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJG47
        /// </summary>
        public string WGJG47
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGPJ47
        /// </summary>
        public string WGPJ47
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WJPD
        /// </summary>
        public string WJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZGQ
        /// </summary>
        public string ZGQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZGQPD
        /// </summary>
        public string ZGQPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GK_DBGL
        /// </summary>
        public string GK_DBGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GK_EDCS
        /// </summary>
        public string GK_EDCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GK_JZL
        /// </summary>
        public string GK_JZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GK_WDCS
        /// </summary>
        public string GK_WDCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GK_Judge
        /// </summary>
        public string GK_Judge
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_SCZ
        /// </summary>
        public string YH_SCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_BZ
        /// </summary>
        public string YH_BZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_SD
        /// </summary>
        public string YH_SD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_JZL
        /// </summary>
        public string YH_JZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_LC
        /// </summary>
        public string YH_LC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YH_PD
        /// </summary>
        public string YH_PD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置temperature
        /// </summary>
        public string temperature
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置humidity
        /// </summary>
        public string humidity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置pressure
        /// </summary>
        public string pressure
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHZ2
        /// </summary>
        public string CHZ2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHPD2
        /// </summary>
        public string CHPD2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ydz1
        /// </summary>
        public string ydz1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ydz2
        /// </summary>
        public string ydz2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ydz3
        /// </summary>
        public string ydz3
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置znjdg
        /// </summary>
        public string znjdg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置znydg
        /// </summary>
        public string znydg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wzzlzczdl
        /// </summary>
        public string wzzlzczdl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wzylzczdl
        /// </summary>
        public string wzylzczdl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置lzzlzczdl
        /// </summary>
        public string lzzlzczdl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置lzylzczdl
        /// </summary>
        public string lzylzczdl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ynjdg
        /// </summary>
        public string ynjdg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ynydg
        /// </summary>
        public string ynydg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLYGCZPCZ
        /// </summary>
        public string YLYGCZPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLYGSPPCZ
        /// </summary>
        public string YLYGSPPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLJGCZPCZ
        /// </summary>
        public string YLJGCZPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLJGSPPCZ
        /// </summary>
        public string YLJGSPPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLYGQDZPD
        /// </summary>
        public string ZLYGQDZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLYGCZPCZPD
        /// </summary>
        public string ZLYGCZPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLYGSPPCZPD
        /// </summary>
        public string ZLYGSPPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLJGCZPCZPD
        /// </summary>
        public string ZLJGCZPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLJGSPPCZPD
        /// </summary>
        public string ZLJGSPPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLYGQDZPD
        /// </summary>
        public string YLYGQDZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLYGCZPCZPD
        /// </summary>
        public string YLYGCZPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLYGSPPCZPD
        /// </summary>
        public string YLYGSPPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLJGCZPCZPD
        /// </summary>
        public string YLJGCZPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YLJGSPPCZPD
        /// </summary>
        public string YLJGSPPCZPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZLDTLH
        /// </summary>
        public string YZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYLDTLH
        /// </summary>
        public string YZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZLDTLH
        /// </summary>
        public string EZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYLDTLH
        /// </summary>
        public string EZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZLDTLH
        /// </summary>
        public string SZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYLDTLH
        /// </summary>
        public string SZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZLDTLH
        /// </summary>
        public string SIZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYLDTLH
        /// </summary>
        public string SIZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CYCPD
        /// </summary>
        public string CYCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSZDCSD
        /// </summary>
        public string LSZDCSD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSZDWDXPD
        /// </summary>
        public string LSZDWDXPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QYCPD
        /// </summary>
        public string QYCPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZZLDTLH
        /// </summary>
        public string WZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZYLDTLH
        /// </summary>
        public string WZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZZLDTLH
        /// </summary>
        public string LZZLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZYLDTLH
        /// </summary>
        public string LZYLDTLH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLYGCZPCZ
        /// </summary>
        public string ZLYGCZPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLYGSPPCZ
        /// </summary>
        public string ZLYGSPPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLJGCZPCZ
        /// </summary>
        public string ZLJGCZPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZLJGSPPCZ
        /// </summary>
        public string ZLJGSPPCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AXLE1_DJPD
        /// </summary>
        public string AXLE1_DJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AXLE2_DJPD
        /// </summary>
        public string AXLE2_DJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AXLE3_DJPD
        /// </summary>
        public string AXLE3_DJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AXLE4_DJPD
        /// </summary>
        public string AXLE4_DJPD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wj_pjx
        /// </summary>
        public string wj_pjx
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wj_ybx
        /// </summary>
        public string wj_ybx
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wj_pjx_desc
        /// </summary>
        public string wj_pjx_desc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置wj_ybx_desc
        /// </summary>
        public string wj_ybx_desc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_COXZ
        /// </summary>
        public string JYST_COXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HCXZ
        /// </summary>
        public string JYST_HCXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_NOXZ
        /// </summary>
        public string JYST_NOXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYST_HCNOXZ
        /// </summary>
        public string JYST_HCNOXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSCO_xz
        /// </summary>
        public string DDSCO_xz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSCO_xz
        /// </summary>
        public string GDSCO_xz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSHDC_xz
        /// </summary>
        public string DDSHDC_xz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GDSHC_xz
        /// </summary>
        public string GDSHC_xz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDSHC_xz
        /// </summary>
        public string DDSHC_xz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGPFJG1
        /// </summary>
        public string BTGPFJG1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGPFJG2
        /// </summary>
        public string BTGPFJG2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGPFJG3
        /// </summary>
        public string BTGPFJG3
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGPFPJZ
        /// </summary>
        public string BTGPFPJZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGPFXZ
        /// </summary>
        public string BTGPFXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDLBGLXZ
        /// </summary>
        public string ZDLBGLXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SCZDLBGL
        /// </summary>
        public string SCZDLBGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LDPFXZ
        /// </summary>
        public string LDPFXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PFJG100
        /// </summary>
        public string PFJG100
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PFJG90
        /// </summary>
        public string PFJG90
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PFJG80
        /// </summary>
        public string PFJG80
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYDGPY
        /// </summary>
        public string ZYDGPY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJDGPY
        /// </summary>
        public string ZJDGPY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYDGPY
        /// </summary>
        public string YYDGPY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YJDGPY
        /// </summary>
        public string YJDGPY
        {
            get;
            set;
        }
    }
}
