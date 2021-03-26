using System;
using System.Collections.Generic;
/**
Name: Lucas Meier
Date of completion:

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine($"Welcome to MPLS Dog Boarding HR Payroll Report Program\nYou will be prompted to enter the Employee's Name, Department Number, Hourly Salary, and Number of Hours Worked");
            inputs();
            outputs();
            Console.WriteLine("Thank you for using MPLS Dog Boarding HR Payroll Report Program.");
        }
        public static void inputs()
        {   
            //Declarations
            string Employee_Name;
            double Hourly_Salary, Number_Of_Hours_Worked;
            int Department_Number;
            double primer;
            bool end = false;
            bool valid_Number = false;

            //Initialize the primer
            Console.WriteLine($"To begin please press the 1 key [1]");
            primer = Convert.ToInt32(Console.ReadLine());

            //looping structure
            while(end != true)
            {   
                //decision logic to continue iterating
                if(primer == 1){
                    //initializing declared variables
                    Console.WriteLine("Please Enter the Employee's name");
                    Employee_Name = Console.ReadLine();     

                    //loop to initialize Department number and validate
                    while(valid_Number == false)
                   {
                    Console.WriteLine("Please Enter the Employee's Department Number\n[1] for Personnel\n[2] for Marketing\n[3] for Information Technology\n[4] for Computer Services\n[5] for Sales\n[6] for Legal\n[7] for Accounting");
                    Department_Number = Convert.ToInt32(Console.ReadLine());
                    var validate = new Number_Validate();
                    int index = Department_Number - 1;
                    try{
                        int value = validate.Department_Number_Validate(index);
                        Console.WriteLine($"{value} Is an accepted Department Number.");
                        valid_Number = true;
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine($"{e.GetType().Name}: {index} is an invalid Department Number, try again.");
                        valid_Number = false;
                    }
                   } 

                    Console.WriteLine("Please Enter the Employee's Hourly Salary");
                    Hourly_Salary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Enter the Employee's Number of Hours Worked");
                    Number_Of_Hours_Worked = Convert.ToInt32(Console.ReadLine());

                    //reinitializing the primer
                    Console.WriteLine("To continue entering employee Payroll data press the 1 key [1] else to exit enter the 2 key [2].");
                    primer = Convert.ToInt32(Console.ReadLine());
                }
                else{
                    end = true;
                }
            }
        }
        public static void outputs()
        {
            //Array logic for Departments
            int[] departmentNumberArray = {1,2,3,4,5,6,7};
            string[] departmentNameArray = {"Personnel","Marketing","Information Technology","Computer Services","Sales","Legal","Accounting"};
            
            List<Payroll_Report_Input> all_Employee_Reports = new List<Payroll_Report_Input>(); 
        }
    }
}
