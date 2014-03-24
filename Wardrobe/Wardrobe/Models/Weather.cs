using System;

namespace Wardrobe.Models
{
    public class Weather
    {
        //TODO: Model weather AtTimeOfDay or make it composite. (Morning, afternoon, evening)
        public WeatherCondition WeatherCondition { get; set; }

        public Temperature Temperature { get; set; }

        public Weather(WeatherCondition weatherCondition, Temperature temperature)
        {
            WeatherCondition = weatherCondition;
            Temperature = temperature;
        }

        protected bool Equals(Weather other)
        {
            return WeatherCondition == other.WeatherCondition && Temperature == other.Temperature;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Weather) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) WeatherCondition*397) ^ (int) Temperature;
            }
        }
    }
}