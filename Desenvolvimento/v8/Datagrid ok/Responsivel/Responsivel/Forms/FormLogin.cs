using System;
using System.Windows.Forms;
using Common.Cache;
using Model;

namespace Responsivel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Botão Logar
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text != "")
            {
                if (txtBoxSenha.Text != "")
                {
                    MdlUsuario user = new MdlUsuario(); //instanciamos o usuario do model
                    var validLogin = user.LoginUser(txtBoxUser.Text, txtBoxSenha.Text);  // validando os campos
                    if (validLogin == true)  //se validado instanciamos o formulario home e ocultamos o login
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        MessageBox.Show("Bem Vindo " + Common.Cache.UserLoginCache.FirstName + "," + UserLoginCache.LastName);  /// Exibe mensagem de boas vindas a ser substituida em breve
                        mainMenu.Show(); // 
                        mainMenu.FormClosed += Logout; //ao fechar o formulario realizar logout
                        this.Hide();
                    }
                    else
                    {
                        msgErro("Login ou senha invalidos");
                        txtBoxSenha.Clear();
                        txtBoxUser.Focus();
                    }
                }
                else msgErro("Por favor insira sua senha!");
            }
            else msgErro("Por favor insira seu nome de usuário!");
        }

        private void msgErro(string msg)
        {
            lblMsgErro.Text = "    " + msg;
            lblMsgErro.Visible = true;
            pctBoxMsgErro.Visible = true;

        }

        #endregion

        #region Logout

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtBoxSenha.Clear(); // Limpar campo senha e login
            txtBoxUser.Clear();
            lblMsgErro.Visible = false;
            this.Show(); // chamar novamente o login q estava oculto
            txtBoxUser.Focus();

        }



        #endregion

        #region NAO TENHO CADASTRO USER

        //private void LinkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    FormCadastroUser formCadastroUser = new FormCadastroUser();
        //    formCadastroUser.Show();
        //}

        #endregion

        #region Botão fechar e minimizar


        //private void PictBoxMin_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        //private void PictBoxFechar_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        #endregion

        #region Data Hora


        //private void horaData_Tick(object sender, EventArgs e)
        //{
        //    // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
        //    lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
        //                                                    // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

        //    lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
        //                                                   //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
        //                                                   //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 
        //}

        #endregion

        #region Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxSenha.Clear(); // Limpar campo senha e login
            txtBoxUser.Clear();
        }
        #endregion

        private void pictBoxFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação? ", "Atenção",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit(); // Fecha todo o sistema 

        }
    }
}
