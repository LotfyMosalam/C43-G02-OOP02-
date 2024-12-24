using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    // part 01

    #region 1. Define a struct "Person" with properties "Name" and "Age".Create an array of three "Person" objects andpopulate it with data. Then, write a C# program to display the details of all the persons in the array.

    //struct Person
    //{
    //    public string name;

    //    public int age;


    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }


    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }


    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //}

    #endregion


    #region 2. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

    //struct Point
    //{

    //    private double x;
    //    private double y;


    //    public double X
    //    {
    //        get { return x; }
    //        set { x = value; }
    //    }

    //    public double Y
    //    {
    //        get { return y; }
    //        set { y = value; }
    //    }


    //    public Point(double x, double y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }


    //    public static double CalculateDistance(Point p1, Point p2)
    //    {
    //        double dx = p2.X - p1.X;
    //        double dy = p2.Y - p1.Y;
    //        return Math.Sqrt(dx * dx + dy * dy);
    //    }

    //}

    #endregion


    #region 3. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

    //struct Person
    //{
    //    public string Name { get; set; }

    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //}

    #endregion

    // part 02
    
    #region  Question 01

    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public class Employee
    //{

    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public DateTime HireDate { get; set; }
    //    private char gender;

    //    public char Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == 'M' || value == 'F')
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' for Male or 'F' for Female.");
    //            }
    //        }
    //    }


    //    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }


    //    public override string ToString()
    //    {
    //        return $"Employee ID: {ID}\n" +
    //               $"Name: {Name}\n" +
    //               $"Security Level: {SecurityLevel}\n" +
    //               $"Salary: {String.Format("{0:C}", Salary)}\n" +
    //               $"Hire Date: {HireDate:MM/dd/yyyy}\n" +
    //               $"Gender: {(Gender == 'M' ? "Male" : "Female")}";
    //    }

    #endregion

    



}