
namespace ChainofResponsibility
{
    class Trouble
    {
        /// <summary>
        /// トラブル番号
        /// </summary>
        private int number;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Trouble(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// トラブル番号の取得
        /// </summary>
        /// <returns></returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// トラブルの文字列表現
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Trouble " + number + "]";
        }
    }
}
