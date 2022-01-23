using System;

namespace Strategy
{
    class ProbStrategy : Strategy
    {
        private Random random;
        private int prevHandValue = 0;
        private int cureentHandValue = 0;

        private int[,] history = new int[,] {
        {1,1,1 },
        {1,1,1 },
        {1,1,1 },
        };

        // コンストラクタ
        public ProbStrategy(int seed)
        {
            this.random = new Random(seed);
        }

        /// <summary>
        /// 次に出す手
        /// </summary>
        public Hand nextHand()
        {
            int bet = random.Next(GetSum(cureentHandValue));
            int handvalue = 0;

            if (bet < history[cureentHandValue, 0])
            {
                handvalue = 0;
            }
            else if (bet < history[cureentHandValue, 0] + history[cureentHandValue, 1])
            {
                handvalue = 1;
            }
            else
            {
                handvalue = 2;
            }
            prevHandValue = cureentHandValue;
            cureentHandValue = handvalue;
            return Hand.GetHand(handvalue);
        }

        /// <summary>
        /// 勝ち数の計算
        /// </summary>
        private int GetSum(int hv)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += history[hv, i];
            }
            return sum;
        }

        /// <summary>
        /// 判定処理
        /// </summary>
        public void study(bool win)
        {
            if (win)
            {
                history[prevHandValue, cureentHandValue]++;
            }
            else
            {
                history[prevHandValue, (cureentHandValue + 1) % 3]++;
                history[prevHandValue, (cureentHandValue + 2) % 3]++;
            }
        }
    }
}
