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

            //uses of replace
            Console.WriteLine(fullName.Replace("Csharp", "C#"));

            //string validation
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid input...1");
            }

            //putting space still unable to validate
            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid input...2");//couldn't able to show
            }
            //toValidate this:
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid input...3");
            }

            //string conversion
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            //float to string
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
