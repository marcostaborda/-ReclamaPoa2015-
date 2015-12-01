<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reclamacoes.aspx.cs" Inherits="ReclamaPoa2015.Reclamacoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Reclamações</h1>
    <hr />
    <table class="table table-hover">
        <thead>
            <tr>
                <th>Título</th>
                <th>Descrição</th>
                <th></th>
                <th></th>
            </tr>
        </thead>

        <asp:ListView ID="reclamacaoList" runat="server"
            DataKeyNames="ReclamacaoId" GroupItemCount="1"
            ItemType="ReclamaPoa2015.Models.ReclamacaoViewModel" SelectMethod="reclamacaoList_GetData">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>Nehum Reclamacao Encontrada.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td/>
            </EmptyItemTemplate>

            <ItemTemplate>
                <tbody runat="server">
                    <tr>
                        <td><%#: Item.Titulo%></td>
                        <td><%#: Item.Descricao%></td>
                        <td style="max-width: 140px; max-height: 100px">
                            <img src="Images/Reclamacao/<%#: Item.Foto%>" style="width: 100%" /></td>
                        <td>
                            <a href="Detalhes.aspx?idReclamacao=<%#:Item.ReclamacaoId%>">Detalhes</a>
                        </td>
                    </tr>
                </tbody>
            </ItemTemplate>
        </asp:ListView>
    </table>
</asp:Content>
