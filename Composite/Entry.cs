
namespace Composite
{
    abstract class Entry
    {
        // ディレクトリエントリ名
        public abstract string GetName();

        // サイズ
        public abstract int GetSize();

        /// <summary>
        /// エントリの追加
        /// </summary>
        public abstract Entry Add(Entry entry);

        /// <summary>
        /// 一覧を表示する
        /// </summary>
        public void PrintList()
        {
            PrintList(" ");
        }
        public abstract void PrintList(string prefix);

        /// <summary>
        /// 文字列表現
        /// </summary>
        public string Tostring()
        {
            return GetName() + "(" + GetSize() + ")";
        }
    }
}
