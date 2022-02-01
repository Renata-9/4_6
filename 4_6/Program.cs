using System;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = N - 1;
            Console.WriteLine("Введите индекс который хотите удалить: ");
            int K = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            int[] mas2 = new int[N];
            if (K > 0)
            {
                if (K < N)
                {
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write("Введите данные в индекс массива: ");
                        mas[i] = Convert.ToInt32(Console.ReadLine());

                        if (i == K)
                        {

                        }
                        else
                        {
                            mas2[i] = i;
                            Console.WriteLine(" " + mas[i]);
                        }
                    }
                }
            }
        }
    }
}
