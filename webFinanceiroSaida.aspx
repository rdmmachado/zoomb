<%@ Page Title="" Language="C#" MasterPageFile="~/frwMestre.Master" AutoEventWireup="true" CodeBehind="webFinanceiroSaida.aspx.cs" Inherits="Zoomb.webFinanceiroSaida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMestre" runat="server">

    <nav aria-label="breadcrumb">
        <ol class="breadcrumb m-3">
            <li class="breadcrumb-item ">
                <a href="index.aspx">Inicio</a></li>
            <li class="breadcrumb-item">Financeiro</li>
        </ol>
    </nav>

    <form id="FrmPaciente" runat="server">



        <div class="container">
            <div class="row">
                <div class="col-md-10 ">
                    <div>
                         <div class=" container">

                            <div id="" style="font-size: 12px" class="clearfix">
                                <div class="form-row ">

                                    <div class="form-group col-md-2 ">       
                                        <label for="lblGrupo">Grupo</label>
                                        <asp:DropDownList ID="ddlGrupo" runat="server" DataTextField="SomeString" DataValueField="SomeUniqueId" />
                                     </div>
                                    
                                    <div class="form-group col-md-2 ">       
                                        <label for="lblDespesas">Despesas</label>
                                        <asp:DropDownList ID="ddlDespesas" runat="server" DataTextField="SomeString" DataValueField="SomeUniqueId" />
                                     </div>

                                    <div class="form-group col-md-9">
                                        <label for="lblNome">Nome</label>
                                        <input type="text" name="ConsultaNome" class="form-control" id="ConsultaNome">
                                    </div>

                                </div>

                                <div class="form-row">

                                    <div class="form-group col-md-4">
                                        <label for="lblCPF">CPF</label>
                                        <input class="form-control" name="ConsultaCPF" id="ConsultaCPF" />
                                    </div>

                                    <div class="form-group col-md-4">
                                        <label for="lblRG">RG</label>
                                        <input class="form-control" id="ConsultaRG" name="ConsultaRG" placeholder="" />
                                    </div>
                                </div>

                                
                                <br />
                                <br />

                             
                                
                            </div>

                        </div>
                    </div>

                    <asp:GridView ID="dgvPaciente" Font-Size="Small"  PageSize="13" AllowPaging="true" OnPageIndexChanging="gvPosts_PageIndexChanging" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Paciente" EmptyDataText="Consulta Paciente">
                        <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                            <asp:BoundField DataField="paciente" HeaderText="Paciente" SortExpression="Paciente" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                            <asp:BoundField DataField="CPF" HeaderText="CPF" SortExpression="CPF" ItemStyle-CssClass="visible-xs" HeaderStyle-CssClass="visible-xs" />
                            <asp:BoundField DataField="RG" HeaderText="RG" SortExpression="RG" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                            <asp:BoundField DataField="dataNascimento" HeaderText="Nascimento" SortExpression="Nascimento" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="Status" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                            <asp:BoundField DataField="observacao" HeaderText="Observação" SortExpression="observacao" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />
                        </Columns>
                    </asp:GridView>


                    <%--       <asp:GridView ID="dgvPaciente" CssClass="table table-striped table-bordered table-hover"
                        runat="server" PageSize="10" AllowPaging="true" OnPageIndexChanging="gvPosts_PageIndexChanging">
                    </asp:GridView>--%>
                </div>

                <div class="col-sm-2 mt-1q border" style="height:150px">
               
                    <!-- Botão para acionar modal -->
                    <asp:Button ID="btnConsulta" CssClass="btn btn-primary w-100 mt-3" runat="server" Text="Consulta" OnClick="btnConsulta_Click" />
                    <br />
                    <br />
                    <button type="button" class="btn btn-primary w-100" data-toggle="modal" data-target="#ChamdaPaciente">
                        Paciente
                    </button>
                </div>

            </div>
        </div>  
          </form>

</asp:Content>
