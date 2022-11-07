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
    public partial class Form3 : Form
    {
        private Thread _childThread;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Four = new Form4();
            
            Four.Show();
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
                    int[] Cartoons = new int[3];
                    Cartoons[0] = 1;
                    Cartoons[1] = 2;
                    Cartoons[2] = 3;
                    if (answerone == Cartoons[0])
                    {
                        MessageBox.Show("Number 1 is correct, Dora the Explorer is the correct answer. :)");
                    }
                    if (answerone == Cartoons[1])
                    {
                        MessageBox.Show("Number 2 is incorrect,Snow White is not the correct answer.");
                    }
                    if (answerone == Cartoons[2])
                    {
                        MessageBox.Show("Number 3 is incorrect, Sleeping Beauty is not the correct answer.");
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
