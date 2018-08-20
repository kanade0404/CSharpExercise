using System;

namespace Exercise3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            int x = int.Parse(Console.ReadLine());
            if(x >= 0){
                if(x % 2 == 0){
                    Console.WriteLine("正の偶数");
                }
                else{
                    Console.WriteLine("正の奇数");
                }
            }
            else{
                if(x % 2 == 0){
                    Console.WriteLine("負の偶数");
                }
                else{
                    Console.WriteLine("負の奇数");
                }
            }
        }
    }
}
