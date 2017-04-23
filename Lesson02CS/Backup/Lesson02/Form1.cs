#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace WindowsApplication1
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value += 10;
            statusStripPanel1.Text = "Current Value: " + toolStripProgressBar1.Value.ToString();

            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;
            }
        }
    }
}