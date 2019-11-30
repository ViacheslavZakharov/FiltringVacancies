using FiltringVacancies.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FiltringVacancies.services
{
    public class GetterVacanciesService : IGetterVacanciesService
    {
        IConfiguration _config;
        public readonly int _numberPage;

        public readonly int _maxNumberVacanciesOnOnePage;

        public readonly string _hostName;

        private RestClient _restClient;

        public GetterVacanciesService(IConfiguration config)
        {
            _config = config;
            _maxNumberVacanciesOnOnePage = _config.GetSection("ApiParameters").GetValue<int>("MaxNumberVacanciesOnThePage");
            _numberPage = _config.GetSection("ApiParameters").GetValue<int>("MaxNumberVacancies") / _maxNumberVacanciesOnOnePage;
            _hostName = _config.GetSection("ApiParameters").GetValue<string>("hostName");
            _restClient = new RestClient(_hostName);
        }

        public List<Vacancy> GetVacancies()
        {
            List<Vacancy> listVacancies = new List<Vacancy>();
            for (int page = 0; page < _numberPage; page++)
            {
                var requestVacanciesOnPage = new RestRequest(string.Format("vacancies?per_page={0}&page={1}",
                                                                _maxNumberVacanciesOnOnePage, page), Method.GET);
                var responseVacanciesOnPage = _restClient.Execute(requestVacanciesOnPage);
                if (responseVacanciesOnPage.StatusCode == HttpStatusCode.OK)
                {
                    var listVacanciesJson = (JArray)JToken.Parse(responseVacanciesOnPage.Content)["items"];
                    foreach (var vacancy in listVacanciesJson)
                    {
                        var requestVacancy = new RestRequest(string.Format("vacancies/{0}",
                                                            vacancy["id"].ToString()), Method.GET);
                        var responseVacancy = _restClient.Execute(requestVacancy);
                        if (responseVacancy.StatusCode == HttpStatusCode.OK)
                        {
                            var vacancyDeserialized = Deserialize(responseVacancy.Content);
                            if (vacancyDeserialized != null)
                                listVacancies.Add(vacancyDeserialized);
                        }
                    }
                }
            }
            return listVacancies;
        }

        private Vacancy Deserialize(string jsonString)
        {
            var vacancyDeserialized = JsonConvert.DeserializeObject<Vacancy>(jsonString);
            //если зарплата не указана то возвращам null
            return vacancyDeserialized.Salary == null ? null : vacancyDeserialized;
        }

        public List<string> GetCitiesVacancies(List<Vacancy> vacancies)
        {
            return vacancies.Where(vacancy => vacancy.Address != null && vacancy.Address.City != null)
                .Select(vacancy => vacancy.Address.City)
                .Distinct()
                .ToList();
        }
    }
}
