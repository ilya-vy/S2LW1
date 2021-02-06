using System;

namespace Jan_21_LW_1_T_1
{
    public delegate double DelegateA(double x, double y, double z);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateA delA = delegate (double x, double y, double z) { return(x + y + z) / 3; };
            Console.WriteLine(delA(5, 5, 27));
            Console.ReadKey();
        }
    }
}
