using System;
using System.Data;
using System.Reflection.Metadata;

namespace icanspoekkk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = 
            {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            };
            Console.WriteLine("hello and welcome to the game");
            Thread.Sleep(1000);
            Console.WriteLine("first player is naughts, second is crosses and if you have a third player theyre gonna have to wait.");
            Thread.Sleep(1000);
            Console.WriteLine("enter the row you would like to place your piece on first ");
            int row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the column you would like to place your piece in first ");
            int col = Convert.ToInt16(Console.ReadLine());
            bool crosses = true;

            for (int i = 0; i < grid.Length; i++)
            {
                
                if (crosses)
                {
                    grid[row, col] = 1;
                }

                if (!(crosses))
                {
                    grid[row, col] = 2;
                }
                crosses = !crosses;
                
            }
            Program.PrintGrid(grid);


        }

        static void PrintGrid(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i,j] + "\t");
                }
                Console.WriteLine();
            }
            

        }

    }
}