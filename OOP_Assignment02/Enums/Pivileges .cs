using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment02.Enums
{
    #region Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    [Flags]
    internal enum Pivileges
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        SecurityOfficer = Guest | Developer | Secretary | DBA
    }
    #endregion
}
