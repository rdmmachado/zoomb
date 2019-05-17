using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace Zoomb
{
    public class clsSaidaFinanceira
    {
        
        string Sql;
        DataSet Ds = new DataSet();

        clsConeccao Con = new clsConeccao();

        #region Objeto
            private string codigo_;
            public string Codigo
            {
                get {return codigo_;}
                set {codigo_ = value;}
            }

            private Int64 codGrupo_;
            public Int64 CodGrupo
            {
                get {return codGrupo_;}
                set {codGrupo_ = value;}
            }

            private Int64 coddespesa_;
            public Int64 CodDespesa
            {
                get { return coddespesa_; }
                set { coddespesa_ = value; }
            }

            private DateTime dataSaida_;
            public DateTime DataSaida
            {
                get
                {
                    return dataSaida_;
                }
                set
                {
                    dataSaida_ = value;
                }
            }

            private string Descricao_;
            public string Descricao
            {
                get
                {
                    return Descricao_;
                }
                set
                {
                    Descricao_ = value;
                }
            }


            private string valorSaida_;
            public string ValorSaida
            {
                get
                {
                    return valorSaida_;
                }
                set
                {
                    valorSaida_ = value;
                }
            }

            private DateTime dataCadastro_;
            public DateTime DataCadastro
            {
                get
                {
                    return dataCadastro_;
                }
                set
                {
                    dataCadastro_ = value;
                }
            }

            private string observacao_;
            public string Observacao
            {
                get
                {
                    return observacao_;
                }
                set
                {
                    observacao_ = value;
                }
            }

            private string status_;
            public string Status
            {
                get
                {
                    return status_;
                }
                set
                {
                    status_ = value;
                }
            }
      
        #endregion


        public void Gravar()
        {
            Sql = "INSERT INTO SaidaFinan(codGrupo, coddespesa, dataSaida, descricao, valorSaida, dataCadastro, observacao,status)" +
                " VALUES('" + codGrupo_ + "','" + coddespesa_ + "','" + dataSaida_ + "','" + Descricao_ + "','" + valorSaida_ + "','" + dataCadastro_ + "','" + observacao_ + "','" + status_ + "')";
            Con.Operar(Sql);
        }

        public DataSet Cosultar()
        {
            Sql = "Select * from SaidaFinan";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet consultarData()
        {
            Sql = "Select * from SaidaFinan where Status='Devedor'";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaGestor(string dtInicial, string dtFinal, Int64 idDespesas, Int64 idGrupo)
        {
            if (idGrupo == 0)
                // Sql = "Select * from SaidaFinan INNER JOIN Despesas  ON SaidaFinan.codDespesa = Despesas.codigo where dataSaida BETWEEN '" & dtInicial & "' And '" & dtFinal & "'"
                Sql = "Select * from SaidaFinan INNER JOIN Despesas  ON SaidaFinan.codDespesa = Despesas.codigo where dataSaida >= #" + dtInicial + "# And dataSaida <= #" + dtFinal + "# order by dataSaida";
            else if (idDespesas == 0)
                Sql = "Select * from SaidaFinan INNER JOIN Despesas  ON SaidaFinan.codDespesa = Despesas.codigo where dataSaida BETWEEN #" + dtInicial + "# And #" + dtFinal + "# And codGrupo=" + idGrupo + "";
            else
                Sql = "Select * from SaidaFinan INNER JOIN Despesas  ON SaidaFinan.codDespesa = Despesas.codigo where dataSaida BETWEEN #" + dtInicial + "# And #" + dtFinal + "# And codGrupo=" + idGrupo + "And codDespesa=" + idDespesas + "";


            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaDespesas(int id)
        {
            Sql = "Select * from Despesas where codGrupoDespesas=" + id + "";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaGrid(int iddesp)
        {
            Sql = "Select * from saidaFinanceira where codigo=" + iddesp + "";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaGrupoDesp()
        {
            Sql = "Select * from GrupoDespesas order by descricao asc ";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public DataSet ConsultaFuncionario()
        {
            Sql = "Select * from Funcionario order by nome asc ";
            Ds = Con.Listar(Sql);
            return Ds;
        }

        public void Alterar()
        {
            Sql = "UPDATE SaidaFinan Set codGrupo='" + codGrupo_ + "',codDespesa='" + coddespesa_ + "',dataSaida='" + dataSaida_ + "',descricao='" + Descricao_ + "',valorSaida='" + valorSaida_ + "',dataCadastro='" + dataCadastro_ + "',observacao='" + observacao_ + "',status='" + status_ + "' Where codigo=" + Codigo;
            Con.Operar(Sql);
        }

        public void Excluir()
        {
            Sql = "Delete from SaidaFinan where codigo=" + Codigo + "";
            Con.Operar(Sql);
        }
    }
}