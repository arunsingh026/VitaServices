using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace LEGO.SERVICES
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            #region

            // enable for one kind of specific origin
            //var corsAttr = new EnableCorsAttribute("http://example.com", "*", "*");
            //config.EnableCors(corsAttr);
            #endregion


            config.MapHttpAttributeRoutes();
            //config.EnableCors();
            #region
            //Enable the configuration of the odata
            //config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            //config.EnsureInitialized();
            #endregion

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
        #region
        //Code for oData restful API configuration
        //private static IEdmModel GetEdmModel()
        //{
        //    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
        //    builder.Namespace = "User";
        //    builder.ContainerName = "DefaultContainer";
        //    builder.EntitySet<User>("User");
        //    var edmModel = builder.GetEdmModel();
        //    return edmModel;
        //}
        #endregion

    }
}
