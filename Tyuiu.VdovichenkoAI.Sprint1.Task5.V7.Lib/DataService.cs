using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double hoursPerDegree = 12.0 / 360.0;

            double hoursPassed = f * hoursPerDegree;

            double h = hoursPassed % 12;

            return (int)h;
        }
    }
}
