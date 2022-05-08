using System;
using System.Collections.Generic;
using System.IO;

namespace Facade
{
    class PageMaker
    {
        private PageMaker() { }

        /// <summary>
        /// 指定したユーザとファイル名でHTMLページを作成する
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="fileName"></param>
        public static void MakeWelcomePage(string mailaddr, string filename)
        {
            try
            {
                IDictionary<string, string> mailprop = Database.GetProperties("maildata");
                string username = mailprop[mailaddr];
                using (var sw = new StreamWriter(filename))
                {
                    HtmlWriter writer = new HtmlWriter(sw);
                    writer.Title($"Welcome to {username}'s page!");
                    writer.Paragraph($"{username}のページへようこそ");
                    writer.Paragraph("メール待ってますね");
                    writer.MailTo(mailaddr, username);
                    writer.Close();
                    Console.WriteLine($"{filename} is created for {mailaddr} ({username})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
