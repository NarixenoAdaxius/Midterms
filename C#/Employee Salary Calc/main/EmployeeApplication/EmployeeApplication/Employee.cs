namespace EmployeeInterface{

    public interface IEmployee{
        void computeSalary(int hoursworked, double rateperhour );
        
        string first_name { get; set; }
        string last_name { get; set; }
        string Department { get; set; }
        string job_title { get; set; }
        double basic_salary { get; set; }
    } 
}