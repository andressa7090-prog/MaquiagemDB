using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Atividade1_MVC.Models;
using Atividade1_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade1_MVC.Controllers
{
    [Route("[controller]")]
    public class MaquiagemController : Controller
    {
        private readonly MaquiagemRepository _repository;

        public MaquiagemController(MaquiagemRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Maquiagem> maquiagens = _repository.ObterMaquiagens();
            return View(maquiagens);
        }
    }
}