using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Builder
{
    class HTMLBuilder : Builder
    {
        // ファイル名
        private string fileName;

        // ファイル書き込み文章
        private List<string> write = new();

        /// <summary>
        /// タイトル作成
        /// </summary>
        public override void MakeTitle(string title)
        {
            // 表示文章作成
            fileName = title + ".html";
            Console.WriteLine("<html><head><title>" + title + "<html><head><title>");
            Console.WriteLine("<h1>" + title + "</h1>");

            // ファイル書き込み準備
            write.Add(fileName);
            write.Add("<html><head><title>" + title + "</html></head></title>");
            write.Add("<h1>" + title + "</h1>");
        }

        /// <summary>
        /// 章タイトル作成
        /// </summary>
        public override void MakeString(string str)
        {
            Console.WriteLine("<p>" + str + "</p>");
            write.Add("<p>" + str + "</p>");
        }

        /// <summary>
        /// 文章作成
        /// </summary>
        public override void MakeItems(List<string> items)
        {
            Console.WriteLine("<ul>");
            write.Add("<ul>");

            foreach (string item in items)
            {
                Console.WriteLine("<li>" + item + "</li>");
                write.Add("<li>" + item + "</li>");
            }

            Console.WriteLine("</ul>");
            write.Add("</ul>");
        }

        /// <summary>
        /// 処理終了
        /// </summary>
        public override void Close()
        {
            Console.WriteLine("</body></html>");
            write.Add("</ body ></ html > ");

            // ファイルへ出力
            var Path = "test.txt";
            File.WriteAllLines(Path, write, Encoding.UTF8);
        }

        /// <summary>
        /// 完成した文章の取得
        /// </summary>
        public string GetResult()
        {
            return fileName;
        }
    }
}
