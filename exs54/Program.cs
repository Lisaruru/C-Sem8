// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
using System;

namespace exs54
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите количество строк в массиве: ");
            int rows=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns=int.Parse(Console.ReadLine());
            
            int [,] array =GetArray(rows,columns,0,20);
            Console.WriteLine();
            PrintArray(array);   
            ArithmeticMeanColumns(array);
            int[,] GetArray(int rows, int columns, int min, int max)
            {
            int[,]result=new int[rows,columns];
            Random random = new Random();
            for (int i=0;i<rows;i++)
                {
                    for( int j=0; j<columns; j++)
                    {
                       result[i,j]= new Random().Next(min,max);
                    }
                }
                return result;
            }
   
            void PrintArray(int[,]array)
            {     
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                        Console.Write($" {array[i,j]}");
                    }
                    Console.WriteLine();
                }
            } 
             void ArithmeticMeanColumns(int[,]array)
            {   
                
                for (int j=0; j<array.GetLength(1); j++)
                {
                     double arith=0;
                     double sum=0;
                    for( int i=0; i<array.GetLength(0); i++)
                    {
                    sum+= array[i,j];
                    }
                     arith=sum/array.GetLength(0);
                     
                    Console.WriteLine ($"среднее арифметическое столбца={arith} ");
                } 
            
            } 
        }
    }
}
