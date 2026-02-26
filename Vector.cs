using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3_
{
    class Vector
    {
        private int size;
        private int[] elements;
        public Vector(int GivenSize)
        {
            size = GivenSize;
            elements = new int[GivenSize];
        }


        public void SetValue(int index, int value)
        {
            elements[index] = value;
        }
        public int GetValue(int index)
        {
            return elements[index];
        }

        public int Size
        {
            get { return size; }
        }

        public void DisplayVal()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }

        internal static void Add(Vector v)
        {
            throw new NotImplementedException();
        }
    }

}
