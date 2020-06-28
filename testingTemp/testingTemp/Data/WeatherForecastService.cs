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
    }
}
