using CapaModelo;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEscritorio
{
    public partial class PantallaListar : Form
    {
        public PantallaListar()
        {
            InitializeComponent();
            this.dgListar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListar.ReadOnly = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Negocio auxNegocio = new Negocio();
            this.dgListar.DataSource = auxNegocio.listarFilas();
            //tabla de la que recoge los datos
            this.dgListar.DataMember = "transaccion";
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }
    }
}
