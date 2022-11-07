using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string Fname;
        private string Lname;
        private string department;
        private string jobtitle;
        private double basicsalary;

        public string first_name
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public string last_name
        {
            get
            {
                return Lname;
            }
            set
            {
                Lname = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string job_title
        {
            get
            {
                return jobtitle;
            }
            set
            {
                jobtitle = value;
            }
        }
        public double basic_salary
        {
            get
            {
                return basicsalary;
            }
            set
            {
                basicsalary = value;
            }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.Fname = FName;
            this.Lname = LName;
            this.department = dept;
            this.jobtitle = job;
        }

        public void computeSalary(int hoursworked, double rateperhour)
        {
            basic_salary = hoursworked * rateperhour;
        }

        public double GetSalary()
        {
            return basic_salary;
        }

    }
}
    