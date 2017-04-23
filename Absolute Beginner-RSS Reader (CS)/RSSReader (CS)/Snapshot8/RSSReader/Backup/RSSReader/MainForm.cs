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
            editFolder();
        }

        private void addFolderToolstripButton_Click(object sender, EventArgs e)
        {
            addFolder();
        }

        private void deleteFolderToolStripButton_Click(object sender, EventArgs e)
        {
            deleteFolder();
        }

        private void addChannelToolstripButton_Click(object sender, EventArgs e)
        {
            addChannel();
        }

        private void editChannelToolstripButton_Click(object sender, EventArgs e)
        {
            editChannel();
        }

        private void deleteChannelToolstripButton_Click(object sender, EventArgs e)
        {
            deleteChannel();
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

                    //if (title.Length >= 50)
                    //    title = title.Substring(0, 49);

                    title = title.Replace("'", "");

                    string filterExpression = "Title = '" + title + "'";

                    System.Data.DataRow[] filteredNewsItems = rssDataSet.NewsItem.Select(filterExpression);

                    if (filteredNewsItems.Length == 0)
                    {
                        // did not find it ... Need to add a new NewsItem datarow!

                        rssDataSet.NewsItemRow newRow = rssDataSet.NewsItem.NewNewsItemRow();
                        newRow.Title = title;
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

        private void addFolder()
        {

            // Display the FolderDialog form.  By setting the FolderID 
            // property to 0, we're telling the dialog to essentially
            // go into "new folder" mode.  If we were to set the 
            // FolderID > 0 then we'd be telling the dialog to go
            // into "folder edit" mode.

            FolderDialog myFolderDialog = new FolderDialog();

            // Dialog, go into "new folder" mode ...
            myFolderDialog.FolderID = 0;
            myFolderDialog.FolderName = "";

            DialogResult result = myFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                rssDataSet.FolderRow folder = rssDataSet.Folder.NewFolderRow();
                folder.FolderName = myFolderDialog.FolderName;

                rssDataSet.Folder.AddFolderRow(folder);

                int rowsAffected = folderTableAdapter.Update(folder);

                // TODO - Update statusLabel.Text based on rowsAffected
            }
            else
            {
                // TODO - Update statusLabel.Text
            }

            myFolderDialog = null;

        }

        private void editFolder()
        {
            FolderDialog myFolderDialog = new FolderDialog();

            int folderID = (int)folderComboBox.SelectedValue;

            rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(folderID);

            myFolderDialog.FolderID = folderID;
            myFolderDialog.FolderName = folder.FolderName;

            DialogResult result = myFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folder.BeginEdit();
                folder.FolderName = myFolderDialog.FolderName;
                folder.EndEdit();

                int rowsAffected = folderTableAdapter.Update(folder);

                // TODO - Update statusLabel.Text based on RowsAffected
            }
            else
            {
                // TODO - Update statusLabel.Text
            }

            myFolderDialog = null;
        }

        private void deleteFolder()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the current Folder? " +
                "Doing so will also delete all the Channels and Messages contained in that foler.",
                "Delete Folder?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly,
                false);

            if (result == DialogResult.Yes)
            {
                // Delete all the Channels for the current Folder.
                int folderID = (int)folderComboBox.SelectedValue;
                deleteChannels(folderID);

                // Delete the folder itself.
                rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(folderID);
                folder.Delete();

                int rowsAffected = folderTableAdapter.Update(rssDataSet);

                // TODO - Update statusLabel.Text based on the rowsAffected

            }
            else
            {
                // TODO - Update statusLabel.text
            }


        }

        private void addChannel()
        {
            ChannelDialog myChannelDialog = new ChannelDialog();

            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = 0;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            DialogResult result = myChannelDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                int rowsAffected = channelTableAdapter.Update(rssDataSet);

                // TODO - Update statusLabel.text based on the rowsAffected

                queryChannels();
            }
            else
            {
                // TODO - Update statusLabel.text
            }


            myChannelDialog = null;
        }

        private void editChannel()
        {
            ChannelDialog myChannelDialog = new ChannelDialog();

            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = (int)channelsListBox.SelectedValue;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            DialogResult result = myChannelDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                int rowsAffected = channelTableAdapter.Update(rssDataSet);

                // TODO - Update statusLabel.text based on the rowsAffected

                queryChannels();
            }
            else
            {
                // TODO - Update statusLabel.text
            }

            myChannelDialog = null;
        }

        private void deleteChannel()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the current Channel? " +
                "Doing so will also delete all the News Items for that Channel.",
                "Delete Folder?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly,
                false);

            if (result == DialogResult.Yes)
            {
                // Delete NewsItems associated with this Channel
                int channelID = (int)channelsListBox.SelectedValue;
                deleteNewsItems(channelID);

                // Delete the Channel
                rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(channelID);
                channel.Delete();

                int rowsAffected = channelTableAdapter.Update(rssDataSet);

                if (rowsAffected > 0)
                {
                    // TODO - Update statusLabel.text based on the rowsAffected
                }
                else
                {
                    // TODO - Update statusLabel.text
                }

            }
        }

        private void deleteChannels(int folderID)
        {
            // Given a FolderID, delete all associated Channels
            // and NewsItems from the database.

            rssDataSet.ChannelRow[] channels = (rssDataSet.ChannelRow[])rssDataSet.Channel.Select("FolderID = " + folderID.ToString());
            

            foreach (rssDataSet.ChannelRow channel in channels)
            {
                int channelID = channel.ChannelID;
                deleteNewsItems(channelID);
                channel.Delete();
            }

            int rowsAffected = channelTableAdapter.Update(rssDataSet);

            // TODO - Update statusLabel.Text based on the rowsAffected

        }


        private void deleteNewsItems(int channelID)
        {
            // For the given Channel, delete all associated NewsItems

            rssDataSet.NewsItemRow[] newsItems = (rssDataSet.NewsItemRow[])rssDataSet.NewsItem.Select("ChannelID = " + channelID.ToString());

            if (newsItems.Length == 0)
                return;

            foreach (rssDataSet.NewsItemRow newsItem in newsItems)
                newsItem.Delete();

            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);

            // TODO - Update statusLabel.Text based on the rowsAffected

        }




    }
}