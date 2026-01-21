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
                
                while (crosses)
                {
                    grid[row, col] = 1;
                    crosses = false;
                }

                while (!(crosses))
                {
                    grid[row, col] = 2;
                    crosses = true;
                }
            }

        }

        static string PrintGrid(string[] args)
        {
            

        }

    }
}