using System;

public class AsusZenbook : Laptop
{
    public override void TurnOn()
    {
        Console.WriteLine("Asus Zenbook is turning on...");
        base.PowerOnSelfTest();
        this.BIOSROM();
        this.Bootloader();
        this.OSConfig();
        this.Security();

    }

    private void BIOSROM(){
        Console.WriteLine("BIOS ROM process...");
    }
    
    private void Bootloader(){
        Console.WriteLine("Bootloader phase process is happening...");
    }

    private void OSConfig(){
        Console.WriteLine("OS configuration phase is happening...");
    }

    private void Security(){
        Console.WriteLine("Security Logon phase is happening...");
    }


    // public override void TurnOff()
    // {
    //     Console.WriteLine("Asus Zenbook is turning off...");
    // }

    // public override void TurnOn(bool accessBIOS)
    // {
    //     if(accessBIOS){
    //         Console.WriteLine("Asus Zenbook is accessing BIOS...");
    //     } else {
    //         Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning on...");
    //     }
    // }

    // public override void TurnOff(bool accessBIOS)
    // {
    //     if(accessBIOS){
    //         Console.WriteLine("Asus Zenbook is accessing BIOS...");
    //     } else {
    //         Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning off...");
    //     }
    // }


    // public bool TouchScreen => true;

}


// public class AsusZenbook : Laptop
// {
//     public bool TouchScreen => true;

//     public void TurnOn(){
//         Console.WriteLine("Asus Zenbook is turning on...");
//     }

//     public void TurnOff(){
//         Console.WriteLine("Asus Zenbook is turning off...");
//     }

//     public void TurnOn(bool accessBIOS){
//         if(accessBIOS){
//             Console.WriteLine("Asus Zenbook is accessing BIOS...");
//         } else {
//             Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning on...");
//         }
//     }

//     public void TurnOff(bool accessBIOS){
//         if(accessBIOS){
//             Console.WriteLine("Asus Zenbook is accessing BIOS...");
//         } else {
//             Console.WriteLine("Asus Zenbook is NOT accessing BIOS, just turning off...");
//         }
//     }
// }

// public class AsusZenbook : Laptop
// {
//     public override bool TouchScreen => true;

//     public override void TurnOn(){
//         Console.WriteLine("Asus Zenbook is turning on...");
//     }
// }