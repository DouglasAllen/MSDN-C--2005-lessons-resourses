using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will call the 'New Folder' helper method
            MessageBox.Show("Will create a New Folder");
        }

        private void newChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will call the 'New Channel' helper method
            MessageBox.Show("Will create a New Channel");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will open the Help Contents
            MessageBox.Show("Will open the Help Contents");
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will open the Help Index
            MessageBox.Show("Will open the Help Index");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will open the Help Search 
            MessageBox.Show("Will open the Help Search");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Will open the About Dialog
            MessageBox.Show("Will open the About Dialog");
        }

        private void editFolderToolstripButton_Click(object sender, EventArgs e)
        {
            FolderDialog f = new FolderDialog();

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User selected Cancel");
            }

            f = null;

        }

        private void addFolderToolstripButton_Click(object sender, EventArgs e)
        {
            FolderDialog f = new FolderDialog();

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User selected Cancel");
            }

            f = null;
        }

        private void deleteFolderToolStripButton_Click(object sender, EventArgs e)
        {
            // TODO: Will delete current folder.
            MessageBox.Show("Will Delete current Folder");
        }

        private void addChannelToolstripButton_Click(object sender, EventArgs e)
        {
            ChannelDialog f = new ChannelDialog();

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK");
            }
            else
            {
                MessageBox.Show("User clicked Cancel");
            }

            f = null;
        }

        private void editChannelToolstripButton_Click(object sender, EventArgs e)
        {
            ChannelDialog f = new ChannelDialog();

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK");
            }
            else
            {
                MessageBox.Show("User clicked Cancel");
            }

            f = null;
        }

        private void deleteChannelToolstripButton_Click(object sender, EventArgs e)
        {
            // TODO: Delete selected Channel
            MessageBox.Show("Will delete channel"); 
        }

        private void refreshRSSFeed_Click(object sender, EventArgs e)
        {
            string rssURL = "http://msdn.microsoft.com/rss.xml";

            // Begin the WebRequest to the desired RSS Feed
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(rssURL);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            // Convert the RSS Feed into an XML document
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            //TextReader rssTextReader = new StreamReader(rssStream);
            //XmlTextReader rssReader = new XmlTextReader(rssTextReader);
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument(); 

            rssDoc.Load(rssStream);


            // This uses an XPath expression to get all nodes that fall 
            // under this path.
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            string title = "";
            string link = "";
            string description = "";

            // Loop through the Item nodes from the RSS Feed and retrieve 
            // the Title, Link and Description.  Then we'll add it to the
            // database (if not already present.)

            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssDetail; 

                rssDetail = rssItems.Item(i).SelectSingleNode("title");
                if (rssDetail != null)
                {
                    title = rssDetail.InnerText;
                }
                else
                {
                    title = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("link");
                if (rssDetail != null)
                {
                    link = rssDetail.InnerText;
                }
                else
                {
                    link = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("description");
                if (rssDetail != null)
                {
                    description = rssDetail.InnerText;
                }
                else
                {
                    description = "";
                }

                // TODO: Check to make sure this news Item isn't already in the database

                // TODO: Add this newsItem to the database

                // TODO: Remove this test

                MessageBox.Show(title + link + description);

            
            }
        
        }

    }
}