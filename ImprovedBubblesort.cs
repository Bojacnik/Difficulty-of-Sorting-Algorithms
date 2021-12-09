using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SamostatnaPrace
{
    public class ImprovedBubblesort
    {
        public static Data Sort(int[] pole)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            improvedBubbleSort(pole);

            s.Stop();
            return new Data(s, 0, pole.Length);
        }

        static void improvedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

    }
}
