namespace countries_api.Models;

public class CountryDto
{
    public required string Name { get; set; }
    public required string Capital { get; set; }
    public required string[] Currencies { get; set; }
    public required string[] Languages { get; set; }
    public required string Region { get; set; }
    public required string Flag { get; set; }
    public required string GoogleMaps { get; set; }
    public required string Alt { get; set; }
}