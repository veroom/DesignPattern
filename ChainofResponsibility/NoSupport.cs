using System;

namespace ChainofResponsibility
{
    class NoSupport : Support
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public NoSupport(String name) : base(name)
        {
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected override bool resolve(Trouble trouble)
        {
            return false;
        }
    }
}
