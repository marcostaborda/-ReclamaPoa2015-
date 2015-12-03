using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
        ReclamacaoDal r = new ReclamacaoDal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }
            else
            {
                string userId = User.Identity.GetUserId();
                ApplicationDbContext db = new ApplicationDbContext();
                var role = (from r in db.Roles where r.Name.Contains("Admin") select r).FirstOrDefault();
                var users = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role.Id)).ToList();
                if (users.Find(x => x.Id == userId) == null)
                {
                    Response.Redirect("Default.aspx");
                }
            }
            if (!IsPostBack)
            {
                MessagemFalse();
                PopulaCategorias();
                PopulaBairros();
                PopulaStatus();
            }
        }

        private void MessagemFalse()
        {
            SucessoCategoria.Visible = false;
            SucessoOficial.Visible = false;
            ErroStatusPercentual.Visible = false;
            ErroCategoria.Visible = false;
        }

        private void PopulaStatus()
        {
            Array c = Enum.GetValues(typeof(Status));

            foreach (var item in c)
            {
                ddlStatus.Items.Add(new ListItem(Enum.GetName(typeof(Status), item), item.ToString()));
            }
            ddlStatus.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlStatus.Items.Remove(ddlStatus.Items.FindByText("Aberta"));
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
            List<CategoriaDal> cat = categoriaDal.getCategoria();

            ddlCategorias.DataSource = cat;
            ddlCategorias.DataTextField = "Cat_Titulo";
            ddlCategorias.DataValueField = "CategoriaId";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlCategoria.SelectedIndex = 0;

            ddlCategoria.DataSource = cat;
            ddlCategoria.DataTextField = "Cat_Titulo";
            ddlCategoria.DataValueField = "CategoriaId";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlCategoria.SelectedIndex = 0;

            ddlCategoriaComent.DataSource = cat;
            ddlCategoriaComent.DataTextField = "Cat_Titulo";
            ddlCategoriaComent.DataValueField = "CategoriaId";
            ddlCategoriaComent.DataBind();
            ddlCategoriaComent.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlCategoriaComent.SelectedIndex = 0;

            ddlCategoria3.DataSource = cat;
            ddlCategoria3.DataTextField = "Cat_Titulo";
            ddlCategoria3.DataValueField = "CategoriaId";
            ddlCategoria3.DataBind();
            ddlCategoria3.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            ddlCategoria3.SelectedIndex = 0;
        }

        protected void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            MessagemFalse();
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDescricao.Text))
            {
                MensagemCategoriaErro.Text = "Por favor verifique se Nome e Descricao estão preenchidos";
                ErroCategoria.Visible = true;
            }
            else
            {
                CategoriaDal novaCat = new CategoriaDal();
                novaCat.Cat_Titulo = txtNome.Text;
                novaCat.Cat_Descricao = txtDescricao.Text;
                int i = categoriaDal.insereCategoria(novaCat);
                if (i > 0)
                    MensagemCategoria.Text = "Inserido com sucesso";
                SucessoCategoria.Visible = true;
                LimpaCategoria();
                PopulaCategorias();
            }
        }

        private void LimpaCategoria()
        {
            txtNome.Text = String.Empty;
            txtDescricao.Text = String.Empty;
        }

        protected void btnPesquisarUser_Click(object sender, EventArgs e)
        {
            MessagemFalse();
            ApplicationDbContext context = new ApplicationDbContext();
            var user = context.Users.ToList();
            var consulta = (from l in user
                            where l.Email.Equals(txtUsuario.Text)
                            select l).Single();
            if (consulta != null)
            {
                lblNomeUsuario.Text = consulta.Email.ToString();
                string userId = consulta.Id;
                ApplicationDbContext db = new ApplicationDbContext();
                var role = (from r in db.Roles where r.Name.Contains("Oficial") select r).FirstOrDefault();
                var users = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role.Id)).ToList();
                if (users.Find(x => x.Id == userId) == null)
                {
                    ckBox.Checked = false;
                }
                else
                {
                    ckBox.Checked = true;
                }
                ViewState["userIdOficial"] = userId;
            }
        }
        protected void btnSalvarOficial_Click(object sender, EventArgs e)
        {
            MessagemFalse();
            string userIdOfical = ViewState["userIdOficial"].ToString();
            if (!userIdOfical.Equals("0"))
            {
                IdentityResult result = null;
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                if (ckBox.Checked)
                {
                    result = manager.AddToRole(userIdOfical, "Oficial");
                    result = manager.RemoveFromRole(userIdOfical, "Usuario");
                }
                else
                {
                    result = manager.AddToRole(userIdOfical, "Usuario");
                    result = manager.RemoveFromRole(userIdOfical, "Oficial");
                }

                if (result.Succeeded)
                {
                    MensagemOficial.Text = "Alterado com sucesso";
                    SucessoOficial.Visible = true;
                    lblNomeUsuario.Text = "Nome do usuário";
                    ckBox.Checked = false;
                    ViewState["userIdOficial"] = 0;
                }
            }
        }

        protected void btnGerar_Click(object sender, EventArgs e)
        {
            int codCategoria = int.Parse(ddlCategoria.SelectedValue);
            int codBairro = int.Parse(ddlBairro.SelectedValue);

            String data1 = txtDate1.Text;
            String data2 = txtDate2.Text;
            DateTime dataValue1;
            DateTime dataValue2;
            DateTime.TryParse(data1, out dataValue1);
            DateTime.TryParse(data2, out dataValue2);
            ConsultaTotalReclama(codCategoria, codBairro, dataValue1, dataValue2);
        }

        private void ConsultaTotalReclama(int codCategoria, int codBairro, DateTime dataValue1, DateTime dataValue2)
        {
            lblTotal.Text = r.consultaTotalReclamacoes(codCategoria, codBairro, dataValue1, dataValue2).ToString();
            LimpaConsultaReclama();
        }

        private void LimpaConsultaReclama()
        {
            ddlCategoria.SelectedValue = "0";
            ddlBairro.SelectedValue = "0";
            txtDate1.Text = String.Empty;
            txtDate2.Text = String.Empty;
        }

        protected void btnGerarStatusPercentual_Click(object sender, EventArgs e)
        {
            MessagemFalse();
            int codCategoria = int.Parse(ddlCategoria3.SelectedValue);
            int codBairro = int.Parse(ddlBairro3.SelectedValue);
            Status statusId = (Status)Enum.Parse(typeof(Status), ddlStatus.SelectedValue);
            if (statusId == 0)
            {
                MessageStatusErro.Text = "Selecione pelo menos um Status";
                ErroStatusPercentual.Visible = true;
            }
            else
            {
                if (codCategoria == 0 && codBairro == 0)
                {
                    MessageStatusErro.Text = "Selecione um bairro ou uma categoria";
                    ErroStatusPercentual.Visible = true;
                }
                else
                {
                    lblPercentualStatus.Text = String.Format("{0}%", r.getPercentualStatus(codCategoria, codBairro, statusId).ToString());
                }
            }
        }
    }
}