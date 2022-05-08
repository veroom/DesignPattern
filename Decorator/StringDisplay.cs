using System.Text;

namespace Decorator
{
    class StringDisplay : Display
    {
        /// <summary>
        /// 表示文字列
        /// </summary>
        private string str;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str"></param>
        public StringDisplay(string str)
        {
            this.str = str;
        }

        /// <summary>
        /// 文字数
        /// </summary>
        public override int Columns
        {
            get
            {
                Encoding sjisEnc = Encoding.GetEncoding("utf-8");
                return sjisEnc.GetByteCount(str);
            }
        }

        /// <summary>
        /// 行数
        /// </summary>
        public override int Rows
        {
            get { return 1; }
        }

        /// <summary>
        /// rowが0のときのみ返す
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return str;
            }
            else
            {
                return null;
            }
        }
    }
}
