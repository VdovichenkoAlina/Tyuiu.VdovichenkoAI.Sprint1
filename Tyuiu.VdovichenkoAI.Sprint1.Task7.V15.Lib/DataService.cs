using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            double res = Math.Round((Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3))) - (Math.Cos(Math.Pow(x, 3)) + (Math.Pow(7 * x, 2))) / ((Math.Pow(x, 3) - (15 * x))), 3);
            return res;
        }
    }
}
