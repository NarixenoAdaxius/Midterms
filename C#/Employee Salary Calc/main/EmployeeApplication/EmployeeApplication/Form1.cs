using EmployeeNamespace;
using System.Xml.Linq;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String Fname = tb1.Text;
            String Lname = tb2.Text;
            String Dept = tb3.Text;
            String jobtitle = tb4.Text;
            double rph = double.Parse(tb5.Text);
            int thw  = int.Parse(tb6.Text);

            PartTimeEmployee p1 = new PartTimeEmployee(Fname, Lname, Dept, jobtitle);

            p1.computeSalary(thw, rph);

            flb.Text = p1.first_name;
            llb.Text = p1.last_name;
            bslb.Text = p1.GetSalary().ToString();
        }
    }
}