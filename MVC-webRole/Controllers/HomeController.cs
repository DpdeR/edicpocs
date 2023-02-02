using MVC_webRole.WCFServiceReference;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_webRole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Data() 
        {
            var client = new ServiceClient();
            var data = client.GetDataUsingDataContract(
                new CompositeType() { StringValue = "Hello from MVC ", BoolValue = true });
            var dataList = new List<CompositeType>() { data };
            return View(dataList);
        }
    }
}