using API.ViewModels;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<string> ListaCursos()
        {
            var teste = await "https://localhost:44376/v1/curso/listaTodos".GetJsonAsync<ResultViewModel>();
            var ret = teste.Data;
            return ret.ToString();
        }
    }
}
