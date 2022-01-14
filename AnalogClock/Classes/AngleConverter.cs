using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock.Classes
{
    public static class AngleConverter
    {
        public static double ConvertToRadians(double degree)
        {
            return degree * Math.PI / 180.0;
        }
        public static double ConvertToDegree(double radians)
        {
            return radians * 180.0 / Math.PI;
        }
    }
}
