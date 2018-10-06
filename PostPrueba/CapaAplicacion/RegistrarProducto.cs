using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using CapaNegocio;

namespace CapaAplicacion
{
    public partial class RegistrarProducto : Form
    {
        Negocio auxNegocio = new Negocio();
        

        public RegistrarProducto()
        {
            InitializeComponent();
            txtStock.Visible = false;
            txtTotalNeto.ReadOnly = true;
            TxtTotalBruto.ReadOnly = true;
            txtIVA.ReadOnly = true;
            txtNomProducto.ReadOnly = true;
            txtPrecio.ReadOnly =  true;
            txtCantidad.ReadOnly = true;

            
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                Producto AuxProductoConsultado = this.auxNegocio.BuscarProducto(this.txtCodProducto.Text);
                this.txtNomProducto.Text = AuxProductoConsultado.Nombre;
                this.txtPrecio.Text = AuxProductoConsultado.Precio.ToString();
                this.txtStock.Text = AuxProductoConsultado.Stock.ToString();
                if(AuxProductoConsultado.Nombre != String.Empty)
                {
                    this.txtCantidad.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                this.txtCodProducto.Text = String.Empty;
                this.txtNomProducto.Text = String.Empty;
                this.txtPrecio.Text = String.Empty;
            }
            
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            calculosPantalla();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculosPantalla();
        }

        public void calculosPantalla()
        {
            if (this.txtCantidad.Text != String.Empty)
            {
                int stock = int.Parse(this.txtStock.Text);
                int cantidad = int.Parse(this.txtCantidad.Text);
                int precio = int.Parse(this.txtPrecio.Text);
                int neto = auxNegocio.PrecioNeto(cantidad, precio);

                if (cantidad > stock)
                {
                    MessageBox.Show("no hay productos suficientes, stock " + stock + " unidades");
                    this.txtCantidad.Text = String.Empty;
                    this.txtTotalNeto.Text = String.Empty;
                }
                else
                {
                    txtTotalNeto.Text = neto.ToString();
                    if (this.txtPrecio.Text != String.Empty)
                    {
                        this.txtIVA.Text = auxNegocio.calculoIva(neto);
                        if (this.txtIVA.Text != String.Empty)
                        {
                            this.TxtTotalBruto.Text = auxNegocio.PrecioTOTAL(neto, double.Parse(this.txtIVA.Text));
                        }
                    }

                }
            }
            
        }

        public void cleanPantalla()
        {
            txtCantidad.Text = String.Empty;
            txtCliente.Text = String.Empty;
            txtCodProducto.Text = String.Empty;
            txtNomProducto.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtIVA.Text = String.Empty;
            TxtTotalBruto.Text = String.Empty;
            txtTotalNeto.Text = String.Empty;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            bool exito = false;
            if(this.txtCliente.Text == String.Empty)
            {
                MessageBox.Show("Falta el cliente");
                return;
            }else if(this.txtCodProducto.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar un producto");
                return;
            }else if(this.txtCantidad.Text == String.Empty)
            {
                MessageBox.Show("Indica la cantidad a comprar");
                return;
            }
            else
            {
                try
                {
                    Producto auxProductoVENTA = new Producto
                    {
                        Codigo = this.txtCodProducto.Text,
                        Stock = int.Parse(this.txtStock.Text) - int.Parse(this.txtCantidad.Text)
                    };
                    Venta auxVenta = new Venta
                    {
                        Cliente = this.txtCliente.Text,
                        Cod_producto = this.txtCodProducto.Text,
                        Cantidad = int.Parse(this.txtCantidad.Text),
                        Neto = int.Parse(this.txtTotalNeto.Text)
                    };
                    NegocioVenta auxNegocioVenta = new NegocioVenta();

                    auxNegocio.RestaStock(auxProductoVENTA);
                    auxNegocioVenta.Insert(auxVenta);

                    exito = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error");
                }
                if (exito)
                {
                    MessageBox.Show("Producto vendido");
                    cleanPantalla();
                }
            }
            
            
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            PantallaVentas p2 = new PantallaVentas();
            p2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Environment.Exit(0);
        }
    }
}
