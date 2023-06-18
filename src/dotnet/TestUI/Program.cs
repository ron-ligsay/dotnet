internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Please enter your first name: ");
        string firstName;
        //  readline with exception
        
        firstName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName}!");
    }
}