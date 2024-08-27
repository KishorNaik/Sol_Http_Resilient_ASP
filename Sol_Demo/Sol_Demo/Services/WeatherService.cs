using Sol_Demo.DTO;
using System.Net;

namespace Sol_Demo.Services;

public class WeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DataResponse<WeatherDto?>> GetCurrentWeatherAsync(string city, CancellationToken cancellationToken = default)
    {
        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=661a1bcf2fae84fe5e5298071369b64c&units=metric";

        var weatherResponse = await _httpClient.GetAsync(url);

        if (weatherResponse.StatusCode != HttpStatusCode.OK)
            return new DataResponse<WeatherDto?>(false, Convert.ToInt32(weatherResponse.StatusCode), null, "No weather found");

        var result = await weatherResponse.Content.ReadFromJsonAsync<WeatherDto>(cancellationToken);

        return new DataResponse<WeatherDto?>(true, Convert.ToInt32(HttpStatusCode.OK), result, "wather found");
    }
}