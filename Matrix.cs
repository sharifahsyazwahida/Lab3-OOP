using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
     class Matrix
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private double[,] Value;

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Value = new double[Rows, Columns];
        }
        public void SetValue(int rows, int column, double value)
        {
            if (rows >= 0 && rows < Rows && column >= 0 && column < Columns)
            {
                Value[rows, column] = value;
            }
        }

        public double GetValue(int rows, int column)
        {
            return Value[rows, column];
        }

        public void DisplayVal()
        {
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(Value[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
        
    }
}
