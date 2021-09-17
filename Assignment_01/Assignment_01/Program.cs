using System;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray4 = new int[][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };
            //for (int i = 0; i < jaggedArray4.Length; i++)
            //{

            //    int x = 0;

            //    // GetLength method takes integer x which 
            //    // specifies the dimension of the array
            //    for (int j = 0; j < jaggedArray4[i].GetLength(x); j++)
            //    {

            //        // Rank is used to determine the total 
            //        // dimensions of an array 
            //        for (int k = 0; k < jaggedArray4[j].Rank; k++)
            //            Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
            //                                        + jaggedArray4[i][j, k] + " ");
            //        Console.WriteLine();
            //    }
            //    x++;
            //    Console.WriteLine();
            //}
            for (int i = 0; i < jaggedArray4.Length; i++)
            {
                Console.WriteLine("\nArray :" + (i + 1));
                Console.WriteLine("=========");
                for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < jaggedArray4[i].GetLength(1); k++)
                    {
                        Console.Write(jaggedArray4[i][j, k] + " ");
                    }
                    Console.Write("} ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
