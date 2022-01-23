using Prototype.framework;
using System;
using System.Text;

namespace Prototype
{
    class UnderLine : Product
    {
        private char ulchar;

        // コンストラクタ
        public UnderLine(char ulchar)
        {
            this.ulchar = ulchar;
        }

        // C#では使用しない
        public object Clone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// インスタンスのコピー作成
        /// </summary>
        public Product createClone()
        {
            Product p = null;
            p = (Product)MemberwiseClone();
            return p;
        }

        /// <summary>
        /// インスタンス使用
        /// </summary>
        public void use(string s)
        {
            int length = Encoding.GetEncoding("utf-8").GetByteCount(s);
            Console.WriteLine("\"" + s + "\"");

            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
