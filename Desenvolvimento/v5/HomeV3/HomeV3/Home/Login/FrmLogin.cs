using System;
using Model;
using System.Windows.Forms;
using Common.Cache;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {

            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)

        {
            if (txtBoxUser.Text != "") { 
                 if (txtBoxSenha.Text != "") {
                    MdlUsuario user = new MdlUsuario(); //instanciamos o usuario do model
                    var validLogin = user.LoginUser(txtBoxUser.Text,txtBoxSenha.Text);  // validando os campos
                    if(validLogin == true)  //se validado instanciamos o formulario home e ocultamos o login
                    {
                        FrmHome mainMenu = new FrmHome();
                        MessageBox.Show("Bem Vindo " +UserLoginCache.FirstName+","+UserLoginCache.LastName);  /// Exibe mensagem de boas vindas a ser substituida em breve
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
        private void msgErro(string msg){
            lblMsgErro.Text = "    " + msg;
            lblMsgErro.Visible = true;
            pctBoxMsgErro.Visible = true;

        }

          
     
       

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxSenha.Clear(); // Limpar campo senha e login
            txtBoxUser.Clear();
        }

        private void linkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             FrmCadastroUser frmCadastroUser = new FrmCadastroUser();
                frmCadastroUser.Show();

        }

       
        private void linkLblEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUser frmCadastroUser = new FrmCadastroUser();
            frmCadastroUser.Show();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtBoxSenha.Clear(); // Limpar campo senha e login
            txtBoxUser.Clear();
            lblMsgErro.Visible = false;
            this.Show(); // chamar novamente o login q estava oculto
            txtBoxUser.Focus();

        }

        private void pictBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação? ", "Atenção",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit(); // Fecha todo o sistema 


        }
    }
}

                    
             
