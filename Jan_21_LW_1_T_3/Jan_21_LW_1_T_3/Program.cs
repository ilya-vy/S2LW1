using System;

namespace Jan_21_LW_1_T_3
{
    public delegate int MyDelegate();

    public static class MyClass
    {
        public static int p1()
        {
            Random rnd = new Random();
            return rnd.Next(1, 299);
        }
        
        
    }
    public class Program
    {
        static MyDelegate[] delegates = new MyDelegate[]
        {
            new MyDelegate(MyClass.p1),
            new MyDelegate(MyClass.p1),
            new MyDelegate(MyClass.p1),
            new MyDelegate(MyClass.p1),
            new MyDelegate(MyClass.p1),
        };
        static void Main(string[] args)
        {
            MyDelegate delA;
            delA = delegate
            {
                int y = 0;
                int sum = 0;
                for (int i = 0; i < delegates.Length; i++)
                {
                    y++;
                    sum = sum + delegates[i]();
                }
                return sum / y;
            };
            Console.WriteLine("Average value: {0}", delA());
            Console.ReadKey();
        }
    } 
}

