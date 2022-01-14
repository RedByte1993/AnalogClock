using System;
using System.Drawing;
using AnalogClock.Enums;

namespace AnalogClock.Classes
{
    
    public class ClockHands
    {
        #region Members
        private int stroke;
        private ClockHandType clockhandType;
        private PointF startPoint, endPoint;
        private Vector vector;
        private Graphics graphics;
        private PolarCoordinates polarCoordinates;
        #endregion
        #region Properties
        public double Length { get; set; }
        public double Angle { get; set; }
        #endregion
        #region Ctor
        public ClockHands(int stroke,double length,ClockHandType clockHandType, PointF startPoint, Graphics graphics)
        {
            this.stroke = stroke;
            Length = length;
            this.startPoint = startPoint;
            this.graphics = graphics;
            this.clockhandType = clockHandType;
            polarCoordinates = new PolarCoordinates(Length, Angle);
            vector = polarCoordinates.ConvertToVector();
            endPoint = vector.CalculatePoint(startPoint);
            Tick();
        }
        #endregion
        #region Methodes
        public void Draw()
        {
            Pen pen = new Pen(Color.Black, stroke);
            graphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }
        public void Tick()
        {
            switch (clockhandType)
            {
                case ClockHandType.SECOND:
                    Angle = AngleConverter.ConvertToRadians(((360 / 60.0) * DateTime.Now.Second) + 270.0);
                    break;
                case ClockHandType.MINUTE:
                    Angle = AngleConverter.ConvertToRadians(((360 / 60.0) * DateTime.Now.Minute) + 270.0);
                    break;
                case ClockHandType.HOUR:
                    Angle = AngleConverter.ConvertToRadians(((360 / 12.0) * DateTime.Now.Hour) + 270.0);
                    break;
                default:
                    break;
            }
            polarCoordinates = new PolarCoordinates(Length, Angle);
            vector = polarCoordinates.ConvertToVector();
            endPoint = vector.CalculatePoint(startPoint);
        }
        #endregion
    }
}
