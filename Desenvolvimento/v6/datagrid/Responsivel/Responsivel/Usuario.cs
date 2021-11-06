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
	public class Usuario : MdlUsuario
    {

		private ConexaoBD Conexao = new ConexaoBD();
		private SqlCommand Comando = new SqlCommand();
		private SqlDataReader BuscarLista;

		public DataTable ListarUsuarios()
		{
			DataTable TdUsuarios = new DataTable();
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "ListarUsuario";
			Comando.CommandType = CommandType.StoredProcedure;
			BuscarLista = Comando.ExecuteReader();
			TdUsuarios.Load(BuscarLista);
			BuscarLista.Close();
			Conexao.FecharConexao();
			return TdUsuarios;
		}

		/* create proc ListarUsuarios 
          as
          select*from Usuario_Funcionario order by Usuario_Funcionario asc
          go
        */

		public int idUser;

		public string tipoUser;

		public string senha;

		public bool estadLogin;

		public string loginUser;

		public DateTime dataDeAceUser;

		public string fotoPerfil;

		public int idPessoa;

		public int idHosp;

		public int idFunc;

		public int idAceite;

		public bool verifLogin()
		{
			return false;
		}
		// Cadastrar usuario
		public void CadastrarUsuario(int idUser, string tipoUser, string senha, bool estadLogin,
		   string loginUser, DateTime dataDeAceUser, string fotoPerfil, int idPessoa, int idAceite, int idFunc_FK, int idHosp_FK)
			{
				Comando.Connection = Conexao.AbrirConexao();
				Comando.CommandText = "CadastrarUsuario";
				Comando.CommandType = CommandType.StoredProcedure;
				Comando.Parameters.AddWithValue("@idUser", idUser);
				Comando.Parameters.AddWithValue("@tipoUser", tipoUser);
				Comando.Parameters.AddWithValue("@senha", senha);
				Comando.Parameters.AddWithValue("@estadLogin", estadLogin);
				Comando.Parameters.AddWithValue("@loginUser", loginUser);
				Comando.Parameters.AddWithValue("@dataDeAceUser", dataDeAceUser);
				Comando.Parameters.AddWithValue("@fotoPerfil", fotoPerfil);
				Comando.Parameters.AddWithValue("@idPessoa", idPessoa);
				Comando.Parameters.AddWithValue("@idAceite", idAceite);
				Comando.Parameters.AddWithValue("@idFunc_FK", idFunc_FK);
				Comando.Parameters.AddWithValue("@idHosp_FK", idHosp_FK);

				Comando.ExecuteNonQuery();
				Comando.Parameters.Clear();
				Conexao.FecharConexao();
			}
		

		public bool alterarUser()
		{
			return false;
		}

		public List<Usuario> consultaUser()
		{
			return null;
		}

		public bool excluirUser(int idUser)
		{
			return false;
		}
	}
}
