using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class ChannelDialog : Form
    {

        private int channelID;
        private int folderID;

        public rssDataSet DataSource
        {
            get { return this.rssDataSet; }
            set { this.rssDataSet = value; }
        }

        public int ChannelID
        {
            get { return channelID; }
            set { channelID = value; }
        }

        public int FolderID
        {
            get { return folderID; }
            set { folderID = value; }
        }


        public ChannelDialog()
        {
            InitializeComponent();
        }

        private void ChannelDialog_Load(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            // if the channelID is greater than 0, then
            // set the current record = to the channelID


            // I shouldn't have to do this ... its already set in the properties.
            // Any ideas as to why this didn't "take" the first time?
            FolderBindingSource.DataSource = rssDataSet;
            FolderBindingSource.DataMember = "Folder";
            FolderBindingSource.ResetBindings(true);

            folderComboBox.SelectedValue = folderID;

            if (channelID > 0)
            {
                // I shouldn't have to do this ... its already set in the properties.
                // Any ideas as to why this didn't "take" the first time?
                ChannelBindingSource.DataSource = rssDataSet;
                ChannelBindingSource.DataMember = "Channel";
                ChannelBindingSource.Filter = "ChannelID = " + channelID.ToString();
                ChannelBindingSource.ResetBindings(true);
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (channelID == 0)
            {
                rssDataSet.ChannelRow channel = rssDataSet.Channel.NewChannelRow();

                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Now;

                rssDataSet.Channel.AddChannelRow(channel);
            }
            else
            {
                // Find the existing channel
                rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(channelID);

                channel.BeginEdit();
                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Parse(lastUpdatedTextBox.Text);
                channel.EndEdit();
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}