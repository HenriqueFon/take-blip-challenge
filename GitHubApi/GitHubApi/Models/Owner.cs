using Newtonsoft.Json;

namespace GitHubApi.Models
{
    public class Owner
    {
        [JsonProperty("avatar_url")]
        public string avatar { get; set; }
    }
}
