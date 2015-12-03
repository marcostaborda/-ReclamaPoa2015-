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
            btnResolver.Visible = false;
            string userId = User.Identity.GetUserId();
            ApplicationDbContext db = new ApplicationDbContext();
            var role = (from j in db.Roles where j.Name.Contains("Oficial") select j).FirstOrDefault();
            var users = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role.Id)).ToList();

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
            if (users.Find(x => x.Id == userId) != null)
            {
                if (c.Status == Status.Encerrada)

                    btnResolver.Visible = false;
                else
                    btnResolver.Visible = true;
            }

            litStatus.Text = Enum.GetName(typeof(Status), c.Status);
            imgReclamacao.ImageUrl = @"~/Images/Reclamacao/" + c.Foto;
        }

        protected void btnResolvida_Click(object sender, EventArgs e)
        {
            String idReclamacao = Request.QueryString["idReclamacao"];
            ReclamacaoDal r = new ReclamacaoDal();
            r.ReclamacaoId = Int32.Parse(idReclamacao);
            r.StatusId = (Status)Enum.Parse(typeof(Status), "3");
            r.altaraReclamacao(r);
            Response.Redirect(String.Format("Detalhes.aspx?idReclamacao={0}", idReclamacao));
        }
    }
}