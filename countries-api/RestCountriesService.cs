using System.Globalization;
using Newtonsoft.Json.Linq;

namespace countries_api
{
    public class RestCountriesService
    {
        private readonly HttpClient _httpClient;

        public RestCountriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");
        }

        public async Task<JArray?> GetAllCountries()
        {
            var response = await _httpClient.GetStringAsync("all");
            return JArray.Parse(response);
        }

        public async Task<JToken?> GetByName(string countryName)
        {
            var response = await _httpClient.GetStringAsync($"name/{countryName}");
            return JArray.Parse(response).FirstOrDefault();
        }
    }
}