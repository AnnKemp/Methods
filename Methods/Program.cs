using System;

namespace Methods
{
    class Program
    {
        //Named arguments are especially useful when you have multiple parameters with default values, and you only want to specify one of them when you call it:
        static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }

        static void Main(string[] args)
        {
            MyMethod("child3");
        }

    }
}
