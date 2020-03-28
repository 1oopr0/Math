using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Geometry
    {
        public static (double RotateX, double RotateY) GetRotatePointBy(double x, double y, double centerX, double centerY, double angle)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            //rX - cX = cos(x-cX) - sin(y-cY)
            //rY - cY = sin(x-cX) + cos(y-cY)
            var rX = cos * (x - centerX) - sin * (y - centerY) + centerX;
            var rY = sin * (x - centerX) + cos * (y - centerY) + centerY;

            return (rX, rY);
        }
    }
}
