using System;

namespace HomeWork_4_14
{
    class Program
    {
        static int InterFace(int number)
        {
            Console.WriteLine("Для использования одномерного массива.....1");
            Console.WriteLine("Для использования двумерного массива.....2");
            Console.Write("Выберите из выше перечисленного: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
        static void Main(string[] args)
        {
            int number = 0;
            number = InterFace(number);
            int k = 0;
            switch (number)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.Write("Введите количество элементов массива: ");
                        int n = int.Parse(Console.ReadLine());
                        double[] mass = new double[n];
                        Random rand = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            double rnd = rand.NextDouble() * 5;
                            mass[i] += rnd;
                            Console.Write("{0:0.00} ", mass[i]);
                            if (mass[i] == 0) {
                                k++;
                            }
                        }
                        double min = mass[0];
                        int index = 0;
                        double sum = 0.0;
                        for (int i = 0; i < n; i++)
                        {
                            if (mass[i] < min)
                            {
                                min = mass[i];
                                index = i;
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            if (i > index)
                            {
                                sum += mass[i];
                            }
                        }
                        Array.Sort(mass);
                        Console.WriteLine();
                        Console.Write("Отсортированный массив: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("{0:0.00} ", mass[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Сумма элементов массива, расположенных после минимального элемента: {0:0.00}", sum);
                        Console.WriteLine($"Количество нулей в массиве: {k}");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.Write("Введите количество строк и столбцов: ");
                        int n = int.Parse(Console.ReadLine());
                        Random rand = new Random();
                        int[,] dvumern_mass = new int[n, n];
                        int[,] dop_mass = new int[n, n];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                int rnd_2 = rand.Next(10);
                                dvumern_mass[i, j] += rnd_2;
                                Console.Write($"{dvumern_mass[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                dop_mass[n - 1 - i, n - 1 - j] = dvumern_mass[i, n - 1 - j];
                            }
                        }
                        Console.WriteLine("Сдвинутая матриица:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write($"{dop_mass[j, i]} ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
        }
    }
}
