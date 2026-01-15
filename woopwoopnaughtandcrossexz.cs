using System;
using System.Data;
using System.Reflection.Metadata;

namespace icanspoekkk
{
    class program
    {
        static void main(string[] args)
        {
            int[,] grid = 
            {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            };
            Console.WriteLine("hello and welcome to the game");
            Console.WriteLine("first player is naughts, second is crosses and if you have a third player theyre gonna have to wait.");
            Console.WriteLine("enter the row you would like to place your piece on first ");
            row = Console.ReadLine();
            Console.WriteLine("enter the column you would like to place your piece in first ");
            col = Console.ReadLine();
            bool crosses = True;

            for (int i = 0; i < grid.Length; i++)
            {
                
                while (crosses)
                {
                    grid[row, col] = "1";
                    crosses = False;
                }

                while (not(crosses))
                {
                    grid[row, col] = "2";
                    crosses = True;
                }
            }



        }

    }
}