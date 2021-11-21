using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class CtlPessoa : CtlPessoaBase
    {
        private ConexaoBD Conexao = new ConexaoBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader BuscarLista;

        public CtlPessoa(ConexaoBD conexao, SqlCommand comando, SqlDataReader buscarLista)
        {
            Conexao = conexao;
            Comando = comando;
            BuscarLista = buscarLista;
        }

            #region  Metodos:    CONSULTAR | CADASTRAR | EDITAR  | EXCLUIR | VALIDAR LOGIN
       
                #region Buscar Pessoa



                #endregion

                #region Cadastrar Pessoa

                // Cadastrando dados pessoais
                public void CadastrarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci,
                          string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)
                {
                    Comando.Connection = Conexao.AbrirConexao();
                    Comando.CommandText = "CadastrarPessoa";
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
                    Comando.Parameters.AddWithValue("@telPessoal", _telPessoal);
                    Comando.Parameters.AddWithValue("@nome", _nome);
                    Comando.Parameters.AddWithValue("@dataNasci", _dataNasci);
                    Comando.Parameters.AddWithValue("@emailPessoal", _emailPessoal);
                    Comando.Parameters.AddWithValue("@dataDeAceP", _dataDeAceP);
                    Comando.Parameters.AddWithValue("@paisOrigem", _paisOrigem);
                    Comando.Parameters.AddWithValue("@estadoOrigem", _estadoOrigem);
                    Comando.Parameters.AddWithValue("@cidadeOrigem", _cidadeOrigem);

                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    Conexao.FecharConexao();


                }
                #endregion

                #region Atualizar Pessoa
                // Editar cadastro Pessoa

                public void AtualizarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci,
                         string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)
                {
                    Comando.Connection = Conexao.AbrirConexao();
                    Comando.CommandText = "AtualizarPessoa";
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.AddWithValue("@idPessoa", _idPessoa);
                    Comando.Parameters.AddWithValue("@telPessoal", _telPessoal);
                    Comando.Parameters.AddWithValue("@nome", _nome);
                    Comando.Parameters.AddWithValue("@dataNasci", _dataNasci);
                    Comando.Parameters.AddWithValue("@emailPessoal", _emailPessoal);
                    Comando.Parameters.AddWithValue("@dataDeAceP", _dataDeAceP);
                    Comando.Parameters.AddWithValue("@paisOrigem", _paisOrigem);
                    Comando.Parameters.AddWithValue("@estadoOrigem", _estadoOrigem);
                    Comando.Parameters.AddWithValue("@cidadeOrigem", _cidadeOrigem);

                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    Conexao.FecharConexao();

                    #endregion

                #region Excluir pessoa

                    // excluirPessoa(int idUser)

                    #endregion

           

        }
    }

    #endregion

    public class Conexao
    {
    }
}
