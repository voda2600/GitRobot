using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    class Program
    {
        static void Main(strings[] args)
        {
            RGB a = RGB.CreateFromRGB(0.24, 1, 0.99);
            Console.WriteLine(a);
            CMY b = CMY.CreateFromCMY(0.76, 0, 0.01);
            Console.WriteLine(b);
            Console.WriteLine("Summa:");
            RGB sum = a + a;
            Console.WriteLine(sum);
            CMY sum1 = b + b;
            Console.WriteLine(sum1);
        }
    }
}
