using FactoryMethod.framework;
using System;

namespace FactoryMethod.idcard
{
    class IDCard : Product
    {
        // 使用者名
        public string owner
        {
            get;
            private set;
        }

        // コンストラクタ
        public IDCard(string owner)
        {
            Console.WriteLine(owner+"のカードを作ります");
            this.owner = owner;
        }

        /// <summary>
        /// 製品の使用
        /// </summary>
        public override void use()
        {
            Console.WriteLine(owner + "のカードを使います");
        }
    }
}
