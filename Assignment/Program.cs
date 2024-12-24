using System.ComponentModel;

namespace Assignment
{

    class Program
    {
        static void Main()
        {
            // part 01

            #region 1. Define a struct "Person" with properties "Name" and "Age".Create an array of three "Person" objects andpopulate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];
            //person[0] = new Person("Lotfy", 27);
            //person[1] = new Person("Nada", 23);
            //person[2] = new Person("Ahmed", 23);

            //foreach (var p in person)
            //{
            //    Console.WriteLine($"Name : {p.Name}  ,  Age : {p.Age} ");
            //}

            #endregion


            #region 2. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //do
            //{

            //    Console.Write("Please enter the point X1 : ");
            //    bool isX1Valid = double.TryParse(Console.ReadLine(), out double X1);

            //    Console.Write("Please enter the point Y1 : ");
            //    bool isY1Valid = double.TryParse(Console.ReadLine(), out double Y1);

            //    Console.Write("Please enter the point X2 : ");
            //    bool isX2Valid = double.TryParse(Console.ReadLine(), out double X2);

            //    Console.Write("Please enter the point Y2 : ");
            //    bool isY2Valid = double.TryParse(Console.ReadLine(), out double Y2);

            //    double x = X1 - X2;
            //    double y = Y1 - Y2;

            //    if (isX1Valid && isY1Valid && isX2Valid && isY2Valid)
            //    {
            //        Point p1 = new Point(X1, Y1);
            //        Point p2 = new Point(X2, Y2);   
            //        double distance = Point.CalculateDistance(p1, p2);

            //        Console.WriteLine($"The distance between the points is : {distance}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input invalid => Please enter valid double values. ");
            //        Console.WriteLine("**********************************************************");
            //        Console.WriteLine();
            //    }

            //} while (true);


            #endregion


            #region 3. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];
            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.Write($"Please enter the name of person {i + 1} : ");
            //    string name = Console.ReadLine();

            //    int age;
            //    while (true) 
            //    {
            //        Console.Write($"Please enter the age of person {i + 1}  : ");
            //        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //        {
            //            break; 
            //        }
            //        Console.WriteLine("Invalid age. Please enter a valid positive number.");
            //    }

            //    person[i] = new Person(name, age);
            //}

            //Person oldest = person[0];
            //for (int i = 1; i < person.Length; i++)
            //{
            //    if (person[i].Age > oldest.Age)
            //    {
            //        oldest = person[i];
            //    }

            //}

            //Console.WriteLine($"\nThe oldest person is {oldest.Name}, aged {oldest.Age}.");

            #endregion


            // part 02

            #region Quetion 01

            //try
            //{
            //    // Create an Employee instance
            //    Employee emp1 = new Employee(
            //        id: 101,
            //        name: "John Doe",
            //        securityLevel: SecurityLevel.Developer,
            //        salary: 75000.50m,
            //        hireDate: new DateTime(2020, 5, 15),
            //        gender: 'M'
            //    );

            //    Console.WriteLine(emp1);

            //    // Create another Employee instance
            //    Employee emp2 = new Employee(
            //        id: 102,
            //        name: "Jane Smith",
            //        securityLevel: SecurityLevel.Secretary,
            //        salary: 60000.75m,
            //        hireDate: new DateTime(2018, 3, 22),
            //        gender: 'F'
            //    );

            //    Console.WriteLine("\n" + emp2);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion


            #region Quetion 02



            #endregion


            #region Quetion 03



            #endregion


            #region Quetion 04



            #endregion
        }
    }
}
