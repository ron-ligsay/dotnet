public class TestData{
    public int Add(int a, int b, int c)
    {
        return a+b+c;
    }
    public int Add(int a, int b)
    {
        return a+b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestData obj = new TestData();
        Console.WriteLine(obj.Add(1,2));
        Console.WriteLine(obj.Add(1,2,3));
    }
}