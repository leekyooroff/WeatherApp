using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
	public static class ApiService
	{
		public static async Task<Root> GetWeather(double latitude, double longtitude)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=92dde2fd04abf11392c88c4b2387d9f0", latitude, longtitude));
			return JsonConvert.DeserializeObject<Root>(response);
		}

		public static async Task<Root> GetWeatherByCity(string city)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=92dde2fd04abf11392c88c4b2387d9f0", city));
			return JsonConvert.DeserializeObject<Root>(response);
		}
	}
}

