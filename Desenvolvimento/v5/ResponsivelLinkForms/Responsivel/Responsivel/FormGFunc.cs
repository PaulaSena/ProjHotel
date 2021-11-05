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
    public partial class FormGFunc : Form
    {
        public FormGFunc()
        {
            InitializeComponent();
        }
      
        private void iconButnEdit_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.Show();
        }

        private void iconButnNovoF_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormCadastroUser>();

            FormCadastroUser formCadastroUser = new FormCadastroUser();
            formCadastroUser.Show();
        }

        private void FormGFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
