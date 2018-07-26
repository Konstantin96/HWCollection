using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollections
{
    public class Services
    {


        public static List<int> AddList()
        {
            List<int> list = new List<int>(20);

            Random random = new Random();

            for (int i = 0; i < list.Capacity; i++)
            {              
                list.Add(random.Next(-9, 10));
            }
            
            return list;
        }

        public static void ListDouble()
        {
            Console.WriteLine();
            ArrayList list = new ArrayList();

            Random random = new Random();
            Console.WriteLine("Initial list: ");
            int average = 0;
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-20, 20));
                average += (int)list[i];
                Console.Write(list[i] + " ");
            }
            average /= list.Count;
            Console.WriteLine("\n\nСреднее число:\n" + average);

            Console.WriteLine("\nЛист все элементы больше среднего: ");
            list.Sort();
            foreach (int item in list)
            {
                if (item > average)
                {
                    Console.Write(item + " ");
                }
            }
            
            Console.WriteLine("\n");

        }
        public static void Show(List<int>list)
        {

            int summa = 0;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < list.Capacity; i++)
            {
                Console.Write("[{0}]:{1}", i, list[i]);
                if (i % 2 == 0)
                    summa += list[i];
                Console.Write("\t");
            }

            int max = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[max])
                {
                    max = i;
                }
            }

            int premax = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (i != max && list[i] != list[max] && list[i] > list[premax])
                {
                    premax = i;
                }
            }
            Console.WriteLine("\n\nВторое максимальное значение: [" + premax + "] : " + list[premax]);

            Console.WriteLine("\nСумма чисел на четных позицияx = " + summa);
            Console.WriteLine();
            Console.WriteLine("Удалены нечетные");
            for (int i = 0; i < list.Count; i++)
            {
                if (Math.Abs((int)list[i]) % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine();
            int j = 0;
            foreach (int item in list)
            {
                Console.Write("[{0}]:{1}", j, item);
                j++;
            }
            Console.WriteLine();

        }
    }
}
