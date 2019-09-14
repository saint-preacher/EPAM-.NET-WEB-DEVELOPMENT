using System;

namespace EPAM_4_task
{
    class Program
    {
        static int Factorial(int n) //Нахождение факториала
        {
            if (n == 0) //Если элемент равен 0, то вернуть факториал, равный 1
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1); // рекурсивное вычисление факториала
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число, факториал которого необходимо найти:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }
    }
}
