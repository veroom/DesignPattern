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

        // インスタンスをコピー
        public object Clone()
        {
            UnderLine underLine = new UnderLine(this.ulchar);
            return underLine;
        }

        /// <summary>
        /// インスタンスのコピー作成
        /// </summary>
        public Product createClone()
        {
            return (Product)Clone();
        }

        /// <summary>
        /// インスタンス使用
        /// </summary>
        public void use(string s)
        {
            int length = Encoding.GetEncoding("utf-8").GetByteCount(s);
            Console.WriteLine("\"" + s + "\"");
            Console.Write(" ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
