using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Model;

namespace Responsivel
{
    public partial class FormGReserv : Form
    { 
        CN_Reserva objetoCN = new CN_Reserva();
        private string idReser = null;
        private bool Editar = false;
        
        public FormGReserv()
        {
            InitializeComponent();
        }

        private void FormGReserv_Load(object sender, EventArgs e)
        {
            MostrarReservas();
        }


        private void MostrarReservas()
        {

            CN_Reserva objeto = new CN_Reserva();
         //   dataGridView1.DataSource = objeto.MostrarReserva();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
               //     objetoCN.InsertarReser(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPreco.Text, txtOrcam.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarReservas();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
              //      objetoCN.EditarReser(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPreco.Text, txtOrcam.Text, idReser);
                    MessageBox.Show("se edito correctamente");
                    MostrarReservas();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows.Count > 0)
                {
                    Editar = true;
                nmricUH.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cboxAcomod.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                cboxRestau.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                gpBoxPeriodo.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                cboxRestau.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPreco.Text = dataGridView1.CurrentRow.Cells["Preco"].Value.ToString();
                    txtOrcam.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                    idReser = dataGridView1.CurrentRow.Cells["IdReser"].Value.ToString();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }



        private void limpiarForm()
        {
            txtDesc.Clear();
            txtPreco.Clear();
            txtOrcam.Clear();
           // nmricUH.Clear();
            cboxAcomod.Text = "";
           // cboxRestau.Clear();
          //  gpBoxPeriodo.Clear();
          //  ckLBoxServic.Clear();
            txtPreco.Clear();
            txtOrcam.Clear();

           // dataGridView1.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idReser = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarReser(idReser);
                MessageBox.Show("Eliminado correctamente");
                MostrarReservas();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        #region



        #endregion

        #region

        #endregion


        #region

        #endregion


        #region

        #endregion


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}


