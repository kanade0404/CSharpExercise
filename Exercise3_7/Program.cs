using System;

namespace Exercise3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください(0〜10)：");
            int x = int.Parse(Console.ReadLine());
            if(x >= 60){
                Console.WriteLine("合格");
            }
            else{
                Console.WriteLine("不合格");
            }
            if(x >= 80){
                Console.WriteLine("大変よくできました。");
            }
            else if(x >= 60 && x < 80){
                Console.WriteLine("よくできました。");
            }
            else{
                Console.WriteLine("残念でした。");
            }
            if(x >= 80){
                Console.WriteLine("優");
            }
            else if(x >= 70 && x < 80){
                Console.WriteLine("良");
            }
            else if(x >= 60 && x < 70){
                Console.WriteLine("可");
            }
            else{
                Console.WriteLine("不可");
            }
        }
    }
}
