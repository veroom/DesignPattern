using System;
using System.Collections.Generic;

namespace Composite
{
    class Directory : Entry
    {
        // ディレクトリ名
        private string name;

        // ディレクトリエントリリスト
        List<Entry> directory = new List<Entry>();

        // コンストラクタ
        public Directory(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// エントリの追加
        /// </summary>
        public override Entry Add(Entry entry)
        {
            directory.Add(entry);
            return this;
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
            int size = 0;
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                size += it.Current.GetSize();
            }
            return size;
        }

        /// <summary>
        /// 文字列表現
        /// </summary>
        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                it.Current.PrintList(prefix + "/" + name);
            }
        }
    }
}
