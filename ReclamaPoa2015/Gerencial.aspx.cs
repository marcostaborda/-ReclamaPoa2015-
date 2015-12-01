using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoa2015
{
    public partial class Gerencial : System.Web.UI.Page
    {
        CategoriaDal categoriaDal = new CategoriaDal();
        BairroDal bairroDal = new BairroDal();

        public enum MessageType { Sucesso, Erro, Info, Perigo };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulaCategorias();
                PopulaBairros();
                PopulaStatus();
            }
        }

        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        private void PopulaStatus()
        {
            Array c = Enum.GetValues(typeof(Status));

            foreach (var item in c)
            {
                ddlStatus.Items.Add(new ListItem(Enum.GetName(typeof(Status), item), item.ToString()));
            }
            ddlStatus.Items.Insert(0, new ListItem("----Selecione-----", "0"));
        }

        private void PopulaBairros()
        {
            List<BairroDal> bai = bairroDal.getBairros();
            ddlBairro.DataSource = bai;
            ddlBairro.DataTextField = "Nome";
            ddlBairro.DataValueField = "BairroId";
            ddlBairro.DataBind();
            ddlBairro.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlBairro.SelectedIndex = 0;

            ddlBairroComent.DataSource = bai;
            ddlBairroComent.DataTextField = "Nome";
            ddlBairroComent.DataValueField = "BairroId";
            ddlBairroComent.DataBind();
            ddlBairroComent.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlBairroComent.SelectedIndex = 0;

            ddlBairro3.DataSource = bai;
            ddlBairro3.DataTextField = "Nome";
            ddlBairro3.DataValueField = "BairroId";
            ddlBairro3.DataBind();
            ddlBairro3.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlBairro3.SelectedIndex = 0;

        }
        private void PopulaCategorias()
        {
            //List<CategoriaDal> cat = categoriaDal.getCategoria();

            //ddlCategorias.DataSource = cat;
            //ddlCategorias.DataTextField = "Cat_Titulo";
            //ddlCategorias.DataValueField = "CategoriaId";
            //ddlCategorias.DataBind();
            //ddlCategorias.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoria.SelectedIndex = 0;

            //ddlCategoria.DataSource = cat;
            //ddlCategoria.DataTextField = "Cat_Titulo";
            //ddlCategoria.DataValueField = "CategoriaId";
            //ddlCategoria.DataBind();
            //ddlCategoria.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoria.SelectedIndex = 0;

            //ddlCategoriaComent.DataSource = cat;
            //ddlCategoriaComent.DataTextField = "Cat_Titulo";
            //ddlCategoriaComent.DataValueField = "CategoriaId";
            //ddlCategoriaComent.DataBind();
            //ddlCategoriaComent.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoriaComent.SelectedIndex = 0;

            //ddlCategoria3.DataSource = cat;
            //ddlCategoria3.DataTextField = "Cat_Titulo";
            //ddlCategoria3.DataValueField = "CategoriaId";
            //ddlCategoria3.DataBind();
            //ddlCategoria3.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoria3.SelectedIndex = 0;
        }


        protected void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            //if (IsValid)
            //{
            //    CategoriaDal novaCat = new CategoriaDal();
            //    novaCat.Cat_Titulo = txtNome.Text;
            //    novaCat.Cat_Descricao = txtDescricao.Text;
            //    int i = categoriaDal.insereCategoria(novaCat);
            //    if (i > 0)
            //        ShowMessage("Você Inseriu com sucesso a Categoria", MessageType.Sucesso);
            //    else
            //        ShowMessage("Ocorreu um erro contate o administrador", MessageType.Erro);
            //    LimpaCategoria();
            //    PopulaCategorias();
            //}
        }

        private void LimpaCategoria()
        {
            txtNome.Text = String.Empty;
            txtDescricao.Text = String.Empty;
        }
    }
}