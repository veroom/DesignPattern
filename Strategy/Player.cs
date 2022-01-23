

namespace Strategy
{
    class Player
    {
        // プレイヤー名
        public string name { get; private set; }

        // Strategyクラス
        private Strategy strategy;

        // 勝ち回数
        private int wincouunt;

        // 負け回数
        private int losecouunt;

        // 勝負回数
        private int gameouunt;

        // コンストラクタ
        public Player(string name, Strategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        /// <summary>
        /// 次に出す手
        /// </summary>
        public Hand NextHand()
        {
            return strategy.nextHand();
        }

        /// <summary>
        /// 勝利回数加算
        /// </summary>
        public void Win()
        {
            strategy.study(true);
            wincouunt++;
            gameouunt++;
        }

        /// <summary>
        /// 負け回数加算
        /// </summary>
        public void Lose()
        {
            strategy.study(false);
            losecouunt++;
            gameouunt++;
        }

        /// <summary>
        /// 引き分け:gamecouuntのみ加算
        /// </summary>
        public void Even()
        {
            gameouunt++;
        }

        /// <summary>
        /// 文字列表現へ変換
        /// </summary>
        public string Tostring()
        {
            return "[" + name + ":" + gameouunt + "games," + wincouunt + "win," + +losecouunt + "lose" + "]";
        }
    }
}