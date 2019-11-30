using FiltringVacancies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.services
{
    public interface IFilterVacanciesService
    {
        List<Vacancy> Filter(Filter filter, List<Vacancy> vacancies);
    }
}
