using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class BairroDal
    {
        public int BairroId { get; set; }
        public string Nome { get; set; }

        public List<BairroDal> getBairros()
        {
            PoaEntities _db = new PoaEntities();
            var bairros = from l in _db.Bairros
                          orderby l.Nome
                          select new BairroDal
                          {
                              BairroId = l.BairroId,
                              Nome = l.Nome
                          };
            return bairros.ToList();
        }
    }
}