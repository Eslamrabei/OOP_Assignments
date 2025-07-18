using OOP_Assignment04.Classes;
using OOP_Assignment04.Interfaces;

namespace OOP_Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:What is the primary purpose of an interface in C#? 
            // b) To define a blueprint for a class
            #endregion
            #region Q2:Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            #endregion
            #region Q3:Can an interface contain fields in C#?
            // b) No
            #endregion
            #region Q4:In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5:Which keyword is used to implement an interface in a class in C#?
            // d) implements
            #endregion
            #region Q6:Can an interface contain static methods in C#?
            //a) Yes
            #endregion
            #region Q7:In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public  
            #endregion
            #region Q8: What is the purpose of an explicit interface implementation in C#? 
            //a) To hide the interface members from outside access
            #endregion
            #region Q9:In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion
            #region Q10:How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(10.5m, 1.3m);
            rectangle.DisplayShapeInfo();



        }
    }
}
