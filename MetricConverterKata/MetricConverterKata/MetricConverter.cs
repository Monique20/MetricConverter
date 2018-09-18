using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverterKata
{
    public class MetricConverter
    {
        public double ConvertToMiles(int km)
        {
            var miles = (km * 0.621371);
            return miles;
        }

        public double ConvertToFahrenheit(int celsius)
        {
            var fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }

        public double ConvertToPounds(int kg)
        {
            var pounds = (kg / 0.45359237);
            return pounds;
        }

        public double ConvertToGallons(int liters, string targetUnit)
        {
            var gallons = 0.0;
            if (targetUnit == "US")
            {
                gallons = liters * 3.785411784;
            }
            else
            {
                gallons = liters * 4.54609;
            }
            return gallons;
        }
    }
}
