using Prototype.framework;
using System;
using System.Text;

namespace Prototype
{
    class MessageBox : Product
    {
        private char decochar;

        // コンストラクタ
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        // C#では使用しない
        public object Clone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///インスタンスのコピー作成
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

            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine(decochar + " " + s + " " + decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
