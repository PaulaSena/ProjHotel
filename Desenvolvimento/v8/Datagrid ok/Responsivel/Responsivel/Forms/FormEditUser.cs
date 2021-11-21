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
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void iconPBoxUser_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconProximo_Click_1(object sender, EventArgs e)
        {
            // abrindo formPessoa
            FormPessoa formPessoa = new FormPessoa();
            formPessoa.Show();
        }

        private void ImgAdd_Click(object sender, EventArgs e)
        {
            #region Adiconar imagem


            //if (ImgAdd == false)
            //{
            //    OpenFileDialog fileimage = new OpenFileDialog();

            //    fileimage.Title = "Selecione a Imagem";
            //    fileimage.Filter = "Imagem(*.jpg) | *.jpg";

            //    if (fileimage.ShowDialog() == DialogResult.OK)
            //    {
            //        Image img = new Bitmap(fileimage.FileName);

            //        ptbImagem.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());

            //        ImgAdd = true;
            //        fvdProgress.Value += 16;
            //        lblStatusProgress.Text = fvdProgress.Value.ToString() + "%";
            //    }


            //}



            #endregion
        }


        #region Data Hora


      
        #endregion

        private void horaData_Tick_1(object sender, EventArgs e)
        {
            // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
                                                            // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

            lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
                                                           //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
                                                           //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 

        }
    }
}
