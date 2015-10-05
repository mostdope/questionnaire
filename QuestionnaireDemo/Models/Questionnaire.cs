using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}