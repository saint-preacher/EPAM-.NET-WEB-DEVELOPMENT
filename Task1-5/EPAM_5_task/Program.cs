using System;

namespace EPAM_5_task
{
    class Program
    {
        static void CheckStr(string[] str) //Метод для проверки строки 
        {
            char[] symbol = new char[100];
            int BracketType1 = 0;
            int BracketType2 = 0;
            int BracketType3 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                foreach (char c in str[i]) 
                {
                    symbol[i] = c;

                        //Для каждого типа скобок работает правило: если скобка открывающая, 
                        //соответствующая переменная увеличивается на 1, если закрывающая - то уменьшается на 1

                    if (symbol[i] == '{')
                        BracketType1 += 1;

                    if (symbol[i] == '(')
                        BracketType2 += 1;

                    if (symbol[i] == '[')
                        BracketType3 += 1;

                    if (symbol[i] == '}')
                        BracketType1 -= 1;

                    if (symbol[i] == ')')
                        BracketType2 -= 1;

                    if (symbol[i] == ']')
                        BracketType3 -= 1;
                }
            }
            if (BracketType1 == 0 && BracketType2 == 0 && BracketType3 == 0)

            {
                Console.WriteLine("Данная строка является псп");
            }
            else
            {
                Console.WriteLine("Данная строка не является псп");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите скобочную последовательность ");
            string [] str = Console.ReadLine().Split( ' ');
            CheckStr(str);  // вызов функции
        }
    }
}
