using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class BookShelf : Aggregate
    {
        // ブックリスト
        private Book[] books;

        // ブックリストの要素数
        private int last = 0;

        // コンストラクタ
        public BookShelf(int maxSize)
        {
            this.books = new Book[maxSize];
        }

        /// <summary>
        /// 指定したブックを取得
        /// </summary>
        public Book getBookAt(int index)
        {
            return books[index];
        }

        /// <summary>
        /// ブックを追加
        /// </summary>
        public void appendBook(Book book)
        {
            this.books[last] = book;
            last++;
        }

        /// <summary>
        /// ブックの要素数取得
        /// </summary>
        public int getLength()
        {
            return last;
        }

        /// <summary>
        /// BookShelfクラスの検索
        /// </summary>
        public Iterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
