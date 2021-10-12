using System;

namespace Methods
{
    class Program
    { // with default value "Norway"
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }

    }
}
