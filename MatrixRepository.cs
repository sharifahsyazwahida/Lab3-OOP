using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
    internal class MatrixRepository
    {
        private List<Matrix> matrices = new List<Matrix>();

        public void AddMatrix(Matrix m)
        {
            matrices.Add(m);
        }

        public void RemoveMatrix(int index)
        {
            matrices.RemoveAt(index); 
        }

        public Matrix GetMatrix(int index)
        {
            return matrices[index];
        }
    }
}
