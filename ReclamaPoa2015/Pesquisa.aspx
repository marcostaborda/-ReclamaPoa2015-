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
                <br>
                <br>
                <br>
                <br>
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
                <asp:Button CssClass="btn btn-default" ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnEnviar_Click" />
                <asp:Button CssClass="btn btn-default" ID="btnlimpar" runat="server" Text="Limpar" OnClick="btnlimpar_Click" />
            </div>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Título</th>
                        <th>Descrição</th>
                        <th>Foto</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody runat="server">
                    <asp:ListView ID="reclamacaoList" runat="server"
                        DataKeyNames="ReclamacaoId" GroupItemCount="1"
                        ItemType="ReclamaPoa2015.Models.ReclamacaoViewModel" Visible="false">
                        <EmptyDataTemplate>
                            <tr>
                                <td>Nehuma Reclamacao Encontrada.</td>
                            </tr>
                        </EmptyDataTemplate>

                        <EmptyItemTemplate>
                        </EmptyItemTemplate>

                        <ItemTemplate>
                            <tr>
                                <td><%#: Item.Titulo%></td>
                                <td><%#: Item.Descricao%></td>
                                <td style="max-width: 140px; max-height: 100px">
                                    <img src="Images/Reclamacao/<%#: Item.Foto %>" style="width: 100%" /></td>
                                <td>
                                    <%#:Item.Status%>
                                </td>
                                <td>
                                    <a href="Detalhes.aspx?idReclamacao=<%#:Item.ReclamacaoId%>">Detalhes</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>

                </tbody>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
