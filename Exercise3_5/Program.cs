using System;

namespace Exercise3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0){
                Console.WriteLine("偶数");
            }
            else{
                Console.WriteLine("奇数");
            }
        }
    }
}
