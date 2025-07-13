using OOP_Assignment03.Classes;
using System;

namespace OOP_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
                {
                    new Student(10, "Eslam", "Eslam@gmail.com",2),
                    new Student(11, "Ahmed", "Ahmed@gmail.com",2),
                    new Teacher (5200,"Rana","Rana@gmail.com","OOP"),
                    new Teacher (5300,"Mira","Mira@gmail.com","DS"),
                    new AdminStaff(1350,"Ali","Ali@gmail.com","Secretary")
                };

            foreach (Person person in people)
            {

                Console.WriteLine(person.GetDetails());

            }

        }
    }
}