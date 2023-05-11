using System;

public abstract class Laptop
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Laptop is turning on...");
    }

    public  void TurnOff()
    {
        Console.WriteLine("Laptop is turning off...");
    }

    public abstract bool TouchScreen { get; }
}