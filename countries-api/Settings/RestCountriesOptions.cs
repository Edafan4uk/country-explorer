namespace countries_api.Settings;

public class RestCountriesOptions
{
    public const string RestCountries = "RestCountries";
    public string ConnectionString { get; set; } = string.Empty;
}