using System;

namespace Jan_21_LW_1_T_2
{
    public delegate double DelegateA(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateA delA;
            double X, Y;
            string op;
            Console.WriteLine("Choose operation +, -, *, /, e");
            op = Console.ReadLine();
                
                Console.WriteLine("Enter X value: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Y value: ");
                Y = Convert.ToDouble(Console.ReadLine());

                
                switch (op)
                {
                    case "+":
                        Console.WriteLine("Add operation chosen");
                        delA = (x, y) => { return x + y; };
                        Console.WriteLine(delA(X, Y));
                        break;

                    case "-":
                        Console.WriteLine("Sub operation chosen");
                        delA = (x, y) => { return x - y; };
                        Console.WriteLine(delA(X, Y));
                        break;

                    case "*":
                        Console.WriteLine("Mul operation chosen");
                        delA = (x, y) => { return x * y; };
                        Console.WriteLine(delA(X, Y));
                        break;

                    case "/":
                        Console.WriteLine("Div operation chosen");
                        delA = (x, y) =>
                        {
                            if (y == 0)
                            {
                                Console.WriteLine("Trying to divide by 0? Well, we can do anything we want..."); return 0;
                            }
                            else return x / y;
                        };
                        Console.WriteLine(delA(X, Y));
                        break;

                    default:
                        Console.WriteLine("Unknown operation");
                        break;

                }
        }
    }
}
