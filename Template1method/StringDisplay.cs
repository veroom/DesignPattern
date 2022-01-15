using System;
using System.Text;

namespace TemplateMethod
{
    class StringDisplay : AbstractDisplaycs
    {
        // 表示文字列
        private string str;

        // 表示文字列の幅
        private int width;

        // コンストラクタ
        public StringDisplay(String str)
        {
            this.str = str;

            // 文字列の幅(バイト単位)
            this.width = Encoding.GetEncoding("utf-8").GetByteCount(str);
        }

        /// <summary>
        /// 表示開始
        /// </summary>
        public override void Open()
        {
            PrintLine();
        }

        /// <summary>
        /// 表示終了
        /// </summary>
        public override void Close()
        {
            PrintLine();
        }

        /// <summary>
        /// コンストラクタで与えられた文字列を表示する
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("|" + str + "|");
        }

        /// <summary>
        /// 表示枠の生成
        /// </summary>
        private void PrintLine()
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
