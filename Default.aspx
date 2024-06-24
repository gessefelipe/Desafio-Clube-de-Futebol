<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_Clube_Futebol.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de Atletas</title>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" />
    
    <script src="https://kit.fontawesome.com/4d2d698f6e.js" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="frmMain" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <h2 class="text-center mt-4 mb-4">Lista de Atletas</h2>
                    <a href="AtletaForm.aspx" class="btn btn-primary mb-3">Adicionar Atleta</a>

                    <div class="table-responsive mt-2">
                        <asp:GridView ID="gvAtletas" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" OnRowCommand="gvAtletas_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="numero_camisa" HeaderText="Número Camisa" />
                                <asp:BoundField DataField="nome" HeaderText="Nome" />
                                <asp:BoundField DataField="apelido" HeaderText="Apelido" />
                                <asp:BoundField DataField="IMC" HeaderText="IMC" DataFormatString="{0:N2}" />
                                <asp:BoundField DataField="ClassificacaoIMC" HeaderText="Classificação IMC" />
                                <asp:TemplateField HeaderText="Ações">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlEditarAtletas" runat="server" Text="Editar" NavigateUrl='<%# "AtletaForm.aspx?Id=" + Eval("Id") %>'></asp:HyperLink>
                                        <asp:LinkButton ID="lbExcluirAtleta" runat="server" CssClass="ml-2 text-danger" OnClientClick="return confirm('Tem certeza que deseja excluir este atleta?')" CausesValidation="false" CommandName="Delete" CommandArgument='<%# Eval("Id") %>'>
                                            <i class="fa-solid fa-trash"></i>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
