using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QuestionnaireDemo.Models;

namespace QuestionnaireDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = new List<Question> {new Question("ЧЛЕН"), new Question("ДРУГОЙ ЧЛЕН")};


            return View(list);
        }
    }
}