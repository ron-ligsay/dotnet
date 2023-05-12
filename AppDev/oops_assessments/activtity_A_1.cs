using System;

public class emp{
    public static int age = 40;
    public static int salary = 25000;

}

public class record : emp{
    new public static int salary = 50000;
    static void Main(string[] args) {
        Console.WriteLine(emp.age + " " + emp.salary + " " + salary);
    }
}