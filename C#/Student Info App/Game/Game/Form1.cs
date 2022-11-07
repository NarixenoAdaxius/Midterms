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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class Form1 : Form
    {
        private Thread _childThread;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 two = new Form2();
            two.Show();
            Visible = false;
        }

        private void Enter_Click(object sender, EventArgs e)
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
                    int[] Simpsons = new int[3];
                    Simpsons[0] = 1;
                    Simpsons[1] = 2;
                    Simpsons[2] = 3;
                    if (answerone == Simpsons[0])
                    {
                        MessageBox.Show("Number 1 is correct, Bart Simpsons is the correct answer. Good Job! :)");
                    }
                    if (answerone == Simpsons[1])
                    {
                        MessageBox.Show("Number 2 is incorrect, Homer Simpsons is not the correct answer.");
                    }
                    if (answerone == Simpsons[2])
                    {
                        MessageBox.Show("Number 3 is incorrect, Lisa Simpsons is not the correct answer.");
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

