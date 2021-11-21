using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
   public class CtlUsuario
    {

        private ConexaoBD Conexao = new ConexaoBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader BuscarLista;

        public CtlUsuario(ConexaoBD conexao, SqlCommand comando, SqlDataReader buscarLista)
        {
            Conexao = conexao;
            Comando = comando;
            BuscarLista = buscarLista;
        }

      
    }
}
