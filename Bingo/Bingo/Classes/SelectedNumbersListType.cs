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
    public class SelectedNumbersListType
    {
        // 76 total numbers in bingo
        int[] numsUsed = new int[76];

        // Method to set back to 0
        public void reset()
        {
            for (int i = 0; i < 76; i++)
            {
                numsUsed[i] = 0;
            }
        }

        // Method to check if called number is unique
        // (has been used)
        public Boolean isNumberUsed(int calledNum)
        {
            return (numsUsed[calledNum] != 0);
        }

        // The display num
        public void setUsedNumber(int num)
        {
            numsUsed[num] = num;
        }

    }
}
