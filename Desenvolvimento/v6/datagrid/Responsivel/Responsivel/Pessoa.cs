
using Controle;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsivel
{
	public class Pessoa  : MdlPessoaa
    {
        private ConexaoBD Conexao = new ConexaoBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader BuscarLista;

        public DataTable ListarPessoas()
        {
            DataTable TbPessoas = new DataTable();
            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "ListarPessoas";
            Comando.CommandType = CommandType.StoredProcedure;
            BuscarLista = Comando.ExecuteReader();
            TbPessoas.Load(BuscarLista);
            BuscarLista.Close();
            Conexao.FecharConexao();
            return TbPessoas;


             void BtnConsultar_Click(object sender, EventArgs e)
            {

                ListarPessoas();
                ListarUsuarios();
                // ListarHospedes();

            }


             void ListarPessoas()
            {
                MdlPessoaa objProd = new MdlPessoaa();
                MdlPessoaa.DataSource = objProd.ListarPessoas();
                MdlPessoaa.DisplayMember = "Pessoa";
                MdlPessoaa.ValueMember = "idPessoa";
                object gridUser = null;
              
            }

             void ListarUsuarios()
            {
                MdlUsuario objProd = new MdlUsuario();
                MdlUsuario.DataSource = objProd.ListarUsuarios();
                MdlUsuario.DisplayMember = "Usuario";
                MdlUsuario.ValueMember = "tipoUser";

                // gridUser.DataSource = objprod.ListarProductos();
            }
        }

        /* create proc ListarPessoas 
           as
           select*from Pessoas order by Pessoas asc
           go
       */
        public int idPessoa;

		public string nome;

		public string telPessoal;

		public string emailPessoal;

		public DateTime dataDeAceP;

		public DateTime dataNasci;

		public string paisOrigem;

		public string estadoOrigem;

		public string cidadeOrigem;

           // Cadastrando dados pessoais
        public void CadastrarPessoa(int idPessoa, string telPessoal, string nome, DateTime dataNasci,
                  string emailPessoal, DateTime dataDeAceP, string paisOrigem, string estadoOrigem, string cidadeOrigem)
            {
                Comando.Connection = Conexao.AbrirConexao();
                Comando.CommandText = "CadastrarPessoa";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idPessoa", idPessoa);
                Comando.Parameters.AddWithValue("@telPessoal", telPessoal);
                Comando.Parameters.AddWithValue("@nome", nome);
                Comando.Parameters.AddWithValue("@dataNasci", dataNasci);
                Comando.Parameters.AddWithValue("@emailPessoal", emailPessoal);
                Comando.Parameters.AddWithValue("@dataDeAceP", dataDeAceP);
                Comando.Parameters.AddWithValue("@paisOrigem", paisOrigem);
                Comando.Parameters.AddWithValue("@estadoOrigem", estadoOrigem);
                Comando.Parameters.AddWithValue("@cidadeOrigem", cidadeOrigem);

                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Conexao.FecharConexao();
            


        }

        public string alterarPessoa()
        {
            return null;
        }

        public List<Pessoa> consultaPessoa(string nome, string telPessoal, int emailPessoal, DateTime dataNasci)
        {
            return null;
        }


        public bool excluirPessoa(int idUser)
     
        {
            return false;
        }

}
}
