using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Classes
{
    internal class Person
    {
        private int id;
        private string name;
        private string email;

        public Person(int _id, string _name, string _email)
        {
            id = _id;
            name = _name;
            email = _email;
        }

        public int Id
        {
            get
            {
                if(id > 0)
                {
                    return id;
                }
                return 0;
            }
            set
            {
                if (value > 0)
                    id = value;
                else
                    return;
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
                return $"Error in Name field.";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
               
            }
        }

        public string Email
        {
            get
            {
                if (!string.IsNullOrEmpty(email))
                {
                    return email;
                }
                return $"Error in email Field";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
            }

        }


        public virtual string GetDetails()
        {
           return $"Id:{id}, Name:{name}, Email:{email}";
        }

    }
}
