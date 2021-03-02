using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusinessModel
{
    public class Atmosphere
    {
        private const double g = 9.81;
        private const double p = 1.29;
        private const double c = 0.15;

        public double G => g;
        public double rho => p;
        public double C => c;
    }
}
