using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество строк i:");
            int stroka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество столбцов j:");
            int stolbec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Массив:");
            Console.WriteLine("-------------------------------------------------------------------------------");
            int razmMas = stroka * stolbec;//Размерность массива
            int[,] Mas = new int[stroka, stolbec];
            Random r = new Random();
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    Mas[i, j] = r.Next(-2 * razmMas, 2 * razmMas);//Размерность массива от -2*n до 2*n
                    Console.Write("{0,6:0}", Mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            int razmVek;
            do
            {
                Console.WriteLine("Количество элементов вектора:");
                razmVek = Convert.ToInt32(Console.ReadLine());
                if (razmVek != stolbec)
                {
                    Console.WriteLine("Размер вектора задан НЕ правильно!");
                    Console.WriteLine("\aВаш шанс упущен! Учите материальную часть! Количество элементов вектора\nдолжно быть одинаково с количеством столбцов в матрице!!!");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            while (razmVek != stolbec);
            int razmElemVek = razmMas;// Дмапозон значений элемента ветора
            int[] Vek = new int[razmVek];//Вектор
            int p = 0;
            Console.WriteLine("Вектор:");
            Console.WriteLine("-------------------------------------------------------------------------------");
            for (int k = 0; k < razmVek; k++)
            {
                Vek[k] = razmMas - p;
                p = p + 2;
                Console.Write("\t" + Vek[k]);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            int[] newVek = new int[stroka];
            Console.WriteLine("Результат умножения матрицы на вектор");
            Console.WriteLine("Вектор:");
            Console.WriteLine("-------------------------------------------------------------------------------");
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    newVek[i] += Mas[i, j] * Vek[j];
                }
            }
            for (int i = 0; i < stroka; i++)
            {
                Console.Write("\t" + newVek[i]);
                newVek[i] = 0;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
