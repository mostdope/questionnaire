using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuestionnaireDemo.Models;

namespace QuestionnaireDemo.api
{
    public class QuestionsController : ApiController
    {
        // GET api/<controller>
        
        public IEnumerable<Question> Get()
        {
            return new [] { new Question("What is your name?"), new Question("How old are you?") };
        }

        // GET api/<controller>/5
        public Question Get(int id)
        {
            return new Question("ЧЛЕН");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}