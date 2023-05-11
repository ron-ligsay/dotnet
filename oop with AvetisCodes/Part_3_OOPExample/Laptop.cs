using System;


public abstract class Laptop
{
    public abstract void TurnOn();

    protected void PowerOnSelfTest(){
        Console.WriteLine("Checking processors...");
        Console.WriteLine("Checking system memory...");
        Console.WriteLine("Checking network...");
        Console.WriteLine("Checking USB...");
        Console.WriteLine("Checking Bluetooth...");
    }

    // public abstract void TurnOff();

    // public abstract void TurnOn(bool accessBIOS);

    // public abstract void TurnOff(bool accessBIOS);

    // public abstract bool TouchScreen { get; }
}


// public interface Laptop
// {
//     void TurnOn()
//     {
//         Console.WriteLine("Laptop is turning on...");
//     }

//     void TurnOn (bool accessBIOS);

//     void TurnOff()
//     {
//         Console.WriteLine("Laptop is turning off...");
//     }

//     void TurnOff (bool accessBIOS);

//     bool TouchScreen { get; }
// }
