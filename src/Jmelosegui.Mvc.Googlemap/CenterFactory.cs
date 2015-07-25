﻿namespace Jmelosegui.Mvc.Googlemap
{
    public class CenterFactory
    {
        public CenterFactory(GoogleMap map)
        {
            Map = map;
        }

        protected GoogleMap Map { get; private set; }

        public CenterFactory UseCurrentPosition()
        {
            Map.UseCurrentPosition = true;
            return this;
        }

        public CenterFactory Latitude(double value)
        {
            Map.Latitude = value;
            return this;
        }

        public CenterFactory Longitude(double value)
        {
            Map.Longitude = value;
            return this;
        }

        public void Address(string address)
        {
            Map.Address = address;
        }
    }
}
