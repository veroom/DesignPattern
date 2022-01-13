using System;

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
