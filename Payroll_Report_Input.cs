using System;
using System.Collections.Generic;

namespace assignment_three
{
    public class Payroll_Report_Input
    {
        public string Employee_Name { get; set; }
        public double Department_Number { get; }
        public double Hourly_Salary { get; set; }
        public double Number_Of_Hours_Worked { get; set; }
        public string employee_Report { get; set; }
        
        public Payroll_Report_Input(string name, double initialSalary, double initial_Hours_Worked, int department)
        {
            //defining each parameter with its argument
            Employee_Name = name;
            Hourly_Salary = initialSalary;
            Number_Of_Hours_Worked = initial_Hours_Worked;
            Department_Number = department;
        }
    }
}