using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Api_Assegnment_1.Models;

namespace Web_Api_Assegnment_1.Controllers
{
    public class Countries
    {
        List<Country> countries = new List<Country>()
        {
            new Country { CountryNumber = 1, CountryName = "India", Countryfavfood = "Delhi" },
            new Country { CountryNumber = 2, CountryName = "US", Countryfavfood = "Washington" },
            new Country { CountryNumber = 3, CountryName = "Austraila", Countryfavfood = "Canberra" }
        };

        // Implement CRUD operations here
        // GET: api/Country
        public IHttpActionResult Get()
        {
            return ((IHttpActionResult)countries);
        }

        // GET: api/Country/1
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryNumber == id);
            if (country == null)
                return NotFoundResult();

            return ((IHttpActionResult)country);
        }

        // POST: api/Country
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.CountryNumber = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.CountryNumber }, country);
        }

        // PUT: api/Country/1
        public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.CountryNumber == id);
            if (country == null)
                return NotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Countryfavfood = updatedCountry.Countryfavfood;

            return ((IHttpActionResult)country);
        }

        // DELETE: api/Country/1
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryNumber == id);
            if (country == null)
                return NotFound();
            countries.Remove(country);
            return StatusCodeResult(HttpStatusCode.NoContent);
        }
    }
}
