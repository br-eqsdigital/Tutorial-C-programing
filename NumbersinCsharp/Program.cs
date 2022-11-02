
namespace NumberCSharp{
    class Program{
        void WorkWithIntegers(){
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");


            // subtraction
            c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");

            // multiplication
            c = a * b;
            Console.WriteLine($"{a} x {b} = {c}");

            // division
            c = a / b;
            Console.WriteLine($"{a} / {b} = {c}");

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine($"{a} + {b} x {c} = {d} ");

            d = (a + b) * c;
            Console.WriteLine($"({a} + {b}) x {c} = {d} ");

        }

        void OrderPrecedence(){
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine($"{a} + {b} x {c} = {d} ");

            d = (a + b) * c;
            Console.WriteLine($"({a} + {b}) x {c} = {d} ");

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine($"({a} + {b}) - 6 x {c} + (12x4)/3 + 12 = {d} ");

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine($"({e} + {f}) / {g} = {h} ");

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        void WorkWithDoublesAndDecimals(){
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal decMin = decimal.MinValue;
            decimal decMmax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {decMin} to {decMmax}");


            a = 1.0;
            b = 3.0;
            Console.WriteLine(a / b);

            decimal cc = 1.0M;
            decimal dd = 3.0M;
            Console.WriteLine(cc / dd);
        }

        public void Main(string[] Args){
            WorkWithIntegers();
            OrderPrecedence();
            WorkWithDoublesAndDecimals();
        }
    }
}