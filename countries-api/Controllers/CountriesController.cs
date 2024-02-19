using countries_api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace countries_api.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountriesController(RestCountriesService restCountriesService) : ControllerBase
    {
        private readonly RestCountriesService _restCountriesService = restCountriesService;

        [HttpGet]
        public async Task<ActionResult<CountryDto[]>> GetCountries()
        {
            var countriesResponse = await _restCountriesService.GetAllCountries();
            var countries = countriesResponse?.Select(Map) ?? [];

            return Ok(countries);
        }

        [HttpGet("{countryName}")]
        public async Task<ActionResult<CountryDto>> GetCountryByName(string countryName)
        {
            var coutryResponse = await _restCountriesService.GetByName(countryName);
            var country = Map(coutryResponse);
            return Ok(country);
        }

        private static CountryDto Map(JToken? jToken) => new()
        {
            Name = jToken?["name"]?["common"]?.ToString() ?? string.Empty,
            Capital = jToken?["capital"]?.First().ToString() ?? string.Empty,
            Currencies = jToken?["currencies"]?.Values()?.Select(x => x["name"]?.ToString() ?? string.Empty).ToArray() ?? Array.Empty<string>(),
            Languages = jToken?["languages"]?.Values().Select(x => x.ToString() ?? string.Empty).ToArray() ?? Array.Empty<string>(),
            Region = jToken?["region"]?.ToString() ?? string.Empty,
            Flag = jToken?["flags"]?["png"]?.ToString() ?? string.Empty,
            GoogleMaps = jToken?["maps"]?["googleMaps"]?.ToString() ?? string.Empty,
            Alt = jToken?["flags"]?["alt"]?.ToString() ?? string.Empty,
        };
    }
}
