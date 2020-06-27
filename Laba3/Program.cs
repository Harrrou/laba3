using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Random r = new Random();
            Console.Write("Размер массива N = ");
            int n = int.Parse(Console.ReadLine());
            /*  int[] array = new int[n];*/
            double[] array = new double[n];
            int min = 0;


            for (int i = 0; i < array.Length; i++)
            {
                /*array[i] = r.Next(-10, 10);*/
                array[i] = (Math.Round((r.NextDouble() - 0.5) * 100)) / 10;
                Console.Write(array[i] + "  ");
                if (array[min] > array[i])
                    min = i;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент = {0}", array[min]);
            int first = -1, last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    first = i;
                    break;
                }
            }
            if (first == -1)
            {
                Console.WriteLine("\nВ массиве нет положительных элементов");
                Console.ReadKey();
                return;
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    last = i;
                    break;
                }
            }
            if (first == last)
            {
                Console.WriteLine("\nВ массиве только один положительный элемент");
                Console.ReadKey();
                return;
            }
            for (int i = first + 1; i < last; i++)
            {
                result += array[i];
            }
            Console.WriteLine("\nСумма элементов, между первым и последним: " + result);
            for (int i = 0, j = 0; i < array.Length; i++)
                if (array[i] <= 1)
                    if (array[i] >= 0)
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        j++;
                    }
            Console.WriteLine();
            Console.WriteLine("Преобразованный массив(сначала нулевые, потом все остальные):");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0}  ", array[i]);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

        
    

