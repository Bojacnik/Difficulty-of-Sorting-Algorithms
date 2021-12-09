using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostatnaPrace
{
    public static class Fill
    {
        public static void Array(int[] array)
        {
            Random rdm = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rdm.Next(0, 50000);
        }
    }
}
