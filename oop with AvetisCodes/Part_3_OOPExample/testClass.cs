using System;

public interface testClass 
{
    string someProperty {get; set;}

    // public testClass(String someProperty)
    // {
    //     this.someProperty = someProperty;
    // }

    void someMethod()
    {
        Console.WriteLine("someMethod");
    }
}

public interface testClass2
{
    string someProperty {get; set;}

    void something();
}


public class testClassChild //: testClass
{
    //public string _prop;
    //public string someProperty {get =>  _prop; set => _prop=value;}
    // public string someOtherProperty {get; set;}

    // public testClassChild(String someProperty, string someOtherProperty) : base(someProperty)
    // {
    //     // this.someOtherProperty = someOtherProperty;
    //     // base.someProperty = someProperty;
    // }

    public void someMethod()
    {
        Console.WriteLine("someMethod");
    }

}