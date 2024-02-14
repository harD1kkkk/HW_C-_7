namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToString();
            listBox1.Items.Add(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(listBox1.SelectedItem + "+");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
