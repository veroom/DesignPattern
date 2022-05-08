
namespace Decorator
{
    class SideBorder : Border
    {
        /// <summary>
        /// 飾り文字となる文字
        /// </summary>
        private char borderChar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display"></param>
        /// <param name="ch"></param>
        public SideBorder(Display display, char ch) : base(display)
        {
            this.borderChar = ch;

        }

        /// <summary>
        /// 文字数
        /// </summary>
        public override int Columns
        {
            get
            {
                return 1 + display.Columns + 1;
            }
        }

        /// <summary>
        /// 行数
        /// </summary>
        public override int Rows
        {
            get
            {
                return display.Rows;
            }
        }

        /// <summary>
        /// 指定行の内容
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override string GetRowText(int row)
        {
            return borderChar + display.GetRowText(row) + borderChar;
        }
    }
}
