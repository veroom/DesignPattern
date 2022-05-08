
namespace ChainofResponsibility
{
    class LimitSupport : Support
    {
        /// <summary>
        /// この番号未満なら解決できる
        /// </summary>
        private int limit;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LimitSupport(string name, int limit):base(name)
        {
            this.limit = limit;
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected override bool resolve(Trouble trouble)
        {
            if (trouble.GetNumber() < limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
