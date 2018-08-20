using System;

namespace Exercise2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("任意の数字を入力してください：");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine(x * x);
            Console.WriteLine(x * x * x);
        }
    }
}
