using System;
using System.Collections.Generic;


interface IPayable
{
    double CalculateSalary();
}

abstract class Employee : IPayable
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculateSalary();

    public virtual void Display()
    {
        Console.WriteLine($"Employee ID : {Id}");
        Console.WriteLine($"Employee Name : {Name}");
    }
}


class FullTimeEmployee : Employee
{
    public double MonthlySalary { get; set; }
    public double Bonus { get; set; }

    public FullTimeEmployee(int id, string name, double salary, double bonus)
        : base(id, name)
    {
        MonthlySalary = salary;
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary + Bonus;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Full Time");
        Console.WriteLine($"Net Salary : {CalculateSalary()}");
        Console.WriteLine();
    }
}


class PartTimeEmployee : Employee
{
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name)
    {
        HoursWorked = hours;
        HourlyRate = rate;
    }

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Part Time");
        Console.WriteLine($"Net Salary : {CalculateSalary()}");
        Console.WriteLine();
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new FullTimeEmployee(101, "Ravi", 50000, 5000));
        employees.Add(new PartTimeEmployee(102, "Anita", 120, 300));
        employees.Add(new FullTimeEmployee(103, "Amit", 60000, 7000));
        employees.Add(new PartTimeEmployee(104, "Ranjan", 100, 250));

        Console.WriteLine("====== Employee Payroll System ======\n");

        foreach (Employee emp in employees)
        {
            emp.Display();  
        }

        Console.ReadKey();
    }
}