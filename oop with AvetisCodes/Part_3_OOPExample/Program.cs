using System;
using System.Collections.Generic;   
namespace Part_3_OOPExample 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Creator programmer = new Programmer();
            // Creator youtuber = new Youtuber();

            // Console.WriteLine("--- Programmer ---");
            // Console.WriteLine();
            // programmer.Create();

            // Console.WriteLine("--- Youtuber ---");
            // Console.WriteLine();
            // youtuber.Create();

            List<Creator> creators = new List<Creator>() {new Programmer(),new Youtuber()};
            foreach(var creator in creators){
                Console.WriteLine(creator.GetType().Name);
                Console.WriteLine();
                creator.Create();
            }


            //Console.WriteLine(" ");
            //Laptop laptop = new Laptop();
            //Laptop macbookAir = new MacbookAir();
            //Laptop asusZenbook = new AsusZenbook();

            //List<Laptop> laptops = new List<Laptop>() {new MacbookAir(),new AsusZenbook()};

            // foreach(var laptop in laptops){
            //     laptop.TurnOn();
            //     //laptop.TurnOn(true);
            //     //laptop.TurnOff();
            // }

            //macbookAir.TurnOn();
            //asusZenbook.TurnOn();

            //Laptop macbookAir2 = new MacbookAir();
            //macbookAir2.TurnOn();   

            //Console.WriteLine("Macbook Air has touch screen: " + macbookAir.TouchScreen);
            //Console.WriteLine("Asus Zenbook has touch screen: " + asusZenbook.TouchScreen);

            //testClass test = new testClass("test");
            //Console.WriteLine("test: " + test.someProperty);
        }
    }
    // Reserved Key Words
    public class A {}
    public abstract class B {}
    public interface C {}
}