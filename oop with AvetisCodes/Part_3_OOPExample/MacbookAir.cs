public class MacbookAir : Laptop
{
    public bool TouchScreen => false;

    public void TurnOn(){
        Console.WriteLine("Macbook Air is turning on...");
    }

    public void TurnOff(){
        Console.WriteLine("Macbook Air is turning off...");
    }

    public void TurnOn(bool accessBIOS)
    {
        if(accessBIOS){
            Console.WriteLine("Macbook Air is accessing BIOS...");
        } else {
            Console.WriteLine("Macbook Air is NOT accessing BIOS, just turning off...");
        }
    }

    public void TurnOff(bool accessBIOS)
    {
        throw new NotImplementedException();
    }
}


// public class MacbookAir : Laptop
// {
//     public override bool TouchScreen => false;
// }