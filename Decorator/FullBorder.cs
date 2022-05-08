using System.Text;

namespace Decorator
{
    class FullBorder : Border
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display"></param>
        public FullBorder(Display display) : base(display) { }

        /// <summary>
        /// 文字数は中身の両側に上下の飾り文字を加えたもの
        /// </summary>
        public override int Columns
        {
            get
            {
                return 1 + display.Columns + 1;
            }
        }

        /// <summary>
        /// 行数は中身の行数に上下の飾り文字を加えたもの
        /// </summary>
        public override int Rows
        {
            get
            {
                return 1 + display.Rows + 1;
            }
        }

        /// <summary>
        /// 指定した行の内容
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', display.Columns) + "+";
            }
            else if (row == display.Rows + 1)
            {
                return "+" + MakeLine('-', display.Columns) + "+";
            }
            else
            {
                return "|" + display.GetRowText(row - 1) + "|";
            }
        }

        /// <summary>
        /// 文字chをcount個連続させた文字列を作る
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private string MakeLine(char ch, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
