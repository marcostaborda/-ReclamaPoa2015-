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

        public int altaraReclamacao(ReclamacaoDal r)
        {
            PoaEntities db = new PoaEntities();
            Reclamacao nova = new Reclamacao();

            var getReclama = (from reclama in db.Reclamacoes
                           where reclama.ReclamacaoId == r.ReclamacaoId
                           select reclama).Single();

            getReclama.StatusId = r.StatusId;           
            try
            {              
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                return 0;
            }
        }


        /// <summary>
        /// Metodo para pegar a reclamacao e listar detalhes
        /// </summary>
        /// <param name="idReclamacao">Id Reclamação</param>
        /// <returns></returns>
        public IQueryable<ReclamacaoViewModel> getReclamacaoId(int idReclamacao)
        {           
            PoaEntities db = new PoaEntities();
            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       where l.ReclamacaoId == idReclamacao
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           CategoriaId = l.CategoriaId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           BairrosId = l.BairroId,                                                           
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           UserId = l.UserId,
                                                       };
            return consulta;
        }

        public List<ReclamacaoViewModel> populaPesquisa(int codCategoria, int codBairro, Status statusId, DateTime data1, DateTime data2)
        {
            PoaEntities db = new PoaEntities();
            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           CategoriaId = l.CategoriaId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           BairrosId = l.BairroId,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           UserId = l.UserId,
                                                           Data = l.Data,
                                                           Link = true,
                                                       };
            if (codCategoria != 0)
            {
                consulta = consulta.Where(c => c.CategoriaId == codCategoria);
            }
            if (codBairro != 0)
            {
                consulta = consulta.Where(c => c.CategoriaId == codBairro);
            }
            if (statusId != 0)
            {
                consulta = consulta.Where(c => c.Status == statusId);
            }
            if (data1 != null)
            {                
                if (data2 != null && data2 != data1)
                {
                    consulta = consulta.Where(c => c.Data >= data1 && c.Data <= data2);
                }
                else
                {
                    data2 = data1.AddDays(1);
                    consulta = consulta.Where(c => c.Data >= data1 && c.Data < data2);
                }
            }
            return consulta.ToList();
        }

        public IQueryable<ReclamacaoViewModel> getReclamacaoUserId(String _idUserId)
        {
            PoaEntities db = new PoaEntities();
            IQueryable<ReclamacaoViewModel> consulta = from l in db.Reclamacoes
                                                       where l.UserId == _idUserId
                                                       select new ReclamacaoViewModel
                                                       {
                                                           ReclamacaoId = l.ReclamacaoId,
                                                           CategoriaId = l.CategoriaId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           BairrosId = l.BairroId,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           UserId = l.UserId,
                                                           Link = true,                                                          
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
                                                           CategoriaId = l.CategoriaId,
                                                           BairrosId = l.BairroId,
                                                           Categoria = l.Categoria.Cat_Titulo,
                                                           Bairro = l.Bairro.Nome,
                                                           Endereco = l.Endereco,
                                                           Descricao = l.Descricao,
                                                           Foto = l.Foto,
                                                           Status = l.StatusId,
                                                           Titulo = l.Titulo,
                                                           Link = false
                                                       };
            return consulta;
        }
    }
}