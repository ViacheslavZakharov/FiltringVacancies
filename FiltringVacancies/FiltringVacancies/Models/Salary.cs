﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.Models
{
    public class Salary
    {
        [JsonProperty("from")]
        public string SalaryFrom { get; set; }

        [JsonProperty("to")]
        public string SalaryTo { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public override string ToString()
        {
            var resultSalary = string.Empty;
            if(SalaryFrom == null && SalaryTo == null)
            {
                return "Зарплата не указана";
            }
            else if (SalaryFrom == null)
            {
                resultSalary = string.Format("{0}", SalaryTo);
            }
            else if (SalaryTo == null)
            {
                resultSalary = string.Format("{0}", SalaryFrom);
            }
            else
            {
                resultSalary = string.Format("от {0} до {1}", SalaryFrom, SalaryTo);
            }

            return string.Format("{0} {1}", resultSalary, Currency);
        }
    }
}
