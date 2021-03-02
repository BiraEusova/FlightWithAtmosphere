using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightWithoutAtmosphere
{
    public class FlightAnalyticalModel
    {
        const double dt = 0.01;
        const double g = 9.81;
        const double C = 0.15;
        const double p = 1.29;

        private double a;
        private double v0, vx, vy;
        private double y0;
        private double t;
        private double x, y, xMax, yMax;
        //public double outputT;
        private double S, m, k;

        public double XMax => xMax + 0.5;
        public double YMax => yMax + 0.5;
        public double X => x;
        public double Y => y;

        public FlightAnalyticalModel(double a, double v0, double y0, double S, double m)
        {
            this.a = a;
            this.v0 = y0;
            this.y0 = y0;
            this.S = S;
            this.m = m;

            k = 0.5 * C * S * p / m;

            vx = v0 * Math.Cos(a);
            vy = v0 * Math.Sin(a);

            t = 0;
            x = 0;
            y = y0;

            double xAdd = vx * (Math.Sqrt(vy * vy + 2 * g * y0) - vy) / g;
            // Если тело брошено с какой-то высоты y0, то обычная формула расчета 
            // максимальной дальности полета не подойдет (данная формула основана
            // на времени подъема тела до самой высокой точки), т.к. при падении относительно самой высокой точки полета
            // тело по оси оХ преодолевает большее расстояние, чем до этой точки.
            // Следовательно, надо прибавить расстояние, 
            // пройденное телом по оси оХ после достижения уровня высоты у0 при падении.
            // Если y0 = 0, то xAdd также = 0.
            //
            // UPD Не знаю как точно считать эту величину с сопротивлением воздуха,
            // но лучше на графике останется свободное место, чем он обрежется


            xMax = v0 * v0 * Math.Sin(2 * a) / g + xAdd;
            yMax = y0 + v0 * v0 * Math.Sin(a) * Math.Sin(a) / (2 * g);
        }

        public void ChangeValues()
        {
            t += dt;

            vx = vx - k * vx * Math.Sqrt(vx * vx + vy * vy) * dt;
            vy = vy - (g + k * vy * Math.Sqrt(vx * vx + vy * vy)) * dt;

            x = x + vx * dt;
            y = y + vy * dt;
        }

        public string GetTime()
        {
            return Math.Round(t, 3).ToString();
        }

    }
}
