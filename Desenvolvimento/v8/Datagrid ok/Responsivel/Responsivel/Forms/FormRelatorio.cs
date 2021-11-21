using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Model;

namespace Responsivel.Forms
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private static FormRelatorio Instancia = null;

        public static FormRelatorio ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FormRelatorio();
                Instancia.FormClosed += new FormClosedEventHandler(reset);//SOLO PARA FORMULARIOS
            }

            return Instancia;
        }
        //FIN SINGLETON        
        private static void reset(object sender, FormClosedEventArgs e)//SOLO PARA FORMULARIOS
        {
            Instancia = null;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            //MOSTRAR TODO
            VerRegistros("");
        }
        //METOOD VER REGISTROS
        private void VerRegistros(string condicion)
       {
                MdlClientes MdlClientes = new MdlClientes();
                dataGridView1.DataSource = MdlClientes.VerRegistros(condicion);

            //ClienteDao DAO = new ClienteDao();
            //dataGridView1.DataSource = DAO.VerRegistros(condicion);


            //    RegistroClienteCache RegistroClienteCache = new RegistroClienteCache();
            //    dataGridView1.DataSource = RegistroClienteCache.VerRegistros(condicion);
        }



        //BUSCAR 

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }

        //FILTRAR

      
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
 }

