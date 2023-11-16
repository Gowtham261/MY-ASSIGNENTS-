using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_api_Assignment_1.Models;

namespace Web_api_Assignment_1.Controllers
{
    public class ContryController : Controller
    {
        private List<Country> _countries;

        public ContryController()
        {
            _countries = new List<Country>
            {
               new Country { ID = 23, CountryName = "Kings Landing", Capital = "GOT" },
               new Country { ID = 24, CountryName = "The nights watch", Capital = "GOT" },
               new Country { ID = 25, CountryName = "Dothrakhi", Capital = "GOT" },
            };
        }
        public IEnumerable<Country> Get()
        {
            return _countries;
        }
        public Country Get(int id)
        {
            return _countries.FirstOrDefault(c => c.ID == id);
        }
        public void Post([FromBody] Country country)
        {
            country.ID = _countries.Count + 1;
            _countries.Add(country);
        }
        public void Put(int id, [FromBody] Country country)
        {
            var existingCountry = _countries.FirstOrDefault(c => c.ID == id);
            if (existingCountry != null)
            {
                existingCountry.CountryName = country.CountryName;
                existingCountry.Capital = country.Capital;
            }
        }
        public void Delete(int id)
        {
            var countryToRemove = _countries.FirstOrDefault(c => c.ID == id);
            if (countryToRemove != null)
            {
                _countries.Remove(countryToRemove);
            }
        }
    }
}