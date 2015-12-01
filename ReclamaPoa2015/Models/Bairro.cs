using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class Bairro
    {
        public int BairroId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Reclamacao> Reclamacao { get; set; }
    }
}