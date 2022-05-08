using System.Collections;

namespace Visitor
{
    abstract class Entry : Element
    {
        /// <summary>
        /// 名前
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();

        /// <summary>
        /// サイズ
        /// </summary>
        /// <returns></returns>
        public abstract int GetSize();

        /// <summary>
        /// エントリの追加
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public Entry Add(Entry entry)
        {
            throw new FileTreatmentExceprion();
        }

        /// <summary>
        /// Iteratorの生成
        /// </summary>
        /// <returns></returns>
        public IEnumerator Enumerator()
        {
            throw new FileTreatmentExceprion();
        }
        public abstract void Accept(Visitor v);
    }
}
