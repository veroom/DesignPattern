using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Book
    {
        // 本のタイトル
        public string title
        {
            get;
            private set;
        }

        // コンストラクタ
        public Book(String title)
        {
            this.title = title;
        }
    }
}
