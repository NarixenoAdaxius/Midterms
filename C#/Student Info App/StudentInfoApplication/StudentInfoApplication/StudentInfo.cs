using System;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace StudentNamespace
{
    public class StudentInfo
    {
        private String fname;
        private String lname;
        private int studentno;

        public StudentInfo()
        {
            this.fname = "";
            this.lname = "";
            this.studentno = 0;
        }
        public StudentInfo(string nfName, string nlName) { 
            this.fname = nfName; 
            this.lname = nlName; 
            this.studentno = 0; 
        }
        public StudentInfo(string nfName, string nlName, int nstudentno)
        {
            this.fname = nfName;
            this.lname = nlName;
            this.studentno = nstudentno;
        }
        public string displayfname() {
            return fname;
            
        }
        public string displaylname()
        {
            return lname;

        }
        public int displaystudentno()
        {
            return studentno;

        }

    }
}


