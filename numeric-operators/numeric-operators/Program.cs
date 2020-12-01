using System;

namespace numeric_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            int sum = a + b;
            int diff = a - b;
            int div = a / b;
            int mod = a % b;
            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"diff={diff}");
            Console.WriteLine($"div={div}");
            Console.WriteLine($"mod={mod}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            a = 10;
            int incPrefix = ++a;
            Console.WriteLine($"incPrefix={incPrefix}");
            Console.WriteLine($"a={a}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            a = 10;
            int incPostfix = a++;
            Console.WriteLine($"incPostfix={incPostfix}");
            Console.WriteLine($"a={a}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            a = 10;
            int decPrefix = --a;
            Console.WriteLine($"decPrefix={decPrefix}");
            Console.WriteLine($"a={a}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            a = 10;
            int decPostfix = a--;
            Console.WriteLine($"decPostfix={decPostfix}");
            Console.WriteLine($"a={a}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            a = 10;
            int val = +a;
            int oppositeVal = -a;
            Console.WriteLine($"val={val}");
            Console.WriteLine($"oppositeVal={oppositeVal}");

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            DemoComplexExpression();

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            DemoDivisionByZero();

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            DemoArithmeticOverflow();

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            DemoBitwiseOperators();
        }

        static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
            Console.WriteLine();
        }

        static void DemoComplexExpression()
        {
            int a = 10;

            int expr = a-- + 1 * a - a / a % a;
            Console.WriteLine($"expr={expr}");
        }

        static void DemoDivisionByZero()
        {
            int div = Div(10, 0);
            Console.WriteLine($"div={div}");

        }

        static void DemoArithmeticOverflow()
        {
            int sum1 = SumUnchecked(int.MaxValue, 1);
            Console.WriteLine($"sum1={sum1}");

            int sum2 = SumChecked(int.MaxValue, 1);
            Console.WriteLine($"sum2={sum2}");
        }

        static void DemoBitwiseOperators()
        {
            int a = 3;
            Console.WriteLine($"{a} * 2 = {Mul2(a)}");
            Console.WriteLine($"{a} / 2 = {Div2(a)}");

            PowersOf2(6);
        }

        static int SumUnchecked(int a, int b)
        {
            return a + b;
        }

        static int SumChecked(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        static int Mul2(int a)
        {
            return a << 1;
        }

        static int Div2(int a)
        {
            return a >> 1;
        }

        static void PowersOf2(int n)
        {
            int x = 1;
            Console.WriteLine($"2 ^ 0 = {x}");

            for (int i = 1; i <=n; i++)
            {
                x = Mul2(x);
                Console.WriteLine($"2 ^ {i} = {x}");
            }
        }
    }
}
