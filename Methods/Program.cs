﻿using System;

namespace Methods
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }

    }
}
