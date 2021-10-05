using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnLogarFunc_Click(object sender, EventArgs e)
      
            /* Se usuario validado verifique a senha*/
        {
            
            /* Se Usuario e senha validada prossiga para a home*/

            if (txtBoxSenha.Text == "adm" && txtBoxUser.Text == "adm")
            {
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
            }
           
           
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
            txtBoxUser.Text = "";
            txtBoxSenha.Text = "";
        }

        private void linkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUser frmCadastroUser = new FrmCadastroUser();
            frmCadastroUser.Show();
        }
    }
}
