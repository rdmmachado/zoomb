using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Specialized;

using System.Data;
using System.Configuration;

namespace Zoomb
{
    public class clsConeccao
    {

            //public static string StringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoClinica"].ConnectionString;
        //public static SqlConnection connection = new SqlConnection(StringConexao);

        //private System.Data.OleDb.OleDbConnection Dbcon = new System.Data.OleDb.OleDbConnection();
        
        //public static void Conectar()
        //{
        //    if (connection.State == System.Data.ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }

        //}
        //public static void Desconectar()
        //{
        //    if (connection.State == System.Data.ConnectionState.Open)
        //    {
        //        connection.Close();
        //    }
        //}

        //Conectar
        //--------------
        //------------------
        //-----------------
        //Public StringConection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & username.ReadToEnd & ";Persist Security Info=False;"

        private System.Data.OleDb.OleDbConnection Dbcon = new System.Data.OleDb.OleDbConnection();
        private OleDbCommand DBcmd;
        private OleDbDataAdapter DBDA;
        public DataSet dbDs;
        private DataTable DbDt;

        public static string StringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoClinica"].ConnectionString;
        public static OleDbConnection connection = new OleDbConnection(StringConexao);
        private DataSet ds = new DataSet();

        public void Conecta(string Query)
        {
            Dbcon = new OleDbConnection(StringConexao);
            Dbcon.Open();

        }

        public void Operar(string OLEDB)
        {
            // Faz a conexão com o banco de dados

            Dbcon = new OleDbConnection(StringConexao);
            Dbcon.Open();

            DBcmd = new System.Data.OleDb.OleDbCommand(OLEDB, Dbcon);
            DBcmd.ExecuteNonQuery();
            Dbcon.Close();
        }

        public DataSet Listar(string OLE)
        {
            try
            {
                Dbcon = new System.Data.OleDb.OleDbConnection(StringConexao);
                Dbcon.Open();

                DBDA = new System.Data.OleDb.OleDbDataAdapter(OLE, Dbcon);
                DBDA.Fill(ds);
            }
            finally
            {
                Dbcon.Close();
            }

            return ds;
        }

    }
}
