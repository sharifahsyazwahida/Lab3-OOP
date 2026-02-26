using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Matrix_lab_3_
{
    internal class Calculator
    {
        private MatrixRepository MatrixRepo;
        private VectorRepository VectorRepo;
        private DimensionValidator v;

        public Calculator(MatrixRepository mRepo, VectorRepository vRepo, DimensionValidator val)
        {
            MatrixRepo = mRepo;
            VectorRepo = vRepo;
            v = val;
        }

        public Matrix AddMatrices(int i1, int i2)
        {
            Matrix m1 = MatrixRepo.GetMatrix(i1);
            Matrix m2 = MatrixRepo.GetMatrix(i2);

            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                return null;

            }

            Matrix result = new Matrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result.SetValue(i, j, m1.GetValue(i, j) + m2.GetValue(i, j));
                }
                
            }
            return result;  
        }
    }
}
