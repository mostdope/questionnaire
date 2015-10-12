using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionnaireDemo.Models
{
    public class Answer
    {
        
        public Answer()
        {
            
        }
        public Answer(string text)
        {
            Text = text;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
    }
}