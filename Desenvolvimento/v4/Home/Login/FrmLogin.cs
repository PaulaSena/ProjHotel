using System;

using Model;

using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

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
                        mainMenu.Show();
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
    

        private void lblInfo1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblInfo2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSenha_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxSenha_Leave(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             FrmCadastroUser frmCadastroUser = new FrmCadastroUser();
                frmCadastroUser.Show();

        }

        private void lblMsgError_Click(object sender, EventArgs e)
        {
        }
      

        private void pctBoxMsgErro_Click(object sender, EventArgs e)
        {

        }

        private void linkLblEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUser frmCadastroUser = new FrmCadastroUser();
            frmCadastroUser.Show();
        }
    }
}

                    
             
