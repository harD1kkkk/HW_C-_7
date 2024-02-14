using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(toolStripTextBox4.Text);

            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, toolStripTextBox3.Text);

            item.SubItems.Add(subItem);
            listView1.Items.Add(item);
        }
        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();

            }
        }
        private void addColumnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string str = toolStripTextBox2.Text;

            listView1.Columns.Add(str);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
