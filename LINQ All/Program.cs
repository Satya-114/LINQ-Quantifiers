using System;
using System.Linq;

namespace LINQ_All1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            bool MSResult = Student.GetAllStudnets().All(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSResult = (from std in Student.GetAllStudnets()
                             select std).All(std => std.TotalMarks > 250);
            Console.WriteLine(MSResult);
            Console.ReadKey();
        }
    }
}
