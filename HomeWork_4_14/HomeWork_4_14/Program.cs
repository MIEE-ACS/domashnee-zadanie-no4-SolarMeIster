using System;

namespace HomeWork_4_14
{
    class Program
    {
        static int InterFace(int number)
        {
            Console.WriteLine("Для использования одномерного массива.....1");
            Console.WriteLine("Для использования двумерного массива.....2");
            Console.WriteLine("Выход из программы.....0");
            Console.Write("Выберите из выше перечисленного: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.Clear();
                number = InterFace(number);
                int k = 0;
                if (number == 1)
                {
                    Console.Clear();
                    Console.Write("Введите количество элементов массива: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        double[] mass = new double[n];
                        Random rand = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            double rnd = rand.NextDouble() * 5;
                            mass[i] += rnd;
                            Console.Write("{0:0.0} ", mass[i]);
                            if (mass[i] == 0)
                            {
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
                            Console.Write("{0:0.0} ", mass[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Сумма элементов массива, расположенных после минимального элемента: {0:0.0}", sum);
                        Console.WriteLine($"Количество нулей в массиве: {k}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                        Console.ReadKey();
                    }
                }
                if (number == 2)
                {
                    Console.Clear();
                    int j, l, num, num2, num3, p;
                    Console.Write("Введите количество строк и столбцов: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Введите кол-во шагов: ");
                    p = int.Parse(Console.ReadLine());
                    Random rand = new Random();
                    int[,] dvumern_mass = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            int rnd_2 = rand.Next(10);
                            dvumern_mass[i, j] += rnd_2;
                            Console.Write($"{dvumern_mass[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    for (int i = 0; i < n / 2; i++)
                    {
                        for (int z = p; z > 0; z--)
                        {
                            for (j = i, num = dvumern_mass[i, j]; j < n - 1 - i; j++)
                            {
                                num2 = dvumern_mass[i, j + 1];
                                dvumern_mass[i, j + 1] = num;
                                num = num2;
                            }
                            for (l = i + 1; l < n - i; l++)
                            {
                                num3 = num;
                                num = dvumern_mass[l, j];
                                dvumern_mass[l, j] = num3;
                            }
                            for (j--, l--; j >= i; j--)
                            {
                                num3 = num;
                                num = dvumern_mass[l, j];
                                dvumern_mass[l, j] = num3;
                            }

                            for (j++, l--; l >= i; l--)
                            {
                                num3 = num;
                                num = dvumern_mass[l, j];
                                dvumern_mass[l, j] = num3;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write($"{dvumern_mass[i, j]} ");
                        Console.WriteLine();
                    }
                break;
                }
                if (number == 0)
                {
                    break;
                }
            }
        }
    }
}
