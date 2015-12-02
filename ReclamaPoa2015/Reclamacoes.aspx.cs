using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ReclamaPoa2015.Models;
using ReclamaPoa2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoa2015
{
    public partial class Reclamacoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression

        public IQueryable<ReclamacaoViewModel> reclamacaoList_GetData()
        {
            ReclamacaoDal r = new ReclamacaoDal();
            IQueryable<ReclamacaoViewModel> rec = r.getReclamacoes();
            if (User.Identity.IsAuthenticated)
            {
                String idUser = Request.QueryString["idUser"];

                int id;
                Int32.TryParse(idUser, out id);
                if (id == 1)
                    rec = r.getReclamacaoUserId(User.Identity.GetUserId());
            }
            return rec;
        }
    }
}