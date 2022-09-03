// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System;

namespace exs60
{
    class Program
    {
        static void Main(string[] args)
        {

        int[,] firstMatr = new int[2, 3];
        GetArray(firstMatr);
        Console.WriteLine("Первая матрица:");
        PrintArray(firstMatr);

        int[,] secondMatr = new int[3, 2];
        GetArray(secondMatr);
        Console.WriteLine("Вторая матрица:");
        PrintArray(secondMatr);

        int[,] thirdMatr = new int[2,2];
        ResultMatr(firstMatr, secondMatr, thirdMatr);
        Console.WriteLine("Произведение первой и второй матриц: ");
        PrintArray(thirdMatr);

        void GetArray(int[,] array)
        {

           for (int i = 0; i < array.GetLength(0); i++)
           {

              for (int j = 0; j < array.GetLength(1); j++)
              {

                array[i, j] = new Random().Next(1,10);
              }
           }
        }

        void PrintArray (int[,] array)
        {

           for (int i = 0; i < array.GetLength(0); i++)
           {

              for (int j = 0; j < array.GetLength(1); j++)
              {

                Console.Write(array[i,j] + " ");
              }
               Console.WriteLine();
           }
       }

        void ResultMatr(int[,] firstMatr, int[,] secondMatr, int[,] thirdMatr)
        {

            for (int i = 0; i < thirdMatr.GetLength(0); i++)
            {

                for (int j = 0; j < thirdMatr.GetLength(1); j++)
                {

                    int sum = 0;
                    for (int g = 0; g < firstMatr.GetLength(1); g++)
                     {
                        sum += firstMatr[i,g] * secondMatr[g,j];
                     }
                    thirdMatr[i,j] = sum;
                }
            }
        }

        }
    }
}
