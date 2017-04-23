#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Lesson03
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is a comment in C#

            textBox1.Text = "Hello world!";

            /*
            * This is a multi-line comment.
            *
            */

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Created by the Properties Window Event view
        }

        #region This is a Region

            // Nothing in particular ... but we'll use
            // regions in our project to better organize
            // our code.

        #endregion


    }
}