using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
    internal class DimensionValidator
    {
        public static bool ValidateMatrix(Matrix m1, Matrix m2) => m1.Rows == m2.Rows && m1.Columns == m2.Columns;

        public bool ValidateVector(Vector v1, Vector V2)
        {
            return v1.Size == V2.Size; 
        }

    }
}
