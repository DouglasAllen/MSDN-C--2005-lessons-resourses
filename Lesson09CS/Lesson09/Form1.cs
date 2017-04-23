using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.customerBindingSource.EndEdit();
                this.customerTableAdapter.Update(this.myCompanyDataSet.Customer);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(this, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myCompanyDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.myCompanyDataSet.Customer);
            // TODO: This line of code loads data into the 'myCompanyDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.myCompanyDataSet.Customer);
            // TODO: This line of code loads data into the 'myCompanyDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.myCompanyDataSet.Customer);

        }

        private void bindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.customerBindingSource.EndEdit();
                this.customerTableAdapter.Update(this.myCompanyDataSet.Customer);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(this, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }

        }

        private void bindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.customerBindingSource.EndEdit();
                this.customerTableAdapter.Update(this.myCompanyDataSet.Customer);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(this, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}