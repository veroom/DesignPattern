using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class TextBuilder : Builder
    {
        // 文章作成用
        public StringBuilder builder = new();

        /// <summary>
        /// タイトル作成
        /// </summary>
        public override void MakeTitle(string title)
        {
            builder.Append("===================================\n");
            builder.Append("【" + title + "】");
            builder.Append('\n');
        }

        /// <summary>
        /// 章タイトル作成
        /// </summary>
        public override void MakeString(string str)
        {
            builder.Append("■" + str + '\n');
            builder.Append('\n');
        }

        /// <summary>
        /// 文章作成
        /// </summary>
        public override void MakeItems(List<string> items)
        {
            foreach (string item in items)
            {
                builder.Append(" ・" + item + '\n');
            }
            builder.Append('\n');
        }

        /// <summary>
        /// 処理終了
        /// </summary>
        public override void Close()
        {
            builder.Append("===================================\n");
        }

        /// <summary>
        /// 完成した文章の取得
        /// </summary>
        public string GetResult()
        {
            return builder.ToString();
        }
    }
}
