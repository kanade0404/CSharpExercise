using System;

namespace Exercise3_2
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
                Console.WriteLine(x);
            }
            else{
                Console.WriteLine(y);
            }
        }
    }
}
