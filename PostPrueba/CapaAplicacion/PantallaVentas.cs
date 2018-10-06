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

namespace CapaAplicacion
{
    public partial class PantallaVentas : Form
    {
        public PantallaVentas()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            NegocioVenta auxNegocioVenta = new NegocioVenta();
            this.dgListar.DataSource = auxNegocioVenta.listarFilas();
            //tabla de la que recoge los datos
            this.dgListar.DataMember = "venta";
            this.txtTotal.Text = auxNegocioVenta.totalVentas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }
    }
}
