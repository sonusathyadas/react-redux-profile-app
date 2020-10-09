using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ProfileApi.Models
{
    public class Profile
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("createdTs")]
        public DateTime CreatedTs { get; set; }
        [JsonProperty("updatedTs")]
        public DateTime UpdatedTs { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("sex")]
        public string Sex { get; set; }
        [JsonProperty("birthdate")]
        public DateTime Birthdate { get; set; }
        [JsonProperty("phonenumber")]
        public string Phonenumber { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("photo")]
        public string Photo { get; set; }
        [JsonProperty("favorite")]
        public bool Favorite { get; set; }
    }
}
