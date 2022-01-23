using System.Collections.Generic;

namespace Builder
{
    abstract class Builder
    {
        /// <summary>
        /// タイトル作成
        /// </summary>
        public abstract void MakeTitle(string title);

        /// <summary>
        /// 章タイトル作成
        /// </summary>
        public abstract void MakeString(string str);

        /// <summary>
        /// 文章作成
        /// </summary>
        public abstract void MakeItems(List<string> items);

        /// <summary>
        /// 処理終了
        /// </summary>
        public abstract void Close();
    }
}
