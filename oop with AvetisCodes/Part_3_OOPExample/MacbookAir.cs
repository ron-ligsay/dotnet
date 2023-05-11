public class MacbookAir : Laptop
{
    public bool TouchScreen => false;

    public void TurnOn(){
        Console.WriteLine("Macbook Air is turning on...");
    }

    public void TurnOff(){
        Console.WriteLine("Macbook Air is turning off...");
    }

}


// public class MacbookAir : Laptop
// {
//     public override bool TouchScreen => false;
// }