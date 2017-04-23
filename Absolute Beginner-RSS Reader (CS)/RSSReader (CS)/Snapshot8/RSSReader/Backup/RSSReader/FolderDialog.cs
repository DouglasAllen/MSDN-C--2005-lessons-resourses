using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class FolderDialog : Form
    {

        private int folderID = 0;
        private string folderName = "";

        public int FolderID
        {
            get { return folderID; }
            set { folderID = value; }
        }

        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public FolderDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            folderName = folderNameTextBox.Text;
            this.Close();
        }

        private void FolderDialog_Load(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            folderIDTextBox.Text = folderID.ToString();
            folderNameTextBox.Text = folderName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}