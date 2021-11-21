using System;

namespace Lab6
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while (again == 'д')
            {
                int a;
                int b;
                int total;
                char oper;

                Console.WriteLine("Введите первое число:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToInt32(Console.ReadLine());

                if (oper == '+')
                {
                    total = Sum(a, b);
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = Substract(a, b);
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = Multiply(a, b);
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = Divide(a, b);
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else if (oper == '%')
                {
                    total = DivideByModel(a, b);
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
        public static int Sum(int a, int b) { return a + b; }

        public static int Substract(int a, int b) { return a - b; }

        public static int Multiply(int a, int b) { return a * b; }

        public static int Divide(int a, int b) { return a / (b == 0 ? throw new ArgumentException(nameof(b)) : b); }

        public static int DivideByModel(int a, int b) { return a % (b == 0 ? throw new ArgumentException(nameof(b)) : b); }
    }
}
