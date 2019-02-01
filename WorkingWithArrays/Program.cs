using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var qwe = new ArrayOfInteger();
            qwe.Add(0, 10);
            qwe.Add(1, 20);
            qwe.Add(2, 30);
            qwe.Print();
        }
    }
}
