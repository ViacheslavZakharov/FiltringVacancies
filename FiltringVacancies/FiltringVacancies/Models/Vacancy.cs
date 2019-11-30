using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.Models
{
    public class Vacancy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("salary")]
        public Salary Salary { get; set; }

        [JsonProperty("key_skills")]
        public List<Skill> KeySkills { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
