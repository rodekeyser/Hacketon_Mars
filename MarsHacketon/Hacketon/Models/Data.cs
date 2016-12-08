using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hacketon.Models
{
    public class Data
    {
        public int Temperature;

        public int Windspeed;

        public int WindOrientation;

        public double ParticleSize;

        public DateTimeKind DateTime;

        public Data(int temperature, int windspeed, int windOrientation , double particleSize, DateTimeKind dateTime)
        {
            this.Temperature = temperature;
            this.Windspeed = windspeed;

        }
    }
}