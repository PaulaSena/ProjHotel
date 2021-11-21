using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public abstract class ConexaoBD
    {
        #region Testes bancos 1

        private readonly string BDConexao;

        public ConexaoBD()
        {    //conexão para a base local Paula (conexaoSQL  DESKTOP-9J2BVIQ)
            BDConexao = @"Data Source=DESKTOP-9J2BVIQ;Initial Catalog=MyCompany;Integrated Security=True";
        }
       // private SqlConnection Conexao = new SqlConnection(BDConexao);

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(BDConexao);
        }

        #endregion


        #region Testes bancos 2

        //private readonly string conexaoString;

        //public ConexaoDoSql()
        //{    //conexão para a base local Paula (conexaoSQL  DESKTOP-9J2BVIQ)
        //    conexaoString = @"Data Source=DESKTOP-9J2BVIQ;Initial Catalog=MyCompany;Integrated Security=True";
        //}
        //protected SqlConnection GetSqlConnection()
        //{
        //    return new SqlConnection(conexaoString);
        //}
        #endregion


        #region Teste banco 3


        //private static string BDConexao = @"Data Source=DESKTOP-9J2BVIQ;DataBase=HHOTEL;Integrated Security=true";
        ////@"Data Source=DESKTOP-9J2BVIQ;Initial Catalog=MyCompany;Integrated Security=True";
        //private SqlConnection Conexao = new SqlConnection(BDConexao);

        //protected SqlConnection GetSqlConnection()
        //{
        //    return new SqlConnection(BDConexao);
        //}


        #endregion



        //public SqlConnection AbrirConexao()
        //{
        //    if (Conexao.State == ConnectionState.Closed)
        //        Conexao.Open();
        //    return Conexao;
        //}

        //public SqlConnection FecharConexao()
        //{
        //    if (Conexao.State == ConnectionState.Open)
        //        Conexao.Close();
        //    return Conexao;
        //}
    }
}
