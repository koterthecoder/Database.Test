using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Database.Test
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutofacConfig.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //using (var context = new CarContext())
            //{
            //    try
            //    {
            //        var licenceNumbers = new[] { "ABC 1234", "CD 54321", "EF 55577" };
            //        foreach (var number in licenceNumbers)
            //        {
            //            context.Cars.Add(new Car { LicenceNumber = number });
            //        }
            //        context.SaveChanges();

            //        var cars = context.Cars.ToArray();
            //        Console.WriteLine($"We have {cars.Length} car(s).");
            //        foreach (var car in cars)
            //        {
            //            Console.WriteLine(car);
            //        }
            //    } catch (Exception ex)
            //    {

            //    }
            //}

        }
    }
}
