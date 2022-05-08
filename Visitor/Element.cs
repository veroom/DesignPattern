
namespace Visitor
{
    interface Element
    {
        /// <summary>
        /// Visitorクラス受け入れクラス
        /// </summary>
        /// <param name="v"></param>
        public abstract void Accept(Visitor v);
    }
}
