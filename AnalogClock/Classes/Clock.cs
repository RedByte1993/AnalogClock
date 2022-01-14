using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AnalogClock.Enums;

namespace AnalogClock.Classes
{
    public class Clock
    {
        #region Members
        Panel surface;
        System.Windows.Forms.Timer timer;
        Thread drawThread;
        PointF startPoint;
        Graphics graphics;
        ClockHands secondClockHand;
        ClockHands minuteClockHand;
        ClockHands hourClockHand;
        #endregion
        #region Ctor
        public Clock(ref Panel Surface)
        {
            startPoint = new PointF((float)(Surface.Width / 2.0), (float)(Surface.Height / 2.0));
            graphics = Surface.CreateGraphics();
            secondClockHand = new ClockHands(2, 100.0, ClockHandType.SECOND, startPoint, graphics);
            minuteClockHand = new ClockHands(5, 100.0, ClockHandType.MINUTE, startPoint, graphics);
            hourClockHand = new ClockHands(8, 50.0, ClockHandType.HOUR, startPoint, graphics);
            Surface.Paint += Surface_Paint;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            surface = Surface;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Tick();
        }


        #endregion
        #region Methodes
        private void Draw()
        {
            while (true)
            {
                DrawDail();
                secondClockHand.Draw();
                minuteClockHand.Draw();
                hourClockHand.Draw();
                Thread.Sleep(500);
                graphics.Clear(Color.LightGray);
            }
        }
        private void DrawDail()
        {
            PointF[] points = new PointF[12];
            startPoint = new PointF(surface.Width / 2.0f, surface.Height / 2.0f);
            double lenght = 150;
            double angle = 0;
            PolarCoordinates polarCoordinates;
            Vector vector;

            for (int i = 0; i < points.Length; i++)
            {
                angle = AngleConverter.ConvertToRadians((360 / 12.0) * i);
                polarCoordinates = new PolarCoordinates(lenght, angle);
                vector = polarCoordinates.ConvertToVector();
                if (i % 3 == 0)
                {
                    graphics.DrawEllipse(new Pen(Color.Black, 2), new RectangleF(vector.CalculatePoint(startPoint), new SizeF(4.0f, 4.0f)));
                }
                else
                {
                    graphics.DrawEllipse(new Pen(Color.Black, 2), new RectangleF(vector.CalculatePoint(startPoint), new SizeF(1.0f, 1.0f)));
                }
            }
        }
        private void Tick()
        {
            secondClockHand.Tick();
            minuteClockHand.Tick();
            hourClockHand.Tick();
        }
        private void Surface_Paint(object sender, PaintEventArgs e)
        {
            drawThread = new Thread(Draw);
            drawThread.Start();
        }
        #endregion
    }
}
