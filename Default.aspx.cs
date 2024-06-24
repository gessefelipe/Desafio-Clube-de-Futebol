using Project_Clube_Futebol.DataAccess;
using System;

namespace Project_Clube_Futebol
{
    public partial class Default : System.Web.UI.Page
    {
        private AtletaBLL atletaBLL = new AtletaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGrid();
            }
        }

        private void CarregarGrid()
        {
            gvAtletas.DataSource = atletaBLL.GetAtletas();
            gvAtletas.DataBind();
        }

        protected void gvAtletas_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                atletaBLL.DeleteAtleta(id);

                Response.Redirect("Default.aspx");
            }
        }
    }
}