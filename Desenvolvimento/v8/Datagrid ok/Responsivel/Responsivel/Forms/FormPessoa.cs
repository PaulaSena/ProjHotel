
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Responsivel
{
    public partial class FormPessoa : Form
    {
        public FormPessoa()
        {
            InitializeComponent();

            void BtnConsultar_Click(object sender, EventArgs e)
            {

                //ListarPessoas();
                // ListarUsuarios();
                // ListarHospedes();

            }


            //void ListarPessoas()
            //{
            //    MdlPessoaa objMdlPessoaa = new MdlPessoaa();
            //    MdlPessoaa.DataSource = MdlPessoaa.ListarPessoas;
            //    MdlPessoaa.DisplayMember = "Pessoa";
            //    MdlPessoaa.ValueMember = "idPessoa";
            //    object gridUser = null;

            //}

            // Cadastrando dados pessoais


            ////public void CadastrarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci,
            ////          string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)
            //private static void CadastrarPessoa(int _idPessoa, string _telPessoal, string _nome, DateTime _dataNasci, string _emailPessoal, DateTime _dataDeAceP, string _paisOrigem, string _estadoOrigem, string _cidadeOrigem)

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


         }

        #region Data Hora


        private void horaData_Tick(object sender, EventArgs e)
        {
            // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
                                                            // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

            lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
                                                           //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
                                                           //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 
        }

        #endregion

        private void horaData_Tick_1(object sender, EventArgs e)
        {

            // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
                                                            // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

            lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
                                                           //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
                                                           //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 

        }

        private void btnFinalLogin_Click(object sender, EventArgs e)
        {
            FormCadastroUser formCadastroUser = new FormCadastroUser();
            formCadastroUser.ShowDialog();
        }
    }
}

