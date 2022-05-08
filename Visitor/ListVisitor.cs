using System;
using System.Collections;

namespace Visitor
{
    class ListVisitor:Visitor
    {
        /// <summary>
        /// 現在注目しているディレクトリ名
        /// </summary>
        private string currentdir = "";

        /// <summary>
        /// Fileの呼び出し
        /// </summary>
        /// <param name="file"></param>
        public override void Visit(File file)
        {
            Console.WriteLine(currentdir + "/" + file);
        }

        /// <summary>
        /// ディレクトリの呼び出し
        /// </summary>
        /// <param name="directory"></param>
        public override void Visit(Directory directory)
        {
            Console.WriteLine(currentdir + "/" + directory);
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.GetName();
            IEnumerator it = directory.GetEnumerator();

            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }
    }
}
