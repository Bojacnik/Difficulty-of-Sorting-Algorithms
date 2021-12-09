using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SamostatnaPrace
{
    public static class Bubblesort
    {
        
        public static Data Sort(int[] numbers)
        {
            int Iterations;
            Stopwatch s = new Stopwatch();
            s.Start();

            Iterations = _sort(numbers);

            s.Stop();
            return new Data(s, Iterations, numbers.Length);
        }

        

        private static int _sort(int[] numbers)
        {
            int iterace = 0;
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                for (int y = 0; y < numbers.Length - 1; y++)
                {
                    if (numbers[y] > numbers[y + 1])
                    { 
                        _swap(numbers, y + 1, y);
                    }

                }
                iterace++;
            }
            return iterace;
        }

        private static void _swap(int[] numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
            return;
        }


    }
}
