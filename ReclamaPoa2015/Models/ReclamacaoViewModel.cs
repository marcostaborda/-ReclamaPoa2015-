using System;

namespace ReclamaPoa2015.Models
{
    public class ReclamacaoViewModel
    {
        public int ReclamacaoId { get; set; }
        public String UserId { get; set; }
        public String Titulo { get; set; }
        public String Categoria { get; set; }
        public String Bairro { get; set; }
        public String Endereco { get; set; }
        public String Descricao { get; set; }
        public String Foto { get; set; }
        public String UserName { get; set; }
        public Status Status
        {
            get; set;
        }
    }
}