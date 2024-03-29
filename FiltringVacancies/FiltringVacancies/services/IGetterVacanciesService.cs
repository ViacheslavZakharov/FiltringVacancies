﻿using FiltringVacancies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.services
{
    public interface IGetterVacanciesService
    {
        List<Vacancy> GetVacancies();

        List<string> GetCitiesVacancies(List<Vacancy> vacancies);
    }
}
