using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*   EXAMPLE 1 - First 'if' Statement Syntax 
            if (comboBox1.Text == "Bob")
            {
                MessageBox.Show("You picked Bob");
                comboBox1.Text = "";
             
            }
            dasdf */
           


            /*  EXAMPLE 2 - Second 'if' Statement Syntax 

            // When only a single line of code must
            // result from the if statement, you
            // can omit the curly braces.

            if (comboBox1.Text == "Beth")
                MessageBox.Show("You picked Beth");
             */


            /*  EXAMPLE 3 - Embedded 'if' Statements, 'else' Statement 

            // If statements can be embedded in other
            // code blocks, such as other if statements.

            if (comboBox1.Text != "Conrad")
            {
                if (comboBox1.Text == "Grant")
                {
                    MessageBox.Show("You picked Grant.");
                }
                else
                {
                    MessageBox.Show("I'm not sure who you picked.");
                }
            }
            else
            {
                MessageBox.Show("You picked Conrad");
            }
            */


            /*  EXAMPLE 4 - 'switch' Branching Statement 

            switch (listBox1.SelectedItem.ToString())
            {
                case "Foobar":
                    MessageBox.Show("You picked Foobar");
                    break;

                case "Bazquirk":
                    MessageBox.Show("You picked Bazquirk");
                    break;

                default:
                    MessageBox.Show("You picked something else.");
                    break;
            }
             */

            /*  EXAMPLE 5 - Sized Array 
            string[] myArray = new string[2];
            myArray[0] = "Bob";
            myArray[1] = "Beth";
            //myArray[2] = "Conrad"; // Causes exception!
            MessageBox.Show(myArray[1]);
             */

            /*  EXAMPLE 6 - Initialized Array 
            string[] myArray = { "Bob", "Beth", "Conrad", "Grant" };
            MessageBox.Show(myArray[1]);
            */

            /*  EXAMPLE 7 - 'foreach' w/ Array 

            string[] myArray = { "Bob", "Beth", "Conrad", "Grant" };

            foreach (string person in myArray)
            {
                MessageBox.Show(person);
            }

             */

            /*  EXAMPLE 8 - 'for' Iteration Statement 

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(i.ToString());
            }
             */

            /*  EXAMPLE 9 - 'While' Iteration Statement 

            int i = 0;
            while (i < int.Parse(textBox1.Text))
            {
                i++;
            }
            MessageBox.Show("The final value was: " + i.ToString());            
            */


            /*  EXAMPLE 10 - Combining Array and branching Statement 

            string[] myArray = { "Bob", "Beth", "Conrad", "Grant" };

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == "Conrad")
                {
                    MessageBox.Show("Found Conrad!");
                }
            }
             */


            /*  EXAMPLE 11 - Iteration and Branching Combined */

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                switch (listBox1.SelectedItems[i].ToString())
                {
                    case "Foobar":
                        MessageBox.Show("Foobar");
                        break;

                    case "Bazquirk":
                        MessageBox.Show("Bazquirk");
                        break;

                    case "Widgets":
                        MessageBox.Show("Widgets");
                        break;

                    case "Gadgets":
                        MessageBox.Show("Gadgets");
                        break;

                }
            }




        }
    }
}