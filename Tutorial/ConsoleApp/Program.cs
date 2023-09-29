using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            // プロンプトでユーザーが入力した文字列を取得
            var name = Console.ReadLine();
            // 現在時刻を取得
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            // ユーザーによる任意キーの入力でプログラムを終了
            Console.ReadKey(true);
        }
    }
}