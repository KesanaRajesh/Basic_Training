using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API_Assessment.Models;

namespace WEB_API_Assessment.Controllers
{
    public class CountryController : ApiController
    {
        List<Country> countries = new List<Country>()
        {
            new Country{Id = 1, countryName = "France" , capital="Paris"},
            new Country{Id = 2, countryName="China" , capital = "Bejing"}
        };

        [HttpGet]
        public List<Country> countryDetails()
        {
            return countries;
        }

        [HttpPost]

        public List<Country> insertCountryDetails([FromBody] Country country)
        {
            countries.Add(country);
            return countries;
        }

        [HttpPut]
        public List<Country> UpdateCountry(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.Id == id);
            if (country == null)
            {
              //  return NotFound();
            }

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return countries;
        }

        [HttpDelete]
        public List<Country> DeleteCountry(int id)
        {
            var country = countries.Find(c => c.Id == id);
            if (country == null)
            {

            }
            countries.Remove(country);
            return countries;
        }
    }
}
