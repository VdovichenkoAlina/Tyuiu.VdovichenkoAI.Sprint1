using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Sqrt(Math.Abs(x - y)) + 3 * x) / (3 + Math.Abs(x)), 3);
            return res;
        }
    }
}
