
namespace Adapter1
{
    class PrintBanner : Banner, Print
    {
        // コンストラクタ
        public PrintBanner(string message):base(message)
        {
        }

        /// <summary>
        /// **で括られた文字列を表示
        /// </summary>
        public void printStrong()
        {
            showWithParen();
        }

        /// <summary>
        /// ()で括られた文字列を表示
        /// </summary>
        public void printWeak()
        {
            showWithAster();
        }
    }
}
