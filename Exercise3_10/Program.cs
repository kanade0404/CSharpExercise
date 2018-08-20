using System;

namespace Exercise3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("数値を入力してください：");
            int y = int.Parse(Console.ReadLine());
            if(x < y && x % 2 == 0 && y % 2 == 0){
                Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
            }
            if(x == y && x < 0 && y < 0){
                Console.WriteLine("xとyは等しく、かつ、負の数である。");
            }
            if(x < y || x % 2 == 0){
                Console.WriteLine("xはyより小さい、または、xは偶数である。");
            }
            if((x <= 10 || x >= 100) && y >= 10 && y <= 100){
                Console.WriteLine("xは10以下または100以上で、かつ、yは10以上100以下である。");
            }
            if((x > 0 && y > 0) || (x < 0 && y < 0)){
                Console.WriteLine("xもyも負の数である、ではない。");
            }
        }
    }
}
