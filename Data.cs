using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SamostatnaPrace
{
    public class Data
    {
        public readonly Stopwatch Time;
        public readonly int Length;
        public readonly int Iterations;

        public Data(Stopwatch s, int Iterations)
        {
            this.Time = s;
            this.Iterations = Iterations;
        }

        public Data(Stopwatch s, int Iterations, int length)
        {
            this.Time = s;
            this.Iterations = Iterations;
            this.Length = length;
        }
            

    }
}
