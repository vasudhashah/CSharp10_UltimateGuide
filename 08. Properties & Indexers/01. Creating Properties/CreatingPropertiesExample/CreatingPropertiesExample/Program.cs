﻿class Program
{
    static void Main()
    {
        Employee emp1 = new Employee();
        emp1.EmpID = 110;
        emp1.EmpName = "Scott";
        emp1.Job = "Manager";

        //display fields
        System.Console.WriteLine(Employee.CompanyName);
        System.Console.WriteLine("\nFirst employee:");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Job);
        System.Console.ReadKey();
    }
}