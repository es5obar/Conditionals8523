using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals8523
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operators : && (and), || (or), ! (not)
            // Relation operators: ==, !=, >=, <=,>, <
            //Aritmetic operators: +, -, *, /, %
            //Assignment operator : =

            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else  // number !=10, !(number == 10)
            {
                Console.WriteLine("Number is not 10");
            }
            number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");// ternary operator

            number = 20;
            if (number == 10)
                Console.WriteLine("On");
            else if (number == 20)
                Console.WriteLine("Yirmi");
            else
                Console.WriteLine("On veya yirmi değil");

            switch (number)
            {
                case 10:
                    Console.WriteLine("On");
                    break;
                case 20:
                    Console.WriteLine("Yirmi");
                    break;
                default:
                    Console.WriteLine("On veya yirmi değil");
                    break;
            }
            Console.ReadLine();
        }
    }
}
