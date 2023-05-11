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

    public void TurnOn(bool accessBIOS){
        if(accessBIOS){
            Console.WriteLine("Asus Zenbook is accessing BIOS...");
        } else {
            Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning on...");
        }
    }

    public void TurnOff(bool accessBIOS){
        if(accessBIOS){
            Console.WriteLine("Asus Zenbook is accessing BIOS...");
        } else {
            Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning off...");
        }
    }
}

// public class AsusZenbook : Laptop
// {
//     public override bool TouchScreen => true;

//     public override void TurnOn(){
//         Console.WriteLine("Asus Zenbook is turning on...");
//     }
// }