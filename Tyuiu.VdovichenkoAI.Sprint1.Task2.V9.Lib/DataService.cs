using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            return Math.Round(volume, 3);

        }
    }
}
