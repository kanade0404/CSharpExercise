using System;

namespace Exercise3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-12月を入力してください：");
            int x = int.Parse(Console.ReadLine());
            switch(x){
                case 1:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 3:
                    Console.WriteLine(31);
                    break;
                case 4:
                    Console.WriteLine(30);
                    break;
                case 5:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(30);
                    break;
                case 7:
                    Console.WriteLine(31);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                case 12:
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("入力が間違っています。");
                    break;
            }
        }
    }
}
