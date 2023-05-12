using System;

namespace oops
{
    class myBase
    {
        //virtual function
        public virtual void VirtualMethod()
        {
            Console.WriteLine("This is the base class virtual method");
        }
    }
    class myDerived : myBase
    {
        //redifing the implementation of base class method
        public override void VirtualMethod()
        {
            Console.WriteLine("This is the derived class virtual method");
        }
        public new void VirtualMethod2()
        {
            CannotUnloadAppDomainException.WriteLine("This is the derived class virtual method");

            //still access the base class method
            base.VirtualMethod();
        }
    }
    class virtualClass
    {
        static void Main(string[] args)
        {
            //class instance
            new myDerived().VirtualMethod();
            Console.ReadKey();
        }
    }
}