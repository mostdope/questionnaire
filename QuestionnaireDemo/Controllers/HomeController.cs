using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using QuestionnaireDemo.Models;

namespace QuestionnaireDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var source = new List<Question>{new Question("123"), new Question("321")};
            var settings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var questions = JsonConvert.SerializeObject(source, Formatting.None, settings);
            return View(model:questions);
        }
    }
}