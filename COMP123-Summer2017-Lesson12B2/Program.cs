﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Alessandro da Silva Santos
 * Student Number: 300927354
 * Date: August 3,2017.
 * Description: Calculator Demo Project 
 * Version 0.1- Created the Project 
 */
namespace COMP123_Summer2017_Lesson12B2
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
            Application.Run(new CalculatorForm());
        }
    }
}
