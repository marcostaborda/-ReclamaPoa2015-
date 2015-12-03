<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gerencial.aspx.cs" Inherits="ReclamaPoa2015.Gerencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Main -->
    <div class="container">
        <div class="row">
            <br />
            <br />
            <a href="#"><strong><span class="glyphicon glyphicon-dashboard"></span>Painel Gerencial </strong></a>

            <hr>
            <div class="well">
                Bem-vindo, <%: Context.User.Identity.GetUserName()  %>
                <p>Acesse aqui informações e gere relatórios sobre o site.</p>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <!--/panel-->
                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#orgaos"><i class="glyphicon glyphicon-eye-open"></i>  Orgãos oficiais</div>
                        <div class="panel-gerencial collapse" id="orgaos">
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>
                                    <p>Consulte o percentual de informações respondidas e encerradas de acordo com o órgão oficial.</p>

                                    <asp:TextBox ID="txtNomeOrgao" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Button ID="btnPesquisarOrgao" CssClass="btn btn-default-sm" runat="server" Text="Pesquisar" />
                                    <br />
                                    <br />
                                    <p class="p-inline">Percentual de reclamações respondidas e encerradas por este órgão: </p>
                                    <asp:Label ID="lblpercentualReclamacoes" CssClass="badge pull-right" runat="server" Text=""></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                    <!--/panel-->

                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#usuarios"><i class="glyphicon glyphicon-user"></i>  Usuários</div>
                        <div class="panel-body collapse" id="usuarios">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <p>
                                        <p>Insira o e-mail do usuário: </p>
                                        <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
                                        <asp:Button ID="btnPesquisarUser" CssClass="btn btn-default btn-sm" runat="server" OnClick="btnPesquisarUser_Click" Text="Pesquisar" />
                                        <br />
                                    </p>
                                    <h2 class="reclam">Resultados: </h2>
                                    <hr />

                                    <asp:Label ID="lblNomeUsuario" runat="server" Text="Nome do Usuário"></asp:Label>
                                    <div class="usuarioOficial pull-right">
                                        <asp:Label ID="lblCheckBox" runat="server" Text="Tornar usuário oficial:"></asp:Label>
                                        &nbsp
                              <asp:CheckBox ID="ckBox" runat="server" />
                                    </div>
                                    <br />
                                    <br />
                                    <div class="inputgroup">
                                        <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" OnClick="btnSalvarOficial_Click" Text="Salvar Alterações" />
                                    </div>
                                    <div class="alert alert-success" runat="server" id="SucessoOficial">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Successo!</strong>
                                        <asp:Literal ID="MensagemOficial" runat="server"></asp:Literal>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>


                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#reclamacoes"><i class="glyphicon glyphicon-comment"></i>  Reclamações </div>
                        <div class="panel-body collapse" id="reclamacoes">
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <p>
                                        <p>Selecione as informações para gerar o número total de reclamações: </p>
                                        <asp:Label ID="lblCategoria" runat="server" Text="Categoria:"></asp:Label>
                                        <asp:DropDownList CssClass="form-control" ID="ddlCategoria" runat="server"></asp:DropDownList>
                                        <br />
                                        <br />
                                        <asp:Label ID="lblBairro" runat="server" Text="Bairro:"></asp:Label>
                                        <asp:DropDownList CssClass="form-control" ID="ddlBairro" runat="server"></asp:DropDownList>
                                        <br />
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <div class="sandbox-container">
                                                    <div class="inputgroup input-daterange">
                                                        <asp:Label ID="lblData1" runat="server" Text="Data inicial: "></asp:Label>
                                                        <asp:TextBox CssClass="form-control" ID="txtDate1" runat="server" Width="150px"></asp:TextBox>
                                                        <br />
                                                        <br />
                                                        <asp:Label ID="lblData2" runat="server" Text="Data final: "></asp:Label>
                                                        <asp:TextBox CssClass="form-control" ID="txtDate2" runat="server" Width="150px"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Button ID="btnGerar" CssClass="btn btn-default btn-sm pull-right" runat="server" Text="Gerar informações" OnClick="btnGerar_Click" />
                                        <br />
                                    </p>
                                    <br />
                                    <br />
                                    <h2 class="reclam">Total de reclamações: </h2>
                                    <asp:Label ID="lblTotal" CssClass="badge pull-right" runat="server" Text=""></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>


                </div>
                <div class="col-md-6">
                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#cadastrar-cat"><i class="glyphicon glyphicon-th-list"></i>  Cadastrar Categorias: </div>
                        <div class="panel-body collapse" id="cadastrar-cat">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="lblCatCadastradas" runat="server" Text="Categorias Cadastradas: "></asp:Label>
                                    <asp:DropDownList ID="ddlCategorias" CssClass="form-control" runat="server"></asp:DropDownList>
                                    <br />
                                    <br />
                                    <asp:Label ID="lblCatNome" runat="server" Text="Informe o nome: "></asp:Label>
                                    <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                                    <br />
                                    <br />

                                    <asp:Label ID="lblCatDescricao" runat="server" Text="Informe a descrição: "></asp:Label>
                                    <asp:TextBox CssClass="form-control" ID="txtDescricao" runat="server"></asp:TextBox>
                                    <br />
                                    <br />
                                    <div class="alert alert-success" runat="server" id="SucessoCategoria">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Successo!</strong>
                                        <asp:Literal ID="MensagemCategoria" runat="server"></asp:Literal>
                                    </div>
                                     <br />
                                    <br />
                                    <div runat="server" class="alert alert-danger" id="ErroCategoria">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Erro!</strong> <asp:Literal runat="server" ID="MensagemCategoriaErro"></asp:Literal> 

                                    </div>
                                    <asp:Button ID="btnInserirCategoria" CssClass="btn btn-default-sm" runat="server" Text="Inserir" OnClick="btnInserirCategoria_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>

                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#comentarios"><i class="glyphicon glyphicon-eye-open"></i>  Comentários</div>
                        <div class="panel-body collapse" id="comentarios">
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>
                                    <p>
                                        <p>Selecione as informações para gerar o número médio de comentários: </p>
                                        <asp:Label ID="Label1" runat="server" Text="Categoria:"></asp:Label>
                                        <asp:DropDownList CssClass="form-control" ID="ddlCategoriaComent" runat="server"></asp:DropDownList>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label2" runat="server" Text="Bairro:"></asp:Label>
                                        <asp:DropDownList CssClass="form-control" ID="ddlBairroComent" runat="server"></asp:DropDownList>
                                        <br />
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <div class="sandbox-container">
                                                    <div class="inputgroup input-daterange">
                                                        <asp:Label ID="Label3" runat="server" Text="Data inicial: "></asp:Label>
                                                        <asp:TextBox CssClass="form-control" ID="txtDataComentIni" runat="server" Width="150px"></asp:TextBox>
                                                        <br />
                                                        <br />
                                                        <asp:Label ID="Label4" runat="server" Text="Data final: "></asp:Label>
                                                        <asp:TextBox CssClass="form-control" ID="txtDataComentFinal" runat="server" Width="150px"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Button ID="btnGerar2" CssClass="btn btn-default btn-sm pull-right" runat="server" Text="Gerar informações" />
                                        <br />
                                    </p>
                                    <br />
                                    <br />
                                    <h2 class="reclam">Número médio de comentários: </h2>
                                    <asp:Label ID="lblNumeroMedioComentario" CssClass="badge pull-right" runat="server" Text=""></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>

                    <div class="panel panel-default">
                        <div class="panel-heading" data-toggle="collapse" href="#status"><i class="glyphicon glyphicon-ok"></i>  Status</div>
                        <div class="panel-body collapse" id="status">
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                <ContentTemplate>
                                    <p>Selecione as informações para gerar o percentual de reclamações de acordo com seu status : </p>
                                    <asp:Label ID="lblStatus" runat="server" Text="Status:"></asp:Label>
                                    <asp:DropDownList CssClass="form-control" ID="ddlStatus" runat="server"></asp:DropDownList>
                                    <br />
                                    <br />
                                    <asp:Label ID="lblCategoria2" runat="server" Text="Categoria:"></asp:Label>
                                    <asp:DropDownList CssClass="form-control" ID="ddlCategoria3" runat="server"></asp:DropDownList>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label6" runat="server" Text="Bairro:"></asp:Label>
                                    <asp:DropDownList CssClass="form-control" ID="ddlBairro3" runat="server"></asp:DropDownList>
                                    <br />
                                    <br />
                                    <asp:Button ID="btnGerarStatusPercentual" CssClass="btn btn-default btn-sm pull-right" runat="server" Text="Gerar informações" OnClick="btnGerarStatusPercentual_Click" />
                                    <br />
                                    <br />
                                    <div runat="server" class="alert alert-danger" id="ErroStatusPercentual">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <strong>Erro!</strong> <asp:Literal runat="server" ID="MessageStatusErro"></asp:Literal> 

                                    </div>
                                    <br />
                                    <h2 class="reclam">Percentual: </h2>
                                    <asp:Label ID="lblPercentualStatus" CssClass="badge pull-right" runat="server" Text=""></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>


                </div>
                <!--/col-span-6-->

            </div>
            <!--/row-->
            <%--</div><!--/col-span-9-->--%>
        </div>
    </div>
</asp:Content>
