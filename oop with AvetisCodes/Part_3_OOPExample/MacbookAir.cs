using System;

public class MacbookAir : Laptop
{

      public override void TurnOn()
    {
        this.PowerOnSelfTest();
        this.BootROMLoaded();
        this.BootROMRunning();
        this.FindBooterFile();
        this.LoadKernel();
        Console.WriteLine("Macbook Air is turning on...");
    }

     private void BootROMLoaded(){
        Console.WriteLine("BootROM Loaded...");
    }
    
    private void BootROMRunning(){
        Console.WriteLine("BootROM running...");
    }

    private void FindBooterFile(){
        Console.WriteLine("Finding booter file...");
    }

    private void LoadKernel(){
        Console.WriteLine("Booter loads the Kernel...");
    }

    // public override void TurnOff()
    // {
    //       Console.WriteLine("Macbook Air is turning off...");
    // }

    // public override void TurnOn(bool accessBIOS)
    // {
    //    if(accessBIOS){
    //         Console.WriteLine("Macbook Air is accessing BIOS...");
    //     } else {
    //         Console.WriteLine("Macbook Air is NOT accessing BIOS, just turning on...");
    //     }
    // }

    // public override void TurnOff(bool accessBIOS)
    // {
    //     if(accessBIOS){
    //         Console.WriteLine("Macbook Air is accessing BIOS...");
    //     } else {
    //         Console.WriteLine("Macbook Air is NOT accessing BIOS, just turning off...");
    //     }
    // }

    // public bool TouchScreen => false;

    
}


// public class MacbookAir : Laptop
// {
//     public override bool TouchScreen => false;
// }