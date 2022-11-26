using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Linurav
    {
        double k;
        double b;

        public Linurav(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x = -b / k;
            return $"Решение уравнения х = {x}";
        }
    }
}
