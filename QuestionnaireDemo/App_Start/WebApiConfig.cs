using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QuestionnaireDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
         
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void SetUpSerializer(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            
            config.Formatters.JsonFormatter.SerializerSettings
                = new JsonSerializerSettings(){ContractResolver = new CamelCasePropertyNamesContractResolver()};
        }
    }
}
