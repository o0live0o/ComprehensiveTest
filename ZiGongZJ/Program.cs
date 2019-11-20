using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ZiGongZJ
{
    static class Program
    {
        public static System.Threading.Mutex Run;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bRun = false;
            Run = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out bRun);
            if (bRun)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppHelper.GetInstance().Init();
                Application.DoEvents();
                Application.Run(new Form1());
            }
        }
    }
}
