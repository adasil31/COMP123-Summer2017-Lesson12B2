﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Alessandro da Silva Santos
 * Student Number: 300927354
 * Date: August 8,2017.
 * Description: Splash Form class
 * Version 0.2- Created splashformtimer
 */

namespace COMP123_Summer2017_Lesson12B2
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;// turn time for off

        }
    }
}
