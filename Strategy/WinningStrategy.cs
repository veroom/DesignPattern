using System;

namespace Strategy
{
    class WinningStrategy : Strategy
    {
        // 次に出す手(値)のランダム値
        private Random random;

        // 判定結果
        private bool won = false;

        // 前回出した手
        private Hand prevHand;

        // コンストラクタ
        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// 次に出す手
        /// </summary>
        public Hand nextHand()
        {
            if (!won)
            {
                prevHand = Hand.GetHand(random.Next(3));
            }
            return prevHand;
        }

        /// <summary>
        /// 判定処理
        /// </summary>
        public void study(bool win)
        {
            won = win;
        }
    }
}
