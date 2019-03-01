using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TC
{
    abstract class Rtd: TempTable
    {
        public double GetRbyС(double R0, double t)
        {
            return this.GetValbyС(t) * R0 / 100;
        }

        public double GetTempC(double R0, double value)
        {
            return GetTempC(value) * R0 / 100;
        }
    }
}