using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение коэф к уравнения 0=kx+b");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение коэф b уравнения 0=kx+b");
            double b = Convert.ToDouble(Console.ReadLine());

            Linurav linurav = new Linurav(k, b);
            Console.WriteLine(linurav.Root());
            Console.ReadKey();

        }
    }
}
