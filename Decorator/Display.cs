using System;

namespace Decorator
{
    public abstract class Display
    {
        /// <summary>
        /// 横の文字数
        /// </summary>
        public abstract int Columns { get; }

        /// <summary>
        /// 縦の行数
        /// </summary>
        public abstract int Rows { get; }

        /// <summary>
        /// row番目の文字列を得る
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public abstract string GetRowText(int row);

        /// <summary>
        /// 全て表示
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine(GetRowText(i));
            }
        }
    }
}
