using System;

namespace Exercise2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("任意の数字を入力してください：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("任意の数字を入力してください：");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("x + y = {0}", x + y);
            Console.WriteLine("x - y = {0}", x - y);
            Console.WriteLine("x * y = {0}", x * y);
            Console.WriteLine("x / y = {0}", x / y);
            Console.WriteLine("x % y = {0}", x % y);
        }
    }
}
