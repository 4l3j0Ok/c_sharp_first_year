﻿using System;

namespace more_arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            ejercicio_uno();
            Console.WriteLine();
            Console.ReadKey();
            ejercicio_dos();
            Console.WriteLine();
            Console.ReadKey();
            ejercicio_tres();
            Console.WriteLine();
            Console.ReadKey();
            ejercicio_cuatro();
        }

        public static void ejercicio_uno()
        {
            int total_columns = 6;
            int total_rows = 4;
            string[,] values = new string [total_rows, total_columns];
            for (int row = 0;  row != total_rows; row += 1)
            {
                for (int column = 0; column != total_columns; column += 1)
                {
                    values[row, column] = Convert.ToString(column + 1) + " ";
                    Console.Write(values[row, column]);
                }
                Console.WriteLine();
            }
        }
        public static void ejercicio_dos()
        {
            int total_columns = 6;
            int total_rows = 6;
            string[,] values = new string[total_rows, total_columns];

            for (int row = 0; row != total_rows; row += 1)
            {
                for (int column = 0; column != total_columns; column += 1)
                {
                    if ((row == 0) || (column == 0)) values[row, column] = "1 ";
                    else if ((row == total_rows - 1) || (column == total_columns - 1)) values[row, column] = "1 ";
                    else values[row, column] = "0 ";
                    Console.Write(values[row, column]);
                }
                Console.WriteLine();
            }
        }
        public static void ejercicio_tres()
        {
            int total_columns = 6;
            int total_rows = 6;
            int one_pos = total_columns -1;
            string[,] values = new string[total_rows, total_columns];

            for (int row = 0; row != total_rows; row += 1)
            {
                for (int column = 0; column != total_columns; column += 1)
                {
                    if (column == one_pos)
                    {
                        values[row, column] = "1 ";
                        one_pos -= 1;
                    }
                    else values[row, column] = "0 ";
                    Console.Write(values[row, column]);
                }
                Console.WriteLine();
            }
        }

        public static void ejercicio_cuatro()
        {
            int total_columns = 5;
            int total_rows = 5;
            int mid_row = (total_rows / 2);
            int mid_column = (total_columns / 2);
            string[,] values = new string[total_rows, total_columns];

            for (int row = 0; row != total_rows; row += 1)
            {
                for (int column = 0; column != total_columns; column += 1)
                {
                    if ((column == mid_column) && (row == mid_row)) values[row, column] = "1 ";
                    else if ((row == 0) && (column == 0 || column == total_columns -1)) values[row, column] = "1 ";
                    else if ((row == total_rows -1) && (column == 0 || column == total_columns - 1)) values[row, column] = "1 ";
                    else values[row, column] = "0 ";
                    Console.Write(values[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}