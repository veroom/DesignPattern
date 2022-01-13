
namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello!");

            // ()で括って文字を表示
            p.printWeak();

            // **で括って文字を表示
            p.printStrong();
        }
    }
}
