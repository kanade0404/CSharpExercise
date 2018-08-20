using System;

namespace Exercise3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください(0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜)：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("時間帯を入力してください(0=午前、1=午後、2=夜間)：");
            int y = int.Parse(Console.ReadLine());
            bool chk = true;
            if(x == 0){
                chk = false;
            }
            if(y == 0 && (x == 2 || x == 5)){
                chk = false;
            }
            if(y == 1 && x == 6){
                chk = false;
            }
            if(y == 2 && (x == 3 || x == 6)){
                chk = false;
            }
            if(chk){
                Console.WriteLine("開いています");
            }
            else{
                Console.WriteLine("休診");
            }
        }
    }
}
