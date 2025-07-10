using OOP_Assignment02.Classes;
using OOP_Assignment02.Enums;

namespace OOP_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //int size;
            //do
            //{
            //    Console.Write("Please enter the size of array: ");
            //} while (! int.TryParse(Console.ReadLine(), out size) || size < 0);
            //Employee[] employees = new Employee[size];
            //employees[0] = new Employee(1, "Eslam", 6600, Enums.Pivileges.DBA, new HireDate(10, 7, 2022), Gender.Male);
            //employees[1] = new Employee(2, "Ali", 5600, Enums.Pivileges.Guest, new HireDate(01, 05, 2020), Gender.Male);
            //employees[2] = new Employee(3, "Mariam", 4600, Enums.Pivileges.SecurityOfficer, new HireDate(05, 09, 2010), Gender.Female);

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(employees[i]);
            //}
            #endregion

            #region Anothor Sol with the user enter the data.
            Console.Write("Enter how many employees to create: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid. Enter a positive number: ");
            }

            Employee[] employees = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\n--- Enter Employee #{i + 1} Data ---");

                int id;
                do
                {
                    Console.Write("Enter Employee ID: ");
                } while (!int.TryParse(Console.ReadLine(), out id) || id < 0);


                string? name;
                do
                {
                    Console.Write("Enter Employee Name: ");
                    name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(name));


                decimal salary;
                do
                {
                    Console.Write("Enter Salary: ");
                } while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0);


                Console.WriteLine("Choose Security Level:");
                foreach (var item in Enum.GetValues(typeof(Pivileges)))
                {
                    Console.WriteLine($"{(int)item} - {item}");
                }
                Pivileges secLevel;
                while (!Enum.TryParse(Console.ReadLine(), out secLevel) || !Enum.IsDefined(typeof(Pivileges), secLevel))
                {
                    Console.Write("Invalid. Enter a valid number for Security Level: ");
                }

                Console.Write("Enter Gender (M/F): ");
                Gender gender;
                string? genderInput;
                do
                {
                    genderInput = Console.ReadLine().ToUpper();
                } while (genderInput != "M" && genderInput != "F");
                gender = genderInput == "M " ? Gender.Male : Gender.Female;


                int day, month, year;
                do
                {
                    Console.Write("Enter Hire Day (1-31): ");
                } while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31);

                do
                {
                    Console.Write("Enter Hire Month (1-12): ");
                } while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);

                do
                {
                    Console.Write("Enter Hire Year (e.g., 2022): ");
                } while (!int.TryParse(Console.ReadLine(), out year) || year < 1000 || year > DateTime.Now.Year);

                HireDate hireDate = new(day, month, year);
                employees[i] = new Employee(id, name, salary, secLevel, hireDate, gender);
            }
            Console.Clear();
            Console.WriteLine(">>> All Employees <<<");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion
        }
    }
 
}
