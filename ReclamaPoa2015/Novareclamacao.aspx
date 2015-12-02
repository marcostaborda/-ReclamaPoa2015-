<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Novareclamacao.aspx.cs" Inherits="ReclamaPoa2015.Novareclamacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1>Reclame!</h1>
    <hr />
    <%--<asp:Label ID="label1" runat="server" Text="Código: "></asp:Label>--%>
    <%--<asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>--%>
    <p>Preencha as informações abaixo para inserir sua reclamação.</p>

    <div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Que tipo de problema você encontrou?" CssClass="col-sm-3"></asp:Label>
            <div class="col-sm-8">
                <asp:DropDownList CssClass="form-control" ID="ddlCategoria" runat="server" Width="250px"></asp:DropDownList>
            </div>
        </div>
        <br>
        <br />
        <div class="form-group">

            <asp:Label ID="Label1" runat="server" Text="Em que bairro fica localizado?" CssClass="col-sm-3"></asp:Label>
            <div class="col-sm-8">
                <asp:DropDownList CssClass="form-control" ID="ddlBairro" runat="server" Width="250px"></asp:DropDownList>
            </div>
        </div>
        <br />
        <br />
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Endereço: " CssClass="col-sm-3"></asp:Label>
            <div class="col-sm-8">
                <asp:TextBox CssClass="form-control" ID="txtEndereco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert alert-danger" ErrorMessage="A rua é obrigatória!" ControlToValidate="txtEndereco"></asp:RequiredFieldValidator>
            </div>
        </div>
        <br />
        <br />
    </div>

    <div>
        <p class="reclam">Reclamação </p>
        <hr />
        <div class="form-group">
            <asp:Label ID="lblTitulo" runat="server" Text="Título: " CssClass="col-sm-1"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="txtTitulo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="alert alert-danger" ErrorMessage="O titulo é obrigatória!" ControlToValidate="txtTitulo"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Descrição: "></asp:Label><br />
            <asp:TextBox CssClass="form-control" ID="txtDescricao" runat="server" TextMode="MultiLine" Rows="10" Columns="60"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="alert alert-danger" ErrorMessage="Escreva uma descrição para nós!" ControlToValidate="txtDescricao"></asp:RequiredFieldValidator>
        </div>
        <br />
        
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Status:" CssClass="col-sm-2"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList CssClass="form-control" ID="ddlStatus" runat="server"  Width="250px"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group" runat="server" id="foto">
            <asp:Label ID="Label5" runat="server" Text="Carregar foto: "></asp:Label>
            <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.jpg|.jpeg|.JPEG)$"
                ControlToValidate="FileUpload1" CssClass="alert alert-danger" runat="server" ErrorMessage="Por favor selecione uma imagem" />
        </div>
    </div>

    <div class="pull-right">
        <asp:Button CssClass="btn btn-default" ID="Button1" runat="server" Text="Enviar" OnClick="cmdInserir_Click" EnableViewState="False" />
        <asp:Button CssClass="btn btn-default" ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CausesValidation="False" EnableViewState="False" />
    </div>
    <div class="messagealert" id="alert_container">
    </div>
</asp:Content>
