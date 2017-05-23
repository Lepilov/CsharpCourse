using System;

namespace HomeWork2_1
{
    class QuadraticAlgorithmExecutionTime
    {
        //O(n^2)
        public void LeadTime(int num1, int num2)
        {
            int sum = 0;

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    sum++;
                }
            }

            Console.WriteLine("sum = {0}", sum);
        }
    }
}
