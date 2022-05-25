using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo3
{
    public delegate int Calculation(int x, int y);
    class Program
    {

        static void Main(string[] args)
        {
            Calculation calc = (x, y) => x + y;
            int result = calc(25, 30);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}




