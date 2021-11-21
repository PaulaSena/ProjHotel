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
     public abstract class Funcionario : Pessoa 

	{
		private ConexaoBD Conexao = new ConexaoBD();
		private SqlCommand Comando = new SqlCommand();
		private SqlDataReader BuscarLista;

		public DataTable ListarFuncionario()
		{
			DataTable TdFuncionario = new DataTable();
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "ListarFuncionario";
			Comando.CommandType = CommandType.StoredProcedure;
			BuscarLista = Comando.ExecuteReader();
			TdFuncionario.Load(BuscarLista);
			BuscarLista.Close();
			Conexao.FecharConexao();
			return TdFuncionario;
		}

		/* create proc TdFuncionario 
         as
         select * from Usuario_Funcionario order by Usuario_Hospede asc
         go
        */


		public int idFunc;

		public string nomeFunc;

		public string rg;

		public string cpf;

		public string acesso;

		public string departamento;

		public bool situacao;

		public double salario;

		public DateTime dataAcessoFunc;

		public string cargo;
		
		// Cadastrar funcionario
		
		public void CadastrarFuncionario(int idFunc, string nomeFunc, string rg, string cpf, string acesso, string departamento,
			bool situacao, double salario, DateTime dataAcessoFunc, string cargo)
		{
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "CadastrarFuncionario";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@idFunc", idFunc);
			Comando.Parameters.AddWithValue("@nomeFunc", nomeFunc);
			Comando.Parameters.AddWithValue("@rg", rg);
			Comando.Parameters.AddWithValue("@cpf", cpf);
			Comando.Parameters.AddWithValue("@acesso", acesso);
			Comando.Parameters.AddWithValue("@departamento", departamento);
			Comando.Parameters.AddWithValue("@situacao", situacao);
			Comando.Parameters.AddWithValue("@salario", salario);
			Comando.Parameters.AddWithValue("@dataAcessoFunc", dataAcessoFunc);
			Comando.Parameters.AddWithValue("@cargo", cargo);
			
			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
			Conexao.FecharConexao();
		}

	

	public bool alterarFunc()
		{
			return false;
		}

		public List<Funcionario> consultarFunc()
		{
			return null;
		}

		public bool excluirFunc(int idFunc)
		{
			return false;
		}
	}
}
