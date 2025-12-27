
using Newtonsoft.Json;

namespace IQAir.Integration.Api.Models.Responses.V2.Community;

public class WeatherModel
{
    [JsonProperty("ts")]
    public DateTimeOffset LastMeasurementAt { get; set; }

    [JsonProperty("tp")]
    public int Temperature { get; set; }

    [JsonProperty("pr")]
    public int Pressure { get; set; }

    [JsonProperty("hu")]
    public int Humidity { get; set; }

    [JsonProperty("ws")]
    public float WindSpeed { get; set; }

    [JsonProperty("wd")]
    public int WindDirection { get; set; }

    [JsonProperty("ic")]
    public string Icon { get; set; } = string.Empty;

    [JsonProperty("heatIndex")]
    public int HeatIndex { get; set; }
    
    // Helper to get a human-readable name of the icon
    [JsonIgnore]
    public string IconWeatherName => Icon switch
    {
        "01d" => "Clear sky (day)",
        "01n" => "Clear sky (night)",
        "02d" => "Few clouds (day)",
        "02n" => "Few clouds (night)", 
        "03d" => "Scattered clouds", 
        "03n" => "Scattered clouds (night time)", 
        "04d" => "Broken clouds",
        "04n" => "Broken clouds (night time)",
        
        "09d" => "Shower rain",
        "09n" => "Shower rain (night time)",
        "10d" => "Rain (day time)",
        "10n" => "Rain (night time)",
        "11d" => "Thunderstorm", 
        "11n" => "Thunderstorm (night time)", 
        "13d" => "Snow", 
        "13n" => "Snow (night time)", 
        "50d" => "Mist", 
        "50n" => "Mist (night time)", 
        _ => "unknown"
    };
}