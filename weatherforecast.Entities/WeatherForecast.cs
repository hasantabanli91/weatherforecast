using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace weatherforecast.Entities
{
    [Table("WeatherForecast")]
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }
    }
}
