using System;


public class AsusZenbook : Laptop
{
    public bool TouchScreen => true;

    public void TurnOn(){
        Console.WriteLine("Asus Zenbook is turning on...");
    }

    public void TurnOff(){
        Console.WriteLine("Asus Zenbook is turning off...");
    }
}

// public class AsusZenbook : Laptop
// {
//     public override bool TouchScreen => true;

//     public override void TurnOn(){
//         Console.WriteLine("Asus Zenbook is turning on...");
//     }
// }