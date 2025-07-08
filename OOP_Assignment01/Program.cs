using OOP_Assignment01.Enums;
using  OOP_Assignment01.Structs;
using System.Text.RegularExpressions;
namespace OOP_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays wd in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine($"{wd} :{(int)wd +1}");
            //}

            #endregion
            #region Q2:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] Array1 = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    do
            //    {

            //        Console.Write("Pleas enter your name: ");
            //        Array1[i].Name = Console.ReadLine() ?? string.Empty;         

            //    } while (string.IsNullOrEmpty(Array1[i].Name));
            //    do
            //    {
            //        Console.Write("Pleas enter your age: ");

            //    } while (!int.TryParse(Console.ReadLine(), out Array1[i].Age) || Array1[i].Age <= 0);

            //}
            //foreach (var i in Array1)
            //{
            //    Console.WriteLine($"My Name is : {i.Name.ToUpper()}, I'm {i.Age} years");
            //}
            #endregion
            #region Q3:Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Please Enter a season name [Spring-Summer-Autumn-Winter]: ");
            //if (Enum.TryParse(Console.ReadLine(), true, out Season season))
            //{
            //    string msg = season switch
            //    {
            //        Season.Spring => "March to May",
            //        Season.Summer => "June to August",
            //        Season.Autumn => "September to November",
            //        Season.Winter => "December to February",
            //        _ => "Enter a valid season!"
            //    };

            //    Console.WriteLine(msg);
            //}
            //else
            //{
            //    Console.WriteLine("Enter a valid name");
            //}
            #endregion
            #region Q4:Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions AddAndDeletePermission = Permissions.write | Permissions.Delete;
            //if ((AddAndDeletePermission & Permissions.write) == Permissions.write ||
            //    (AddAndDeletePermission & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("You have the permision");
            //}
            //else
            //{
            //    Console.WriteLine("You don't have the permision to do that.");
            //}

            #endregion
            #region Q5:Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not
            //Console.WriteLine("Please Enter a color name: ");
            //if (Enum.TryParse(Console.ReadLine(), true, out Colors colorName))
            //{
            //    if (colorName.Equals(Colors.Green) || colorName.Equals(Colors.Red) || colorName.Equals(Colors.Blue))
            //    {
            //        Console.WriteLine($"The Color {colorName} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The Color {colorName} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a valid color");
            //}



            #endregion
            #region Q6:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point point1 = new();
            //Point point2 = new();
            //do
            //{
            //    Console.Write("Enter the p1.x: ");
            //} while (! double.TryParse(Console.ReadLine(), out point1.X));
            //do
            //{
            //    Console.Write("Enter the p1.y: ");
            //} while (! double.TryParse(Console.ReadLine(), out point1.Y));
            //do
            //{
            //    Console.Write("Enter the p2.x: ");
            //} while (! double.TryParse(Console.ReadLine(), out point2.X));
            //do
            //{
            //    Console.Write("Enter the p2.y: ");
            //} while (! double.TryParse(Console.ReadLine(), out point2.Y));
            //double Distance =Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2)) ;
            //Console.WriteLine($"The Distance between two points = {Distance}");
            #endregion
            #region Q7:Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //int CountPersons = 3;
            //Person[] person = new Person[CountPersons];
            //for (int i = 0; i < CountPersons; i++)
            //{
            //    do
            //    {

            //        Console.Write("Pleas enter your name: ");
            //        person[i].Name = Console.ReadLine() ?? string.Empty;

            //    } while (string.IsNullOrEmpty(person[i].Name));
            //    do
            //    {
            //        Console.Write("Pleas enter your age: ");

            //    } while (!int.TryParse(Console.ReadLine(), out person[i].Age) || person[i].Age <= 0 || person[i].Age >= 110);

            //}
            //Person OldPerson = person[0];
            //for (int i = 0; i < CountPersons; i++)
            //{
            //    if (person[i].Age > OldPerson.Age)
            //    {
            //        OldPerson = person[i];
            //    }

            //}

            //Console.WriteLine($"The oldest person is {OldPerson.Name} and the age is: {OldPerson.Age}");



            #endregion
        }
    }
}
