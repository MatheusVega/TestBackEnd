using API.ViewModels;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> ListaAlunos()
        {
            var lista = await "https://localhost:44376/v1/aluno/ListaTodas".GetJsonAsync<ResultViewModel>();
            var ret = lista.Data;
            return ret.ToString();
        }

        public async Task<string> ListaDetalhesAlunolunos(int id)
        {
            var lista = await "https://localhost:44376/v1/aluno/Lista".AppendPathSegments("get", id).GetJsonAsync<ResultViewModel>();
            var ret = lista.Data;
            return ret.ToString();
        }

    }
}
