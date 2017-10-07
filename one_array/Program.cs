using System;

namespace one_array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0; int size = 0;
                Random rnd = new Random();

                Console.Write("Введите колличество элементов: ");
                size = Int32.Parse(Console.ReadLine());

                float[] m = new float[size];

                Console.WriteLine("1 : Случайный ввод");
                Console.WriteLine("2 : Ручной ввод");

                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        for (i = 0; i <= size - 1; i++)
                        {
                            m[i] = rnd.Next(-100, 100); Console.Write(" " + m[i]);
                        }
                        break;
                    case 2:
                        for (i = 0; i <= size - 1; i++)
                        {
                            Console.Write("Введите элемент № " + (i + 1) + ": ");
                            m[i] = float.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();

                        for (i = 0; i <= size - 1; i++) { Console.Write(" " + m[i]); }
                        break;
                }


                int imax = 0;
                float max = 0;

                for (i = 0; i <= size - 1; i++)
                {
                    if (m[i] > max)
                    {
                        max = m[i];
                        imax = i + 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент № " + imax + " равен " + max);

                float sum = 0; int ip = 0;

                for (i = 0; i <= size - 1; i++)
                {
                    if (m[i] > 0)
                    {
                        ip = i;
                    }
                }
                for (i = 0; i <= ip; i++)
                {
                    sum = sum + m[i];
                }

                Console.WriteLine("Сумма элементов до последнего положительного равна" + " " + sum);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
