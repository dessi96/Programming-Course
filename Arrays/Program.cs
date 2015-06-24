using System;
using System.Collections.Generic;

  class Program
    {
        static void Main(string[] args)
        {
            // multidiementional arrays

            CreateGrid();

        }
        public static void CreateGrid()
        {
            int width = 20;
            int height = 20;

            int[,] grid = new int[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }

