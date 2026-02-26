using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
    internal class VectorRepository
    {
        private List<Vector> vector = new List<Vector>();

        public void AddVector(Vector v)
        {
            Vector.Add(v);
        }

        internal static void RemoveVector(int index)
        {
            throw new NotImplementedException();
        }

        public Vector GetVector(int index)
        {
            return vector[index];
        }
    }
}
