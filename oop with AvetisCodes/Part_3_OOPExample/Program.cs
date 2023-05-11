using System;

namespace Part_3_OOPExample 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine(" ");
            //Laptop laptop = new Laptop();
            Laptop macbookAir = new MacbookAir();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();

            Console.WriteLine("Macbook Air has touch screen: " + macbookAir.TouchScreen);
            Console.WriteLine("Asus Zenbook has touch screen: " + asusZenbook.TouchScreen);

        }
    }

    // Reserved Key Words
    public class A 
    {
        
    }

    public abstract class B 
    {

    }

    public interface C 
    {

    }
}