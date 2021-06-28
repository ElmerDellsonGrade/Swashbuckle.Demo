using System;

namespace Swashbuckle.Demo
{
    public class WeatherForecast
    {
        /// <summary>
        /// Date for the weather.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in degrees Celsius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in degrees Farenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        
        /// <summary>
        /// A Summary.
        /// </summary>
        public string Summary { get; set; }
    }
}
