using Model;
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
        private object objprod;

        public FormGFunc()
        {
            InitializeComponent();

            #region FOR  teste populando datagrid
            for (int contador = 0; contador < 100; contador++)
            {
                gridUser.Rows.Add(new object[] {
                    imageList.Images[0]

                    });
            }
            # endregion Fim teste populando datagrid

        }
        private void FormGFunc_Load(object sender, EventArgs e)
        {

        }



        private void IconButnEdit_Click(object sender, EventArgs e)
        {
           FormEditUser formEditUser = new FormEditUser();
           formEditUser.Show();
        }

        private void IconButnNovoF_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormCadastroUser>();

           FormCadastroUser formCadastroUser = new FormCadastroUser();
             formCadastroUser.Show();
        }

       

        private void IconBtnExc_Click(object sender, EventArgs e)
        {
            FormDelDados formDelDados = new FormDelDados();
            formDelDados.Show();
        }

        

       

        #region Scrollbar Barra de rolagem
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gridUser.FirstDisplayedScrollingRowIndex = gridUser.Rows[e.NewValue].Index;
        }

        private void GridUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = gridUser.RowCount-1;
        }

        private void GridUser_RowsRemoved(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = gridUser.RowCount-1;
        }
        #endregion Scrollbar

        private void PlaceholderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

       

        //ClsProductos objproducto = new ClsProductos();
        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    objproducto.InsertarProductos(
        //        Convert.ToInt32(cbxTipoUser.SelectedValue),
        //        Convert.ToInt32(CmbMarca.SelectedValue),
        //        txtDescripcion.Text,
        //        Convert.ToDouble(txtPrecio.Text)
        //        );
        //    MessageBox.Show("Se inserto correctamente");
        //    ListarProductos();
        //}
        //private void ListarHospedes()
        //{
        //    ClsProductos objprod = new ClsProductos();
        //    dataGridView1.DataSource = objprod.ListarProductos();
        //}



    }
}
