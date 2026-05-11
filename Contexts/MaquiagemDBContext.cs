using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade1_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade1_MVC.Contexts
{
    public class MaquiagemDBContext : DbContext
    {
        public MaquiagemDBContext(DbContextOptions<MaquiagemDBContext> options) : base (options) {}

        public DbSet<Maquiagem> Produto{get ; set ;}
    }
}