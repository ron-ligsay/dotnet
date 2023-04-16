// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            int Number = 1;
            const float Pi = 3.14f;
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Naming Conventions
            // Camel Case: firstName
            // Pascal Case: FirstName
            // Underscore: first_name
            // Hungarian Notation: strFirstName
            // For constant: Pascal Case - MaxZoom
            float number = 1.2f;
            decimal number2 = 1.2m;

            //Non-Primitive Types
            // String
            // Array
            // Enum
            // Class

            // Overflowing
            byte number3 = 255; //byte can only hold 0-255
            number3 = number3 + 1; // 0 because it overflows


        }
    }
}
    