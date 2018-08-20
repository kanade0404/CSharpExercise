using System;

namespace Exercise3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("好きなキャラクターを選んでください。");
            Console.Write("0=電、1=雷、2=響、3=暁");
            int ship = int.Parse(Console.ReadLine());
            switch(ship){
                case 0:
                    Console.WriteLine("電");
                    break;
                case 1:
                    Console.WriteLine("雷");
                    break;
                case 2:
                    Console.WriteLine("響");
                    break;
                case 3:
                    Console.WriteLine("暁");
                    break;
                default:
                    break;
            }
        }
    }
}
