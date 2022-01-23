using System.Collections.Generic;

namespace Builder
{
    class Director
    {
        // Builderパターン
        public Builder builder;

        // コンストラクタ
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// 文章作成
        /// </summary>
        public void construct()
        {
            // 文を構築
            builder.MakeTitle("Greeting");
            builder.MakeString("朝から昼にかけて");
            builder.MakeItems(new List<string>() { "おはようございます。", "こんにちは。" });
            builder.MakeString("夜に");
            builder.MakeItems(new List<string>() { "こんばんは。", "おやすみなさい。", "さようなら。" });

            // 文章の完成
            builder.Close();
        }
    }
}
