using System;

namespace Exercise2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("あなたの年齢を教えてください：");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("生まれてから現在までの日数：約{0}日", age * 365);
        }
    }
}
