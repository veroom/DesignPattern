using System;
using System.IO;

namespace Facade
{
    class HtmlWriter:IDisposable
    {
        public StreamWriter writer { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        /// <summary>
        /// タイトル部分を構成するタグを生成する
        /// </summary>
        /// <param name="title"></param>
        public void Title(string title)
        {
            writer.Write("<html>");
            writer.Write("<head>");
            writer.Write("<title>" + title + "</title>");
            writer.Write("</head>");
            writer.Write("<body>\n");
            writer.Write("<h1>" + title + "</h1>");
        }

        /// <summary>
        /// 段落を構成するタグを生成する
        /// </summary>
        /// <param name="msg"></param>
        public void Paragraph(string msg)
        {
            writer.Write("<p>" + msg + "</p>\n");
        }

        /// <summary>
        /// リンクを構成するタグを生成する
        /// </summary>
        /// <param name="href"></param>
        /// <param name="caprion"></param>
        public void Link(string href, string caprion)
        {
            writer.Write("<a href = \"" + href + "\">" + caprion + "</p>\n");
        }

        /// <summary>
        /// メールアドレス部分の文字列を生成する
        /// </summary>
        /// <param name="mailAddr"></param>
        /// <param name="userName"></param>
        public void MailTo(string mailAddr, string userName)
        {
            Link(("mailto:" + mailAddr), userName);
        }

        /// <summary>
        /// body,headの末尾を生成する
        /// </summary>
        public void Close()
        {
            writer.Write("</body>");
            writer.Write("<html>\n");
        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
