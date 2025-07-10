using OOP_Assignment02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment02.Classes
{
    #region Employee is identified by an ID, Name, security level, salary, hire date and Gender.
    internal class Employee
    {
        int id;
        string name;
        Pivileges securityLevel;
        decimal salary;
        HireDate hireDate;
        Gender gender;


        public Employee(int _id, string _name, decimal _salary, Pivileges _securityLevel, HireDate _hireDate, Gender _gender)
        {
            id = _id;
            name = _name;
            salary = _salary;
            securityLevel = _securityLevel;
            hireDate = _hireDate;
            gender = _gender;
        }

        public int ID
        {
            get
            {
                if (id >= 0 && id < int.MaxValue) return id;
                return 0;
            }
            set
            {
                if (value >= 0 && value < int.MaxValue)
                    id = value;
            }
        }
        public string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
                return $"Error name input: ";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public Pivileges SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public HireDate HireDate
        {
            get { return hireDate; }
            set
            {
                if (value != null)
                {
                    hireDate = value;
                }
                else
                {
                    throw new ArgumentException("HireDate cannot be null.");
                }
            }
        }


        #region We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
        public override string ToString()
        {
            return $"Hello, {name}\nYour ID: {id}\nYour role is: {securityLevel}\nYour Salary= {string.Format("{0:c2}", salary)}\nYour Gender is: {gender}\nYou hired at: {hireDate}\n ";
        }
        #endregion
    } 
    #endregion
}
