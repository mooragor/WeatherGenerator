using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherGenerator
{
    internal class Forecast
    {

        static string[] directions = ["N", "NE", "E", "SE", "S", "SW", "W", "NW"];

        public static string RandomDirection()
        {
            int position = new Random().Next(0, directions.Length);
            return directions[position];
        }

        // Latitude 90 -> -90 inclusive to 6 decimal places
        public static string RandomLatitude()
        {
            return RandomDouble(90, -90, 6);
        }

        // Longitude 180 -> -180 inclusive to 6 decimal places
        public static string RandomLongitude()
        {
            return RandomDouble(180, -180, 6);
        }

        public static string RandomCelcius() 
        {
            return RandomDouble(50, -90, 1);
        }

        public static string RandomFahrenheit()
        {
            return RandomDouble(136, -126, 1);
        }

        public static string RandomTemperature()
        {
            // don't like putting the formatting (\t) in here, but it works
            if (new Random().Next(100) > 50)
                return RandomCelcius() +"\tC";
            else
                return RandomFahrenheit() + "\tF";

        }

        public static string RandomPrecipitation()
        {
            return RandomDouble(100, 0, 0);
        }
        public static string RandomWindSpeed()
        {
            return RandomDouble(410, 0, 1);
        }


        /**
         * Returns a string formatted positive or negative double always to X decimal places.
         */
        private static string RandomDouble(int max, int min, int decimalPlaces)
        {
            Random random = new Random();
            double degrees = random.NextDouble() * (max - min) + min;
            return degrees.ToString($"F{decimalPlaces}");
        }


    }


}
