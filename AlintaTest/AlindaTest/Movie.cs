using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlintaTest
{
    public class Movie
    {
        [JsonProperty("name")]
        public string MovieName { get; set; }
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; } 

        public Movie()
        {
            Roles = new List<Role>();
        }
    }
}
