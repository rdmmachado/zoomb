<%@ Page Title="" Language="C#" MasterPageFile="~/frwMestre.Master" AutoEventWireup="true" CodeBehind="webPaciente.aspx.cs" Inherits="Zoomb.webPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMestre" runat="server">

    <nav aria-label="breadcrumb">
        <ol class="breadcrumb m-3">
            <li class="breadcrumb-item ">
                <a href="index.aspx">Inicio</a></li>
            <li class="breadcrumb-item">Paciente</li>
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
                                        <label for="lblCodigo">Código</label>
                                        <input type="number" name="ConsultaCodigo" class="form-control" id="ConsultaCodigo">
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



        <!-- Modal -->
        <div class="modal fade" id="ChamdaPaciente" tabindex="-1" role="dialog" aria-labelledby="Paciente" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg" role="document">

                <div class="modal-content">

                    <div class="modal-header">
                        <h5 class="modal-title" id="TituloModalCentralizado">Paciente</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Fechar">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>

                    <div class=" modal-body">

                        <div class=" container">

                            <div id="" style="font-size: 12px" class="clearfix">


                                <div class="form-row ">

                                    <div class="form-group col-md-2 ">
                                        <label for="lblCodigo">Código</label>
                                        <input type="number" name="Codigo" class="form-control" id="Codigo">
                                    </div>

                                    <div class="form-group col-md-9">
                                        <label for="lblNome">Nome</label>
                                        <input  name="txtNome" class="form-control" id="txtNome" />
                                    </div>

                                </div>

                                <div class="form-row">

                                    <div class="form-group col-md-4">
                                        <label for="lblCPF">CPF</label>
                                        <input class="form-control" name="txtCPF" id="txtCPF" />
                                    </div>

                                    <div class="form-group col-md-4">
                                        <label for="lblRG">RG</label>
                                        <input class="form-control" id="txtRG" name="txtRG"  />
                                    </div>

                                    <div class="form-group col-md-3">
                                        <label for="lblNascimento">Data Nascimento</label>
                                        <input class="form-control" id="txtDataNasc" name="txtDataNasc" type="date" />
                                    </div>
                                    <div class="form-group col-md-11">
                                        <label for="lblObservacao">Observação</label>
                                        <input class="form-control" id="txtObservacao" type="text" />
                                    </div>

                                </div>

                                <div class="form-row">

                                    <div class="form-group col-md-3">
                                        <label for="lblNascimento">Status</label>
                                        <select class="custom-select my-1 mr-sm-2" id="cmbStatus" name="cmbStatus">
                                            <option selected>Escolher...</option>
                                            <option value="1">ATIVO</option>
                                            <option value="2">EM TRATAMENTO</option>
                                            <option value="3">INATIVO</option>
                                            <option value="3">FINALIZADO</option>
                                            <option value="3">INADIMPLENTE</option>

                                        </select>
                                    </div>

                                </div>

                                <br />
                                <br />

                                <br />
                                <br />

                                <div id="Alerta" class="alert alert-success collapse">
                                    <a id="FechaAlerta" class="close" href="#">&times;</a>
                                    <strong id="Mensagem" class="alert-success">Sucesso</strong>&nbsp;&nbsp;&nbsp;Gravação Realizada com sucesso
                                    <section id="meuModal" class ="modal hide fade" data-backdrop="static" tabindex="-1" role="dialog" aria-labelledby="meuModalLabel" aria-hidden="true" />
                                </div>

                                <div class="container">
                                    <%--     <asp:GridView ID="dgvPaciente" runat="server" CssClass="table table-hover table-striped" GridLines="None" >
                </asp:GridView>--%>
                                </div>


                            </div>

                        </div>

                    </div>

                    <div class="modal-footer">


                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                        <asp:Button ID="btnGravar" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="btnGravar_Click" />

                    </div>

                </div>
            </div>
        </div>
    </form>
    <!------>




    <script type="text/javascript">

        $("#txtCPF").mask("000.000.000-00");

        $(document).ready(function () {
            $('#Gravar').click(function () {
                $('#Alerta').show('fade');

                setTimeout(function () {
                    $('#Alerta').hide('fade');
                }, 130000);
            });

            $('#FechaAlerta').click(function () {
                $('#Alerta').hide('fade');
            });

            function alertBootstrap() {
                $("#divAlertBootstrap").slideDown(500).delay(4000).slideUp(500);
            };

        });
    </script>

</asp:Content>
