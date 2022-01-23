
namespace Strategy
{
    interface Strategy
    {
        /// <summary>
        /// 次に出す手
        /// </summary>
        public abstract Hand nextHand();

        /// <summary>
        /// 判定処理
        /// </summary>
        public abstract void study(bool win);
    }
}
