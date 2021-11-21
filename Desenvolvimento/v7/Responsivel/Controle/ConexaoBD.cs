using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ConexaoBD

    {
        static private string BDConexao = "Server=DESKTOP-9J2BVIQ;DataBase=HHOTEL;Integrated Security=true";
        private SqlConnection Conexao = new SqlConnection(BDConexao);

        public SqlConnection AbrirConexao()
        {
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();
            return Conexao;
        }

        public SqlConnection FecharConexao()
        {
            if (Conexao.State == ConnectionState.Open)
                Conexao.Close();
            return Conexao;
        }
    }
}
