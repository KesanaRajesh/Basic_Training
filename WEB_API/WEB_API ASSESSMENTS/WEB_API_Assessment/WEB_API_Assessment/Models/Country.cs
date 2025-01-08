using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



//Web Api Assessment :
 
//1.Create a Model called Country under Models Folder.
//2. Add Properties in the country model as 
//   ID, CountryName, Capital 
//3. Create an Empty api controller called Country 
//4. Perform CRUD operations using either (HTTPResponseMessage / IHttpActionResult / others) and consume the api using either Postman/ Swagger

namespace WEB_API_Assessment.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string countryName { get; set; }
        public object CountryName { get; internal set; }
        public string capital { get; set; }
        public object Capital { get; internal set; }
    }
}