using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Singleton obj1 = Singleton.singleton;
            Singleton obj2 = Singleton.singleton;

            // インスタンスの比較
            if (obj1 == obj2)
            {
                Console.WriteLine("同一インスタンスです");
            }
            else
            {
                Console.WriteLine("別インスタンスです");
            }

            Console.WriteLine("End");
        }
    }
}
