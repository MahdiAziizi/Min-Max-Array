using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter count number's \t");
            n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            float min = a[0], max = a[0];
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter num {0} : \t", i);
                a[i] = float.Parse(Console.ReadLine());
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
            }
            Console.Write("max is : \t{0} \nand min is :\t{1}", max, min);
            Console.ReadLine();
        }
    }
}
