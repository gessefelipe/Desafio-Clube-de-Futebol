using Project_Clube_Futebol.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Clube_Futebol
{
    public partial class AtletaForm : System.Web.UI.Page
    {
        private AtletaBLL atletaBLL = new AtletaBLL();
        public bool IsEditMode => !string.IsNullOrEmpty(Request.QueryString["Id"]);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && IsEditMode)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                var atleta = atletaBLL.GetAtletas().Find(a => a.Id == id);
                if (atleta != null)
                {
                    hfId.Value = atleta.Id.ToString();
                    txtNome.Text = atleta.Nome;
                    txtApelido.Text = atleta.Apelido;
                    txtDataNascimento.Text = atleta.Data_Nascimento.ToString("dd/MM/yyyy");
                    txtAltura.Text = atleta.Altura.ToString("0.00");
                    txtPeso.Text = atleta.Peso.ToString("0.00");
                    txtPosicao.Text = atleta.Posicao;
                    txtNumeroCamisa.Text = atleta.Numero_Camisa.ToString();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Atleta atleta = new Atleta
            {
                Nome = txtNome.Text,
                Apelido = txtApelido.Text,
                Data_Nascimento = DateTime.ParseExact(txtDataNascimento.Text, "dd/MM/yyyy", null),
                Altura = double.Parse(txtAltura.Text),
                Peso = double.Parse(txtPeso.Text),
                Posicao = txtPosicao.Text,
                Numero_Camisa = int.Parse(txtNumeroCamisa.Text),
            };

            if (IsEditMode)
            {
                atleta.Id = int.Parse(hfId.Value);
                atletaBLL.UpdateAtleta(atleta);
            }
            else
            {
                atletaBLL.AddAtleta(atleta);
            }

            Response.Redirect("Default.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}