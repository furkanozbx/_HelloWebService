using _HelloWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _HelloWebService
{
    /// <summary>
    /// Summary description for helloservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class helloservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] Iller()
        {
            return new string[]
            {
                "Ordu",
                "Giresun",
                "Trabzon",
                "Rize",
                "Artvin",
                "Gümüşhane"
            };
        }

        [WebMethod]
        public List<City> GetCities()
        {
            return new List<City>
            {
                new City
                {
                    Name="Ordu"
                },
                 new City
                {
                    Name="Giresun"
                },
                  new City
                {
                    Name="Trabzon"
                },
                   new City
                {
                    Name="Rize"
                },
                    new City
                {
                    Name="Artvin"
                }
            };
        }
    }
}
