
using System;
using System.Collections.Generic;

namespace StudentAdmissionManagement
{
    class Student
    {
        
        private int studentId;
        private string studentName;
        private int age;
        private double marks;
        private string course;
        private double admissionFee;

     
        public Student(int id, string name, int age, double marks,
                       string course, double fee)
        {
            studentId = id;
            studentName = name;
            this.age = age;
            this.marks = marks;
            this.course = course;
            admissionFee = fee;
        }

    
        public int StudentId
        {
            get { return studentId; }
        }

  
        public void Display()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Student ID     : " + studentId);
            Console.WriteLine("Name           : " + studentName);
            Console.WriteLine("Age            : " + age);
            Console.WriteLine("Marks          : " + marks);
            Console.WriteLine("Course         : " + course);
            Console.WriteLine("Admission Fee  : $" + admissionFee);
        }

       
        public void ApplyScholarship()
        {
            if (marks >= 90)
            {
                admissionFee *= 0.75; //25% Discount
                Console.WriteLine("25% Scholarship Applied.");
            }
            else if (marks >= 80)
            {
                admissionFee *= 0.90; //10% Discount
                Console.WriteLine("10% Scholarship Applied.");
            }
            else
            {
                Console.WriteLine("No Scholarship.");
            }
        }

        
        public void UpdateCourse(string newCourse)
        {
            course = newCourse;
            Console.WriteLine("Course Updated Successfully.");
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== STUDENT ADMISSION MANAGEMENT =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Course");
                Console.WriteLine("5. Apply Scholarship");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        DisplayStudents();
                        break;

                    case 3:
                        SearchStudent();
                        break;

                    case 4:
                        UpdateCourse();
                        break;

                    case 5:
                        ApplyScholarship();
                        break;

                    case 6:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 6);
        }

        static void AddStudent()
        {
            Console.Write("Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Console.Write("Course: ");
            string course = Console.ReadLine();

            Console.Write("Admission Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(id, name, age, marks, course, fee);

            students.Add(s);

            Console.WriteLine("Student Added Successfully.");
        }

        static void DisplayStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No Student Records Found.");
                return;
            }

            foreach (Student s in students)
            {
                s.Display();
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.StudentId == id)
                {
                    s.Display();
                    return;
                }
            }

            Console.WriteLine("Student Not Found.");
        }

        static void UpdateCourse()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.StudentId == id)
                {
                    Console.Write("New Course: ");
                    string course = Console.ReadLine();

                    s.UpdateCourse(course);
                    return;
                }
            }

            Console.WriteLine("Student Not Found.");
        }

        static void ApplyScholarship()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.StudentId == id)
                {
                    s.ApplyScholarship();
                    return;
                }
            }

            Console.WriteLine("Student Not Found.");
        }
    }
}