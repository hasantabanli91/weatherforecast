using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using weatherforecast.DAL.Interface;
using weatherforecast.Entities;

namespace weatherforecast.DAL.Implementation
{
    public class WeatherForecastRepository : GenericRelationalRepository<WeatherForecast>, IWeatherForecastRepository
    {
        public new void Update(WeatherForecast weatherForecast)
        {
            using (var context = new DataBaseContext())
            {
                context.Update(weatherForecast);
                context.SaveChanges();
            }
        }
    }
}
