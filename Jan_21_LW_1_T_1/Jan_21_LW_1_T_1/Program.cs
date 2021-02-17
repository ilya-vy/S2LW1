using System;

namespace Jan_21_LW_1_T_1
{
    public delegate int DelegateA(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateA delA = delegate (int x, int y, int z) { return(x + y + z) / 3; };
            Console.WriteLine(delA(5, 5, 27));
            Console.ReadKey();
        }
    }
}
