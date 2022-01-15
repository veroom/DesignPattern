using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // 表示文字'H'のインスタンス
            AbstractDisplaycs charDisplay = new CharDisplay('H');

            // 表示文字列"Hello,World"のインスタンス
            AbstractDisplaycs strDisplay = new StringDisplay("Hello,World");

            // 文字表示
            charDisplay.Display();

            Console.WriteLine("\r\n" + "=====================================" + "\r\n");

            // 文字列表示
            strDisplay.Display();
        }
    }
}
