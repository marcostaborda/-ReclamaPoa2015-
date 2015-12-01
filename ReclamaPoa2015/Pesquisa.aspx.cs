using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoa2015
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        //CategoriaDal categoriaBll = new CategoriaDal();
        //BairroDal bairroBll = new BairroDal();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    PopulaCategorias();
            //    PopulaBairros();
            //    PopulaStatus();
            //}
        }

        private void PopulaBairros()
        {
            //ddlBairro.DataSource = bairroBll.getBairros();
            //ddlBairro.DataTextField = "Nome";
            //ddlBairro.DataValueField = "BairroId";
            //ddlBairro.DataBind();
            //ddlBairro.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlBairro.SelectedIndex = 0;
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

        private void PopulaCategorias()
        {
            //ddlCategoria.DataSource = categoriaBll.getCategoria();
            //ddlCategoria.DataTextField = "Cat_Titulo";
            //ddlCategoria.DataValueField = "CategoriaId";
            //ddlCategoria.DataBind();
            //ddlCategoria.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoria.SelectedIndex = 0;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void btnlimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            ddlCategoria.SelectedIndex = 0;
            ddlBairro.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
            txtDate1.Text = String.Empty;
            txtDate2.Text = String.Empty;
        }
    }
}