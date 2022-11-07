using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        private Thread _childThread;
        public Form2()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Form3 three = new Form3();
            three.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
                int answerone = Int32.Parse(textBox1.Text);
                MessageBox.Show("Checking your answer...");
                Thread.Sleep(5000);
                ThreadStart delThreadObj = new ThreadStart(ThreadCycle);
                _childThread = new Thread(delThreadObj);
                _childThread.Start();
                Thread.Sleep(1000);
                _childThread.Abort();

                void ThreadCycle()
                {
                    int[] Alien = new int[3];
                    Alien[0] = 1;
                    Alien[1] = 2;
                    Alien[2] = 3;
                    if (answerone == Alien[0])
                    {
                        MessageBox.Show("Number 1 is incorrect, Gwen Tennyson is not the correct answer.");
                    }
                    if (answerone == Alien[1])
                    {
                        MessageBox.Show("Number 2 is correct, Ben Tennyson is the correct answer. Good Job! :)");
                    }
                    if (answerone == Alien[2])
                    {
                        MessageBox.Show("Number 3 is incorrect, Grandpa Max is not the correct answer.");
                    }
                }
            }
            catch (FormatException qwe)
            {
                MessageBox.Show("Invalid answer, " + qwe.Message);
            }
        }
    }
}
