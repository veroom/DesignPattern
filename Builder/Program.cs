using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("make plain text");
            TextBuilder textBuilder = new TextBuilder();
            Director textDirector = new Director(textBuilder);
            textDirector.construct();
            Console.WriteLine(textBuilder.GetResult());

            Console.WriteLine("make html text");
            HTMLBuilder htmlBuilder = new HTMLBuilder();
            Director htmlDirector = new Director(htmlBuilder);
            htmlDirector.construct();
            Console.WriteLine(htmlBuilder.GetResult());
        }
    }
}
