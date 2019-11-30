using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.Models
{
    public class Skill
    {
        [JsonProperty("name")]
        public string SkillName { get; set; }

        public override string ToString()
        {
            return SkillName;
        }
    }
}
