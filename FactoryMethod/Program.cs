using FactoryMethod.framework;
using FactoryMethod.idcard;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Console.WriteLine("=======Create=======");
            Product cardOne = factory.Create("Bob");
            Product cardTwo = factory.Create("Mike");
            Product cardThree = factory.Create("Tom");

            Console.WriteLine("=======Use=======");
            cardOne.use();
            cardTwo.use();
            cardThree.use();
        }
    }
}
