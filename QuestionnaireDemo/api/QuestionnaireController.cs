using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using QuestionnaireDemo.Models;

namespace QuestionnaireDemo.api
{
    public class QuestionnaireController : ApiController
    {
       
        public IEnumerable<Questionnaire> Get()
        {
            return new Questionnaire[] { };
        }


        public Questionnaire Get(int id)
        {
            return new Questionnaire();
        }


        public void Post([FromBody]Questionnaire value)
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
