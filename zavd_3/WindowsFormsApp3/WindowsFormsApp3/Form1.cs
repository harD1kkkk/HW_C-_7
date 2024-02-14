using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string str = listBox1.SelectedItem.ToString();

            if(str == "C#")
            {
                ListViewItem item = new ListViewItem("2000");

                listView1.Items.Add(item);
                item.SubItems.Add("Anders Hejlsberg");
                item.SubItems.Add("ASP.NET Core, Entity Framework Core, Dapper");
                
            }
            else if(str == "C++")
            {
                ListViewItem item = new ListViewItem("1979");

                listView1.Items.Add(item);
                item.SubItems.Add("Bjarne Stroustrup");
                item.SubItems.Add("Qt, Boost, STL, SFML");
            }
            else if(str == "Java")
            {
                ListViewItem item = new ListViewItem("1991");

                listView1.Items.Add(item);
                item.SubItems.Add("James Gosling");
                item.SubItems.Add("Spring Framework, Hibernate, Apache Struts");
            }
        }
    }
}
