using System;

//ref link:https://www.youtube.com/watch?v=gXIesHqhY44&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=7
//

class Base { }
class Derived1 : Base { }
class Derived2 : Base { }
class Cow
{   //convertion operator
    public static implicit operator Derived1(Cow cow)
    {
        return null;
    }
}

class MainClass
{
    static void Main()
    {
        //var myInstance = new { FirstName = "Kulpot", LastName = "King" };
        //var yourInstance = new { FirstName = "Awesome", LastName = "Viewer" };

        //var myArray = new[] { myInstance , yourInstance };

        //int[] myInts = new[] { 1, 2, 3, 4, 5 };
        //var myInts = new[] { 1, 2, 3.0, 4, 5 };
        //var myInts = new[] { 1, 2, 'g', 4, 5 };
        var myArray = new[] { new Derived1(), new Base(), new Derived2(), new Cow() };
        //Console.WriteLine(myInts.GetType());
        Console.WriteLine(myArray.GetType());
    }
}