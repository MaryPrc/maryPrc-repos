using Newtonsoft.Json;

namespace AlintaTest
{
    public class Role
    {
        [JsonProperty("name")]
        public string RoleName { get; set; }
        [JsonProperty("actor")]
        public string ActorName { get; set; }

        public string MovieName { get; set; } 
        

    }
}