using System;

namespace EPAM_3_task
{
    class Program
    {
        static void OneWord(string[] str) // Метод для нахождения слова, встречающегося в строке только один раз
        {
            int counter = 0; //Счётчик для подсчета количества вхождений слова
            string temp;
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i]; 

                for (int j = 0; j < str.Length; j++)
                {
                    if (temp == str[j]) //Сравнение элемента строки со всеми остальными
                        counter++;
                }
                if (counter == 1) //Если счётчик равен 1, значит слово присутствует в единственном экземпляре
                    Console.WriteLine(str[i]); 
                counter = 0;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");

            string[] str = Console.ReadLine().Split(' ', ',', ':', ';', '.', '!', '?', '/','|', '[',']','{','}');

            OneWord(str); 
        }
    }
}
