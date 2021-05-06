using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    interface Interface1
    {
        //void Add(int x,int y);
        void Show();
    }
    interface Interface2
    {
        //void Sub(int x, int y);
        void Show();
    }

    class ImplementationClass : Interface1, Interface2
    {        
        static void Main(string[] args)
        {
            ImplementationClass IC = new ImplementationClass();
            Interface1 i1 = IC;
            i1.Show();

            Console.ReadKey();
        }

        public void Show()
        {
            Console.WriteLine("Show Method Invoked!");
        }
    }
}
