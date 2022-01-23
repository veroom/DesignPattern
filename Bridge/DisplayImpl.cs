
namespace Bridge
{
    abstract class DisplayImpl
    {
        /// <summary>
        /// 表示前処理
        /// </summary>
        public abstract void RawOpen();

        /// <summary>
        /// 表示処理
        /// </summary>
        public abstract void RawPrint();

        /// <summary>
        /// 表示後処理
        /// </summary>
        public abstract void RawClose();
    }
}
