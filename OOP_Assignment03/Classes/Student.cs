using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Classes
{
    internal class Student:Person
    {
        public Student(int _id, string _name, string _email,int _gradeLevel) : base(_id, _name, _email)
        {
            GradeLevel = _gradeLevel;
        }

        public int GradeLevel
        {
            get;set;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, GradeLevel: {GradeLevel}";
        }
    }
}
