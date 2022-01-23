using Prototype.framework;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            UnderLine upen = new UnderLine('-');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.register("strong message", upen);
            manager.register("warning box", mbox);
            manager.register("slash box", sbox);

            Product p1 = manager.create("strong message");
            p1.use("Hellow,world");
            Product p2 = manager.create("warning box");
            p2.use("Hellow,world");
            Product p3 = manager.create("slash box");
            p3.use("Hellow,world");

        }
    }
}
