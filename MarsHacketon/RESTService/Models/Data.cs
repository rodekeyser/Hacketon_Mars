using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTService.Models
{
    public class Data
    {
        public double Temperature
        {
            get;
            set;
        }
        public double WindSpeed
        {
            get;
            set;
        }
        public WindOrientation WindOrientation
        {
            get;
            set;
        }
        public double ParticleSize
        {
            get;
            set;
        }
        public string TimeStamp
        {
            get;
            set;
        }
        public Data(double Temperature, double WindSpeed, WindOrientation WindOrientation, double ParticleSize, string TimeStamp)
        {
            this.Temperature = Temperature;
            this.WindSpeed = WindSpeed;
            this.WindOrientation = WindOrientation;
            this.ParticleSize = ParticleSize;
            this.TimeStamp = TimeStamp;
        }
    }
}