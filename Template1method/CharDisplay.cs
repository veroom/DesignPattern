using System;

namespace TemplateMethod
{
    class CharDisplay : AbstractDisplaycs
    {
        // 表示文字
        private char ch;

        // コンストラクタ
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        /// <summary>
        /// 表示開始
        /// </summary>
        public override void Open()
        {
            Console.Write("<<");
        }

        /// <summary>
        /// 表示終了
        /// </summary>
        public override void Close()
        {
            Console.WriteLine(">>");
        }

        /// <summary>
        /// コンストラクタで与えられた文字を表示する
        /// </summary>
        public override void Print()
        {
            Console.Write(ch);
        }
    }
}
