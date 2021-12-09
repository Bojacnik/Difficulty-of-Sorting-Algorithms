using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SamostatnaPrace
{
    class MinMax
    {
        public static Data Sort(int[] pole)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            minMaxSelectionSort(pole, pole.Length);

            s.Stop();
            return new Data(s, 0, pole.Length);
        }

        private static void minMaxSelectionSort(int[] arr, int n)
        {
            for (int i = 0, j = n - 1;
                     i < j; i++, j--)
            {
                int min = arr[i], max = arr[i];
                int min_i = i, max_i = i;
                for (int k = i; k <= j; k++)
                {
                    if (arr[k] > max)
                    {
                        max = arr[k];
                        max_i = k;
                    }

                    else if (arr[k] < min)
                    {
                        min = arr[k];
                        min_i = k;
                    }
                }

                _swap(arr, i, min_i);

                if (arr[min_i] == max)
                    _swap(arr, j, min_i);
                else
                    _swap(arr, j, max_i);
            }
        }

        private static int[] _swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }
    }
}
