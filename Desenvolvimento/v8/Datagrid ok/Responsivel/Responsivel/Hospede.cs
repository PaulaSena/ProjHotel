using Controle;
using Model
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsivel
{
    public abstract class Hospede : Pessoa

    {
		private ConexaoBD Conexao = new ConexaoBD();
		private SqlCommand Comando = new SqlCommand();
		private SqlDataReader BuscarLista;

		public DataTable ListarHospedes()
		{
			DataTable TdHospede = new DataTable();
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "ListarHospedes";
			Comando.CommandType = CommandType.StoredProcedure;
			BuscarLista = Comando.ExecuteReader();
			TdHospede.Load(BuscarLista);
			BuscarLista.Close();
			Conexao.FecharConexao();
			return TdHospede;
		}

		/* create proc ListarHospedes 
         as
         select * from Usuario_Hospede order by Usuario_Hospede asc
         go
        */
		public int idHosp;

		public string nomeHosp;

		public int rg_string;

		public string cpf;

		public bool situacaoHosp;

		public DateTime dataAcessoHop;

		public bool cadastrarHosp()
		{
			return false;
		}

		public bool  alterarHosp()
		{
			return false;
		}

		public List<Hospede> consultarHosp()
		{
			return null;
		}

		public bool  excluirHosp(int idHosp)
		{
			return false;
		}

	}
}
