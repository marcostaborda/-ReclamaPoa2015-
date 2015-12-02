using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoa2015
{
    public partial class Detalhes : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                String idReclamcao = Request.QueryString["idReclamacao"];
                if (idReclamcao != null)
                {
                    int id;
                    Int32.TryParse(idReclamcao, out id);
                    PopulaReclamacao(id);
                }
                else
                    Response.Redirect("Reclamacoes");
            }
        }

        private void PopulaReclamacao(int _idReclamcao)
        {
           


            ReclamacaoDal r = new ReclamacaoDal();
            ReclamacaoViewModel c = r.getReclamacaoId(_idReclamcao).FirstOrDefault();
            var currentUserId = c.UserId;

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var currentUser = manager.FindById(currentUserId);
            litUsuario.Text = currentUser.UserName;
            litCategoria.Text = c.Categoria;
            litBairro.Text = c.Bairro;
            litDescricao.Text = c.Descricao;
            litEndereco.Text = c.Endereco;
            litTituloReclamacao.Text = c.Titulo;
            litStatus.Text = Enum.GetName(typeof(Status), c.Status);
            imgReclamacao.ImageUrl = @"~/Images/Reclamacao/" + c.Foto;
        }
    }
}