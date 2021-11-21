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
            //for (int contador = 0; contador < 100; contador++)
            //{
            //    gridFunc.Rows.Add(new object[] {
            //        imageList.Images[0]

            //        });
            //}
            # endregion Fim teste populando datagrid

        }



        private void IconButnEdit_Click(object sender, EventArgs e)
        {
           FormEditUser formEditUser = new FormEditUser();
           formEditUser.Show();
        }

        private void IconButnNovoF_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormCadastroUser>();

           FormPessoa formPessoa = new FormPessoa();
             formPessoa.Show();
        }

       

        private void IconBtnExc_Click(object sender, EventArgs e)
        {
            FormDelDados formDelDados = new FormDelDados();
            formDelDados.Show();
        }




        #region Scrollbar Barra de rolagem
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gridFunc.FirstDisplayedScrollingRowIndex = gridFunc.Rows[e.NewValue].Index;
        }

        private void GridUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = gridFunc.RowCount-1;
        }

        private void GridUser_RowsRemoved(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = gridFunc.RowCount-1;
        }
        #endregion Scrollbar

        private void PlaceholderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        #region DataGrid Funcionario aula angel
       
        void populaGrid()
        {
            // ClsFuncionario x = new ClsFuncionario();
            MdlFuncionario funcionario = new MdlFuncionario();
            // dataGridView1.DataSource = x.consultarFuncionario();
            gridFunc.DataSource = funcionario.consultarFuncionario();

        }

        private void FormGFunc_Load(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void iconButton1_Click(object sender, EventArgs e)
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


        #endregion







        //  TESTES ClsProductos objproducto = new ClsProductos();
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
