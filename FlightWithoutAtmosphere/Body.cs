using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusinessModel
{
    public class Body
    {
        private double v0, vx, vy;
        private double y0, x, y;
        private double s;
        private double m;

        public double M => m;
        public double X => x;
        public double Y => y;
        public double Y0 => y0;
        public double S => s;
        public double Vx => vx;
        public double Vy => vy;
        public double V0 => v0;

        public Body(double s, double m, double v0, double y0, double a)
        {
            this.v0 = v0;
            this.y0 = y0;
            this.s = s;
            this.m = m;

            vx = v0 * Math.Cos(a);
            vy = v0 * Math.Sin(a);

            x = 0;
            y = y0;
        }

        public void ChangeSpeed(double newVx, double newVy)
        {
            vx = newVx;
            vy = newVy;
        }

        public void ChangeCoordinates(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
    }
}
