using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public int ReclamacaoId { get; set; }
        public string Foto { get; set; }
        public DateTime Data { get; set; }
        public string UserId { get; set; }

        public virtual Reclamacao Reclamacao { get; set; }
    }
}