using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocationWebAPISample
{
    public static class ResponseSerializerConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            JsonResponse(configuration);
            XmlResponse(configuration);
        }

        private static void XmlResponse(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }

        private static void JsonResponse(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.None    /*prevent $id/$ref 
                                                                              at client end*/
            };
        }
    }
}