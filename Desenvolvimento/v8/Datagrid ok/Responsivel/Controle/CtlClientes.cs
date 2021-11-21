using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace Controle
{
   public class CtlClientes : ConexaoBD 
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        private int _idCli;
        private string _Nome;
        private string _Sobrenome;
        private string Direcao;
        private string Cidade;
        private string Email;
        private string Telefone;
        private string Ocupacao;

        //METODOS CRUD
        public List<CtlClientes> VerRegistros(string Condicion)
        {
           // Comando.Connection = BDConexao;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);
           // BDConexao.Open();
            LeerFilas = Comando.ExecuteReader();
            List<CtlClientes> ListaGenerica = new List<CtlClientes>();
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new CtlClientes {
                    _idCli = LeerFilas.GetInt32(0),
                    _Nome = LeerFilas.GetString(1),
                    _Sobrenome = LeerFilas.GetString(2),
                    Direcao = LeerFilas.GetString(3),
                    Cidade = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefone = LeerFilas.GetString(6),
                    Ocupacao = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
          //  Conexao.Close();
            return ListaGenerica;
        }

        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }

    
}
