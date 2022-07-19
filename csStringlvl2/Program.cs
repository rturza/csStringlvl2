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

            //uses of index
            Console.WriteLine();
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //uses of split
            Console.WriteLine();
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
        }
    }
}
