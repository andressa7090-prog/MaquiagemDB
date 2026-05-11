using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade1_MVC.Contexts;
using Atividade1_MVC.Models;

namespace Atividade1_MVC.Repositories
{
    public class MaquiagemRepository
    {
        private readonly MaquiagemDBContext _context;

        public MaquiagemRepository(MaquiagemDBContext context)
        {
            _context = context;
        }

        public List<Maquiagem> ObterMaquiagens()
        {
            return _context.Produto.ToList();
        }
    }
}