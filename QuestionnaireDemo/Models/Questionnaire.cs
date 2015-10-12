using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace QuestionnaireDemo.Models
{
    
    public class Questionnaire
    {
        public Questionnaire()
        {
            Questions = new List<Question>();
        }
        public Questionnaire(string name) : this()
        {
            Name = name;
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}