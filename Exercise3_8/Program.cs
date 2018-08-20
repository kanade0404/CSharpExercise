using System;

namespace Exercise3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("中間試験の結果を入力してください(0〜100)：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("期末試験の結果を入力してください(0〜100)：");
            int y = int.Parse(Console.ReadLine());
            if((x >= 60 && y >= 60) || (x + y >= 130) || (x + y >= 130 && (x >= 90 || y >= 90))){
                Console.WriteLine("合格");
            }
            else{
                Console.WriteLine("不合格");
            }
        }
    }
}
