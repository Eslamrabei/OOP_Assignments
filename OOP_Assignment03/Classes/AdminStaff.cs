using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Classes
{
    internal class AdminStaff:Person
    {

        public AdminStaff(int _id, string _name, string _email, string _role) : base(_id, _name, _email)
        {
            Role = _role;
        }

        public string Role { get; set; }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Role: {Role}";
        }
    }
}
