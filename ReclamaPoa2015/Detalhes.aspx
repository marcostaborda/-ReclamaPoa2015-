<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="ReclamaPoa2015.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    <h1 id="detalhes">
        <asp:Literal ID="litTituloReclamacao" runat="server" Text="Calçada com Buracos" ></asp:Literal>
    </h1>
    <div class="pull-right status">
        <asp:Literal ID="litStatus" runat="server" Text="Em Aberto" ></asp:Literal>
    </div>
    <hr />
    <p>Reclamação inserida por <asp:Literal ID="litUsuario" runat="server" Text="João da Silva" ></asp:Literal></p>
    <div class="container">
      <div class="row">
        <div class="col-md-6">
            <div id="resumo-detalhes">
                <p> Categoria: <asp:Literal ID="litCategoria" runat="server" Text="Buracos" ></asp:Literal> </p>
                <p> Bairro: <asp:Literal ID="litBairro" runat="server" Text="Bela Vista" ></asp:Literal> </p>
                <p> Endereço: <asp:Literal ID="litEndereco" runat="server" Text="Rua Anita Garibaldi, 1200" ></asp:Literal> </p>
            </div>
            <div>
                <p> <asp:Literal ID="litDescricao" runat="server" Text="As obras na rua Anita Garibaldi encontram-se neste estado há mais de três anos! Atrapalham imensamente a vida dos morados, estragam carros e prejudicam o aluguem de imóveis. Quando a prefeitura irá tomar uma atitude?" ></asp:Literal>  </p>
            </div>
        </div>
        <div class="col-md-6" style="max-width:350px;">
            <asp:Image ID="imgReclamacao" runat="server" CssClass="imgDetalhes" Width="100%" ImageUrl="http://placehold.it/350x150"/>
        </div>
      </div>
    </div>
    <br />
    <h2> Comentários </h2>
    <hr />
    <div class="container">
      <div class="row">
        <div class="col-md-2">
            <img class="imgDetalhes" src="http://placehold.it/140x100" />            
        </div>
        <div class="col-md-8">
           <p><asp:Literal ID="litComentario" runat="server" Text="Apoiado! Esperando uma atitude da prefeitura!" ></asp:Literal> </p>
            <p class="offset-md-4" ><asp:Literal ID="litUsuarioComentario" runat="server" Text="Maria da Silva" ></asp:Literal> </p>
        </div>
        </div>
        <br />
         <div class="row">
        <div class="col-md-2">
            <img class="imgDetalhes" src="http://placehold.it/140x100" />            
        </div>
        <div class="col-md-8">
           <p><asp:Literal ID="Literal1" runat="server" Text="Apoiado! Esperando uma atitude da prefeitura!" ></asp:Literal> </p>
            <p class="offset-md-4" ><asp:Literal ID="Literal2" runat="server" Text="Maria da Silva" ></asp:Literal> </p>
        </div>
      </div>
    </div>
</asp:Content>
