using System;

namespace Composite
{
    class File : Entry
    {
        // ファイル名
        private string name;

        // ファイルサイズ
        private int size;

        // コンストラクタ
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        /// <summary>
        /// エントリの追加
        /// </summary>
        public override Entry Add(Entry entry)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 名前の取得
        /// </summary>
        public override string GetName()
        {
            return name;
        }

        /// <summary>
        /// 容量取得
        /// </summary>
        public override int GetSize()
        {
            return size;
        }

        /// <summary>
        /// 一覧を表示する
        /// </summary>
        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
        }
    }
}
