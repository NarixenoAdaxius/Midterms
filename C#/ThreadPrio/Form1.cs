using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadPrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(MyThreadClass.Thread2);
            ThreadB.Name = "Thread B Process";
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            ThreadC.Name = "Thread C Process";
            Thread ThreadD = new Thread(MyThreadClass.Thread2);
            ThreadD.Name = "Thread D Process";

            Console.WriteLine("--Thread Starts--");

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("--End of Thread--");
            label1.Text = "--End of Thread-- ";
        }
    }
}
