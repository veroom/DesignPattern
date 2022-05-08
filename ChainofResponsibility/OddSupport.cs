using System;

namespace ChainofResponsibility
{
    class OddSupport : Support
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public OddSupport(string name) : base(name)
        {
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected override bool resolve(Trouble trouble)
        {
            if (trouble.GetNumber() % 2 == 1)
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
