using System;

namespace Adapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello!");

            // ()で括って文字を表示
            p.printWeek();

            // **で括って文字を表示
            p.printStrong();
        }
    }
}
