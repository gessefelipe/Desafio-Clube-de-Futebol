<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AtletaForm.aspx.cs" Inherits="Project_Clube_Futebol.AtletaForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Adicionar/Editar Atleta</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js"></script>
    
    <script>
        $(document).ready(function ($) {
            $('.date').mask('00/00/0000');
            $('.height').mask('0.00');
            $('.weight').mask("000.00", { reverse: true });
            $('.number').mask('00');
        });
    </script>
</head>
<body>
    <form id="frmMain" runat="server">
        <div class="container mt-4">
            <h2 class="text-center mb-4"><%: IsEditMode ? "Editar Atleta" : "Adicionar Atleta" %></h2>

            <div class="row justify-content-center">
                <div class="col-md-6">
                    <asp:HiddenField ID="hfId" runat="server" />
                    
                    <div class="mb-3">
                        <label for="txtNome" class="form-label">Nome:</label>
                        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtApelido" class="form-label">Apelido:</label>
                        <asp:TextBox ID="txtApelido" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtDataNascimento" class="form-label">Data de Nascimento:</label>
                        <asp:TextBox ID="txtDataNascimento" CssClass="form-control date" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtAltura" class="form-label">Altura (metros):</label>
                        <asp:TextBox ID="txtAltura" CssClass="form-control height" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtPeso" class="form-label">Peso (kg):</label>
                        <asp:TextBox ID="txtPeso" CssClass="form-control weight" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtPosicao" class="form-label">Posição:</label>
                        <asp:TextBox ID="txtPosicao" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="txtNumeroCamisa" class="form-label">Número da Camisa:</label>
                        <asp:TextBox ID="txtNumeroCamisa" CssClass="form-control number" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
