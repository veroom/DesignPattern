
namespace Strategy
{
    class Hand
    {
        // グー
        public static readonly int HANDVALUE_GUU = 0;

        // チョキ
        public static readonly int HANDVALUE_CHO = 1;

        // パー
        public static readonly int HANDVALUE_PAA = 2;

        /// <summary>
        /// じゃんけんの手のインスタンス
        /// </summary>
        public static readonly Hand[] hand =
        {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA),
          };

        /// <summary>
        /// じゃんけんの手の値
        /// </summary>
        private Hand(int handvalue)
        {
            this.handvalue = handvalue;
        }
        private int handvalue;

        /// <summary>
        /// じゃんけんの文字列表現
        /// </summary>
        public static readonly string[] name =
        {
            "グー", "チョキ", "パー",
         };

        /// <summary>
        /// インスタンスの取得
        /// </summary>
        public static Hand GetHand(int handvalue)
        {
            return hand[handvalue];
        }

        /// <summary>
        /// 相手より強い手か判定
        /// </summary>
        public bool isStrongerThan(Hand h)
        {
            return fight(h) == 1;
        }

        /// <summary>
        /// 相手より弱い手か判定
        /// </summary>
        public bool isWeekerThan(Hand h)
        {
            return fight(h) == -1;
        }

        /// <summary>
        /// じゃんけんの実施
        /// </summary>
        private int fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((this.handvalue + 1) % 3 == h.handvalue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 文字列表現へ変換
        /// </summary>
        public string Tostring()
        {
            return name[handvalue];
        }
    }
}
