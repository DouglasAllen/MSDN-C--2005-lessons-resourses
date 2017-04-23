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

        // Private Toolstrip button Events

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
            // I commented these out because I'm implementing this
            // functionality.

            // string rssURL = "http://msdn.microsoft.com/rss.xml";
            //RssManager.RefreshRSS(rssURL);

            queryChannels();
        
        }




        private void MainForm_Load(object sender, EventArgs e)
        {
           
            this.folderTableAdapter.Fill(this.rssDataSet.Folder);

            refreshChannels();
            refreshNewsItems();

        }


        private void folderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a Folder is selected, we'll want to display
            // the Channels associated with the Folder.  Additionally,
            // we'll want to display the NewsItems for the default
            // selected Channel.

            refreshChannels();
            refreshNewsItems();
        }

        private void channelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshNewsItems();
        }

        private void newsItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The "details area" (on the right-hand side of the form
            // is bound to the NewsItemDataConnector, so when we want
            // to display the details of the currently selected NewsItem
            // we must set the Position property of the DataConnector.

            if (this.newsItemsListBox.SelectedIndex != -1)
                this.NewsItemBindingSource.Position = this.newsItemsListBox.SelectedIndex;
        }

        // Helper Methods

        private void refreshChannels()
        {
            if (this.rssDataSet.Channel.Rows.Count == 0)
                this.channelTableAdapter.Fill(this.rssDataSet.Channel);

            if (folderComboBox.SelectedValue != null)
                this.ChannelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue;
        }

        private void refreshNewsItems()
        {
            // Refresh the list of NewsItems based on the current Channel
            // selection.

            if (this.rssDataSet.NewsItem.Rows.Count == 0)
                this.newsItemTableAdapter.Fill(this.rssDataSet.NewsItem);

            if (channelsListBox.SelectedValue != null)
                this.NewsItemBindingSource.Filter = "ChannelID = " + channelsListBox.SelectedValue.ToString();
        }

        private void queryChannels()
        {
            // Loop through all Channels.  For each Channel, delegate
            // the work of obtaining the RSS Feed to the processNewsFeed
            // method.

            // Unfortunately, I have a naming irregularity that bites me
            // in VB ... my Type name (rssDataSet) is the same name as my instance
            // (RssDataSet) so I'm going to need to change the instance name.
            // Fortunately, doing so on the visual designer changes the
            // instance name everywhere!

            foreach (rssDataSet.ChannelRow currentChannel in rssDataSet.Channel.Rows) 
            {
                System.Collections.ArrayList result;
                result = RssManager.ProcessNewsFeed(currentChannel.URL);

                
                foreach (RSSReader.NewsItem currentNewsItem in result) 
                {
                    // Admittedly I feel a little dirty about this ... 
                    // perhaps I could spend some more time and fix this
                    // kludge.  I'm going to check to make sure that
                    // the currentNewsItem.Title is not already in the
                    // database by checking it against the Title column
                    // of the rows that are already in the myRssDataSet.NewsItems 
                    // table.

                    // During testing, I realized the single quote was causing
                    // problems, so I needed to remove completely or escape it.
                    // I chose to remove them ... may rethink this later.

                    string title = currentNewsItem.Title;

                    if (title.Length >= 50)
                        title = title.Substring(0, 49);

                    title = title.Replace("'", "");

                    string filterExpression = "Title = '" + title + "'";

                    System.Data.DataRow[] filteredNewsItems = rssDataSet.NewsItem.Select(filterExpression);

                    if (filteredNewsItems.Length == 0)
                    {
                        // did not find it ... Need to add a new NewsItem datarow!

                        rssDataSet.NewsItemRow newRow = rssDataSet.NewsItem.NewNewsItemRow();
                        newRow.Title = currentNewsItem.Title;
                        newRow.Description = currentNewsItem.Description;
                        newRow.Link = currentNewsItem.Link;
                        newRow.ChannelID = currentChannel.ChannelID;
                        newRow.DateAcquired = DateTime.Now;

                        rssDataSet.NewsItem.AddNewsItemRow(newRow);

                    }
                }
            }

            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);
            
            // TODO: based on rowsAffected, update the StatusLabel.Text

        }




    }
}