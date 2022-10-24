using StudentNamespace;
using System.Security.Cryptography.X509Certificates;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname, lname;
            int studentno;

            fname = textBox3.Text;
            lname = textBox2.Text;
            studentno = Convert.ToInt32(textBox1.Text);

            StudentInfo u1 = new StudentInfo(fname, lname, studentno);

            lb1.Items.Add(u1.displaystudentno());
            lb2.Items.Add(u1.displaylname());
            lb3.Items.Add(u1.displayfname());



        }
    }
}