using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InputToCSV.Models;
using System.IO;
using System.Text;

namespace InputToCSV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Convert(string name, string age)
        {
            
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Nome;Idade;{ name };{ age }");

            /*
                Se tivesse de fazer apartir de uma lista que viesse do backend, bastava fazer a adição num For/Forech. E.g:
                
               foreach (var item in collection)
                {
                    stringBuilder.append($"collection.name;collection.age"  ... concatena itens conforme coleção ... )
                }

             */



            return File(Encoding.ASCII.GetBytes(stringBuilder.ToString()), "text/csv", "dados.csv");
        }
    }
}
