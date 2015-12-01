<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="ReclamaPoa2015.Pesquisa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Pesquisar Reclamações:</h1>
    <hr />
    <p>Preencha as informações abaixo para pesquisar reclamações.</p>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                <div class="sandbox-container">
                    <div class="form-group">
                        <asp:Label ID="lblCategoria" runat="server" Text="Tipo de problema:" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:DropDownList CssClass="form-control" ID="ddlCategoria" runat="server" Width="250px"></asp:DropDownList>
                        </div>
                    </div>
                    <br>
                    <br>
                    <div class="form-group">
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro:" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:DropDownList CssClass="form-control" ID="ddlBairro" runat="server" Width="250px"></asp:DropDownList>
                        </div>
                    </div>              
                    <br>    
                    <br>  
                    <div class="form-group">
                        <asp:Label ID="lblStatus" runat="server" Text="Status:" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:DropDownList CssClass="form-control" ID="ddlStatus" runat="server" Width="250px"></asp:DropDownList>
                        </div>
                    </div>
                    <br><br>
                    <div class="input-daterange input-group" id="datepicker">                         
                        <div class="input-group">
                            <asp:Label ID="lblData1" runat="server" Text="Data inicial: " CssClass="input-group-addon"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtDate1" runat="server" Width="250px"></asp:TextBox>
                        </div>
                        <br>  
                        <div class="input-group">
                            <asp:Label ID="lblData2" runat="server" Text="Data final:" CssClass="input-group-addon"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtDate2" runat="server" Width="250px"></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <br />
                <div class="pull-right">
                    <asp:Button CssClass="btn btn-default" ID="btnEnviar" runat="server" Text="Pesquisar" OnClick="btnEnviar_Click" />
                    <asp:Button CssClass="btn btn-default" ID="btnlimpar" runat="server" Text="Limpar" OnClick="btnlimpar_Click" />
                </div>
           

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Título</th>
                        <th>Descrição</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Calçada com buraco</td>
                        <td>Minha calçada está com buracos.</td>
                        <td>
                            <img src="http://placehold.it/140x100" /></td>
                        <td>
                            <a href="#">Detalhes</a>
                        </td>
                    </tr>
                    <tr>
                        <td>Calçada com buraco</td>
                        <td>Minha calçada está com buracos.</td>
                        <td>
                            <img src="http://placehold.it/140x100" /></td>
                        <td>
                            <a href="#">Detalhes</a>
                        </td>
                    </tr>
                    <tr>
                        <td>Calçada com buraco</td>
                        <td>Minha calçada está com buracos.</td>
                        <td>
                            <img src="http://placehold.it/140x100" /></td>
                        <td>
                            <a href="#">Detalhes</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
