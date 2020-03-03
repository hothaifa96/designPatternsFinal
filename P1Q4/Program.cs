using System;
using System.Collections.Generic;

namespace P1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesList empList = new EmployeesList();
            if (empList!=null)
            {


                foreach (Employee emp in empList)
                {
                    Console.WriteLine(emp.Id + "   " + emp.Name + "   " + emp.Age + "   " + emp.Salary);
                }
            }
        }
       
    }
}