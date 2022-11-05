using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using weatherforecast.Entities;

namespace weatherforecast.BLL.Interface
{
    public interface IWeatherforecastService
    {
        WeatherForecast Create(WeatherForecast weatherForecast);
        ICollection<WeatherForecast> GettAll();
        WeatherForecast GetById(int id);
        void Update(WeatherForecast weatherForecast);
        void Delete(int id);
    }
}
