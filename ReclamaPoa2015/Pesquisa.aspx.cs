using Microsoft.AspNet.Identity;
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
        CategoriaDal categoriaBll = new CategoriaDal();
        BairroDal bairroBll = new BairroDal();
        ReclamacaoDal r = new ReclamacaoDal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PopulaCategorias();
                PopulaBairros();
                PopulaStatus();
                LimpaTela();             
            }
        }

        private void PopulaBairros()
        {
            ddlBairro.DataSource = bairroBll.getBairros();
            ddlBairro.DataTextField = "Nome";
            ddlBairro.DataValueField = "BairroId";
            ddlBairro.DataBind();
            ddlBairro.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlBairro.SelectedIndex = 0;
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
            ddlCategoria.DataSource = categoriaBll.getCategoria();
            ddlCategoria.DataTextField = "Cat_Titulo";
            ddlCategoria.DataValueField = "CategoriaId";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlCategoria.SelectedIndex = 0;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            int codCategoria = int.Parse(ddlCategoria.SelectedValue);
            int codBairro = int.Parse(ddlBairro.SelectedValue);;
            Status statusId = (Status)Enum.Parse(typeof(Status), ddlStatus.SelectedValue);

            String data1 = txtDate1.Text;
            String data2 = txtDate2.Text;
            DateTime dataValue1;
            DateTime dataValue2;
            DateTime.TryParse(data1, out dataValue1);
            DateTime.TryParse(data2, out dataValue2);
            PopulaList(codCategoria, codBairro, statusId, dataValue1, dataValue2);
        }

        private void PopulaList(int codCategoria, int codBairro, Status statusId, DateTime data1, DateTime data2)
        {    
            reclamacaoList.DataSource = r.populaPesquisa(codCategoria, codBairro, statusId, data1, data2);
            reclamacaoList.DataBind();
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
            reclamacaoList.DataSource = null;
            reclamacaoList.DataBind();
        }        
    }
}