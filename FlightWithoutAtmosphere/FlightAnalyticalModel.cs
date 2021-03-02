using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusinessModel
{
    public class FlightAnalyticalModel
    {
        private Atmosphere atmosphere;
        private Body body;
        private const double dt = 0.01;
        private double a;
        private double t;
        private double xMax, yMax;
        private double k;

        public double XMax => xMax + 0.5;
        public double YMax => yMax + 0.5;
        public Body Body => body;
        
        public FlightAnalyticalModel(double a, double v0, double y0, double S, double m)
        {
            this.a = a;

            body = new Body(S, m, v0, y0, a);
            atmosphere = new Atmosphere();

            k = 0.5 * atmosphere.C * body.S * atmosphere.rho / body.M;
            
            t = 0;

            double xAdd = body.Vx * (Math.Sqrt(body.Vy * body.Vy + 2 * atmosphere.G * body.Y0) - body.Vy) / atmosphere.G;
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


            xMax = body.V0 * body.V0 * Math.Sin(2 * a) / atmosphere.G + xAdd;
            yMax = body.Y0 + body.V0 * body.V0 * Math.Sin(a) * Math.Sin(a) / (2 * atmosphere.G);
        }

        public void ChangeValues()
        {
            t += dt;

            double sqrt = Math.Sqrt(body.Vx * body.Vx + body.Vy * body.Vy);

            double newVx = body.Vx - k * body.Vx * Math.Sqrt(body.Vx * body.Vx + body.Vy * body.Vy) * dt;
            double newVy = body.Vy - (atmosphere.G + k * body.Vy * Math.Sqrt(body.Vx * body.Vx + body.Vy * body.Vy)) * dt;

            body.ChangeSpeed(newVx, newVy);

            double newX = body.X + newVx * dt;
            double newY = body.Y + newVy * dt;

            body.ChangeCoordinates(newX, newY);
        }

        public string GetTime()
        {
            return Math.Round(t, 3).ToString();
        }

    }
}
