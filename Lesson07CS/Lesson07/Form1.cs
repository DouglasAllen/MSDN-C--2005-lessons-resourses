using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GreatCars.Finance;
using GreatCars.Engineering;

namespace Lesson07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();

            System.Windows.Forms.MessageBox.Show("Hi");
            // ms-help://MS.VSExpressCC.v80/MS.NETFramework.v20.en/cpref/html/T_System_Math.htm

        }
    }
}