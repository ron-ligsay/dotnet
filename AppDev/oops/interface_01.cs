// multiple line comments
/* 
in here I can write as many comments as I want it to be.
 */



using Systems;
namespace oops {
    // interface
    public interface xyz{
        void methodA();
        void methodB();

    }
    // interface method implementation
    class test: xyz{
        public void methodA(){
            Console.WriteLine("This is the method A");
        }
        public void methodB(){
            Console.WriteLine("This is the method B");
        }
    }
    class interfaceDemo{
        static void Main(string[] args){
            
            test obj = new test();
            obj.methodA();
            obj.methodB();

            //new test().methodA();
            //new test().methodB();
            //Console.ReadKey();
        }
    }
}