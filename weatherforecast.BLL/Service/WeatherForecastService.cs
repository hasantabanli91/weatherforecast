using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weatherforecast.BLL.Interface;
using weatherforecast.DAL.Interface;
using weatherforecast.Entities;

namespace weatherforecast.BLL.Service
{
    public class WeatherForecastService : IWeatherforecastService
    {
        private IWeatherForecastRepository _weatherforecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            this._weatherforecastRepository = weatherForecastRepository;
        }
        public WeatherForecast Create(WeatherForecast weatherForecast)
        {
            return _weatherforecastRepository.Insert(weatherForecast);
        }

        public void Delete(int id)
        {
            var entity = _weatherforecastRepository.GetById(id);
            _weatherforecastRepository.Delete(entity);
        }

        public WeatherForecast GetById(int id)
        {
            return _weatherforecastRepository.GetById(id);
        }

        public ICollection<WeatherForecast> GettAll()
        {
            return _weatherforecastRepository.GetAll();
        }

        public void Update(WeatherForecast weatherForecast)
        {
            _weatherforecastRepository.Update(weatherForecast);
        }
    }
}
