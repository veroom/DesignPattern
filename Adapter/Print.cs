

namespace Adapter1
{
    interface Print
    {
        /// <summary>
        /// ()で括られた文字列を表示
        /// </summary>
        public abstract void printWeak();

        /// <summary>
        /// **で括られた文字列を表示
        /// </summary>
        public abstract void printStrong();
    }
}
