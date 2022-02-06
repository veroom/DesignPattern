using System;
using System.Text;

namespace Bridge
{
    class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;

        // コンストラクタ
        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = Encoding.GetEncoding("utf-8").GetByteCount(str);
        }

        /// <summary>
        /// 表示前処理
        /// </summary>
        public override void RawOpen()
        {
            printLine();
        }

        /// <summary>
        /// 表示処理
        /// </summary>
        public override void RawPrint()
        {
            Console.WriteLine("|" + str + "|");
        }

        /// <summary>
        /// 表示後処理
        /// </summary>
        public override void RawClose()
        {
            printLine();
        }

        /// <summary>
        /// 出力処理
        /// </summary>
        private void printLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
