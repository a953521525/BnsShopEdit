﻿using System;
using System.Windows.Forms;





namespace BnsShop
{







    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new XtraForm1());
            Application.Run(new Form1());
        }
    }
}
