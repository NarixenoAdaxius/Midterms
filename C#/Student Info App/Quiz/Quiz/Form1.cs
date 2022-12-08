using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button2_Click(object sender, EventArgs e)
        {
        Form2 two = new Form2();
        two.Show();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int totalLetters = 0;
            string name = textBox1.Text;
            string message = textBox2.Text;
            char[] chars = message.ToCharArray();
            foreach (var item in chars)
                if (char.IsLetter(item))
                    totalLetters++;
            try
            {
                if (totalLetters <= 150)
                {
                    MessageBox.Show("Name: " + name + "\n" + "Message: " + message);
                }
                else
                {
                    throw new StackOverflowException();
                }
            }
            catch (StackOverflowException qwe)
            {
                MessageBox.Show(qwe.Message);
            }

        }
    }
}
