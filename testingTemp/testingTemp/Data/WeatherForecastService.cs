using EndToEndDB.Data.EndToEnd;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EndToEnd.Data
{
    public class WeatherForecastService
    {
        private readonly EndtoEndContext _context;
        public WeatherForecastService(EndtoEndContext context)
        {
            _context = context;
        }

        public Task<List<WeatherForecast>>
            GetForecastsAsync(string strCurrentUser)
        {
            List<WeatherForecast> colWeatherForecasts =
                new List<WeatherForecast>();
            //Get Weather Forecasts
            colWeatherForecasts =
                (from weatherForecast in _context.WeatherForecast
                     //only get entries for the current logged in user
                 where weatherForecast.UserName == strCurrentUser
                 select weatherForecast).ToList();

            return Task.FromResult(colWeatherForecasts);
        }

        public Task<WeatherForecast>
            CreateForecastAsync(WeatherForecast objWeatherForecast)
        {
            _context.WeatherForecast.Add(objWeatherForecast);
            _context.SaveChanges();
            return Task.FromResult(objWeatherForecast);
        }

        public Task<bool>
            UpdateForecastAsync(WeatherForecast objWeatherForecast)
        {
            var ExistingWeatherForecast = _context.WeatherForecast
                .Where(x => x.Id == objWeatherForecast.Id)
                .FirstOrDefault();
            if (ExistingWeatherForecast != null)
            {
                ExistingWeatherForecast.Date = objWeatherForecast.Date;
                ExistingWeatherForecast.Summary = objWeatherForecast.Summary;
                ExistingWeatherForecast.TemperatureC = objWeatherForecast.TemperatureC;
                ExistingWeatherForecast.TemperatureF = objWeatherForecast.TemperatureF;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteForecastAsync(WeatherForecast objWeatherForecast)
        {
            var ExistingWeatherForecast = _context.WeatherForecast
                .Where(x => x.Id == objWeatherForecast.Id)
                .FirstOrDefault();
            if (ExistingWeatherForecast != null)
            {
                _context.WeatherForecast.Remove(ExistingWeatherForecast);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
