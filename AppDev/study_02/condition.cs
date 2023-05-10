using System;
namespace Studytonight {
    public class Program {
        public static void Main (String[] args) {
            int i = 100;
            if ( i > 0) {
                Console.WriteLine("Given number is positive!");
            }
            else  if (i < 0) {
                Console.WriteLine("Given number is negative!");
            }
            else {
                Console.WriteLine("Given number is neither positive nor negative!");
            }
            Console.ReadKey();
        }
    }
}