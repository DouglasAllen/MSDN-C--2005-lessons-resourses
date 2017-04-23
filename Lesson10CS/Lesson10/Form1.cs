#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Lesson10
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // StreamReader will retrieve the file from the source
            // and will convert it into a stream ready to be processed.
            System.IO.StreamReader sr = new System.IO.StreamReader(@"test.xml");

            // The XmlTextReader
            System.Xml.XmlTextReader xr = new System.Xml.XmlTextReader(sr);

            // The XmlDocument
            System.Xml.XmlDocument carlotDoc = new System.Xml.XmlDocument();

            carlotDoc.Load(xr);

            // Using the InnerText property will give us just the data
            // ... since we are at the entire Document level, it will
            // give us *all* the values (no delimiter).
            label1.Text = carlotDoc.InnerText;


            // Navigate from the root node to the first child node.
            // As you can see, this will give us the XML schema node.
            // Probably not what we want.
            label2.Text = "First child node: " + carlotDoc.FirstChild.InnerText;

            // The NextSibling of the FirstChild would be the carlot.
            label3.Text = "Second child node: " + carlotDoc.FirstChild.NextSibling.InnerText;

            // Lets just get a reference to the carlot ...
            System.Xml.XmlNode carlot = carlotDoc.FirstChild.NextSibling;
            label4.Text = "Now that we have a reference to 'carlot': " + carlot.InnerText;

            label5.Text = "First child of carlot: " + carlot.FirstChild.InnerText;

            label6.Text = "First child of the first child of carlot:" + carlot.FirstChild.FirstChild.InnerText;

            // Using the Parent-Child-Sibling metaphore is one way to navigate through 
            // an XML document ... but it can sometime be tedious AND problematic because
            // the document may not be formed properly (i.e., may not have the correct
            // nodes where your application might expect them).


            // Another way to navigate is to utilize an XPath expression.
            // XPath is easy ... Just think of the hierarchy of nodes in terms
            // of a path, much like folder paths on your hard drive.
            // In our example:  carlot/car/model

            //System.Xml.XmlNodeList carLotItems = carlotDoc.SelectNodes("carlot");
            System.Xml.XmlNodeList carLotItems = carlotDoc.SelectNodes("carlot/car");

            System.Xml.XmlNode make = carLotItems.Item(0).SelectSingleNode("make");

            label7.Text = "make.InnerText: " + make.InnerText; 


        }
    }
}