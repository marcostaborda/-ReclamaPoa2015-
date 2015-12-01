using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class PoaEntities : DbContext
    {
        public PoaEntities() : base("BancoPoaConnection")
        {

        }
        public DbSet<Reclamacao> Reclamacoes { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}