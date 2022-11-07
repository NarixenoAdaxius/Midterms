using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(rThread);
            Thread rigusu = new Thread(start);
            Thread.CurrentThread.Name = ("The Name Age Thread");
            MessageBox.Show(textBox3.Text);
        }

        public void rThread()
        {
            String name = textBox1.Text.ToString();
            MessageBox.Show("Name: " + name);

            int age = Int32.Parse(textBox2.Text);
            MessageBox.Show("Age: " + age);
        }
    }
}
