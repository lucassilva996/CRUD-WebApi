using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas {get; set;}

        public Contexto(DbContextOptions<Contexto> opcoes)
         : base(opcoes)
        {
            
        }
    }
}