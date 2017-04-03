﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_DOLLARS_RAILL
{
    static class Program
    {
        
        //declared globally 
        public static SplashScreen MySplashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //initialize splashScreen and selectionForm
            Program.MySplashScreen = new SplashScreen();

            //start program at SplashScreen
            Application.Run(Program.MySplashScreen);
        }
    }
}
