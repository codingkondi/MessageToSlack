using Newtonsoft.Json;
namespace SlackAPI.Models
{
    public class Attachment
    {
        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("color")]
        public string Color = "danger";
    }
}
