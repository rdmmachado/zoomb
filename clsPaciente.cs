using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Zoomb
{
    public class clsPaciente
    {
        string Sql;
        DataSet Ds = new DataSet();

        clsConeccao Con = new clsConeccao();

        #region Objeto
    
        private Int32 Codigo_;
        public Int32 Codigo
        {
            get { return Codigo_; }
            set { Codigo_ = value; }
        }

        private string Paciente_;
        public string paciente
        {
            get { return Paciente_; }
            set { Paciente_ = value; }
        }

        private string CPF_;
        public string cpf
        {
            get { return CPF_; }
            set { CPF_ = value; }
        }

        private string Rg_;
        public string RG
        {
            get { return Rg_; }
            set { Rg_ = value; }
        }

        private string DataNasc_;
        public string dataNasc
        {
            get { return DataNasc_; }
            set { DataNasc_ = value; }
        }

        private string Status_;
        public string status
        {
            get { return Status_; }
            set { Status_ = value; }
        }

        private string Observacao_;
        public string observacao
        {
            get { return Observacao_; }
            set { Observacao_ = value; }
        }
        #endregion


        public DataSet Consulta()
        {
            Sql = "Select * from Paciente order by Codigo asc ";
            Ds = Con.Listar(Sql);
            return Ds;
        }

       public DataSet ConsultaPaciente(string codPaciente, string paciente, string CPF, string RG)
        {

                       
            if (paciente !="" | CPF != "")
            {
                Sql = "Select * from Paciente where paciente like '%" + paciente + " %' And CPF Like '%" + CPF + "%' order by Codigo asc ";
                Ds = Con.Listar(Sql);
            }
            else if (codPaciente != null)
            {
                Sql = "Select * from Paciente where codigo=" + codPaciente+ " order by Codigo asc ";
                Ds = Con.Listar(Sql);
            }
            else if (RG != "")
            {
                Sql = "Select * from Paciente where RG= " + RG + "order by Codigo asc ";
                Ds = Con.Listar(Sql);
            }
            else
            {
                Sql = "Select * from Paciente order by Codigo asc ";
                Ds = Con.Listar(Sql);
                
            }
            return Ds;
                
        }


        public void Gravar()
        {
            Sql = "INSERT INTO Paciente(Codigo, paciente, CPF, RG, dataNascimento, Status)" + 
                " VALUES(" + Codigo_ + ",'" + Paciente_ + "','" + CPF_ + "','" + Rg_ + "','" + DataNasc_ + "','" + Status_ + "')";
            
            Con.Operar(Sql);
        }

        public DataSet ConsultaCodigo(string codigoPaciente)
        {
            if (Convert.ToInt64(codigoPaciente) > 0)
                Sql = "Select * from Paciente where codigo=" + codigoPaciente + "";
            else
                Sql = "Select Max(codigo) from Paciente";

            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaUltimoCodigo()
        {
            Sql = "Select Max(codigo) from Paciente";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public void Alterar()
        {
            Sql = "UPDATE Paciente Set paciente='" + Paciente_ + "',cpf='" + cpf + "',rg='" + Rg_ + "',dataNascimento='" + DataNasc_ + "',Status='" + Status_ + "' Where codigo=" + Codigo_;

            Con.Operar(Sql);
        }




    }
}