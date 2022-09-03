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
            int temp;
            Console.WriteLine();
            PrintArray(array); 
             Console.WriteLine();  
            SortingNums(array);
             GiveArray(array); 
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
             void SortingNums(int[,]array)
            {   
                
                for (int k=0; k<array.GetLength(0); k++)
                {
          
                    for( int i=0; i<array.GetLength(0); i++)
                    {
                       for (int j = array.GetLength(1) - 1; j > i; j--)
                       if(array[k,j]>array[k,j-1])

                       {
                            temp=array[k,j-1];
                            array[k,j-1]=array[k,j];
                            array[k,j]=temp;
                        }
                     
                    } 
                } 
               
            } 

             void GiveArray(int[,] array)
             {
                  for (int i = 0; i < array.GetLength(0); i++)
                  {
                    
                     for (int j = 0; j < array.GetLength(1); j++)
                     {
                       Console.Write($"{array[i,j]}  ");
                     }
                      Console.WriteLine();
                   }
            }
        }
    }
}
