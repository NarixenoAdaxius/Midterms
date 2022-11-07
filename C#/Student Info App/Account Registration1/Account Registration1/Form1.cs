using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = Programb.Text.ToString();            
            StudentInfoClass.FirstName = Fname.Text.ToString();          
            StudentInfoClass.LastName = Lname.Text.ToString();            
            StudentInfoClass.Address = Addressb.Text.ToString();           
            StudentInfoClass.Program = Programb.Text.ToString();
            StudentInfoClass.StudentNo = Int32.Parse(Studbox.Text.ToString());            
            StudentInfoClass.Age = Int32.Parse(Ageb.Text.ToString());
            StudentInfoClass.ContactNo = Int32.Parse(Contactb.Text.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
    
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

       public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        static string GetFirstName(string FirstName) {
            return FirstName;
        }
        static string GetLastName(string LastName) 
        {
            return LastName;
        }
        static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        static string GetAddress(string Address)
        {
            return Address;
        }
        static string GetProgram(string Program)
        {
            return Program;
        }
        static long GetAge (long Age)
        {
            return Age;

        }
        static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
      
    }



}