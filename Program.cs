using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SET_OPERATORS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Set_Operation_With_Class.EmployMain emp =
                new Set_Operation_With_Class.EmployMain();

            emp.Union();
            emp.Intersect();
            emp.Except();
            emp.Distinct();
        }
    }
}
