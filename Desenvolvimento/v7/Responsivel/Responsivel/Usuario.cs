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
	public abstract class Usuario : Pessoa 
	{
		public static object DataSource { get; set; }
		public static string DisplayMember { get; set; }
		public static string ValueMember { get; set; }
		
		//private ConexaoBD Conexao = new ConexaoBD();
		//private SqlCommand Comando = new SqlCommand();
		//private SqlDataReader BuscarLista;



		private int idUser;

		private string tipoUser;

		private string senha;

		private bool estadLogin;

		private string loginUser;

		private DateTime dataDeAceUser;

		private string fotoPerfil;

		private int idPessoa;

		private int idHosp;

		private int idFunc;

		private int idAceite;


        public int IdUser { get => idUser; set => idUser = value; }
        public string TipoUser { get => tipoUser; set => tipoUser = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool EstadLogin { get => estadLogin; set => estadLogin = value; }
        public string LoginUser { get => loginUser; set => loginUser = value; }
        public DateTime DataDeAceUser { get => dataDeAceUser; set => dataDeAceUser = value; }
        public string FotoPerfil { get => fotoPerfil; set => fotoPerfil = value; }
        public int IdPessoa { get => idPessoa; set => idPessoa = value; }
        public int IdHosp { get => idHosp; set => idHosp = value; }
        public int IdFunc { get => idFunc; set => idFunc = value; }
        public int IdAceite { get => idAceite; set => idAceite = value; }



        /* create proc ListarUsuarios 
          as
          select*from Usuario_Funcionario order by Usuario_Funcionario asc
          go
        */


        #region  Metodos:    CONSULTAR | CADASTRAR | EDITAR  | EXCLUIR | VALIDAR LOGIN


        // Consultar usuario

        #region  Buscar Usuario


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



            void BtnConsultar_Click(object sender, EventArgs e)
            {

                //ListarPessoas();
                ListarUsuarios();
                // ListarHospedes();

            }

            void ListarUsuarios()
            {
                MdlUsuario objUsuario = new MdlUsuario();
                MdlUsuario.DataSource = objUsuario.ListarUsuarios();
                MdlUsuario.DisplayMember = "Usuario";
                MdlUsuario.ValueMember = "tipoUser";

                // gridUser.DataSource = objprod.ListarProductos();
            }
        }

        #endregion

        // VerificarLogin

        #region Verificar Login

        public bool verifLogin()
		{
			return false;
		}

		#endregion

		// Cadastrar usuario

		#region Cadastrar Usuario

		public void CadastrarUsuario(int _idUser, string _tipoUser, string _senha, bool _estadLogin, string _loginUser, DateTime _dataDeAceUser, string _fotoPerfil, int _idPessoa, int _idAceite, int _idFunc_FK, int _idHosp_FK)
		{
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "CadastrarUsuario";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@idUser", _idUser);
			Comando.Parameters.AddWithValue("@tipoUser", _tipoUser);
			Comando.Parameters.AddWithValue("@senha", _senha);
			Comando.Parameters.AddWithValue("@estadLogin", _estadLogin);
			Comando.Parameters.AddWithValue("@loginUser", _loginUser);
			Comando.Parameters.AddWithValue("@dataDeAceUser", _dataDeAceUser);
			Comando.Parameters.AddWithValue("@fotoPerfil", _fotoPerfil);
			Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
			Comando.Parameters.AddWithValue("@idAceite", _idAceite);
			Comando.Parameters.AddWithValue("@idFunc_FK", _idFunc_FK);
			Comando.Parameters.AddWithValue("@idHosp_FK", _idHosp_FK);

			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
			Conexao.FecharConexao();
		}
		#endregion

		//Editar User

		#region Atualizar Usuario

		public void AtualizarUsuario(int _idUser, string _tipoUser, string _senha, bool _estadLogin, string _loginUser, DateTime _dataDeAceUser, string _fotoPerfil, int _idPessoa, int _idAceite, int _idFunc_FK, int _idHosp_FK)
		{
			Comando.Connection = Conexao.AbrirConexao();
			Comando.CommandText = "AtualizarUsuario";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@idUser", _idUser);
			Comando.Parameters.AddWithValue("@tipoUser", _tipoUser);
			Comando.Parameters.AddWithValue("@senha", _senha);
			Comando.Parameters.AddWithValue("@estadLogin", _estadLogin);
			Comando.Parameters.AddWithValue("@loginUser", _loginUser);
			Comando.Parameters.AddWithValue("@dataDeAceUser", _dataDeAceUser);
			Comando.Parameters.AddWithValue("@fotoPerfil", _fotoPerfil);
			Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
			Comando.Parameters.AddWithValue("@idAceite", _idAceite);
			Comando.Parameters.AddWithValue("@idFunc_FK", _idFunc_FK);
			Comando.Parameters.AddWithValue("@idHosp_FK", _idHosp_FK);

			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
			Conexao.FecharConexao();
		}

		#endregion



		// excluirUser(int idUser)

		#region ExcluirUsuario



		#endregion


		#endregion


	}
}

