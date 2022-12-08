using System.ComponentModel;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string message = textBox2.Text;

                if (textBox2.Text.Length > 15)
                    throw new OverflowException();

                else
                    MessageBox.Show("Name: " + name + "      " + "Message: " + message);

            }

            catch (OverflowException r)
            {
                MessageBox.Show("Maximum Input Reached!!!" + r.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}