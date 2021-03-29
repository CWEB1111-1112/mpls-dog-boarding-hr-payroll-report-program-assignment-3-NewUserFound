using System;
using System.Collections.Generic;
/**
Name: Lucas Meier
Date of completion:3/28

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {   
            //declare string for Departments and list
            string[] DEPARTMENT_ARRAY = {"Personnel","Marketing","Information Technology","Computer Services","Sales","Legal","Accounting"};
            double[] totals = {0,0,0,0,0,0,0};

            List<string> departmentList = new List<string>();
            //Iterate through the array and populate the list for departments
            for (var i = 0; i < DEPARTMENT_ARRAY.Length; i++)
            {
                departmentList.Add(DEPARTMENT_ARRAY[i]);
            }
            Console.WriteLine("Welcome to MPLS Dog Boarding HR Payroll Report Program\nYou will be prompted to enter the Employee's Name, Department Number, Hourly Salary, and Number of Hours Worked");
            //Initialize the loop
            Console.WriteLine("To enter employee Payroll data press the 1 key [1] else to exit enter the 2 key [2].");
            //looping structure
            while(Convert.ToInt32(Console.ReadLine()) == 1)
            {
                //method to get user inputs and assign total salaries
                Prompt_Total_Salary(DEPARTMENT_ARRAY,  totals);
                Console.WriteLine("To enter employee Payroll data press the 1 key [1] else to get payroll for all departments enter the 2 key [2].");    
            }
            //Output
            Console.WriteLine("");
            Console.WriteLine(pad("DEPARTMENTS") + "TOTALS");
            Console.WriteLine(pad("-----------")+"------");
            departmentList.ForEach(d => Console.WriteLine(pad(d) + totals[departmentList.IndexOf(d)]));
            Console.WriteLine("");
            Console.WriteLine("Thank you for using MPLS Dog Boarding HR Payroll Report Program.");
        }
        private static void Prompt_Total_Salary(string[] DEPARTMENT_ARRAY,  double[] totals)
        {
            int index = 0;
            try
            {
                //Declarations
                int Department_Number;
                string Employee_Name;
                double Hourly_Rate, Hours_Worked, salary_Employee;
                //input of user data for department
                //loop displays department numbers and names
                for (var i = 0; i < DEPARTMENT_ARRAY.Length; i++)
                {
                    Console.WriteLine($"[{i+1}] for {DEPARTMENT_ARRAY[i]}");
                }
                Console.WriteLine("Please Enter the Employees department number:");
                Department_Number = Convert.ToInt32(Console.ReadLine());
                index = Department_Number - 1;

                //Validate department number
                var validate = new Number_Validate();
                int value = validate.Department_Number_Validate(index);
                Console.WriteLine($"{value + 1} Is an accepted Department Number.");

                //initializing declared variables
                Console.WriteLine("Please Enter the Employee's name");
                Employee_Name = Console.ReadLine();     

                Console.WriteLine("Please Enter the Employee's Hourly Salary");
                Hourly_Rate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter the Employee's Number of Hours Worked");
                Hours_Worked = Convert.ToDouble(Console.ReadLine());
                
                //Individual employee output
                Console.WriteLine($"Employee:\t{Employee_Name}\nDepartment:\t{Department_Number}\nHourly Rate:\t{Hourly_Rate}\nHours Worked:\t{Hours_Worked}");
                Console.WriteLine("Is the data entered correct [Y] or [N]?");

                //Guard for salary totaling
                if(Console.ReadLine().ToUpper() == "Y")
                {
                    //logic for total salary
                    salary_Employee = Hours_Worked*Hourly_Rate;
                    totals[index] = totals[index] + salary_Employee;
                }
            }
            //invalid input catch
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"{index + 1} is an invalid Department Number, try again.");
            } 
        }
        static string pad(string department)
        {
            //Adding padding for table
            int collumnWidth = 30;
            int departmentWidth = department.Length;
            string paddingDepartment = department;
            int padSpace = collumnWidth - departmentWidth;
            int tabCounter = padSpace / 8;
            while(tabCounter-- > 0)
            {
                paddingDepartment += "\t";
            }
            return paddingDepartment;
        }
    }
}
