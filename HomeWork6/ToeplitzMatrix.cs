using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class ToeplitzMatrix : Matrix
    {
        private int[] firstRow;
        private int[] firstCol;

        public ToeplitzMatrix(uint numberOfRows, uint numberOfCols)
            : base(numberOfRows, numberOfCols)
        {
        }

        public override int this[uint i, uint j]
        {
            get
            {
                if (i != 0 && j != 0)
                {
                    i = i - Math.Min(i, j);
                    j = j - Math.Min(i, j);
                }
                if (j == 0)
                {
                    return firstRow[i];
                }
                if (i == 0)
                {
                    return firstCol[j - 1];
                }
                return 0;
            }
            set
            {
                if (i != 0 && j != 0)
                {
                    i = i - Math.Min(i, j);
                    j = j - Math.Min(i, j);
                }
                if (j == 0)
                {
                    firstRow[i] = value;
                }
                if (i == 0)
                {
                    firstCol[j - 1] = value;
                }
            }
        }

        protected override void DataMatrix()
        {
            firstRow = new int[NumberOfCols];
            firstCol = new int[NumberOfRows - 1];

            Random random = new Random();
            for (uint i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = random.Next(1, 4);
            }
            for (uint j = 0; j < firstCol.Length; j++)
            {
                firstCol[j] = random.Next(1, 4);
            }
        }

        public void PrintToeplitzMatrix()
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