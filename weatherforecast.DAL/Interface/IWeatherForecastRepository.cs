using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using weatherforecast.DAL.Implementation;
using weatherforecast.Entities;

namespace weatherforecast.DAL.Interface
{
    public interface IWeatherForecastRepository : IGenericRepository<WeatherForecast>
    {
        new void Update(WeatherForecast weatherForecast);
    }
}
