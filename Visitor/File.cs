
namespace Visitor
{
    class File : Entry
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// サイズ
        /// </summary>
        private int size;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        /// <param name="size"></param>
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        /// <summary>
        /// 名前のゲッター
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return name;
        }

        /// <summary>
        /// サイズのゲッター
        /// </summary>
        /// <returns></returns>
        public override int GetSize()
        {
            return size;
        }

        /// <summary>
        /// visit(File)の呼び出し
        /// </summary>
        /// <param name="v"></param>
        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
