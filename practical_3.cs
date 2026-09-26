using System;
using System.Collections.Generic;

namespace ExpenseTrackingModule
{

    class Expense
    {

        public string Category { get; set; }


        public decimal Amount { get; set; }


        public DateTime Date { get; set; }


        public Expense(string category, decimal amount)
        {
            Category = category;
            Amount = amount;
            Date = DateTime.Now;
        }
    }

    class Program
    {

        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\n===== Expense Tracking System =====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Expenses");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        AddExpense();
                        break;

                    case "2":
                        ViewExpenses();
                        break;

                    case "3":
                        ShowTotalExpenses();
                        break;

                    case "4":
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }


        static void AddExpense()
        {
            try
            {

                Console.Write("Enter Category: ");
                string category = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(category))
                    throw new Exception("Category cannot be empty.");


                Console.Write("Enter Amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());


                if (amount <= 0)
                    throw new Exception("Amount must be greater than zero.");


                expenses.Add(new Expense(category, amount));

                Console.WriteLine("Expense added successfully.");
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid amount. Please enter a numeric value.");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Amount entered is too large.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        static void ViewExpenses()
        {

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
                return;
            }


            Console.WriteLine("\nCategory\tAmount\t\tDate");


            foreach (Expense exp in expenses)
            {
                Console.WriteLine(
                    $"{exp.Category}\t\t{exp.Amount:C}\t{exp.Date}"
                );
            }
        }


        static void ShowTotalExpenses()
        {
            decimal total = 0;


            foreach (Expense exp in expenses)
            {
                total += exp.Amount;
            }


            Console.WriteLine($"Total Expenses: {total:C}");
        }
    }
}
