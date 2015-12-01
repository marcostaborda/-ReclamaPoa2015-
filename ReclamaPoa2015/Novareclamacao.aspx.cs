using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoa2015
{
    public partial class Novareclamacao : System.Web.UI.Page
    {
        //BairroDal b = new BairroDal();
        //CategoriaDal c = new CategoriaDal();

        public enum MessageType { Sucesso, Erro, Info, Perigo };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                PopulaCategorias();
                PopulaBairros();
                PopulaStatus();
                EscondeCampos(true);
            }
        }

        private void EscondeCampos(bool talvez)
        {
            Label6.Visible = talvez; ddlStatus.Visible = talvez;
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

        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        private void PopulaBairros()
        {
            //ddlBairro.DataSource = b.getBairros();
            //ddlBairro.DataTextField = "Nome";
            //ddlBairro.DataValueField = "BairroId";
            //ddlBairro.DataBind();
            //ddlBairro.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlBairro.SelectedIndex = 0;
        }

        private void PopulaCategorias()
        {
            //ddlCategoria.DataSource = c.getCategoria();
            //ddlCategoria.DataTextField = "Cat_Titulo";
            //ddlCategoria.DataValueField = "CategoriaId";
            //ddlCategoria.DataBind();
            //ddlCategoria.Items.Insert(0, new ListItem("----Selecione-----", "0"));
            //ddlCategoria.SelectedIndex = 0;
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    String savePath = MapPath("~/Images/Reclamacao/");
            //    int codCategoria = int.Parse(ddlCategoria.SelectedValue);
            //    int codBairro = int.Parse(ddlBairro.SelectedValue);
            //    if (codCategoria != 0)
            //    {
            //        if (codBairro != 0)
            //        {
            //            if (FileUpload1.HasFile)
            //            {
            //                savePath = SaveFile(FileUpload1.PostedFile, savePath);
            //                ReclamacaoDal rec = new ReclamacaoDal()
            //                {
            //                    BairroId = codBairro,
            //                    UserId = 3,
            //                    CategoriaId = codCategoria,
            //                    Titulo = txtTitulo.Text,
            //                    Descricao = txtDescricao.Text,
            //                    Endereco = txtEndereco.Text,
            //                    StatusId = Status.Aberta,
            //                    Foto = savePath
            //                };
            //                int retorno = rec.insereReclamacao(rec);

            //                if (retorno == 0)
            //                {
            //                    ShowMessage("Ocorreu um erro ao inserir!", MessageType.Erro);
            //                }
            //                else
            //                {
            //                    //Response.Redirect("Reclamacoes.aspx");
            //                    LimparCampos();
            //                    ShowMessage("Cadastrado com sucesso", MessageType.Sucesso);
            //                }
            //            }
            //            else
            //            {
            //                ShowMessage("Selecione uma Foto!", MessageType.Erro);
            //            }
            //        }
            //        else
            //        {
            //            ShowMessage("Selecione um bairro!", MessageType.Erro);
            //        }
            //    }
            //    else
            //    {
            //        ShowMessage("Selecione uma Categoria!", MessageType.Erro);
            //    }
            //}
        }

        private string SaveFile(HttpPostedFile postedFile, String path)
        {
            // Specify the path to save the uploaded file to.
            String savePath = path;

            // Get the name of the file to upload.
            String fileName = FileUpload1.FileName;

            // Create the path and file name to check for duplicates.
            String pathToCheck = savePath + fileName;

            // Create a temporary file name to use for checking duplicates.
            String tempfileName = "";

            // Check to see if a file already exists with the
            // same name as the file to upload.        
            if (System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    // if a file with this name already exists,
                    // prefix the filename with a number.
                    tempfileName = counter.ToString() + fileName;
                    pathToCheck = savePath + tempfileName;
                    counter++;
                }

                fileName = tempfileName;
            }
            // Append the name of the file to upload to the path.
            savePath += fileName;

            FileUpload1.SaveAs(savePath);
            return fileName;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            ddlCategoria.SelectedIndex = 0;
            ddlBairro.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
            txtDescricao.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTitulo.Text = String.Empty;
        }
    }
}