﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RoudClient
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebClient webclient = new WebClient();
            if (!webclient.DownloadString("https://spanel.syroex.com/kontrol.txt").Contains("1"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RoudClient());
            }
            else
            {
                MessageBox.Show("LAUNCHER HAMZALESS TARAFINDAN KULLANIM DIŞI EDİLMİŞTİR | Developer: Hamzaless#8267 ile iletişime geçiniz!", "Launcher Devre Dışı | Developer: Hamzaless#8267 ile iletişime geçiniz!");
            }

               
        }
    }
}