using System;

namespace HomeWork6
{
    public class Matrix
    {
        public uint NumberOfRows { get;  set; }
        public uint NumberOfCols { get;  set; }
        private int[,] matrix;

        public Matrix(uint numberOfRows, uint numberOfCols)
        {
            NumberOfRows = numberOfRows;
            NumberOfCols = numberOfCols;
            DataMatrix();
        }

        protected virtual void DataMatrix()
        {
            matrix = new int[NumberOfRows, NumberOfCols];
            Random random = new Random();
            for (uint i = 0; i < NumberOfRows; i++)
            {
                for (uint j = 0; j < NumberOfCols; j++)
                {
                    this[i, j] = random.Next(1, 4);
                }
            }
        }

        public virtual int this[uint i, uint j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultAdditionOfTwoMatrices = new Matrix(firstMatrix.NumberOfRows, secondMatrix.NumberOfCols);
            for (uint i = 0; i < resultAdditionOfTwoMatrices.NumberOfRows; i++)
            {
                for (uint j = 0; j < resultAdditionOfTwoMatrices.NumberOfCols; j++)
                {
                    resultAdditionOfTwoMatrices[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return resultAdditionOfTwoMatrices;
        }

        public static Matrix operator +(Matrix firstMatrix, int number)
        {
            Matrix resultAdditionOfMatrixToNumber = new Matrix(firstMatrix.NumberOfRows, firstMatrix.NumberOfCols);
            for (uint i = 0; i < resultAdditionOfMatrixToNumber.NumberOfRows; i++)
            {
                for (uint j = 0; j < resultAdditionOfMatrixToNumber.NumberOfCols; j++)
                {
                    resultAdditionOfMatrixToNumber[i, j] = firstMatrix[i, j] + number;
                }
            }

            return resultAdditionOfMatrixToNumber;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrixMultiplications = new Matrix(firstMatrix.NumberOfRows, secondMatrix.NumberOfCols);
            for (uint i = 0; i < resultMatrixMultiplications.NumberOfRows; i++)
            {
                for (uint j = 0; j < resultMatrixMultiplications.NumberOfCols; j++)
                {
                    for (uint r = 0; r < secondMatrix.NumberOfCols; r++)
                    {
                        resultMatrixMultiplications[i, j] += firstMatrix[i, r] * secondMatrix[r, j];
                    }
                }
            }

            return resultMatrixMultiplications;
        }

        public static Matrix operator *(Matrix firstMatrix, int number)
        {
            Matrix resultMatrixMultiplicationByNumber = new Matrix(firstMatrix.NumberOfRows, firstMatrix.NumberOfCols);
            for (uint i = 0; i < resultMatrixMultiplicationByNumber.NumberOfRows; i++)
            {
                for (uint j = 0; j < resultMatrixMultiplicationByNumber.NumberOfCols; j++)
                {
                    resultMatrixMultiplicationByNumber[i, j] = firstMatrix[i, j] * number;
                }
            }

            return resultMatrixMultiplicationByNumber;
        }

        public virtual Matrix GetTranspose()
        {
            Matrix resultTransposeMatrix = new Matrix(NumberOfRows, NumberOfCols);
            for (uint i = 0; i < NumberOfRows; i++)
            {
                for (uint j = 0; j < NumberOfCols; j++)
                {
                    resultTransposeMatrix[j, i] = this[i, j];
                }
            }

            return resultTransposeMatrix;
        }

        public virtual double GetDeterminant()
        {
            if (NumberOfRows != NumberOfCols)
            {
                throw new ArgumentException("Матрица должна быть квадратной!");
            }
                
            for (uint k = 0; k < NumberOfCols - 1; k++)
            {
                for (uint j = k + 1; j < NumberOfRows; j++)
                {
                    var res = this[j, k] / this[k, k];
                    for (uint i = 0; i < NumberOfCols; i++)
                    {
                        this[j, i] = this[j, i] - res * this[k, i];
                    }
                }
            }

            double result = 1;
            for (uint i = 0; i < NumberOfRows; i++)
            {
                result *= this[i, i];
            }

            return result;
        }

        public void PrintMatrix()
        {
            for (uint i = 0; i < this.NumberOfRows; i++)
            {
                for (uint j = 0; j < this.NumberOfCols; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.WriteLine();
            }
        }
    }
}






