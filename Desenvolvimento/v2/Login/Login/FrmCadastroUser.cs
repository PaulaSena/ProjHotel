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
            {
                txtBoxUser.Text = "";
                txtBoxSenha.Text = "";
                txtBoxConfSenha.Text = "";
            }
        }

        private void txtBoxConfSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if
            (txtBoxUser.Text == "" || txtBoxSenha.Text == "" && txtBoxConfSenha.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos para cadastro de Usuario!");
            }
            else if (txtBoxSenha.Text == txtBoxConfSenha.Text)
            {

                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            else if (txtBoxSenha.Text != txtBoxConfSenha.Text)
                {
                MessageBox.Show("Senhas nao conferem!");
                }
        }
        }
    } 
      


    
            
            
        
    
