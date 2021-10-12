using System;

namespace Methods
{
    class Program
    {
        static void MyMethod(string fname)  // always write het method-name with a capital letter at the start!
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main(string[] args)
        {
           // calling MyMethod from the Main method 
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }
    }
}
