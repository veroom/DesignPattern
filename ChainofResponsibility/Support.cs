
namespace ChainofResponsibility
{
    abstract class Support
    {
        /// <summary>
        /// トラブル解決者の名前
        /// </summary>
        private string name;

        /// <summary>
        /// たらい回し先
        /// </summary>
        private Support next;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public Support(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// たらい回し先を設定
        /// </summary>
        /// <param name="next"></param>
        /// <returns></returns>
        public Support SetNext(Support next)
        {
            this.next = next;
            return next;
        }

        /// <summary>
        /// トラブル解決の手段
        /// </summary>
        /// <param name="trouble"></param>
        public void DoSupport(Trouble trouble)
        {
            if (resolve(trouble))
            {
                done(trouble);
            }
            else if (next != null)
            {
                next.DoSupport(trouble);
            }
            else
            {
                fail(trouble);
            }
        }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + name + "]";
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected abstract bool resolve(Trouble trouble);

        /// <summary>
        /// 解決
        /// </summary>
        /// <param name="trouble"></param>
        protected void done(Trouble trouble)
        {
            System.Console.WriteLine(trouble + " is resolved by" + this + ".");
        }

        /// <summary>
        /// 未解決
        /// </summary>
        /// <param name="trouble"></param>
        protected void fail(Trouble trouble)
        {
            System.Console.WriteLine(trouble + " cannot be resolved.");
        }
    }
}
