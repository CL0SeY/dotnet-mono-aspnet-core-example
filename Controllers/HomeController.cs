using System.Collections.Generic;
using System.Linq;
using dotnet_mono_aspnet_core_example.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace dotnet_mono_aspnet_core_example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            IRestRequest request = new RestRequest("posts");
            var response = client.Get<List<PostModel>>(request);
            return View(response.Data.Take(5));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
