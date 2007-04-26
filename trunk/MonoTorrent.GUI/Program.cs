using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MonoTorrent.GUI.View;

namespace MonoTorrent.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			ThreadPool.SetMaxThreads(70,70);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}