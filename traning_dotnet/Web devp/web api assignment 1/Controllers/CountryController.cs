using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web_Api_Assegnment_1.Models;

namespace Web_Api_Assegnment_1.Controllers
{
    public class CountryController : Controller
    {

        List<Country> countries = new List<Country>()
        {
            new Country { CountryNumber = 1, CountryName = "India", Countryfavfood = "Rice" },
            new Country { CountryNumber = 2, CountryName = "US", Countryfavfood = "Burger" },
            new Country { CountryNumber = 3, CountryName = "Austraila", Countryfavfood = "Red Wine" }
        };

        // Implement CRUD operations here
        // GET: api/Country
        // GET: api/Country/1
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryNumber == id);
            if (country == null)
                return HttpNotFound();

            return (country);
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
                return HttpNotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Countryfavfood = updatedCountry.Countryfavfood;

            return(country);
        }
        // DELETE: api/Country/1
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryNumber == id);
            if (country == null)
                return HttpNotFound();

            countries.Remove(country);

            return FtpStatusCode(HttpStatusCode.NoContent);
        }
    }
}