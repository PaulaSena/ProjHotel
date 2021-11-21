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

        private void BtnLogar_Click(object sender, EventArgs e)
        {

        }

        private void LinkLblNaotenho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroUser formCadastroUser = new FormCadastroUser();
            formCadastroUser.Show();
        }

        private void PictBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

    }
}
