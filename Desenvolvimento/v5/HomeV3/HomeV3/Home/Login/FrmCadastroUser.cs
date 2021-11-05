using Model;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmCadastroUser : Form
    {
        public FrmCadastroUser()
        {
           InitializeComponent();
        }

        private void FrmCadastroUser_Load(object sender, EventArgs e)
        {

        }

        private void linkLblJaTenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxConfSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
                if (txtBoxUser.Text != "")
                {
                    if (txtBoxSenha.Text != "") { }
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

        private void pictBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação? ", "Atenção",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit(); // Fecha todo o sistema 
        }
    }
    }
             


      


    
            
            
        
    
