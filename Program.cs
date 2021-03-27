using System;
using System.Collections.Generic;
/**
Name: Lucas Meier
Date of completion:N/A

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {   
            //main program calling inputs/outputs
            Console.WriteLine($"Welcome to MPLS Dog Boarding HR Payroll Report Program\nYou will be prompted to enter the Employee's Name, Department Number, Hourly Salary, and Number of Hours Worked");
            workingProgram();
            //Payroll_Report();
            Console.WriteLine("Thank you for using MPLS Dog Boarding HR Payroll Report Program.");
        }
        public static void workingProgram()
        {   
            //Declarations
            string[] DEPARTMENT_ARRAY = {"Personnel","Marketing","Information Technology","Computer Services","Sales","Legal","Accounting"};
            string Employee_Name;
            double Hourly_Salary, Number_Of_Hours_Worked, total_Gross_Salary;
            int Department_Number, primer;
            bool end = false;
            bool valid_Number = false;

            //Initialize the primer
            Console.WriteLine("To enter employee Payroll data press the 1 key [1] else to exit enter the 2 key [2].");
            primer = Convert.ToInt32(Console.ReadLine());

            //looping structure
            while(end != true)
            {
                //initializing declared variables
                if(primer == 1)
                {
                    //loop to initialize Department number and validate
                    while(valid_Number == false)
                   {
                        //input of user data for department
                        Console.WriteLine($"Please Enter the Employee's Department Number\n[1] for {DEPARTMENT_ARRAY[0]}\n[2] for {DEPARTMENT_ARRAY[1]}\n[3] for {DEPARTMENT_ARRAY[2]}\n[4] for {DEPARTMENT_ARRAY[3]}\n[5] for {DEPARTMENT_ARRAY[4]}\n[6] for {DEPARTMENT_ARRAY[5]}\n[7] for {DEPARTMENT_ARRAY[6]}");
                        Department_Number = Convert.ToInt32(Console.ReadLine());

                        //passing the number entered through a new validate expression
                        var validate = new Number_Validate();
                        int index = Department_Number - 1;

                        //to validate number using a try/catch against an array in Number_Validate class
                        try{
                            int value = validate.Department_Number_Validate(index);
                            Console.WriteLine($"{value} Is an accepted Department Number.");
                            valid_Number = true;
                        }
                        //invalid input catch
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine($"{e.GetType().Name}: {index} is an invalid Department Number, try again.");
                            valid_Number = false;
                        }
                    
                        Console.WriteLine("Please Enter the Employee's name");
                        Employee_Name = Console.ReadLine();     

                        Console.WriteLine("Please Enter the Employee's Hourly Salary");
                        Hourly_Salary = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please Enter the Employee's Number of Hours Worked");
                        Number_Of_Hours_Worked = Convert.ToInt32(Console.ReadLine());

                        //equation for total gross salary
                        total_Gross_Salary = Hourly_Salary*Number_Of_Hours_Worked;

                        //Decision logic for each department list
                        if(Department_Number == 1)
                        {
                            List<String> departmentPersonnel = new List<String>();
                            departmentPersonnel.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else if(Department_Number == 2)
                        {
                            List<String> departmentMarketing = new List<String>();
                            departmentMarketing.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else if(Department_Number == 3)
                        {
                            List<String> departmentInformation_Technology = new List<String>();
                            departmentInformation_Technology.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else if(Department_Number == 4)
                        {
                            List<String> departmentComputer_Services = new List<String>();
                            departmentComputer_Services.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else if(Department_Number == 5)
                        {
                            List<String> departmentSales = new List<String>();
                            departmentSales.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else if(Department_Number == 6)
                        {
                            List<String> departmentLegal = new List<String>();
                            departmentLegal.Add(Convert.ToString(total_Gross_Salary));
                        }
                        else
                        {
                            List<String> departmentAccounting = new List<String>();
                            departmentAccounting.Add(Convert.ToString(total_Gross_Salary));
                        }
                    }

                    //initializing the primer
                    Console.WriteLine("To enter employee Payroll data press the 1 key [1] else to exit enter the 2 key [2].");
                    primer = Convert.ToInt32(Console.ReadLine());
                    valid_Number = false;
                }
                else{
                    end = true;
                }
            }
        }
    }
}
