using System;
using System.Collections.Generic;
using System.IO;
class Solution {

static void displayPathtoPrincess(int n, String [] grid){
    int botRow = 0, botCol = 0, princessRow = 0, princessCol = 0;

        // Get the coordinates for the bot and the princess
        //r is row, c is column
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < grid.Length; c++)
            {
                if (grid[r][c] == 'm')
                {
                    botRow = r;
                    botCol = c;
                }
                else if (grid[r][c] == 'p')
                {
                    princessRow = r;
                    princessCol = c;
                }
            }
        }

        // Move the bot up or down until it reaches the same row as the princess
        if( princessRow < botRow )
        {
            while(botRow != princessRow)
            {
                botRow--;
                Console.WriteLine("UP");
            }
        }
        else if( princessRow > botRow )
        {
            while(botRow != princessRow)
            {
                botRow++;
                Console.WriteLine("DOWN");
            }
        }

        // Move the bot left or right until it reaches the same column as the princess
        if( princessCol < botCol )
        {
            while(botCol != princessCol)
            {
                botCol--;
                Console.WriteLine("LEFT");
            }
        }
        else if( princessCol > botCol )
        {
            while(botCol != princessCol)
            {
                botCol++;
                Console.WriteLine("RIGHT");
            }
        }
  }

static void Main(String[] args) 
{
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}
