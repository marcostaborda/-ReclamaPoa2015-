using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class Reclamacao
    {
        public int ReclamacaoId { get; set; }
        public int BairroId { get; set; }
        public int CategoriaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Foto { get; set; }
        public DateTime Data { get; set; }
        public Status StatusId { get; set; }

        public string UserId { get; set; }
        public virtual Bairro Bairro { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Comentario> Comentario { get; set; }
    }
}