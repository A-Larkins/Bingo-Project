/*
 * Andrew Larkins
 * Cis-3309-01
 * Project 1
 * Bingo Game
 * 02/4/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{

    // Class used for the internal board.
    class InternalCardType2DimArray
    {

        public const int BINGOSIZE = 5;

        // Creates the bingo board to keep track.
        // Board is made up of 1s and 0s.
        // 5 x 5
        // 1 in center is the free spot in bingo.
        public static int[,] internalBoard = new int[5, 5] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 } };

        // Check for BINGO.
        // Keeps track of gameplay by tracking every 1 onto the
        // array of ints. Return 1 if the user has BINGO.

        public static int isWinner(int row, int column)
        {
            int ret = 0;
            trackCalledNumber(row, column);
            if (checkRows() || checkColumns() || checkLeftDiagonal() || checkRightDiagonal())
            {
                ret = 1;
            }
            return ret;
        }

        // Keep track of buttons clicked. If button clicked it is marked as 1 in the 2D array.
        public static void trackCalledNumber(int row, int column)
        {
            internalBoard[row, column] = 1;
            
        }

        // Check rows method will check for BINGO row by row starting with 0 and going to row 4.
        public static Boolean checkRows()
        {
            int count = 0;
            bool ret = false;
            int i = 0;
            
            for(int j = 0; j <= 5; j++)
            {
                if(internalBoard[i, j] == 1)
                {
                    count++;
                    if(count == 5)
                    {
                        ret = true;
                        break;
                    }
                }
                if(j == 4)
                {
                    j = -1;
                    i++;
                    if(i == 5)
                    {
                        break;
                    }
                    count = 0;
                }
            }
            return ret;
        }

        // Check columns method will check for BINGO column by column  starting with 0 and going to column 4.
        public static Boolean checkColumns()
        {
            int count = 0;
            bool ret = false;
            int j = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (internalBoard[i, j] == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        ret = true;
                        break;
                    }
                }
                if (i == 4)
                {
                    i = -1;
                    j++;
                    if (j == 5)
                    {
                        break;
                    }
                    count = 0;
                }
            }
            return ret;
        }
        
        // Check for BINGO going from top right to bottom left diagonally.
        public static Boolean checkRightDiagonal()
        {
            int count = 0;
            bool ret = false;
            int i = 0;
            int j = 4;
            while (true)
            {
                if (internalBoard[i, j] == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        ret = true;
                        break;
                    }
                    i++;
                    j--;
                }
                else
                {
                    i++;
                    j--;
                }
                if (i == 5)
                {
                    break;
                }
            }
            return ret;
        }

        // Check for BINGO going from top left to bottom right diagon alley.
        public static Boolean checkLeftDiagonal()
        {
            int count = 0;
            bool ret = false;
            int i = 0;
            int j = 0;
            while (true)
            {
                if (internalBoard[i, j] == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        ret = true;
                        break;
                    }
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                if(i == 5)
                {
                    break;
                }
            }
            return ret;
        }
    }
}
