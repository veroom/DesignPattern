using System;
using System.Collections;

namespace Visitor
{
    class Directory:Entry
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// ディレクトリの集合
        /// </summary>
        private ArrayList dir = new ArrayList();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public Directory(string name)
        {
            this.name = name;
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
            int size = 0;
            IEnumerator it = dir.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.GetSize();
            }
            return size;
        }

        /// <summary>
        /// エントリの追加
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public new Entry Add(Entry entry)
        {
            dir.Add(entry);
            return this;
        }

        /// <summary>
        /// Iteratorの生成
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return dir.GetEnumerator();
        }

        /// <summary>
        /// 訪問者の受け入れ
        /// </summary>
        /// <param name="v"></param>
        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
