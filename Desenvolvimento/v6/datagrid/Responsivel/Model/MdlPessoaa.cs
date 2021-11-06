using Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model 
{

    public class MdlPessoaa 
    {
        public static object DataSource { get; set; }
        public static string DisplayMember { get; set; }
        public static string ValueMember { get; set; }

        //private ConexaoBD Conexao = new ConexaoBD();
        //private SqlCommand Comando = new SqlCommand();
        //private SqlDataReader BuscarLista;

        //    public DataTable ListarPessoas()
        //    {
        //        DataTable TbPessoas = new DataTable();
        //        Comando.Connection = Conexao.AbrirConexao();
        //        Comando.CommandText = "ListarPessoas";
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        BuscarLista = Comando.ExecuteReader();
        //        TbPessoas.Load(BuscarLista);
        //        BuscarLista.Close();
        //        Conexao.FecharConexao();
        //        return TbPessoas;
        //    }

        //        /* create proc ListarPessoas 
        //           as
        //           select*from Pessoas order by Pessoas asc
        //           go
        //       */
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public string TelPessoal { get; set; }

        public string EmailPessoal { get; set; }

        public DateTime DataDeAceP { get; set; }

        public DateTime DataNasci { get; set; }

        public string PaisOrigem { get; set; }

        public string EstadoOrigem { get; set; }

        public string CidadeOrigem { get; set; }

        public object ListarPessoas()
        {
            throw new NotImplementedException();
        }
    }




}