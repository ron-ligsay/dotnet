using System;

public interface Laptop
{
    void TurnOn()
    {
        Console.WriteLine("Laptop is turning on...");
    }

    void TurnOff()
    {
        Console.WriteLine("Laptop is turning off...");
    }

    bool TouchScreen { get; }
}


// public abstract class Laptop
// {
//     public virtual void TurnOn()
//     {
//         Console.WriteLine("Laptop is turning on...");
//     }

//     public  void TurnOff()
//     {
//         Console.WriteLine("Laptop is turning off...");
//     }

//     public abstract bool TouchScreen { get; }
// }