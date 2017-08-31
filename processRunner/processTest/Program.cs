using processRunner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTest1 test1 = new UnitTest1();

            IParameteriseAble n= test1.TestNumber();
            n.SetValue((float)4);
            Console.WriteLine(n.GetValue());
            n.SetName("Hello");
            Console.WriteLine(n.GetName());

            IParameteriseAble t = test1.TestText();
            t.SetValue("hell");
            Console.WriteLine(t.GetValue());
            t.SetName("Hello1");
            Console.WriteLine(t.GetName());

        }
    }
}
