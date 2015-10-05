using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionnaireDemo.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }
        public Question(string text) : this()
        {
            
        }

        public string Text { get; set; }
        public List<Answer> Answers  { get; set; }
    }
}