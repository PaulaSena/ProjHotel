using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Responsivel
{
    public partial class FormGUser : Form
    {
        public FormGUser()
        {
            InitializeComponent();
        }

        #region DataGrid Usuario aula angel

        void populaGrid()
        {
            // ClsFuncionario x = new ClsFuncionario();
            MdlUsuario usuario = new MdlUsuario();
            // dataGridView1.DataSource = x.consultarFuncionario();
            gridUser.DataSource = usuario.consultarUsuario();

        }


        #endregion

        private void FormGUser_Load(object sender, EventArgs e)
        {
            populaGrid();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            populaGrid();
        }


        #region Data Hora


        private void horaData_Tick_1(object sender, EventArgs e)
        {
            // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
                                                            // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

            lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
                                                           //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
                                                           //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 

            #endregion

       
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa();
            formPessoa.ShowDialog();
        }
    }
}
