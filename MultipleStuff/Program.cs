using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double min, max;

            SuperList.MinMax valores;

            Tuple<double, double> t;

            // Instanciar Superlist
            SuperList list = new SuperList() {-24, 3, 4.5, -2.3, -100.3, 23};

            // Get min and max
            list.GetMinMax(out min, out max);

            valores = list.GetMinMax();

            t = list.GetMinMax2();

            // Print out first result with first method overload
            Console.WriteLine($"{min} and {max}");

            Console.WriteLine();

            // Print out second result with second method overload
            Console.WriteLine($"{valores.Min} and {valores.Max}");

            Console.WriteLine();

            // Print out third result with third method overload with tuples
            Console.WriteLine($"{t.Item1} and {t.Item2}");
        }
    }
}
