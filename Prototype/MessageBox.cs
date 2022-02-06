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

        // インスタンスをコピー
        public object Clone()
        {
            MessageBox messageBox = new MessageBox(this.decochar);
            return messageBox;
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
