using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class CtlFuncionario
    {
        private ConexaoBD Conexao = new ConexaoBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader BuscarLista;

    }

    public class Comando
    {
        public static string CommandText;

        public static object Connection { get; set; }
    }
}
