using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int Seed1 = 0;
            int Seed2 = 1;

            Player player1 = new Player("Taro", new WinningStrategy(Seed1));
            Player player2 = new Player("Jiro", new ProbStrategy(Seed2));

            for (int i = 0; i < 1000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();

                if (nextHand1.isStrongerThan(nextHand2))
                {
                    Console.WriteLine("Winner:" + player1.name);
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.isStrongerThan(nextHand1))
                {
                    Console.WriteLine("Winner:" + player2.name);
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine("==========Toal Result============");
            Console.WriteLine(player1.Tostring());
            Console.WriteLine(player2.Tostring());
            Console.WriteLine("=================================");
        }
    }
}
