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
            byte b1 = 1;
            int i = b1;
            Console.WriteLine(Number + Pi + i);

            // Naming Conventions
            // Camel Case: firstName
            // Pascal Case: FirstName
            // Underscore: first_name
            // Hungarian Notation: strFirstName
            // For constant: Pascal Case - MaxZoom
            float number = 1.2f;
            decimal number2 = 1.2m;
            Console.WriteLine("Floath {0}, Decimal {1}", number, number2);
            //Non-Primitive Types
            // String
            // Array
            // Enum
            // Class

            // Overflowing
            //byte number3 = 255; //byte can only hold 0-255
            //number3 = number3 + 1; // 0 because it overflows

            // Using Checked
            checked // Like try catch or exception
            {
                //byte number4 = 255;
                //number4 = (byte)(number4 + 1);
            } // will not happen

            // Scope
            {
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                        // a = 1 is accesible anywhere in the code block
                        // b = 2 is accesible anywhere inside a 
                        // c = 3 is accesible only here
                        Console.WriteLine("{0} {1} {2}", a, b, c);
                    }
                }
            }

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            byte MinValue = 0;
            byte MaxValue = 255;
            Console.WriteLine("{0} {1}", MinValue, MaxValue);


            byte number5 = 1;
            int count = 10;
            float totalPrice = 20.93f;
            char character = 'A';
            String firstName = "Mosh";
            bool isWorking = false;

            Console.WriteLine(number5);
            System.Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            
        }
    }
}
    