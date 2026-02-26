using Matrix_lab_3_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_lab_3
{
    class program
    {
        internal class Program
        {

            static void Main()
            {
                InputHandlercs input = new InputHandlercs();
                MatrixRepository mRepo = new MatrixRepository();
                VectorRepository vRepo = new VectorRepository();
                DimensionValidator validator = new DimensionValidator();

                Calculator calc = new Calculator(mRepo, vRepo, validator);

                Matrix m1 = input.ReadMatrix();
                Matrix m2 = input.ReadMatrix();

                mRepo.AddMatrix(m1);
                mRepo.AddMatrix(m2);

                Matrix result = calc.AddMatrices(0, 1);
                Console.WriteLine("Results : ");
                result.DisplayVal();
            }

        }
    }
    
}
    
