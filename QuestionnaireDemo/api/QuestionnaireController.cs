using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using QuestionnaireDemo.Models;

namespace QuestionnaireDemo.api
{
    public class QuestionnaireController : ApiController
    {   
        public IEnumerable<Questionnaire> Get()
        {
            var questionnaire = new Questionnaire("Анкета 1")
            {
                Questions = new List<Question>()
                {
                    new Question("Выберите ваш пол"){Answers = new List<Answer>(){new Answer("Мужской"), new Answer("Женский")}},
                    new Question("Выберите вашу модель телефона"){Answers = new List<Answer>(){new Answer("Samsung"), new Answer("Nokia"), new Answer("Apple Iphone")}}
                }
            };
            var questionnaires = new List<Questionnaire>();
            questionnaires.Add(questionnaire);

            return questionnaires;
        }


        public Questionnaire Get(int id)
        {
            var questionnaire = new Questionnaire("Questionnaire number 1")
            {
                Questions = new List<Question>()
                {
                    new Question("Выберите ваш пол"){Answers = new List<Answer>(){new Answer("Мужской"), new Answer("Женский")}},
                    new Question("Выберите вашу модель телефона"){Answers = new List<Answer>(){new Answer("Samsung"), new Answer("Nokia"), new Answer("Apple Iphone")}}
                }
            };
            return questionnaire;
        }


        public void Post(Questionnaire value)
        {
            
        }


        public void Put(int id, [FromBody]Questionnaire value)
        {

        }

        // DELETE: api/Questionnaire/5
        public void Delete(int id)
        {

        }
    }
}
