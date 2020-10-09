using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.Model
{
    public class DailyInformation
    {
        [JsonPropertyName("daypart_name")]
        public string DayPartName { get; set; }
        public int Temp { get; set; }
        public string Narrative { get; set; }
    }

}
