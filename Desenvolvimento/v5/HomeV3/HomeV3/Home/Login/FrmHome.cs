using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Login
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            CarregarDadosUser(); // Chamamdo funcao criada a baixo.
        }

        private void CarregarDadosUser() // Carregando dados do banco
        {
            lblNome.Text = UserLoginCache.FirstName + "," + UserLoginCache.LastName;
            lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }

        private void pictBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação? ", "Atenção",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit(); // Fecha todo o sistema 
        }

        private void likLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a página? ", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();// Fecha apenas o formulario
            
        }

    }
}
