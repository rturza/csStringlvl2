using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStringlvl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Csharp Fundamentals ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim()); //removes extra spaces from text

            //removes spaces + makes Uppercase all texts
            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper()); 

        }
    }
}
