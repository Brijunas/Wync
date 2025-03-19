﻿namespace Core.Dtos
{
    public class GetCurrentResponseMain
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int? Sea_Level { get; set; }
        public int? Grnd_Level { get; set; }
    }
}
