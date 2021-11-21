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
    public class MdlPessoaa //: CtlPessoa
    {

        private int idPessoa;

        private string nome;

        private string telPessoal;

        private string emailPessoal;

        private DateTime dataDeAceP;

        private DateTime dataNasci;

        private string paisOrigem;

        private string estadoOrigem;

        private string cidadeOrigem;

        public int IdPessoa { get => idPessoa; set => idPessoa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string TelPessoal { get => telPessoal; set => telPessoal = value; }
        public string EmailPessoal { get => emailPessoal; set => emailPessoal = value; }
        public DateTime DataDeAceP { get => dataDeAceP; set => dataDeAceP = value; }
        public DateTime DataNasci { get => dataNasci; set => dataNasci = value; }
        public string PaisOrigem { get => paisOrigem; set => paisOrigem = value; }
        public string EstadoOrigem { get => estadoOrigem; set => estadoOrigem = value; }
        public string CidadeOrigem { get => cidadeOrigem; set => cidadeOrigem = value; }
        public static object DataSource { get; set; }
        public static string DisplayMember { get; set; }
        public static string ValueMember { get; set; }


        #region  ConexaoBD

        //private ConexaoBD Conexao = new ConexaoBD();
        //private SqlCommand Comando = new SqlCommand();
        //private SqlDataReader BuscarLista;

        //public DataTable ListarPessoas()
        //{
        //    DataTable TbPessoas = new DataTable();
        //    Comando.Connection = Conexao.AbrirConexao();
        //    Comando.CommandText = "ListarPessoas";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    BuscarLista = Comando.ExecuteReader();
        //    TbPessoas.Load(BuscarLista);
        //    BuscarLista.Close();
        //    Conexao.FecharConexao();
        //    return TbPessoas;
        //}

        /* create proc ListarPessoas 
           as
           select*from Pessoas order by Pessoas asc
           go
            */
        //{
        //    throw new NotImplementedException();
        //}

        #endregion Conectar Banco de dados


        #region  Metodos:    CONSULTAR | CADASTRAR | EDITAR  | EXCLUIR | VALIDAR LOGIN


        #region Buscar Pessoa

        // consultaPessoa()

        //public DataTable ListarPessoas()
        //{
        //    DataTable TbPessoas = new DataTable();
        //    Comando.Connection = Conexao.AbrirConexao();
        //    Comando.CommandText = "ListarPessoas";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    BuscarLista = Comando.ExecuteReader();
        //    TbPessoas.Load(BuscarLista);
        //    BuscarLista.Close();
        //    Conexao.FecharConexao();
        //    return TbPessoas;




        //    void ListarPessoas()
        //{
        //    MdlPessoaa objMdlPessoaa = new MdlPessoaa();
        //    MdlPessoaa.DataSource = MdlPessoaa.ListarPessoas;
        //    MdlPessoaa.DisplayMember = "Pessoa";
        //    MdlPessoaa.ValueMember = "idPessoa";
        //    object gridUser = null;

        //}
        //}



        #endregion

        #region Cadastrar Pessoa
        // Cadastrando dados pessoais


        //public void CadastrarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci,
        //          string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)
        //{
        //    Comando.Connection = Conexao.AbrirConexao();
        //    Comando.CommandText = "CadastrarPessoa";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
        //    Comando.Parameters.AddWithValue("@telPessoal", _telPessoal);
        //    Comando.Parameters.AddWithValue("@nome", _nome);
        //    Comando.Parameters.AddWithValue("@dataNasci", _dataNasci);
        //    Comando.Parameters.AddWithValue("@emailPessoal", _emailPessoal);
        //    Comando.Parameters.AddWithValue("@dataDeAceP", _dataDeAceP);
        //    Comando.Parameters.AddWithValue("@paisOrigem", _paisOrigem);
        //    Comando.Parameters.AddWithValue("@estadoOrigem", _estadoOrigem);
        //    Comando.Parameters.AddWithValue("@cidadeOrigem", _cidadeOrigem);

        //    Comando.ExecuteNonQuery();
        //    Comando.Parameters.Clear();
        //    Conexao.FecharConexao();
        // }
        #endregion

        #region Atualizar Pessoa
        // Editar cadastro Pessoa

        //public void AtualizarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci,
        //         string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)
        //{
        //    Comando.Connection = Conexao.AbrirConexao();
        //    Comando.CommandText = "AtualizarPessoa";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
        //    Comando.Parameters.AddWithValue("@telPessoal", _telPessoal);
        //    Comando.Parameters.AddWithValue("@nome", _nome);
        //    Comando.Parameters.AddWithValue("@dataNasci", _dataNasci);
        //    Comando.Parameters.AddWithValue("@emailPessoal", _emailPessoal);
        //    Comando.Parameters.AddWithValue("@dataDeAceP", _dataDeAceP);
        //    Comando.Parameters.AddWithValue("@paisOrigem", _paisOrigem);
        //    Comando.Parameters.AddWithValue("@estadoOrigem", _estadoOrigem);
        //    Comando.Parameters.AddWithValue("@cidadeOrigem", _cidadeOrigem);

        //    Comando.ExecuteNonQuery();
        //    Comando.Parameters.Clear();
        //    Conexao.FecharConexao();

        #endregion

        #region Excluir pessoa

        // excluirPessoa(int idUser)

        #endregion

        #endregion


    }
}
   


