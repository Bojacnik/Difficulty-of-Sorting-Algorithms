using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SamostatnaPrace
{
    public class InsertionSort
    {
        public static Data Sort(int[] pole)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            insertionSort(pole);

            s.Stop();
            return new Data(s, 0, pole.Length);
        }

        private static void insertionSort(int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}
