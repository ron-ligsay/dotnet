using System;
namespace oops{
    //abstract class
    public abstract class Employees
    {
        //abstract method with no implementation
        public abstract void displayData();
    }

    //derived class
    public class test: Employees
    {
        //abstract class method implementation
        public override void displayData()
        {
            Console.WriteLine("This is the derived class method");
        }
        class abstractClass
        {
            static void Main(string[] args) {
                //class instance
                new test().displayData();
                Console.ReadKey();
            }
        }
    }
}


// namespace oops{
//     sealed class SealedClass
//     {
//         void myfunv();

//     }

//     public class test: SealedClass //wrong. will give compilation error
//     {

//     }
// }