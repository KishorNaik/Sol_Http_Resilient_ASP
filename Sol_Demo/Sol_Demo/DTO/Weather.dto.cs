using System.Text.Json.Serialization;

namespace Sol_Demo.DTO;

public class WeatherDto
{
    [JsonPropertyName("id")]
    public long Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("weather")]
    public List<WeatherDescription> WeatherDescription { get; init; }

    [JsonPropertyName("base")]
    public string Base { get; init; }

    [JsonPropertyName("visibility")]
    public long Visibility { get; init; }

    [JsonPropertyName("timezone")]
    public long Timezone { get; init; }
}

public class WeatherDescription
{
    [JsonPropertyName("id")]
    public long Id { get; init; }

    [JsonPropertyName("main")]
    public string Main { get; init; }

    [JsonPropertyName("description")]
    public string Description { get; init; }

    [JsonPropertyName("icon")]
    public string Icon { get; init; }
}