using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using CsvHelper;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using CSVToTemplate.Models;


namespace CSVToTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
                
        [HttpPost]
        public IActionResult Listar(IFormFile arquivo)
        {
            //var files = Request.Form.Files; //Esta forma tambem é possivel pegar o arquivo que vem do formulario
            //var path = Path.GetTempFileName().ToString() +  arquivo.FileName; //Pegando o caminho dos arquivo

            try
            {
                Pessoa pessoas = new Pessoa();

                using (StreamReader sr = new StreamReader(arquivo.OpenReadStream()))
                {
                    string n = sr.ReadToEnd();
                    string[] linha = n.Split(";");
                    for (int i = 0; i < linha.Length; i++)
                    {
                        if(i == 2)
                        {
                            pessoas.Name = linha[i];
                        }
                        if(i == 3)
                        {
                            pessoas.Age = linha[i];
                        }
                    }
                }
                return View();
            }
            catch (System.Exception e)
            {
                return RedirectToAction("Index");
            }

        }
        
    }
}
