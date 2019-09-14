using System;

namespace EPAM_2_task
{
    class Program
    {
        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод, возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //метод для быстрой сортировки
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static int BinarySearch(int[] array, ref int searchedValue, int left, int right)
        {
            while (left <= right)
            {
                //индекс среднего элемента
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    //поиск с правой стороны
                    right = middle - 1;
                }
                else
                {
                    //поиск с левой стороны
                    left = middle + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            var len = Convert.ToInt32(Console.ReadLine());
            var a = new int[len];
            for (var i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(a)));

            Console.Write("Введите искомое значение: ");
            var k = Convert.ToInt32(Console.ReadLine());

            var searched = BinarySearch(a, ref k, 0, a.Length - 1);
            if (searched < 0)
            {
                Console.WriteLine("Элемент со значением {0} не найден", k);
            }
            else
            {
                Console.WriteLine("Элемент найден. Индекс искомого элемента {0} = {1}", k, searched);
            }
        }
    }
}

