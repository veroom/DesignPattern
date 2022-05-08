
namespace Decorator
{
    abstract class Border : Display
    {
        /// <summary>
        /// 枠の中身
        /// </summary>
        protected Display display;

        /// <summary>
        /// インスタンス生成時に「中身」を引数で指定
        /// </summary>
        /// <param name="display"></param>
        protected Border(Display display)
        {
            this.display = display;
        }
    }
}
