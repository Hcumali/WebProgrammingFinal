using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramming.Extensions;
using WebProgramming.Models;

namespace WebProgramming.Controllers
{
    public class HomeController : Controller
    {
        private INewsDal _newsDal;
        public HomeController(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public async Task<IActionResult> Index()
        {
            List<News> result = new List<News>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method
                HttpResponseMessage response = await client.GetAsync("api/News/getAll");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<List<News>>();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

            return View(result);
        }

    }
}
