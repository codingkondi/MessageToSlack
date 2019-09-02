using Newtonsoft.Json;
namespace SlackAPI.Models
{
    public class SlackMessage
    {
        [JsonProperty("attachments")]
        public Attachment[] Attachment { get; set; }
        [JsonProperty("username")]
        public string ServiceType { get; set; }
    }

}
