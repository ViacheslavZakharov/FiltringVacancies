using FiltringVacancies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltringVacancies.services
{
    public class FilterVacanciesService : IFilterVacanciesService
    {
        private readonly Dictionary<string, double> salaryToRUB = new Dictionary<string, double>
        {
            { "EUR", 70.55 },
            { "BYR", 30.40 },
            { "USD", 64.08 },
            { "KZT", 0.16 },
            { "UAH", 2.60 },
            { "RUB", 1.00 }
        };

        private readonly Dictionary<string, double> salaryRangeToLimitSalary = new Dictionary<string, double>
        {
            {RangeSalary.SMALL_SALARY, 30000 },
            {RangeSalary.MIDDLE_SALARY, 60000 }
        };

        public List<Vacancy> Filter(Filter filter, List<Vacancy> vacancies)
        {
            var filteredVacancies = new List<Vacancy>();
            // Любой город -> низкая зарплата
            if (filter.City == Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.SMALL_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null && GetAverageSalary(vacancy.Salary) <= salaryRangeToLimitSalary[RangeSalary.SMALL_SALARY])
                    .ToList();
            }
            // Любой город -> средняя зарплата
            else if (filter.City == Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.MIDDLE_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null &&
                    GetAverageSalary(vacancy.Salary) > salaryRangeToLimitSalary[RangeSalary.SMALL_SALARY] &&
                    GetAverageSalary(vacancy.Salary) <= salaryRangeToLimitSalary[RangeSalary.MIDDLE_SALARY])
                    .ToList();
            }
            // Любой город -> высокая зарплата
            else if (filter.City == Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.HIGHT_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null &&
                    GetAverageSalary(vacancy.Salary) > salaryRangeToLimitSalary[RangeSalary.MIDDLE_SALARY])
                    .ToList();
            }
            // Любой город -> любая зарплата
            else if (filter.City == Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.DEFAULT_SALARY)
            {
                return vacancies;
            }

            // Конкретный город -> низкая зарплата
            if (filter.City != Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.SMALL_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null &&
                    GetAverageSalary(vacancy.Salary) <= salaryRangeToLimitSalary[RangeSalary.SMALL_SALARY] &&
                    vacancy.Address != null && vacancy.Address.City != null && vacancy.Address.City == filter.City)
                    .ToList();
            }
            // Конкретный город -> средняя зарплата
            else if (filter.City != Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.MIDDLE_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null &&
                    GetAverageSalary(vacancy.Salary) > salaryRangeToLimitSalary[RangeSalary.SMALL_SALARY] &&
                    GetAverageSalary(vacancy.Salary) <= salaryRangeToLimitSalary[RangeSalary.MIDDLE_SALARY] &&
                    vacancy.Address != null && vacancy.Address.City != null && vacancy.Address.City == filter.City)
                    .ToList();
            }
            // Конкретный город -> высокая зарплата
            else if (filter.City != Vacancy.DEFAULT_CITY && filter.RangeSalary == RangeSalary.HIGHT_SALARY)
            {
                return vacancies.Where(vacancy =>
                    vacancy.Salary != null &&
                    GetAverageSalary(vacancy.Salary) > salaryRangeToLimitSalary[RangeSalary.MIDDLE_SALARY] &&
                    vacancy.Address != null && vacancy.Address.City != null && vacancy.Address.City == filter.City)
                    .ToList();
            }
            // Конкретный город -> любая зарплата
            else
            {
                return vacancies.Where(vacancy =>
                    vacancy.Address != null && vacancy.Address.City != null && vacancy.Address.City == filter.City)
                    .ToList();
            }
        }

        private double GetAverageSalary(Salary salary)
        {
            try
            {
                if (salary.SalaryFrom != null && salary.SalaryTo != null)
                {
                    return (double.Parse(salary.SalaryFrom) + double.Parse(salary.SalaryTo)) *
                        (salaryToRUB.ContainsKey(salary.Currency) ? salaryToRUB[salary.Currency] : salaryToRUB["RUB"]) / 2;
                }
                else if (salary.SalaryFrom != null && salary.SalaryTo == null)
                {
                    return double.Parse(salary.SalaryFrom) *
                        (salaryToRUB.ContainsKey(salary.Currency) ? salaryToRUB[salary.Currency] : salaryToRUB["RUB"]);
                }
                else if (salary.SalaryFrom == null && salary.SalaryTo != null)
                {
                    return double.Parse(salary.SalaryTo) *
                        (salaryToRUB.ContainsKey(salary.Currency) ? salaryToRUB[salary.Currency] : salaryToRUB["RUB"]);
                }
                return 0.0;
            }
            catch(Exception)
            {
                return 0.0;
            }
        }
    }
}
