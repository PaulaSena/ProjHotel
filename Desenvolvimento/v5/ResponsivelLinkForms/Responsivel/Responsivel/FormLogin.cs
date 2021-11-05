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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

        }

        private void linkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroUser formCadastroUser = new FormCadastroUser();
            formCadastroUser.Show();
        }

        private void pictBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
