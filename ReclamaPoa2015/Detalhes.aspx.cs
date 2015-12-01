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
                //else
                //    Response.Redirect("Default.aspx");
            }
        }

        private void PopulaReclamacao(int _idReclamcao)
        {
            //ReclamacaoViewModel c = reclamacaoDal.getReclamacaoId(_idReclamcao).FirstOrDefault();
            //litCategoria.Text = c.Categoria;
            //litBairro.Text = c.Bairro;
            //litDescricao.Text = c.Descricao;
            //litEndereco.Text = c.Endereco;
            //litTituloReclamacao.Text = c.Titulo;
            //litStatus.Text = Enum.GetName(typeof(Status), c.Status);
            //imgReclamacao.ImageUrl = @"~/Images/Reclamacao/" + c.Foto;
        }
    }
}