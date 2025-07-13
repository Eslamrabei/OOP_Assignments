using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Classes
{
    internal class Teacher:Person
    {
        public Teacher(int _id, string _name, string _email,string _subject) : base(_id, _name, _email)
        {
            Subjects = _subject;
        }

        public string Subjects { get; set; }

        public override string GetDetails()
        {
            return $"{base.GetDetails()} , Subject: {Subjects}";
        }
    }
}
