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
    public partial class webFinanceiroSaida : System.Web.UI.Page
    {
        private DataSet Ds = new DataSet();
        private clsSaidaFinanceira obj_Saida = new clsSaidaFinanceira();
        //public int Salvar = 0;

        #region PAramento
        public void ConsultaGrupoDesp()
        {
            try
            {
                Ds = obj_Saida.ConsultaGrupoDesp();
                ddlGrupo.DataValueField = "codigo";
                ddlGrupo.DataTextField = "descricao";
                ddlGrupo.DataSource = Ds.Tables[0];
                ddlGrupo.DataBind();
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox("Nao Foi Possicevel Consulta Paciente", MsgBoxStyle.Critical, "Erro");
            }
        }


        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            //ConsultaGrupoDesp()
        }
    }
}