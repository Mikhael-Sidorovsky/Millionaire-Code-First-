﻿using System;
using System.Windows.Forms;

namespace Millionaire
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Presenter presenter = new Presenter(form);
            Application.Run(form);
        }
    }
}