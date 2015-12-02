using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoa2015.Models
{
    public class ReclamacaoDal
    {
        public int ReclamacaoId { get; set; }
        public string UserId { get; set; }
        public int BairroId { get; set; }
        public int CategoriaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Foto { get; set; }
        public Status StatusId { get; set; }

        public int insereReclamacao(ReclamacaoDal r)
        {
            PoaEntities db = new PoaEntities();
            Reclamacao nova = new Reclamacao();
            nova.UserId = r.UserId;
            nova.BairroId = r.BairroId;
            nova.CategoriaId = r.CategoriaId;
            nova.Titulo = r.Titulo;
            nova.Descricao = r.Descricao;
            nova.Endereco = r.Endereco;
            nova.Foto = r.Foto;
            nova.Data = DateTime.Now;
            nova.StatusId = r.StatusId;

            try
            {
                db.Reclamacoes.Add(nova);
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                return 0;
            }
        }

        public IQueryable<ReclamacaoViewModel> getReclamacaoId(int _idReclamacao)
        {           
            PoaEntities db = new PoaEntities();
            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       where l.ReclamacaoId == _idReclamacao
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           UserId = l.UserId
                                                       };
            return consulta;
        }

        public IQueryable<ReclamacaoViewModel> getReclamacaoUserId(String _idUserId)
        {
            PoaEntities db = new PoaEntities();
            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       where l.UserId == _idUserId
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           UserId = l.UserId
                                                       };
            return consulta;
        }


        public IQueryable<ReclamacaoViewModel> getReclamacoes()
        {
            PoaEntities db = new PoaEntities();

            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo
                                                       };
            return consulta;
        }
    }
}