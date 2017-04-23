namespace RSSReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.newsItemsLabel = new System.Windows.Forms.Label();
            this.newsItemsListBox = new System.Windows.Forms.ListBox();
            this.datePosted = new System.Windows.Forms.TextBox();
            this.datePostedLabel = new System.Windows.Forms.Label();
            this.expandLabel = new System.Windows.Forms.Label();
            this.channelsLabel = new System.Windows.Forms.Label();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addFolderToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editFolderToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteFolderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshRSSFeed = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.webBrowser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.datePosted);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.datePostedLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.expandLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelsListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.titleTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.titleLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.folderLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.folderComboBox);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(508, 401);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(508, 23);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            // 
            // progressBar
            // 
            this.progressBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(186, 160);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(310, 158);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(186, 74);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(310, 53);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(185, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(59, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description:";
            // 
            // newsItemsLabel
            // 
            this.newsItemsLabel.AutoSize = true;
            this.newsItemsLabel.Location = new System.Drawing.Point(15, 167);
            this.newsItemsLabel.Name = "newsItemsLabel";
            this.newsItemsLabel.Size = new System.Drawing.Size(61, 13);
            this.newsItemsLabel.TabIndex = 11;
            this.newsItemsLabel.Text = "News Items:";
            // 
            // newsItemsListBox
            // 
            this.newsItemsListBox.FormattingEnabled = true;
            this.newsItemsListBox.Location = new System.Drawing.Point(15, 184);
            this.newsItemsListBox.Name = "newsItemsListBox";
            this.newsItemsListBox.Size = new System.Drawing.Size(150, 134);
            this.newsItemsListBox.TabIndex = 10;
            // 
            // datePosted
            // 
            this.datePosted.Location = new System.Drawing.Point(256, 133);
            this.datePosted.Name = "datePosted";
            this.datePosted.Size = new System.Drawing.Size(143, 20);
            this.datePosted.TabIndex = 9;
            // 
            // datePostedLabel
            // 
            this.datePostedLabel.AutoSize = true;
            this.datePostedLabel.Location = new System.Drawing.Point(185, 139);
            this.datePostedLabel.Name = "datePostedLabel";
            this.datePostedLabel.Size = new System.Drawing.Size(65, 13);
            this.datePostedLabel.TabIndex = 8;
            this.datePostedLabel.Text = "Date Posted:";
            // 
            // expandLabel
            // 
            this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandLabel.ForeColor = System.Drawing.Color.Blue;
            this.expandLabel.Location = new System.Drawing.Point(451, 139);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(45, 14);
            this.expandLabel.TabIndex = 7;
            this.expandLabel.Text = "Expand";
            // 
            // channelsLabel
            // 
            this.channelsLabel.AutoSize = true;
            this.channelsLabel.Location = new System.Drawing.Point(12, 51);
            this.channelsLabel.Name = "channelsLabel";
            this.channelsLabel.Size = new System.Drawing.Size(50, 13);
            this.channelsLabel.TabIndex = 6;
            this.channelsLabel.Text = "Channels:";
            // 
            // channelsListBox
            // 
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.Location = new System.Drawing.Point(12, 68);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(153, 95);
            this.channelsListBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(186, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(310, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(189, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(26, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.folderLabel.Location = new System.Drawing.Point(13, 11);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(35, 13);
            this.folderLabel.TabIndex = 2;
            this.folderLabel.Text = "Folder:";
            // 
            // folderComboBox
            // 
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(12, 28);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(153, 21);
            this.folderComboBox.TabIndex = 1;

            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(508, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.newChannelToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Text = "New";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // newChannelToolStripMenuItem
            // 
            this.newChannelToolStripMenuItem.Name = "newChannelToolStripMenuItem";
            this.newChannelToolStripMenuItem.Text = "New Channel";
            this.newChannelToolStripMenuItem.Click += new System.EventHandler(this.newChannelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Text = "Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolstripButton,
            this.editFolderToolstripButton,
            this.deleteFolderToolStripButton,
            this.toolStripSeparator1,
            this.addChannelToolstripButton,
            this.editChannelToolstripButton,
            this.deleteChannelToolstripButton,
            this.toolStripSeparator2,
            this.refreshRSSFeed});
            this.toolStrip.Location = new System.Drawing.Point(3, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(184, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStip";
            // 
            // addFolderToolstripButton
            // 
            this.addFolderToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFolderToolstripButton.Image = RSSReader.Properties.Resources.folder_add;
            this.addFolderToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFolderToolstripButton.Name = "addFolderToolstripButton";
            this.addFolderToolstripButton.Text = "New Folder";
            this.addFolderToolstripButton.Click += new System.EventHandler(this.addFolderToolstripButton_Click);
            // 
            // editFolderToolstripButton
            // 
            this.editFolderToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editFolderToolstripButton.Image = RSSReader.Properties.Resources.folder_edit;
            this.editFolderToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editFolderToolstripButton.Name = "editFolderToolstripButton";
            this.editFolderToolstripButton.Text = "toolStripButton1";
            this.editFolderToolstripButton.ToolTipText = "Edit Folder";
            this.editFolderToolstripButton.Click += new System.EventHandler(this.editFolderToolstripButton_Click);
            // 
            // deleteFolderToolStripButton
            // 
            this.deleteFolderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteFolderToolStripButton.Image = RSSReader.Properties.Resources.folder_delete;
            this.deleteFolderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteFolderToolStripButton.Name = "deleteFolderToolStripButton";
            this.deleteFolderToolStripButton.Text = "toolStripButton3";
            this.deleteFolderToolStripButton.ToolTipText = "Delete Folder";
            this.deleteFolderToolStripButton.Click += new System.EventHandler(this.deleteFolderToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // addChannelToolstripButton
            // 
            this.addChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addChannelToolstripButton.Image = RSSReader.Properties.Resources.channel_new;
            this.addChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addChannelToolstripButton.Name = "addChannelToolstripButton";
            this.addChannelToolstripButton.Text = "toolStripButton4";
            this.addChannelToolstripButton.ToolTipText = "Add Channel";
            this.addChannelToolstripButton.Click += new System.EventHandler(this.addChannelToolstripButton_Click);
            // 
            // editChannelToolstripButton
            // 
            this.editChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editChannelToolstripButton.Image = RSSReader.Properties.Resources.channel_edit;
            this.editChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editChannelToolstripButton.Name = "editChannelToolstripButton";
            this.editChannelToolstripButton.Text = "toolStripButton5";
            this.editChannelToolstripButton.ToolTipText = "Edit Channel";
            this.editChannelToolstripButton.Click += new System.EventHandler(this.editChannelToolstripButton_Click);
            // 
            // deleteChannelToolstripButton
            // 
            this.deleteChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteChannelToolstripButton.Image = RSSReader.Properties.Resources.channel_delete;
            this.deleteChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteChannelToolstripButton.Name = "deleteChannelToolstripButton";
            this.deleteChannelToolstripButton.Text = "toolStripButton6";
            this.deleteChannelToolstripButton.ToolTipText = "Delete Channel";
            this.deleteChannelToolstripButton.Click += new System.EventHandler(this.deleteChannelToolstripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // refreshRSSFeed
            // 
            this.refreshRSSFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshRSSFeed.Image = RSSReader.Properties.Resources.rss;
            this.refreshRSSFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshRSSFeed.Name = "refreshRSSFeed";
            this.refreshRSSFeed.Text = "toolStripButton7";
            this.refreshRSSFeed.ToolTipText = "Refresh RSS Feed";
            this.refreshRSSFeed.Click += new System.EventHandler(this.refreshRSSFeed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 401);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "RSS Reader";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.ToolStripButton addFolderToolstripButton;
        private System.Windows.Forms.ToolStripButton editFolderToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteFolderToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton editChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteChannelToolstripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton refreshRSSFeed;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.Label channelsLabel;
        private System.Windows.Forms.ListBox channelsListBox;
        private System.Windows.Forms.Label newsItemsLabel;
        private System.Windows.Forms.ListBox newsItemsListBox;
        private System.Windows.Forms.TextBox datePosted;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label datePostedLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

