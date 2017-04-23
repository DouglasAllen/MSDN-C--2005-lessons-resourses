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
            // TODO: Will open the Folder Dialog
            MessageBox.Show("Will open the Folder Dialog");
        }

        private void addFolderToolstripButton_Click(object sender, EventArgs e)
        {
            // TODO: Will open the Folder Dialog
            MessageBox.Show("Will open the Folder Dialog");
        }

        private void deleteFolderToolStripButton_Click(object sender, EventArgs e)
        {
            // TODO: Will delete current folder.
            MessageBox.Show("Will Delete current Folder");
        }

        private void addChannelToolstripButton_Click(object sender, EventArgs e)
        {
            // TODO: Will open folder dialog.
            MessageBox.Show("Will open Channel dialog");
        }

        private void editChannelToolstripButton_Click(object sender, EventArgs e)
        {
            // TODO: Will open folder dialog.
            MessageBox.Show("Will open Channel dialog");
        }

        private void deleteChannelToolstripButton_Click(object sender, EventArgs e)
        {
            // TODO: Delete selected Channel
            MessageBox.Show("Will delete channel"); 
        }

        private void refreshRSSFeed_Click(object sender, EventArgs e)
        {
            // TODO: Refresh RSS Feed
            MessageBox.Show("Will referesh RSS feed");
        }
    }
}