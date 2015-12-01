using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Cat_Titulo { get; set; }
        public string Cat_Descricao { get; set; }
        public virtual ICollection<Reclamacao> Reclamacao { get; set; }
    }
}