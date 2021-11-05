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

        private void pnlForms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
