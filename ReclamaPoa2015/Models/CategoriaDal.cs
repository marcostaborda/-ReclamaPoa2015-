using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class CategoriaDal
    {
        public string Cat_Titulo { get; set; }
        public string Cat_Descricao { get; set; }
        public int CategoriaId { get; set; }


        public List<CategoriaDal> getCategoria()
        {
            PoaEntities _db = new PoaEntities();
            var categorias = from l in _db.Categorias
                          orderby l.Cat_Titulo
                          select new CategoriaDal
                          {
                              CategoriaId = l.CategoriaId,
                              Cat_Titulo = l.Cat_Titulo,
                              Cat_Descricao = l.Cat_Descricao
                          };
            return categorias.ToList();
        }

        public int insereCategoria(CategoriaDal novaCat)
        {
            PoaEntities _db = new PoaEntities();
            Categoria nova = new Categoria
            {
                Cat_Titulo = novaCat.Cat_Titulo,
                Cat_Descricao = novaCat.Cat_Descricao
            };
            try
            {
                _db.Categorias.Add(nova);
                _db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

    
}
