using System;
using System.Drawing;
namespace AnalogClock.Classes
{
    public class Vector
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        #endregion
        #region Ctor
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion
        #region Methodes
        public double ScalarProduct(Vector other)
        {
            return X * other.X + Y * other.Y;
        }
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public PolarCoordinates ConvertToPolarCoordinates()
        {
            return new PolarCoordinates(Magnitude(), Math.Atan(Y / X));
        }
        public PointF CalculatePoint(PointF p)
        {
            return new PointF((float)(p.X + X), (float)(p.Y + Y));
        }
        #endregion
    }
}
