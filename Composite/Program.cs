using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory rootdir = new Directory("root");
                Directory bindir = new Directory("bin");
                Directory tmpdir = new Directory("tmp");
                Directory userdir = new Directory("user");
                rootdir.Add(bindir);
                rootdir.Add(tmpdir);
                rootdir.Add(userdir);
                bindir.Add(new File("vi", 10000));
                bindir.Add(new File("latex", 1200));
                rootdir.PrintList();

                Console.WriteLine("");
                Console.WriteLine("Making user entries...");
                Directory yuki = new Directory("yuki");
                Directory hanako = new Directory("hanako");
                Directory tomura = new Directory("tomura");
                userdir.Add(yuki);
                userdir.Add(hanako);
                userdir.Add(tomura);
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Composite.java", 1200));
                hanako.Add(new File("memo.txt", 1500));
                tomura.Add(new File("game.doc", 100));
                tomura.Add(new File("junk.mail", 100));
                rootdir.PrintList();
            }
            catch (FileTreatmentException e)
            {
                _ = e.StackTrace;
            }
        }
    }
}
