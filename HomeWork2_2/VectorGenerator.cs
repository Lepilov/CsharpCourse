using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    class VectorGenerator<T> : IEnumerable<Vector<T>> where T : struct
    {
        private List<Vector<T>> vectors;

        public VectorGenerator(int numberVectors)
        {
            vectors = new List<Vector<T>>(numberVectors);
            var randomNumbers = new Random();
            for (int i = 0; i < numberVectors; i++)
            {
                dynamic x = randomNumbers.Next(1, 5);
                dynamic y = randomNumbers.Next(1, 5);
                vectors.Add(new Vector<T>(x,y));
            }
        }

        public IEnumerator<Vector<T>> GetEnumerator()
        {
            return vectors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return vectors.GetEnumerator();
        }
    }
}
