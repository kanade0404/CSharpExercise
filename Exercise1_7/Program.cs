using System;

namespace Exercise1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;

            int z = x;
            x = y;
            y = z;
            Console.WriteLine("x={0},y={1}", x, y);
        }
    }
}
