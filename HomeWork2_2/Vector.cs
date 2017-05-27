using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    class Vector<T> where T : struct
    {
        public T X { get; private set; }

        public T Y { get; private set; }

        public Vector(T xPos, T yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString()
        {
            return $"X: {X} ; Y: {Y}";
        }

        public static Vector<T> operator +(Vector<T> beginningVector, Vector<T> endVector)
        {
            dynamic beginningX = beginningVector.X;
            dynamic beginningY = beginningVector.Y;
            return new Vector<T>(beginningX + endVector.X, beginningY + endVector.Y);
        }

        public static Vector<T> operator *(Vector<T> beginningVector, T number)
        {
            dynamic beginningX = beginningVector.X;
            dynamic beginningY = beginningVector.Y;
            return new Vector<T>(beginningX * number, beginningY * number);
        }

        public void ResetVector()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
