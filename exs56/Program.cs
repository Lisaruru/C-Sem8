//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;

namespace exs56
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array=new int[6,4];
            int[] array1 = new int[6];
            
            void PrintArray(int[,]array)
            {     
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i,j]} ");
                    }
                    Console.WriteLine();
                }
            } 
            
            void FillArray(int[,]array)
            {     
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                     array[i,j]=new Random().Next(1,10);
                    }
            
                }
            }
            
            void IndexRowOfMaxSumNum(int[,]array)
            {   
                
                for (int i=0; i<array.GetLength(0); i++)
                {
                    int sum=0;
                    for( int j=0; j<array.GetLength(1); j++)
                    {
                        sum= sum+array[i,j];
                    }

                    array1[i]=sum;
                  
                }
                     int min=array1[0];
                     int imin = 0;
                    
                for (int k = 0; k < array.GetLength(0); k++) 
                {
                     if (array1[k] <min)
                     {
                       min = array1[k];
                       imin = k;
                     }
                    
                } 
                    Console.WriteLine ($"номер строки с минимальной  суммой элементов={imin+1} ");
            }
           
            FillArray(array);
            Console.WriteLine("исходный массив");
            PrintArray(array);
            
 
            IndexRowOfMaxSumNum(array);
            Console.WriteLine("массив с суммами строк");

            for( int g=0; g<array1.Length;g++)
            {
                Console.Write($"{array1[g]} ");
            }  
            
        }
    }
}
