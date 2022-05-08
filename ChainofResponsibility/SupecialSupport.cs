
namespace ChainofResponsibility
{
    class SupecialSupport :Support
    {
        /// <summary>
        /// この番号だけ解決できる
        /// </summary>
        private int number;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public SupecialSupport(string name,int number) : base(name)
        {
            this.number = number;
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected override bool resolve(Trouble trouble)
        {
            if (trouble.GetNumber() == number)
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
