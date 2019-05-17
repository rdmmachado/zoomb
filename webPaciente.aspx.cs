using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;




namespace Zoomb
{
    public partial class webPaciente : System.Web.UI.Page
    {

        private DataSet Ds = new DataSet();
        private clsPaciente obj_Paciente = new clsPaciente();
        //public int Salvar = 0;

                protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            string Codigo = Request["ConsultaCodigo"];
            string Nome = Request["ConsultaNome"];
            string CPF = Request["ConsultaCPF"];
            string RG = Request["ConsultaRG"];
            string DataNasc = Request["ConsultaDataNasc"];
            string Status = Request["ConsultaStatus"];


            Ds = obj_Paciente.ConsultaPaciente(Codigo,Nome,CPF, RG);

            if (Ds.Tables[0].Rows.Count <= 0)

                dgvPaciente.DataSource = null;
            else if (Ds.Tables[0].Rows.Count > 0)
            {
                dgvPaciente.DataSource = Ds;
                dgvPaciente.DataBind();
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string Codigo = Request["txtCodigo"];
                string Nome = Request["txtNome"];
                string CPF = Request["txtCPF"];
                string RG = Request["txtRG"];
                string DataNasc = Request["txtDataNasc"];
                string Status = Request["cmbStatus"];

                string codigo = String.Empty;


                if (Codigo != null)
                {
                    Ds = obj_Paciente.ConsultaCodigo(Codigo);
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<div id=\"divAlertBootstrap\" style=\"width:100%; position:fixed; top:300px; margin: 0px; text-align:center; font-weight:bold; z-index:999; display: none;\" class=\"alert alert-success\">" +
                            "Caixa de alerta com Bootstrap funcionando corretamente!</div>" +
                            "<script type=\"text/javascript\">window.onload=function(){alertBootstrap();};</script>");
                    }
                    codigo = Codigo;
                }
                
                else if (Codigo == null)
                {
                    Ds = obj_Paciente.ConsultaUltimoCodigo();

                    Int64 ultimocodigo;
                    ultimocodigo = Convert.ToInt64(Ds.Tables[0].Rows[0][0])+1;
                    codigo = ultimocodigo.ToString();
                }

                obj_Paciente.paciente = Nome;
                obj_Paciente.cpf = CPF;
                obj_Paciente.RG = RG;
                obj_Paciente.dataNasc = DataNasc;
                obj_Paciente.status = Status;
                obj_Paciente.Codigo = Int32.Parse(codigo);

               // if (Salvar == 1)
                ///{
                    obj_Paciente.Gravar();
                Response.Write("<div id=\"divAlertBootstrap\" style=\"width:100%; position:fixed; top:0px; margin: 0px; text-align:center; font-weight:bold; z-index:999; display: none;\" class=\"alert alert-success\">" +
           "Caixa de alerta com Bootstrap funcionando corretamente!</div>" +
           "<script type=\"text/javascript\">window.onload=function(){alertBootstrap();};</script>");
                  }
            catch (Exception ex)
            {
                Response.Write("<strong id=\"Mensagem\">" +
                                    "Paciente Cadastrado com sucesso!</div>" +
                                    "<script type=\"text/javascript\">window.onload=function(){alertBootstrap();};</script>");
            }

        }

        protected void gvPosts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    
{
            Ds = obj_Paciente.Consulta();
           
            if (Ds.Tables[0].Rows.Count <= 0)

                dgvPaciente.DataSource = null;
            else if (Ds.Tables[0].Rows.Count > 0)
            {
                dgvPaciente.PageIndex = e.NewPageIndex;
                dgvPaciente.DataSource = Ds;
                dgvPaciente.DataBind();
            }
}


 
    }
}