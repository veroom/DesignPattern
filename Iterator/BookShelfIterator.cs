using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;

        // コンストラクタ
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        /// <summary>
        /// 次の要素があるか
        /// </summary>
        public bool hasNext()
        {
            if (index < bookShelf.getLength())
            {
                // 次の要素がある場合
                return true;
            }
            else
            {
                // 次の要素がない場合
                return false;
            }
        }

        /// <summary>
        /// インデックスを次の要素に進める
        /// </summary>
        public object next()
        {
            Book book = bookShelf.getBookAt(index);
            index++;
            return book;
        }
    }
}
