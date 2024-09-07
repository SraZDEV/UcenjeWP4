﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UcenjeCS
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            int rows = Pomocno.UcitajCijeliBroj("Unesi broj redova", 1, 20);
            int columns = Pomocno.UcitajCijeliBroj("Unesi broj stupaca", 1, 20);

            int[,] table = new int[rows, columns];
            int bottomRow = rows - 1;
            int leftColumn = 0;
            int topRow = 0;
            int rightColumn = columns - 1;
            int currentNum = 1;

            Console.WriteLine();
            Console.WriteLine("Redova: {0} - Stupaca: {1} - Ukupno: {2}", rows, columns, table.Length);
            Console.WriteLine("*********************");

            for (int t = 0; currentNum <= table.Length; t++)
            {
                for (int i = rightColumn; i >= leftColumn; i--)
                {
                    table[bottomRow, i] = currentNum++;
                }
                bottomRow--;

                for (int i = bottomRow; i >= topRow; i--)
                {
                    table[i, leftColumn] = currentNum++;
                }
                leftColumn++;

                if (topRow <= bottomRow)
                {
                    for (int i = leftColumn; i <= rightColumn; i++)
                    {
                        table[topRow, i] = currentNum++;
                    }
                    topRow++;
                }
                if (leftColumn <= rightColumn)
                {
                    for (int i = topRow; i <= bottomRow; i++)
                    {
                        table[i, rightColumn] = currentNum++;
                    }
                    rightColumn--;
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write("{0, 5}", table[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}