//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
using System;

namespace exs62
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,]array =new int[2,2,2];
            int [] temparray = new int [8];
            Random random=new Random();
            FillFlatArray(temparray);
            FillArray(array,temparray);
            PrintArray(array); 

            void FillFlatArray(int[] arr) 
            {
                bool existnum;
                for (int i=0; i<8;) 
                {
                    int ran = random.Next(1,9);
                    existnum = false; 
                    for (int ii=0; ii<8; ii++)
                    {
                         if (temparray[ii] == ran)
                            {
                                existnum =true;
                                break;                        
                            }
                    }    
                    if (!existnum)
                    {
                        temparray[i] = ran;
                        i++;
                    }                  
                }
            }
             
             
             void FillArray(int[,,]array, int[]temparray)
            {
                
                for (int l=0; l<8;)
                {
                    for( int i=0; i<2; i++)
                    {
                       for (int j = 0; j < 2; j++)
                       {                    
                            for (int k = 0; k < 2; k++)
                            {
                                array[i,j,k] = temparray[l];
                                l++;
                            }
                       
                       }
        
                    }
                }
            }
   
            void PrintArray(int[,,]array)
            {   
              
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {

                            Console.Write ($"{array[i, j, k] } ({i}{j}{k})"+ " ");
                        }
                        Console.WriteLine();
                    }
                      
                }  
           }
        }
    }
}
