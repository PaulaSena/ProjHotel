using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Responsivel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
           
    #region Funcionalidades do formulario Minimizar maximizar fechar
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //RESIZE METODO PARA REDIMENCIONAR O FORMULARIO ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelConteudo.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

         base.OnPaint(e);
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void pictBoxFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Encerra  a aplicação
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void pictBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictBoxRestaurar_Click(object sender, EventArgs e)
        {
            pictBoxMax.Visible = true;
            pictBoxRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void pictBoxMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            pictBoxMax.Visible = false;
            pictBoxRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        
        // Función para arrastar o formulario 

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        // Función para arrastar o formulario (Drag Form) System.Runtime.InteropService

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Funcoes para abrir formularios dentro do painel
        #region Formulario dentro do painel

        private void btnDashboard2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDashbord>();
        }

        private void btnGFunc_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGFunc>();
        }

        private void btnGReserv_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGReserv>();
        }

        private void btnGClient_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGHosp>();
        }

        private void iconBFormGUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGUser>();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {   
            AbrirFormulario<FormDashbord>();   
        }

        private void btnDashboard2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormDashbord>();
        }

        private void btnFormGFunc_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGFunc>();
        }

        private void btnFormGReser_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGReserv>();
        }

        private void btnFormGHosp_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormGHosp>();
        }

        private void pctBoxLogoHome_Click(object sender, EventArgs e)
        {
         
        }



        #endregion



        private void horaData_Tick(object sender, EventArgs e)
        {
          // lblHora.Text = DateTime.Now.ToLongTimeString();// Hora e segundos
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");// Hora e segundos 12H "hh:mm:ss" 24H "HH:mm:ss"
                                                            // lblHora.Text = DateTime.Now.ToShortTimeString();// Hora 

            lblData.Text = DateTime.Now.ToLongDateString();//dia dia da semana mes e ano
                                                           //  lblData.Text = DateTime.Now.ToShortDateString();// apenas a data
                                                           //  lblData.Text = DateTime.Now.ToString("ddd MMMM YYY");// dia da semana mes e ano 
        }

       

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       

        // Metodo para abrir o formulario dentro do painel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault(); //Buscar o formulario da coleção
           //se o formulario nao existi
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //se o formulario existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
