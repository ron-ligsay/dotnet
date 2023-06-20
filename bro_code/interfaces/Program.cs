

using interfaces;

class Program
{
    static void Main(String[] args)
    {
        // Interface = a blueprint of a class. It tells the class what to do.
        // Interfaces are used to achieve polymorphism
        // Interfaces can contain events, methods, and properties
        // Interfaces CANNOT contain fields
        // Interfaces defines a contract. Anything that uses the interface MUST implement everything inside of it
        // Interfaces can't be instantiated
        // An Interface declares what something can do, but not how it does it
        // An Interface class defines how it should do  it
        // Benefit = security + multiple inheritance + "plug and play" = you can add new functionality without breaking existing code

        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();
        
    }

    // interface IPrey
    // {
    //     void Flee();
    // }
    // interface IPredator
    // {
    //     void Hunt();
    // }
    // class Hawk : IPredator
    // {
    //     public void Hunt()
    //     {
    //         Console.WriteLine("The hawk is hunting");
    //     }   
    // }
    // class Fish
    // {
    // }
}