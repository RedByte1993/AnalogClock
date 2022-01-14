using System;
namespace AnalogClock.Classes
{
    public class PolarCoordinates
    {
        #region Properties
        public double Radius { get; set; }
        public double Angle { get; set; }
        #endregion
        #region Ctor
        public PolarCoordinates(double radius, double angle)
        {
            Radius = radius;
            Angle = angle;
        }
        #endregion
        #region Methodes
        public Vector ConvertToVector()
        {
            return new Vector(Math.Round(Radius * Math.Cos(Angle), 14), Math.Round(Radius * Math.Sin(Angle), 14));
        }
        #endregion
    }
}
