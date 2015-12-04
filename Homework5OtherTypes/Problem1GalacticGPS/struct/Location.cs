﻿using System;

namespace Problem1GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet) 
            : this()
        {
            this.Latitude = latitude;
            this.Llongitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be in range[0...(+/-90°)]");
                }
                this.latitude = value;
            }
        }

        public double Llongitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Llongitude must be in range[0...(+/-180°)]");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return $"{this.Latitude}, {this.Llongitude} - {this.Planet}";
        }
    }
}
