using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionnaireDemo.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }

    
}