#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Lesson11
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;

            result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            MessageBox.Show(result.ToString());

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;

            try
            {
                result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                MessageBox.Show(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem with your entry.  Please make sure you enter numberical values.", "Input Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}