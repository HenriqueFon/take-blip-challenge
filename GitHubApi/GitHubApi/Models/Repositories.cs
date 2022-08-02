using Newtonsoft.Json;

namespace GitHubApi.Models
{
    public class Repositories
    {
        [JsonProperty("owner")]
        public Owner owner { get; set; }

        [JsonProperty("full_name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }    
    }
}
