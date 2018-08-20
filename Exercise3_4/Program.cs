using System;

namespace Exercise3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("数値を入力してください：");
            int y = int.Parse(Console.ReadLine());
            if(x > y){
                Console.WriteLine("xはyより大きい");
            }
            else if(y > x){
                Console.WriteLine("yはxより大きい");
            }
            else{
                Console.WriteLine("xとyは等しい");
            }
        }
    }
}
