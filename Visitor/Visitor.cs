
namespace Visitor
{
    abstract class Visitor
    {
        /// <summary>
        /// ファイルクラスが呼び出すメソッド
        /// </summary>
        /// <param name="file"></param>
        public abstract void Visit(File file);

        /// <summary>
        /// ディレクトリクラスが呼び出すメソッド
        /// </summary>
        /// <param name="directory"></param>
        public abstract void Visit(Directory directory);
    }
}
