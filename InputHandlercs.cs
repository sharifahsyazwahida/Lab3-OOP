using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
    class InputHandlercs
    {
        public Matrix ReadMatrix()
        {
            Console.Write("Rows : ");
            int R = int.Parse(Console.ReadLine());

            Console.Write("Columns : ");
            int C = int.Parse(Console.ReadLine());

            Matrix m = new Matrix(R, C);

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write($"Value[{i},{j}] : ");
                    m.SetValue(i, j, int.Parse(Console.ReadLine()));
                }
               
            }
            return m;

        }

        public Vector ReadVector()
        {
            Console.Write("Vector Size : ");
            int S = int.Parse(Console.ReadLine());
            Vector v = new Vector(S);

            for (int i = 0; i < S; i++)
            {
                Console.Write($"Elements[{i}]: ");
                v.SetValue(i, int.Parse(Console.ReadLine()));
            }
            return v;
        }

        public void DisplayMatrix(Matrix m)
        {
            m.DisplayVal();
        }

        public void DisplayVector(Vector v)
        {
            v.DisplayVal();
        }
    }
}
