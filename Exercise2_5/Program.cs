using System;

namespace Exercise2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("任意の数字を入力してください：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("任意の数字を入力してください：");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine((x + y) / 2);
        }
    }
}
