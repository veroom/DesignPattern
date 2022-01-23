using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImp1("Hello, World"));
            Display d2 = new CountDisplay(new StringDisplayImp1("Hello, Japan"));
            CountDisplay d3 = new CountDisplay(new StringDisplayImp1("Hello, Universe")) ;
            d1.display();
            d2.display();
            d3.display();
            d3.multiDisplay(5);
        }
    }
}
