using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT3_EX
{
    class MethodesDuProjet
    {
        public void ResoudreTrinome(int a, int b, int c,out string result)
        {
            double Delta;
            result = "";
            Delta = (b*b) - 4*a*c;
            double x1;
            double x2;

            if (Delta < 0)
            {
                result = "Il n'y a pas de racines";
            }
            if(Delta == 0)
            {
                x1 = -b / (2 * a);
                result = "x1 est égal à : " + x1;
            }
            if(Delta > 0)
            {
                x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                result = "x1 est égal à : " + Math.Round(x1,2) + " x2 est égal à : " + Math.Round(x2,2);
            }
        }
    }
}
