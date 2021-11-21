using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class CD_Conexao
    {
      
            private SqlConnection Conexao = new SqlConnection("Server=(DESKTOP-9J2BVIQ);DataBase= Practica;Integrated Security=true");

            public SqlConnection AbrirConexion()
            {
                if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();
                return Conexao;
            }

            public SqlConnection CerrarConexion()
            {
                if (Conexao.State == ConnectionState.Open)
                Conexao.Close();
                return Conexao;
            }
        }
}
